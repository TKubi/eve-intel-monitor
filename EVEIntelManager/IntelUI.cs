using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EVEIntelAnalyzer;
using System.Media;
using System.Speech.Synthesis;

namespace EVEIntelManager
{
    public delegate void NotifyIntel(Intel intel);
    public delegate void VoidDelegate();

    public partial class IntelUI : UserControl
    {
        public IntelAnalyzer Analyzer { 
            get 
            {
                return analyzer; 
            }
            set
            {
                this.analyzer = value;
                this.analyzer.ChangedIntel += NotifyIntel;
                this.analyzer.ChangedIntelActive += NotifyIntelActive;
            }
        }

        public void PauseSpeech()
        {
            if (InvokeRequired)
            {
                this.Invoke((VoidDelegate)PauseSpeech);
                return;
            }

            lock (this)
            {
                if (lastSynth != null && lastSynth.State != SynthesizerState.Paused)
                {
                    lastSynth.Pause();
                }
            }
        }

        public void ResumeSpeech()
        {
            if (InvokeRequired)
            {
                this.Invoke((VoidDelegate)PauseSpeech);
                return;
            }

            lock (this)
            {
                if (lastSynth != null && lastSynth.State != SynthesizerState.Paused)
                {
                    lastSynth.Resume();
                }
            }
        }

        private IntelAnalyzer analyzer;
        private SpeechSynthesizer lastSynth;

        private Queue<IntelPresentation> synthesizerMessages = new Queue<IntelPresentation>();
        
        public IntelUI()
        {
            InitializeComponent();

            this.Analyzer = new IntelAnalyzer();

            if (Properties.Settings.Default.FirstLoad) {
                setMessageText("The List View is activated. If the performance is poor, try switching to List View (button ->).");
            }

        }

        public bool ShowGrid 
        {
            get
            {
                return dataGridIntel.Visible;
            }
            set
            {
                dataGridIntel.Visible = value;
                listIntel.Visible = !value;
                buttonToggleView.ImageIndex = ShowGrid ? 0 : 1;
            }
        }

        private void buttonMonitorIntel_Click(object sender, EventArgs e)
        {
            Analyzer.Active = !Analyzer.Active;
        }

        private void NotifyIntelActive(bool status)
        {
            if (Analyzer.Active)
            {
                buttonMonitorIntel.Text = "&Stop";
                setMessageText("");
                if (!backgroundIntelSound.IsBusy)
                {
                    backgroundIntelSound.RunWorkerAsync();
                }
            }
            else
            {
                buttonMonitorIntel.Text = "&Start";

                if (backgroundIntelSound.IsBusy)
                {
                    setMessageText("Pausing intel...");
                }
            }
        }
        
        private void NotifyIntel(Intel intel)
        {
            if (InvokeRequired)
            {
                this.Invoke((NotifyIntel)NotifyIntel, intel);
                return;
            }

            IntelPresentation intelDisplay = new IntelPresentation(intel);

            if (intelBindingSource.Count > 0)
            {
                intelBindingSource.Insert(0, intel);
            }
            else
            {
                intelBindingSource.Add(intel);
            }

            if (listIntel.Items.Count > 0)
            {
                listIntel.Items.Insert(0, intelDisplay);
            }
            else
            {
                listIntel.Items.Add(intelDisplay);
            }

            if (Properties.Settings.Default.TextToSpeech)
            {
                synthesizerMessages.Enqueue(intelDisplay);
                if (!backgroundIntelSound.IsBusy)
                {
                    backgroundIntelSound.RunWorkerAsync();
                }
            }
            else if (Properties.Settings.Default.PlayIntelSound)
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void buttonClearIntel_Click(object sender, EventArgs e)
        {
            intelBindingSource.Clear();
            listIntel.Items.Clear();
            synthesizerMessages.Clear();
            setMessageText("");
        }

        private delegate void SetText(string text);

        private void setMessageText(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((SetText)setMessageText, text);

                return;
            }

            labelPausingIntel.Text = text;
        }

        private void backgroundIntelSound_DoWork(object sender, DoWorkEventArgs e)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                try
                {
                    lock (this)
                    {
                        this.lastSynth = synth;
                    }

                    string selectedVoiceName = Properties.Settings.Default.TextToSpeechVoice;
                    if (!string.IsNullOrEmpty(selectedVoiceName))
                    {
                        synth.SelectVoice(selectedVoiceName);
                    }
                    synth.Rate = Properties.Settings.Default.TextToSpeechRate;

                    int maxItel = Properties.Settings.Default.TextToSpeechMaxMessages;
                    int skippedIntel = 0;

                    for (int intel = 0; synthesizerMessages.Count > 0 && intel <= maxItel; intel++)
                    {
                        if (Properties.Settings.Default.SkipOlderIntel)
                        {
                            // keep looping through the queue until there are 
                            // less then maxIntel messages remaining
                            int intelToKeep = Math.Max(maxItel, 0);
                            
                            while (synthesizerMessages.Count > intelToKeep)
                            {
                                IntelPresentation message = synthesizerMessages.Dequeue();
                                // set the text of the message anyway.
                                setMessageText(message.ToString());
                                skippedIntel++;
                            }
                        }

                        // since we may have skipped everything, we should check if the queue is empty
                        if (synthesizerMessages.Count == 0)
                        {
                            break;
                        }

                        if (Analyzer.Active)
                        {
                            IntelPresentation message = synthesizerMessages.Dequeue();
                            setMessageText(message.ToString());
                            synth.Speak(message.ToSpeech());
                        }
                        else
                        {
                            setMessageText("Intel Paused.");
                            return;
                        }

                    }

                    if (skippedIntel > 0)
                    {
                        string text = IntelSettings.Default.ReadSkipIntel;
                        text = text.Replace("[count]", skippedIntel.ToString());

                        setMessageText(text);
                        synth.Speak(text);
                    }

                    if (synthesizerMessages.Count > 0)
                    {
                        string text = IntelSettings.Default.ReadAdditionalIntelReports;
                        text = text.Replace("[count]", synthesizerMessages.Count.ToString());

                        setMessageText(text);
                        synth.Speak(text);
                    }

                    synthesizerMessages.Clear();
                    setMessageText("");
                }
                finally
                {
                    lock (this)
                    {
                        this.lastSynth = null;
                    }
                }
            }
        }

        private void buttonToggleView_Click(object sender, EventArgs e)
        {
            ShowGrid = !ShowGrid;
            if (ShowGrid)
            {
                setMessageText("The Grid View is activated. Go to Tools -> Options to make this setting permanent.");
            }
            else
            {
                setMessageText("The List View is activated. Go to Tools -> Options to make this setting permanent.");
            }
        }
    }
}
