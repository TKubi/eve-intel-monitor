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
    public delegate void CheckForUpdates();

    public partial class IntelWindow : Form
    {
        public IntelAnalyzer Analyzer { get { return intelUI.Analyzer; } }
        private SettingsForm settingsForm = new SettingsForm();

        public LogDirectoryMonitor Monitor
        {
            set {
                this.monitor = value;
                
                ApplySettings();
                settingsForm.ReadProperties();

                if (!Properties.Settings.Default.FirstLoad &&
                    Properties.Settings.Default.AutoLoadDefaultChannel)
                {
                    LoadStartupChannels();
                }

                if (Properties.Settings.Default.UpgrateOnStartup)
                {
                    backgroundUpdateWorker.RunWorkerAsync();
                }
            }
            get { return this.monitor; }
        }

        public IntelWindow()
        {
            InitializeComponent();
            
            settingsForm.SettingsUI.ChangedSettings += ApplySettings;

            this.Text = "EVE Intel Monitor - " + ApplicationInstaller.GetCurrentVersion();
        }

        private LogDirectoryMonitor monitor;
        private AboutBox aboutBox = new AboutBox();

        private void ApplySettings()
        {
            monitor.ReadLogsAferSeconds = Properties.Settings.Default.ReadLogsAferSeconds;
            textChannelName.Text = Properties.Settings.Default.DefaultChannel;
            logReaderUI.TimerInterval = Properties.Settings.Default.LogRefreshRate;

            intelUI.Analyzer.MatchStrings = Properties.Settings.Default.Keywords;

            statusStrip.Visible = Properties.Settings.Default.ShowStatusBar;
            intelUI.Analyzer.MatchStrings = Properties.Settings.Default.Keywords;
            intelUI.ShowGrid = Properties.Settings.Default.ShowIntelGrid;

            toolStripStatusLabel.Text = "Settings have been applied.";
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            WriteMessage("Searching eve-chat folder for " + textChannelName.Text + " channel.");
            LogFileMonitor monitor = ReadChannel(textChannelName.Text);

            if (monitor == null)
            {
                string readLogsAferMinutes = (this.Monitor.ReadLogsAferSeconds / 60).ToString();

                WriteMessage("Channel \"" + textChannelName.Text + "\" is not found or is not active.\n");

                MessageBox.Show(this,
                    "Channel \"" + textChannelName.Text + "\" is not found or is not active.\n" +
                    "Is the game currently running?\n" +
                    "Is the channel window open in the game?\n" +
                    "Has the channel been updated in the past " + readLogsAferMinutes + " minutes?\n\n" +
                    "If you answered 'yes' to any question above, this is normal behavior.\n" +
                    "Otherwise, try replacing non-alphanumeric characters with \nunderscores ( _ )",
                    "Channel not found or is not active",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Properties.Settings.Default.ReadFolderAutoLoadFirstChannel)
            {
                if (LoadLogFileMonitor(monitor)) {
                    WriteMessage("Channel is automatically loaded. See UI settings to disable this feature.");
                }
            }
            else
            {
                WriteMessage("Channel file(s) are identified on the left, please select a channel to start monitoring.");
            }
        }

        private bool LoadLogFileMonitor(LogFileMonitor monitor)
        {

            if (!listLoadedChannels.Items.Contains(monitor))
            {
                logReaderUI.Add(monitor);
                listLoadedChannels.Items.Add(monitor);
                Analyzer.Add(monitor);

                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoadStartupChannels()
        {
            foreach (string channel in Properties.Settings.Default.StartupChannels)
            {
                LogFileMonitor fileMonitor = ReadChannel(channel);

                if (fileMonitor != null)
                {
                    LoadLogFileMonitor(fileMonitor);
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
            toolStripStatusLabel.Text = "Checking for updates...";
            
            AppVersionList versionList;

            if (ApplicationInstaller.CheckForUpdates(out versionList))
            {
                ApplicationInstallerForm installerForm = new ApplicationInstallerForm();
                installerForm.VersionList = versionList;

                installerForm.PopulateLatestVersion();
                installerForm.Show(this);

                toolStripStatusLabel.Text = "New version found.";
            }
            else
            {
                toolStripStatusLabel.Text = "Current version is up to dated.";
            }
        }

        private void upgradeToVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Loading all available versions.";

            AppVersionList versionList;

            if (ApplicationInstaller.PromptUpgrade(out versionList))
            {
                ApplicationInstallerForm installerForm = new ApplicationInstallerForm();
                installerForm.VersionList = versionList;

                installerForm.PopulateVersions();
                installerForm.Show(this);
            }
            else
            {
                toolStripStatusLabel.Text = "No versions avaialble for download.";
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog(this);
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundUpdateWorker.RunWorkerAsync();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox.ShowDialog(this);
        }

        private void qandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.HomePage);
        }

        private void ShowOptionsDialog()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((VoidDelegate)ShowOptionsDialog);
                return;
            }
            settingsForm.TopMost = this.TopMost;
            settingsForm.ShowDialog();
        }

        private void IntelWindow_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstLoad)
            {
                ShowOptionsDialog();
            }
        }

        private void showActiveKeywordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string keyword in Analyzer.MatchStrings) 
            {
                WriteMessage(keyword);
            }
            WriteMessage("Active Keywords:");
        }

        private void WriteMessage(string message)
        {
            if (logReaderUI.Visible)
            {
                logReaderUI.WriteMessage(message);
            }
            else if (intelUI.Visible)
            {
                intelUI.WriteMessage(message);
            }
        }

    }
}
