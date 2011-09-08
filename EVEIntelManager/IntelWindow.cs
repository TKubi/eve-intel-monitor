using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using EVELogMonitor;
using EVEIntelAnalyzer;
using System.IO;
using System.Media;
using System.Speech.Synthesis;

namespace EVEIntelManager
{ 
    public delegate void NotifyIntel(Intel intel);
    public delegate void CheckForUpdates();

    public partial class IntelWindow : Form
    {
        public static Color BG_COLOR = System.Drawing.SystemColors.Control;
        public static Color FG_COLOR = System.Drawing.SystemColors.ControlText;
        public static Color BG_WINDOW_COLOR = System.Drawing.SystemColors.Window;
        public static Color FG_WINDOW_COLOR = System.Drawing.SystemColors.WindowText;
        public static Color BG_BUTTON_COLOR = System.Drawing.SystemColors.Control;
        public static Color FG_BUTTON_COLOR = System.Drawing.SystemColors.ControlText;

        //public static Color BG_COLOR = System.Drawing.Color.FromArgb(29, 48, 56);
        //public static Color FG_COLOR = System.Drawing.Color.FromArgb(183, 189, 193);
        //public static Color BG_WINDOW_COLOR = System.Drawing.Color.FromArgb(29, 48, 56);
        //public static Color FG_WINDOW_COLOR = System.Drawing.Color.FromArgb(183, 189, 193);
        //public static Color BG_BUTTON_COLOR = System.Drawing.Color.FromArgb(29, 48, 56);
        //public static Color FG_BUTTON_COLOR = System.Drawing.Color.FromArgb(0, 0, 0);

        private LogDirectoryMonitor monitor;
        private Queue<IntelPresentation> synthesizerMessages = new Queue<IntelPresentation>();

        public IntelAnalyzer Analyzer { set; get; }

        public LogDirectoryMonitor Monitor
        {
            set {
                this.monitor = value;
                
                ApplySettings();
                settingsUI.ReadProperties();

                if (!Properties.Settings.Default.FirstLoad &&
                    Properties.Settings.Default.AutoLoadDefaultChannel)
                {
                    LoadStartupChannels();
                }
            }
            get { return this.monitor; }
        }


        public IntelWindow()
        {
            InitializeComponent();
            UpdateColorScheme();
            
            this.Analyzer = new IntelAnalyzer();

            if (Properties.Settings.Default.SettingsTabLast)
            {
                this.tabControl.Controls.Remove(this.tabSettings);
                this.tabControl.Controls.Add(this.tabSettings);
            }

            Analyzer.ChangedIntel += NotifyIntel;
            Analyzer.ChangedIntelActive += NotifyIntelActive;
            Analyzer.Active = true;

            if (Properties.Settings.Default.UpgrateOnStartup)
            {
                backgroundUpdateWorker.RunWorkerAsync();
            }

            this.Text = "EVE Intel Monitor - " + ApplicationInstaller.GetCurrentVersion();
        }

        private void ApplySettings()
        {
            monitor.ReadLogsAferSeconds = Properties.Settings.Default.ReadLogsAferSeconds;
            textChannelName.Text = Properties.Settings.Default.DefaultChannel;
            logReaderUI.TimerInterval = Properties.Settings.Default.LogRefreshRate;

            this.Analyzer.MatchStrings = Properties.Settings.Default.Keywords;

            if (Properties.Settings.Default.SettingsTabLast)
            {
                if (this.tabControl.Controls.IndexOf(this.tabSettings) == 0)
                {
                    this.tabControl.Controls.Remove(this.tabChannels);
                    this.tabControl.Controls.Remove(this.tabIntel);
                    this.tabControl.Controls.Remove(this.tabSettings);
                    this.tabControl.Controls.Add(this.tabChannels);
                    this.tabControl.Controls.Add(this.tabIntel);
                    this.tabControl.Controls.Add(this.tabSettings);
                }
            }
            else
            {
                if (this.tabControl.Controls.IndexOf(this.tabSettings) == this.tabControl.Controls.Count - 1)
                {
                    this.tabControl.Controls.Remove(this.tabChannels);
                    this.tabControl.Controls.Remove(this.tabIntel);
                    this.tabControl.Controls.Remove(this.tabSettings);
                    this.tabControl.Controls.Add(this.tabSettings);
                    this.tabControl.Controls.Add(this.tabChannels);
                    this.tabControl.Controls.Add(this.tabIntel);
                }
            }

            this.tabControl.Refresh();
            statusStrip.Visible = Properties.Settings.Default.ShowStatusBar;

            toolStripStatusLabel.Text = "Settings have been applied.";
        }

        private void UpdateColorScheme() {
            this.tabChannels.ForeColor = IntelWindow.FG_COLOR;
            this.textChannelName.ForeColor = IntelWindow.FG_COLOR;
            this.tabIntel.BackColor = IntelWindow.BG_COLOR;
            this.tabIntel.ForeColor = IntelWindow.FG_COLOR;
            this.tabSettings.BackColor = IntelWindow.BG_COLOR;
            this.tabSettings.ForeColor = IntelWindow.FG_COLOR;
            this.checkAlwaysOnTop.ForeColor = IntelWindow.FG_COLOR;
            this.tabChannels.BackColor = IntelWindow.BG_COLOR;
            this.BackColor = IntelWindow.BG_COLOR;

            this.buttonLoadChannels.ForeColor = IntelWindow.FG_BUTTON_COLOR;
            this.buttonRead.ForeColor = IntelWindow.FG_BUTTON_COLOR;
            this.buttonMonitorIntel.ForeColor = IntelWindow.FG_BUTTON_COLOR;
            
            this.listFiles.BackColor = IntelWindow.BG_WINDOW_COLOR;
            this.listFiles.ForeColor = IntelWindow.FG_WINDOW_COLOR;
            this.listIntel.BackColor = IntelWindow.BG_WINDOW_COLOR;
            this.listIntel.ForeColor = IntelWindow.FG_WINDOW_COLOR;
        }
        
        private void buttonRead_Click(object sender, EventArgs e)
        {
            LogFileMonitor monitor = ReadChannel(textChannelName.Text);

            if (monitor == null)
            {
                MessageBox.Show(this, 
                    "Invalid Channel Name: " + textChannelName.Text 
                    + " (try replacing non-alphanumeric charecters with underscors_)", "Invalid channel name", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStartupChannels()
        {
            foreach (string channel in Properties.Settings.Default.StartupChannels)
            {
                LogFileMonitor fileMonitor = ReadChannel(channel);

                if (fileMonitor != null)
                {
                    logReaderUI.Add(fileMonitor);
                    listLoadedChannels.Items.Add(fileMonitor);
                    Analyzer.Add(fileMonitor);
                }
            }
        }

        private LogFileMonitor ReadChannel(string channel)
        {
            try
            {
                monitor.ChannelName = channel;
                List<LogFileMonitor> monitors = monitor.ReadDirectory();

                listFiles.Items.Clear();
                foreach (LogFileMonitor logFile in monitors)
                {
                    if (!listFiles.Items.Contains(logFile))
                    {
                        logFile.Refresh(true);
                        listFiles.Items.Add(logFile);
                    }
                    else
                    {
                        SystemSounds.Beep.Play();
                    }
                }

                if (listFiles.Items.Count > 0)
                {
                    listFiles.SetItemChecked(0, true);
                    return (LogFileMonitor)listFiles.Items[0];
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool validateInput(string input)
        {
            double value;
            if (!double.TryParse(input, out value))
            {
                return false;
            }
            else
            {
                return (value >= 1 && value <= 3600);
            }
        }

        private void checkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkAlwaysOnTop.Checked;
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

        private void buttonLoadChannels_Click(object sender, EventArgs e)
        {
            foreach (LogFileMonitor monitor in listFiles.CheckedItems)
            {
                logReaderUI.Add(monitor);
                listLoadedChannels.Items.Add(monitor);

                Analyzer.Add(monitor);
            }
        }

        private void buttonUnloadChannel_Click(object sender, EventArgs e)
        {
            if (listLoadedChannels.SelectedIndex > -1)
            {
                LogFileMonitor monitor = (LogFileMonitor)listLoadedChannels.SelectedItem;
                logReaderUI.Remove(monitor);
                listLoadedChannels.Items.Remove(monitor);

                Analyzer.Remove(monitor);
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

            toolStripStatusLabel.Text = text;
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

                        toolStripStatusLabel.Text = message.ToString();
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

        private void backgroundUpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((CheckForUpdates)CheckForUpdates);
                return;
            }

            CheckForUpdates();
        }

        private void CheckForUpdates()
        {
            ApplicationInstaller.CheckForUpdates(this);
        }
    }

    class IntelPresentation
    {
        public Intel Intel { get; set; }

        public IntelPresentation(Intel intel)
        {
            this.Intel = intel;
        }

       
        public override string ToString()
        {
            string message = "";

            if (Intel != null)
            {
                message += Intel.System != null ? GetRed(Intel.Red) : "";
                message += GetSystem(Intel.System);
                message += (message != "" ? " > " : "") + GetRawIntel(Intel);
            }

            return message;
        }


        public string ToSpeach()
        {
            string message = "";

            if (Intel != null)
            {

                if (Intel.System != null && Intel.System.Name != null)
                {
                    if (!Intel.Clear)
                    {
                        message += GetRed(Intel.Red);
                    }

                    // convert the system name into "spelled by letter" with '-' spelled as 'tac'.
                    string system = Intel.System.Name;
                    string speakSystem = "";

                    for (int i = 0; i < system.Length; i++)
                    {
                        char letter = system[i];
                        if (char.IsLetter(letter))
                        {
                            speakSystem += system[i] + ". ";
                        }
                        else if (char.IsNumber(letter))
                        {
                            speakSystem += system[i] + ", ";
                        }
                        else if (letter == '-')
                        {
                            speakSystem += " tac ";
                        }
                    }

                    if (Intel.Clear)
                    {
                        message += speakSystem + " is clear.";
                    }
                    else
                    {
                        message += " in " + speakSystem;

                        if (Intel.NoVisual)
                        {
                            message += " no visual";
                        }
                    }

                }
                else
                {
                    message += GetRawIntel(Intel);
                }
            }

            return message;
        }

        private string GetRed(Player red)
        {
            if (red != null)
            {
                string name = red.name != null ? red.name : "Intel";
                string ship = red.ship != null ? " flying " + red.ship : "";
                return name + ship;
            }
            else
            {
                return "red";
            }
        }

        private string GetSystem(SolarSystem system)
        {
            if (system != null)
            {
                string name = system.Name != null ? system.Name : "Unknown system";
                return " in " + name;
            }
            else
            {
                return "";
            }
        }

        private string GetRawIntel(Intel intel)
        {
            string rawIntel = Intel.Message.Message;
            if (rawIntel.Length > 50)
            {
                rawIntel = rawIntel.Substring(0, 50);
            }
            return "Intel: " + rawIntel;
        }
    }
}
