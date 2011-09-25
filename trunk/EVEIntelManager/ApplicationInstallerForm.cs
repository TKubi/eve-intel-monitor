using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Media;

namespace EVEIntelManager
{
    public partial class ApplicationInstallerForm : Form
    {
        private delegate AppVersion GetSelectedVersionDelegate();
        private delegate void SetToolTipDelegate(string toolTip);
        private delegate void SetProgressDelegate(int value);
        
        public AppVersionList VersionList { get; set; }
        public AppVersion CurrentVersion { get; set; }

        public ApplicationInstallerForm()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            listVersions.Items.Clear();

            if (VersionList != null)
            {
                foreach (AppVersion version in VersionList.Versions)
                {
                    if (CurrentVersion.GetVersion() < version.GetVersion())
                    {
                        listVersions.Items.Add(version);
                    }
                }

            }
            textTemporaryInstallerPath.Text = System.IO.Path.GetTempPath();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Downloading...";
            buttonDownload.Enabled = false;
            buttonCancel.Enabled = false;
            backgroundDownloader.RunWorkerAsync();
        }

        private void listVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppVersion version = listVersions.SelectedItem as AppVersion;
            if (version != null)
            {
                bool isLatest = VersionList.Latest != null && version.GetVersion() == VersionList.Latest.GetVersion();

                textDescription.Clear();
                textDescription.AppendText("Version: ");
                textDescription.AppendText(version.ToString() + "\n\n");
                textDescription.AppendText("Has been released: " + (version.Released ? "Yes" : "No") + "\n");
                if (isLatest)
                {
                    textDescription.AppendText("This version is the recommended for download!\n");
                }
                if (version.Description != null)
                {
                    textDescription.AppendText(version.Description);
                }

                toolStripStatusLabel.Text = "Selected Version: " + version.ToString() 
                    + (isLatest ? " * Latest *" : "") 
                    + " [" + version.URL + "]";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private AppVersion GetSelectedVersion()
        {
            if (this.InvokeRequired)
            {
                return this.Invoke((GetSelectedVersionDelegate)GetSelectedVersion) as AppVersion;
            }
            return listVersions.SelectedItem as AppVersion;
        }

        private void SetToolTip(string toolTip)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((SetToolTipDelegate)SetToolTip, toolTip);
                return;
            }
            toolStripStatusLabel.Text = toolTip;
        }

        private void SetProgressMax(int max)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((SetProgressDelegate)SetProgressMax, max);
                return;
            }
            progressBarDownload.Maximum = max;
        }

        private void SetProgressValue(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((SetProgressDelegate)SetProgressValue, value);
                return;
            }
            progressBarDownload.Value = value;
        }

        private void AddProgressValue(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((SetProgressDelegate)AddProgressValue, value);
                return;
            }
            progressBarDownload.Value += value;
        }


        private void backgroundDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            AppVersion version = GetSelectedVersion();
            if (version != null)
            {
                string path = textTemporaryInstallerPath.Text;
                string filename = Path.GetFileName(version.URL);
                path = Path.Combine(path, filename);

                bool downloadFile = true;

                if (File.Exists(path))
                {
                    downloadFile = false;
                    
                    DialogResult redownloadResult = MessageBox.Show("The installer file already downloaded, would you like to redownload it?", "Redownload the installer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (redownloadResult == DialogResult.Yes)
                    {
                        File.Delete(path);
                        downloadFile = true;
                    }
                }
                
                bool installerAvaialble = false;


                if (downloadFile)
                {
                    installerAvaialble = DownloadVersion(version.URL, path);
                }

                if (installerAvaialble) {
                    DialogResult result = MessageBox.Show("Would you like to close EVE Intel Monitor and launch the installer?", "Launch the installer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(path);
                        Application.Exit();
                    }
                }
            }
        }


        private bool DownloadVersion(string URL, string outputPath)
        {
            try {
                SetToolTip("Downloading " + URL);

                WebRequest objRequest = System.Net.HttpWebRequest.Create(URL);
                WebResponse objResponse = objRequest.GetResponse();

                SetProgressMax((int)objResponse.ContentLength);

                using (BinaryReader inputReader = new BinaryReader(objResponse.GetResponseStream()))
                {
                    using (FileStream outputStream = new FileStream(outputPath, FileMode.CreateNew))
                    {

                        byte[] buffer = new byte[32768];
                        int read;
                        while ((read = inputReader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            AddProgressValue(read);
                            outputStream.Write(buffer, 0, read);
                        }
                    }
                }

                return true;
            } catch (Exception e) {
                SetToolTip("Unable to download " + URL + ": " + e.Message);
                SystemSounds.Beep.Play();

                return false;
            }
        }
    }
}
