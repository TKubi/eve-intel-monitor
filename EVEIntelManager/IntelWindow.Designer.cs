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
            this.panelChannelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.textChannelName = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUnloadChannel = new System.Windows.Forms.Button();
            this.labelSelectedChannels = new System.Windows.Forms.Label();
            this.listLoadedChannels = new System.Windows.Forms.ListBox();
            this.buttonLoadChannels = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.CheckedListBox();
            this.logReaderUI = new EVEIntelManager.LogReaderUI();
            this.tabIntel = new System.Windows.Forms.TabPage();
            this.intelUI = new EVEIntelManager.IntelUI();
            this.checkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.backgroundUpdateWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabChannels.SuspendLayout();
            this.panelChannelHeader.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabIntel.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(737, 408);
            this.tabControl.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.Controls.Add(this.settingsUI);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(729, 382);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // settingsUI
            // 
            this.settingsUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsUI.Location = new System.Drawing.Point(3, 3);
            this.settingsUI.Name = "settingsUI";
            this.settingsUI.Size = new System.Drawing.Size(723, 376);
            this.settingsUI.TabIndex = 0;
            this.settingsUI.ChangedSettings += new EVEIntelManager.NotifySettingsChanged(this.ApplySettings);
            // 
            // tabChannels
            // 
            this.tabChannels.Controls.Add(this.panelChannelHeader);
            this.tabChannels.Controls.Add(this.splitContainer);
            this.tabChannels.Location = new System.Drawing.Point(4, 22);
            this.tabChannels.Name = "tabChannels";
            this.tabChannels.Padding = new System.Windows.Forms.Padding(3);
            this.tabChannels.Size = new System.Drawing.Size(729, 382);
            this.tabChannels.TabIndex = 0;
            this.tabChannels.Text = "Channels";
            this.tabChannels.UseVisualStyleBackColor = true;
            // 
            // panelChannelHeader
            // 
            this.panelChannelHeader.Controls.Add(this.label1);
            this.panelChannelHeader.Controls.Add(this.buttonRead);
            this.panelChannelHeader.Controls.Add(this.textChannelName);
            this.panelChannelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChannelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelChannelHeader.Name = "panelChannelHeader";
            this.panelChannelHeader.Size = new System.Drawing.Size(723, 28);
            this.panelChannelHeader.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Channel Name: ";
            // 
            // buttonRead
            // 
            this.buttonRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRead.Location = new System.Drawing.Point(633, 1);
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
            this.textChannelName.Location = new System.Drawing.Point(96, 3);
            this.textChannelName.Name = "textChannelName";
            this.textChannelName.Size = new System.Drawing.Size(531, 20);
            this.textChannelName.TabIndex = 2;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(3, 32);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.label7);
            this.splitContainer.Panel1.Controls.Add(this.buttonUnloadChannel);
            this.splitContainer.Panel1.Controls.Add(this.labelSelectedChannels);
            this.splitContainer.Panel1.Controls.Add(this.listLoadedChannels);
            this.splitContainer.Panel1.Controls.Add(this.buttonLoadChannels);
            this.splitContainer.Panel1.Controls.Add(this.listFiles);
            this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.logReaderUI);
            this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer.Size = new System.Drawing.Size(723, 354);
            this.splitContainer.SplitterDistance = 236;
            this.splitContainer.TabIndex = 7;
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
            this.buttonUnloadChannel.Location = new System.Drawing.Point(3, 326);
            this.buttonUnloadChannel.Name = "buttonUnloadChannel";
            this.buttonUnloadChannel.Size = new System.Drawing.Size(232, 25);
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
            this.labelSelectedChannels.Location = new System.Drawing.Point(3, 157);
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
            this.listLoadedChannels.Location = new System.Drawing.Point(2, 173);
            this.listLoadedChannels.Name = "listLoadedChannels";
            this.listLoadedChannels.Size = new System.Drawing.Size(232, 147);
            this.listLoadedChannels.TabIndex = 6;
            // 
            // buttonLoadChannels
            // 
            this.buttonLoadChannels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadChannels.Location = new System.Drawing.Point(3, 131);
            this.buttonLoadChannels.Name = "buttonLoadChannels";
            this.buttonLoadChannels.Size = new System.Drawing.Size(232, 23);
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
            this.listFiles.Location = new System.Drawing.Point(3, 34);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(232, 94);
            this.listFiles.TabIndex = 4;
            // 
            // logReaderUI
            // 
            this.logReaderUI.BackColor = System.Drawing.SystemColors.Control;
            this.logReaderUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logReaderUI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logReaderUI.Location = new System.Drawing.Point(0, 0);
            this.logReaderUI.Name = "logReaderUI";
            this.logReaderUI.Size = new System.Drawing.Size(483, 354);
            this.logReaderUI.TabIndex = 6;
            this.logReaderUI.TimerInterval = 5000;
            // 
            // tabIntel
            // 
            this.tabIntel.Controls.Add(this.intelUI);
            this.tabIntel.Location = new System.Drawing.Point(4, 22);
            this.tabIntel.Name = "tabIntel";
            this.tabIntel.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntel.Size = new System.Drawing.Size(729, 382);
            this.tabIntel.TabIndex = 2;
            this.tabIntel.Text = "Intel";
            this.tabIntel.UseVisualStyleBackColor = true;
            // 
            // intelUI
            // 
            this.intelUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intelUI.Location = new System.Drawing.Point(3, 3);
            this.intelUI.Name = "intelUI";
            this.intelUI.Size = new System.Drawing.Size(723, 376);
            this.intelUI.TabIndex = 0;
            // 
            // checkAlwaysOnTop
            // 
            this.checkAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAlwaysOnTop.AutoSize = true;
            this.checkAlwaysOnTop.Checked = true;
            this.checkAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAlwaysOnTop.Location = new System.Drawing.Point(634, 1);
            this.checkAlwaysOnTop.Name = "checkAlwaysOnTop";
            this.checkAlwaysOnTop.Size = new System.Drawing.Size(98, 17);
            this.checkAlwaysOnTop.TabIndex = 9;
            this.checkAlwaysOnTop.Text = "Always On Top";
            this.checkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.checkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkAlwaysOnTop_CheckedChanged);
            // 
            // backgroundUpdateWorker
            // 
            this.backgroundUpdateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundUpdateWorker_DoWork);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 411);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(737, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // IntelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 433);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.checkAlwaysOnTop);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntelWindow";
            this.Text = "EVE Intel Monitor - Beta";
            this.TopMost = true;
            this.tabControl.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabChannels.ResumeLayout(false);
            this.panelChannelHeader.ResumeLayout(false);
            this.panelChannelHeader.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.tabIntel.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private LogReaderUI logReaderUI;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListBox listLoadedChannels;
        private System.Windows.Forms.Button buttonUnloadChannel;
        private System.Windows.Forms.Label labelSelectedChannels;
        private System.Windows.Forms.Label label7;
        private SettingsUI settingsUI;
        private System.ComponentModel.BackgroundWorker backgroundUpdateWorker;
        private System.Windows.Forms.Panel panelChannelHeader;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TabPage tabIntel;
        private IntelUI intelUI;
    }
}

