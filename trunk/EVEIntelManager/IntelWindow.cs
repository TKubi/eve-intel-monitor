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
        public IntelAnalyzer Analyzer { set { intelUI.Analyzer = value; } get { return intelUI.Analyzer; } }
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
            LogFileMonitor monitor = ReadChannel(textChannelName.Text);

            if (monitor == null)
            {
                MessageBox.Show(this, 
                    "Channel \"" + textChannelName.Text + "\" is not found.\n"+
                    "Is the game currently running?\n" +
                    "Is the channel window open in the game?\n" +
                    "Try replacing non-alphanumeric charecters with underscors ( _ )", 
                    "Channel not found", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
