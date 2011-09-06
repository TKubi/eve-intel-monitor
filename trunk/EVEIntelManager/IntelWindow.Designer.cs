namespace EVEIntelManager
{
    partial class IntelWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntelWindow));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.settingsUI = new EVEIntelManager.SettingsUI();
            this.tabChannels = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUnloadChannel = new System.Windows.Forms.Button();
            this.labelSelectedChannels = new System.Windows.Forms.Label();
            this.listLoadedChannels = new System.Windows.Forms.ListBox();
            this.buttonLoadChannels = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.CheckedListBox();
            this.logReaderUI = new EVEIntelManager.LogReaderUI();
            this.buttonRead = new System.Windows.Forms.Button();
            this.textChannelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabIntel = new System.Windows.Forms.TabPage();
            this.buttonMonitorIntel = new System.Windows.Forms.Button();
            this.labelPausingIntel = new System.Windows.Forms.Label();
            this.listIntel = new System.Windows.Forms.ListBox();
            this.buttonClearIntel = new System.Windows.Forms.Button();
            this.checkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.backgroundIntelSound = new System.ComponentModel.BackgroundWorker();
            this.backgroundUpdateWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabChannels.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabIntel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabChannels);
            this.tabControl.Controls.Add(this.tabIntel);
            this.tabControl.Location = new System.Drawing.Point(0, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(601, 369);
            this.tabControl.TabIndex = 8;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.Controls.Add(this.settingsUI);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(593, 343);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // settingsUI
            // 
            this.settingsUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsUI.Location = new System.Drawing.Point(0, 0);
            this.settingsUI.Name = "settingsUI";
            this.settingsUI.Size = new System.Drawing.Size(593, 347);
            this.settingsUI.TabIndex = 0;
            this.settingsUI.ChangedSettings += new EVEIntelManager.NotifySettingsChanged(this.ApplySettings);
            // 
            // tabChannels
            // 
            this.tabChannels.Controls.Add(this.splitContainer2);
            this.tabChannels.Controls.Add(this.buttonRead);
            this.tabChannels.Controls.Add(this.textChannelName);
            this.tabChannels.Controls.Add(this.label1);
            this.tabChannels.Location = new System.Drawing.Point(4, 22);
            this.tabChannels.Name = "tabChannels";
            this.tabChannels.Padding = new System.Windows.Forms.Padding(3);
            this.tabChannels.Size = new System.Drawing.Size(593, 343);
            this.tabChannels.TabIndex = 0;
            this.tabChannels.Text = "Channels";
            this.tabChannels.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 35);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.buttonUnloadChannel);
            this.splitContainer2.Panel1.Controls.Add(this.labelSelectedChannels);
            this.splitContainer2.Panel1.Controls.Add(this.listLoadedChannels);
            this.splitContainer2.Panel1.Controls.Add(this.buttonLoadChannels);
            this.splitContainer2.Panel1.Controls.Add(this.listFiles);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.logReaderUI);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(598, 310);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Available Channel Logs:";
            // 
            // buttonUnloadChannel
            // 
            this.buttonUnloadChannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnloadChannel.Location = new System.Drawing.Point(3, 279);
            this.buttonUnloadChannel.Name = "buttonUnloadChannel";
            this.buttonUnloadChannel.Size = new System.Drawing.Size(192, 25);
            this.buttonUnloadChannel.TabIndex = 8;
            this.buttonUnloadChannel.Text = "&Unload Channel";
            this.buttonUnloadChannel.UseVisualStyleBackColor = true;
            this.buttonUnloadChannel.Click += new System.EventHandler(this.buttonUnloadChannel_Click);
            // 
            // labelSelectedChannels
            // 
            this.labelSelectedChannels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedChannels.AutoSize = true;
            this.labelSelectedChannels.Location = new System.Drawing.Point(5, 187);
            this.labelSelectedChannels.Name = "labelSelectedChannels";
            this.labelSelectedChannels.Size = new System.Drawing.Size(99, 13);
            this.labelSelectedChannels.TabIndex = 7;
            this.labelSelectedChannels.Text = "Selected Channels:";
            // 
            // listLoadedChannels
            // 
            this.listLoadedChannels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listLoadedChannels.FormattingEnabled = true;
            this.listLoadedChannels.Location = new System.Drawing.Point(3, 204);
            this.listLoadedChannels.Name = "listLoadedChannels";
            this.listLoadedChannels.Size = new System.Drawing.Size(192, 69);
            this.listLoadedChannels.TabIndex = 6;
            // 
            // buttonLoadChannels
            // 
            this.buttonLoadChannels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadChannels.Location = new System.Drawing.Point(2, 162);
            this.buttonLoadChannels.Name = "buttonLoadChannels";
            this.buttonLoadChannels.Size = new System.Drawing.Size(192, 23);
            this.buttonLoadChannels.TabIndex = 5;
            this.buttonLoadChannels.Text = "&Load Channels";
            this.buttonLoadChannels.UseVisualStyleBackColor = true;
            this.buttonLoadChannels.Click += new System.EventHandler(this.buttonLoadChannels_Click);
            // 
            // listFiles
            // 
            this.listFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(3, 24);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(192, 124);
            this.listFiles.TabIndex = 4;
            // 
            // logReaderUI
            // 
            this.logReaderUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logReaderUI.BackColor = System.Drawing.SystemColors.Control;
            this.logReaderUI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logReaderUI.Location = new System.Drawing.Point(3, 3);
            this.logReaderUI.Name = "logReaderUI";
            this.logReaderUI.Size = new System.Drawing.Size(377, 303);
            this.logReaderUI.TabIndex = 6;
            this.logReaderUI.TimerInterval = 5000;
            // 
            // buttonRead
            // 
            this.buttonRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRead.Location = new System.Drawing.Point(500, 7);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(87, 23);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "&Read Folder";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // textChannelName
            // 
            this.textChannelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textChannelName.Location = new System.Drawing.Point(97, 9);
            this.textChannelName.Name = "textChannelName";
            this.textChannelName.Size = new System.Drawing.Size(397, 20);
            this.textChannelName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Channel Name: ";
            // 
            // tabIntel
            // 
            this.tabIntel.Controls.Add(this.buttonMonitorIntel);
            this.tabIntel.Controls.Add(this.labelPausingIntel);
            this.tabIntel.Controls.Add(this.listIntel);
            this.tabIntel.Controls.Add(this.buttonClearIntel);
            this.tabIntel.Location = new System.Drawing.Point(4, 22);
            this.tabIntel.Name = "tabIntel";
            this.tabIntel.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntel.Size = new System.Drawing.Size(593, 343);
            this.tabIntel.TabIndex = 2;
            this.tabIntel.Text = "Intel";
            this.tabIntel.UseVisualStyleBackColor = true;
            // 
            // buttonMonitorIntel
            // 
            this.buttonMonitorIntel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMonitorIntel.Location = new System.Drawing.Point(513, 6);
            this.buttonMonitorIntel.Name = "buttonMonitorIntel";
            this.buttonMonitorIntel.Size = new System.Drawing.Size(75, 23);
            this.buttonMonitorIntel.TabIndex = 1;
            this.buttonMonitorIntel.Tag = "";
            this.buttonMonitorIntel.Text = "&Start";
            this.buttonMonitorIntel.UseVisualStyleBackColor = true;
            this.buttonMonitorIntel.Click += new System.EventHandler(this.buttonMonitorIntel_Click);
            // 
            // labelPausingIntel
            // 
            this.labelPausingIntel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPausingIntel.BackColor = System.Drawing.Color.Transparent;
            this.labelPausingIntel.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPausingIntel.Location = new System.Drawing.Point(84, 8);
            this.labelPausingIntel.Name = "labelPausingIntel";
            this.labelPausingIntel.Size = new System.Drawing.Size(423, 19);
            this.labelPausingIntel.TabIndex = 10;
            this.labelPausingIntel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listIntel
            // 
            this.listIntel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listIntel.FormattingEnabled = true;
            this.listIntel.Location = new System.Drawing.Point(3, 33);
            this.listIntel.Name = "listIntel";
            this.listIntel.Size = new System.Drawing.Size(585, 303);
            this.listIntel.TabIndex = 9;
            // 
            // buttonClearIntel
            // 
            this.buttonClearIntel.Location = new System.Drawing.Point(6, 6);
            this.buttonClearIntel.Name = "buttonClearIntel";
            this.buttonClearIntel.Size = new System.Drawing.Size(75, 23);
            this.buttonClearIntel.TabIndex = 8;
            this.buttonClearIntel.Text = "&Clear Intel";
            this.buttonClearIntel.UseVisualStyleBackColor = true;
            this.buttonClearIntel.Click += new System.EventHandler(this.buttonClearIntel_Click);
            // 
            // checkAlwaysOnTop
            // 
            this.checkAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAlwaysOnTop.AutoSize = true;
            this.checkAlwaysOnTop.Checked = true;
            this.checkAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAlwaysOnTop.Location = new System.Drawing.Point(495, 4);
            this.checkAlwaysOnTop.Name = "checkAlwaysOnTop";
            this.checkAlwaysOnTop.Size = new System.Drawing.Size(98, 17);
            this.checkAlwaysOnTop.TabIndex = 9;
            this.checkAlwaysOnTop.Text = "Always On Top";
            this.checkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.checkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkAlwaysOnTop_CheckedChanged);
            // 
            // backgroundIntelSound
            // 
            this.backgroundIntelSound.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundIntelSound_DoWork);
            // 
            // backgroundUpdateWorker
            // 
            this.backgroundUpdateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundUpdateWorker_DoWork);
            // 
            // IntelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 373);
            this.Controls.Add(this.checkAlwaysOnTop);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntelWindow";
            this.Text = "EVE Intel Monitor - Beta";
            this.TopMost = true;
            this.tabControl.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabChannels.ResumeLayout(false);
            this.tabChannels.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tabIntel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabChannels;
        private System.Windows.Forms.CheckBox checkAlwaysOnTop;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textChannelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button buttonLoadChannels;
        private System.Windows.Forms.CheckedListBox listFiles;
        private System.Windows.Forms.TabPage tabIntel;
        private System.Windows.Forms.Button buttonMonitorIntel;
        private LogReaderUI logReaderUI;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listLoadedChannels;
        private System.Windows.Forms.Button buttonUnloadChannel;
        private System.Windows.Forms.Label labelSelectedChannels;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonClearIntel;
        private System.ComponentModel.BackgroundWorker backgroundIntelSound;
        private SettingsUI settingsUI;
        private System.Windows.Forms.ListBox listIntel;
        private System.Windows.Forms.Label labelPausingIntel;
        private System.ComponentModel.BackgroundWorker backgroundUpdateWorker;
    }
}

