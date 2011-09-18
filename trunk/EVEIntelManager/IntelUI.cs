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

    public partial class IntelUI : UserControl
    {
        public IntelAnalyzer Analyzer { set; get; }
        private Queue<IntelPresentation> synthesizerMessages = new Queue<IntelPresentation>();

        public IntelUI()
        {
            InitializeComponent();

            this.Analyzer = new IntelAnalyzer();
            
            Analyzer.ChangedIntel += NotifyIntel;
            Analyzer.ChangedIntelActive += NotifyIntelActive;
            Analyzer.Active = true;

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
                setPausingText("");
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
                    setPausingText("Pausing intel...");
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
            listIntel.Items.Clear();
            synthesizerMessages.Clear();
            setPausingText("");
        }

        private delegate void SetText(string text);

        private void setPausingText(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((SetText)setPausingText, text);

                return;
            }

            //toolStripStatusLabel.Text = text;
            labelPausingIntel.Text = text;
        }

        private void backgroundIntelSound_DoWork(object sender, DoWorkEventArgs e)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                string selectedVoiceName = Properties.Settings.Default.TextToSpeechVoice;
                if (!string.IsNullOrEmpty(selectedVoiceName))
                {
                    synth.SelectVoice(selectedVoiceName);
                }
                synth.Rate = Properties.Settings.Default.TextToSpeechRate;

                int maxItel = Properties.Settings.Default.TextToSpeechMaxMessages;
                for (int intel = 0; synthesizerMessages.Count > 0 && intel < maxItel; intel++)
                {
                    if (Analyzer.Active)
                    {
                        IntelPresentation message = synthesizerMessages.Dequeue();

                        //toolStripStatusLabel.Text = message.ToString();
                        synth.Speak(message.ToSpeach());
                    }
                    else
                    {
                        setPausingText("Intel Paused.");
                        return;
                    }
                }

                if (synthesizerMessages.Count > 0)
                {
                    synth.Speak("Additional, " + synthesizerMessages.Count + " intel reports");
                }
                synthesizerMessages.Clear();
                setPausingText("");
            }

        }
    }
}
