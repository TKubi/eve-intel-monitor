using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Speech.Synthesis;

namespace EVEIntelManager
{
    public partial class SettingsUI : UserControl
    {
        public delegate void NotifySettingsChanged();
        public delegate void NotifyCloseWindowRequested();
        public event NotifySettingsChanged ChangedSettings;
        public event NotifyCloseWindowRequested CloseWindowRequested;

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

        public void ActivatedUI()
        {
            treeMenu.ExpandAll();
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(0, 1);
        }

        public System.Windows.Forms.Button ButtonOK { get { return this.buttonOK; } }
        public System.Windows.Forms.Button ButtonCancel { get { return this.buttonCancel; } }

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

                string[] keywords = textKeywords.Text.Split(new string[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
                listKeywords.Items.Clear();
                listKeywords.Items.AddRange(keywords);

                labelError.Text = "Click 'Apply' to apply changes to Keywords";
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ApplySettings();
            if (CloseWindowRequested != null)
            {
                CloseWindowRequested();
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ReadProperties();
            if (CloseWindowRequested != null)
            {
                CloseWindowRequested();
            }
        }

        private string[] GetStartupChannels()
        {
            string[] channels = new string[textDefaultChannel.Items.Count];

            for (int i = 0; i < textDefaultChannel.Items.Count; i++)
            {
                channels[i] = textDefaultChannel.Items[i].ToString().Trim();
            }

            return channels;
        }

        private bool AddStartupChannel(string channel)
        {
            if (!string.IsNullOrEmpty(channel))
            {
                channel = channel.Trim();

                if (!textDefaultChannel.Items.Contains(channel))
                {
                    textDefaultChannel.Items.Add(channel);

                    labelError.Text = "Click 'Apply' to apply changes to Startup Channels";
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void SetStartupChannels(string[] channels)
        {
            textDefaultChannel.Items.Clear();
            textDefaultChannel.Items.AddRange(channels);
        }

        private void buttonAddChannel_Click(object sender, EventArgs e)
        {
            if (AddStartupChannel(textDefaultChannel.Text))
            {
                SystemSounds.Asterisk.Play();
            }
            else
            {
                labelError.Text = "Channel " + textDefaultChannel.Text + " is already added.";
                SystemSounds.Beep.Play();
            }
        }

        private void buttonRemoveChannel_Click(object sender, EventArgs e)
        {
            if (textDefaultChannel.SelectedItem != null)
            {
                textDefaultChannel.Items.Remove(textDefaultChannel.SelectedItem);

                if (textDefaultChannel.Items.Count > 0)
                {
                    textDefaultChannel.SelectedIndex = 0;
                }

                labelError.Text = "Click 'Apply' to apply changes to Startup Channels";
                SystemSounds.Asterisk.Play();
            }
            else
            {
                labelError.Text = "Unable to remove " + textDefaultChannel.Text + ", channel is not in the list.";
                SystemSounds.Beep.Play();
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

        private void ApplySettings()
        {
            ////////////////////////////////////////////////////////////////////////////////////
            // Start validations
            ////////////////////////////////////////////////////////////////////////////////////

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

            if (readLogsAferSeconds < 0 || readLogsAferSeconds > 60 * 60 * 24)
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
            // Validations finished, start saving properties.
            ////////////////////////////////////////////////////////////////////////////////////

            if (Properties.Settings.Default.FirstLoad)
            {
                // if this is first 
                Properties.Settings.Default.FirstLoad = false;
            }

            Properties.Settings.Default.EVELogDirectory = textEVELogDirectory.Text;
            Properties.Settings.Default.ReadLogsAferSeconds = readLogsAferSeconds;
            Properties.Settings.Default.LogRefreshRate = refreshRate.Value;
            Properties.Settings.Default.DefaultChannel = textDefaultChannel.Text;
            Properties.Settings.Default.StartupChannels = GetStartupChannels();
            Properties.Settings.Default.ShowStatusBar = checkShowStatusBar.Checked;
            Properties.Settings.Default.ShowIntelGrid = checkBoxIntelGrid.Checked;

            Properties.Settings.Default.PlayIntelSound = !checkSynthesizeSpeech.Checked;
            Properties.Settings.Default.TextToSpeech = checkSynthesizeSpeech.Checked;

            string[] keywords = textKeywords.Text.Split(new string[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            Properties.Settings.Default.Keywords = keywords;

            if (comboSelectedVoice.SelectedValue != null)
            {
                Properties.Settings.Default.TextToSpeechVoice = comboSelectedVoice.SelectedValue.ToString();
            }
            Properties.Settings.Default.TextToSpeechRate = scrollSpeachRate.Value - 10;

            Properties.Settings.Default.AutoLoadDefaultChannel = checkAutoLoad.Checked;
            Properties.Settings.Default.UpgrateOnStartup = checkUpgrateOnStartup.Checked;

            Properties.Settings.Default.FirstLoad = false;
            Properties.Settings.Default.Save();

            labelError.Text = "";

            if (ChangedSettings != null)
            {
                ChangedSettings();
            }
        }

        public void ReadProperties()
        {
            textEVELogDirectory.Text = Properties.Settings.Default.EVELogDirectory;
            textReadLogsAferSeconds.Text = Properties.Settings.Default.ReadLogsAferSeconds.ToString();
            textRefreshRate.Text = GetRefreshRateAsString();
            textDefaultChannel.Text = Properties.Settings.Default.DefaultChannel;
            SetStartupChannels(Properties.Settings.Default.StartupChannels);

            checkAutoLoad.Checked = Properties.Settings.Default.AutoLoadDefaultChannel;
            checkUpgrateOnStartup.Checked = Properties.Settings.Default.UpgrateOnStartup;
            checkSynthesizeSpeech.Checked = Properties.Settings.Default.TextToSpeech;
            checkShowStatusBar.Checked = Properties.Settings.Default.ShowStatusBar;

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
            }
            else
            {
                labelError.Text = "";
            }
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

        private void scrollSpeachRate_Scroll(object sender, ScrollEventArgs e)
        {
            labelSpeachRateDisplay.Text = (scrollSpeachRate.Value - 10).ToString();
        }

        private void textDefaultChannel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddChannel_Click(sender, e);
            }
        }

        private void treeMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ("inteleganceNode".Equals(treeMenu.SelectedNode.Name))
            {
                tabControl.SelectedIndex = 0;
            }
            else if ("inteleganceSpeechNode".Equals(treeMenu.SelectedNode.Name))
            {
                tabControl.SelectedIndex = 1;
            }
            else if ("inteleganceAnalysisNode".Equals(treeMenu.SelectedNode.Name))
            {
                tabControl.SelectedIndex = 2;
            }
            else if ("generalNode".Equals(treeMenu.SelectedNode.Name))
            {
                tabControl.SelectedIndex = 3;
            }
            else if ("uiNode".Equals(treeMenu.SelectedNode.Name))
            {
                tabControl.SelectedIndex = 4;
            }

            
        }
    }
}
