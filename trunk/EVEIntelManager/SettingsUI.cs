using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using EVELogMonitor;
using System.Collections;
using System.Speech.Synthesis;

namespace EVEIntelManager
{
    public delegate void NotifySettingsChanged();

    public partial class SettingsUI : UserControl
    {
        public event NotifySettingsChanged ChangedSettings;

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (textEVELogDirectory.Text.Length == 0)
            {
                labelError.Text = "Directory path is missing.";
                SystemSounds.Beep.Play();

                return;
            }

            try
            {
                DirectoryInfo eveDirectory = new DirectoryInfo(textEVELogDirectory.Text);
                if (!eveDirectory.Exists)
                {
                    labelError.Text = "Directory " + textEVELogDirectory.Text + " does not exist";
                    SystemSounds.Beep.Play();

                    return;
                }
            }
            catch (Exception)
            {
                labelError.Text = "Directory " + textEVELogDirectory.Text + " is not valid";
                SystemSounds.Beep.Play();

                return;
            }

            Nullable<int> refreshRate = GetRefreshRate();
            if (refreshRate == null)
            {
                labelError.Text = "Refresh Rate is not valid number.";
                SystemSounds.Beep.Play();

                return;
            }

            if (refreshRate < 1000 || refreshRate > 3600000)
            {
                labelError.Text = "Refresh Rate is must be between 1 and 3600 seconds.";
                SystemSounds.Beep.Play();

                return;
            }

            int readLogsAferSeconds = 0;
            if (!int.TryParse(textReadLogsAferSeconds.Text, out readLogsAferSeconds))
            {
                labelError.Text = "Invalid numeric value for the 'Read Logs After' seconds.";
                SystemSounds.Beep.Play();

                return;
            }

            if (readLogsAferSeconds < 0 || readLogsAferSeconds > 60*60*24)
            {
                labelError.Text = "The 'Read Logs After' seconds cannot be negative and cannot be more then 1 day.";
                SystemSounds.Beep.Play();

                return;
            }

            if (textDefaultChannel.Text == null || textDefaultChannel.Text.Trim() == "")
            {
                labelError.Text = "The default Channel cannot be blank.";
                SystemSounds.Beep.Play();

                return;
            }

            ////////////////////////////////////////////////////////////////////////////////////

            if (Properties.Settings.Default.FirstLoad)
            {
                Properties.Settings.Default.SettingsTabLast = true;
                Properties.Settings.Default.FirstLoad = false;
            }

            Properties.Settings.Default.EVELogDirectory     = textEVELogDirectory.Text;
            Properties.Settings.Default.ReadLogsAferSeconds = readLogsAferSeconds;
            Properties.Settings.Default.LogRefreshRate      = refreshRate.Value;
            Properties.Settings.Default.DefaultChannel      = textDefaultChannel.Text;
            Properties.Settings.Default.SettingsTabLast     = checkSettingsLastTab.Checked;

            Properties.Settings.Default.PlayIntelSound      = !checkSynthesizeSpeech.Checked;
            Properties.Settings.Default.TextToSpeech        = checkSynthesizeSpeech.Checked;

            string[] keywords = textKeywords.Text.Split(new string[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            Properties.Settings.Default.Keywords            = keywords;

            if (comboSelectedVoice.SelectedValue != null)
            {
                Properties.Settings.Default.TextToSpeechVoice = comboSelectedVoice.SelectedValue.ToString();
            }
            Properties.Settings.Default.TextToSpeechRate    = scrollSpeachRate.Value - 10;

            Properties.Settings.Default.AutoLoadDefaultChannel = checkAutoLoad.Checked;
            Properties.Settings.Default.UpgrateOnStartup = checkUpgrateOnStartup.Checked;

            Properties.Settings.Default.FirstLoad           = false;
            Properties.Settings.Default.Save();

            labelError.Text = "";
            
            ChangedSettings();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ReadProperties();
        }

        public void ReadProperties()
        {
            textEVELogDirectory.Text = Properties.Settings.Default.EVELogDirectory;
            textReadLogsAferSeconds.Text = Properties.Settings.Default.ReadLogsAferSeconds.ToString();
            textRefreshRate.Text = GetRefreshRateAsString();
            textDefaultChannel.Text = Properties.Settings.Default.DefaultChannel;
            checkAutoLoad.Checked = Properties.Settings.Default.AutoLoadDefaultChannel;
            checkUpgrateOnStartup.Checked = Properties.Settings.Default.UpgrateOnStartup;
            checkSettingsLastTab.Checked = Properties.Settings.Default.SettingsTabLast;
            checkSynthesizeSpeech.Checked = Properties.Settings.Default.TextToSpeech;

            if (Properties.Settings.Default.KeywordArrayList != null)
            {
                textKeywords.Text = string.Join("\r\n", Properties.Settings.Default.Keywords);
            }

            listKeywords.Items.Clear();
            listKeywords.Items.AddRange(Properties.Settings.Default.Keywords);

            if (Properties.Settings.Default.TextToSpeechVoice != null)
            {
                comboSelectedVoice.SelectedItem = Properties.Settings.Default.TextToSpeechVoice;
            }

            scrollSpeachRate.Value = Properties.Settings.Default.TextToSpeechRate + 10;

            if (Properties.Settings.Default.FirstLoad)
            {
                labelError.Text = "Since this is your first time launching EVE Intel Monitor, please verify all settings and click apply.";
                checkSettingsLastTab.Checked = true;
            }
            else
            {
                labelError.Text = "";
            }
        }

        private void buttonCanel_Click(object sender, EventArgs e)
        {
            ReadProperties();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textEVELogDirectory.Text;
            DialogResult result = folderBrowserDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                textEVELogDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private string GetRefreshRateAsString()
        {
            return (Properties.Settings.Default.LogRefreshRate / 1000.0).ToString();
        }

        private Nullable<int> GetRefreshRate()
        {
            string value = textRefreshRate.Text;
            if (value != null)
            {
                double result = 0;
                if (double.TryParse(value, out result))
                {
                    return (int)(result * 1000);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public SettingsUI()
        {
            InitializeComponent();

            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                IList<InstalledVoice> voices = synth.GetInstalledVoices();
                foreach (InstalledVoice voice in voices)
                {
                    comboSelectedVoice.Items.Add(voice.VoiceInfo.Name);
                }

                if (synth.Voice != null)
                {
                    comboSelectedVoice.SelectedItem = synth.Voice.Name;
                }
            }
        }

        private void scrollSpeachRate_Scroll(object sender, ScrollEventArgs e)
        {
            labelSpeachRateDisplay.Text = (scrollSpeachRate.Value - 10).ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listKeywords.Visible)
            {
                listKeywords.Visible = false;
                labelKeywordsDesc.Visible = true;
                textKeywords.Visible = true;
                buttonEdit.Text = "&Apply";
            }
            else
            {
                listKeywords.Visible = true;
                labelKeywordsDesc.Visible = false;
                textKeywords.Visible = false;
                buttonEdit.Text = "&Edit";

                string[] keywords = textKeywords.Text.Split(new string[] {"\n","\r"}, StringSplitOptions.RemoveEmptyEntries);
                listKeywords.Items.Clear();
                listKeywords.Items.AddRange(keywords);

                labelError.Text = "Click 'Apply' to apply changes to Keywords";
            }
        }
    }
}
