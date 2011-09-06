namespace EVEIntelManager
{
    partial class SettingsUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKeywordsDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textKeywords = new System.Windows.Forms.TextBox();
            this.checkAutoLoad = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDefaultChannel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listKeywords = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkSynthesizeSpeech = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSpeachRateDisplay = new System.Windows.Forms.Label();
            this.scrollSpeachRate = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkSettingsLastTab = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textReadLogsAferSeconds = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textRefreshRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textEVELogDirectory = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboSelectedVoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkUpgrateOnStartup = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKeywordsDesc
            // 
            this.labelKeywordsDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKeywordsDesc.Location = new System.Drawing.Point(321, 62);
            this.labelKeywordsDesc.Name = "labelKeywordsDesc";
            this.labelKeywordsDesc.Size = new System.Drawing.Size(297, 53);
            this.labelKeywordsDesc.TabIndex = 9;
            this.labelKeywordsDesc.Text = "Enter keywords to search for in the intel (separatede by new lines)\r\nIn here you " +
                "can enter system names, partial names or other keywords that you want to match i" +
                "ntel agaist.\r\n";
            this.labelKeywordsDesc.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(320, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Channel Name as it appears in game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Keywords:";
            // 
            // textKeywords
            // 
            this.textKeywords.Location = new System.Drawing.Point(97, 62);
            this.textKeywords.Multiline = true;
            this.textKeywords.Name = "textKeywords";
            this.textKeywords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textKeywords.Size = new System.Drawing.Size(217, 122);
            this.textKeywords.TabIndex = 3;
            this.textKeywords.Visible = false;
            // 
            // checkAutoLoad
            // 
            this.checkAutoLoad.AutoSize = true;
            this.checkAutoLoad.Location = new System.Drawing.Point(97, 39);
            this.checkAutoLoad.Name = "checkAutoLoad";
            this.checkAutoLoad.Size = new System.Drawing.Size(165, 17);
            this.checkAutoLoad.TabIndex = 0;
            this.checkAutoLoad.Text = "Auto-load the default channel";
            this.checkAutoLoad.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Default Channel:";
            // 
            // textDefaultChannel
            // 
            this.textDefaultChannel.Location = new System.Drawing.Point(97, 13);
            this.textDefaultChannel.Name = "textDefaultChannel";
            this.textDefaultChannel.Size = new System.Drawing.Size(217, 20);
            this.textDefaultChannel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listKeywords);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.labelKeywordsDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textKeywords);
            this.groupBox1.Controls.Add(this.checkAutoLoad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textDefaultChannel);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intel Settings";
            // 
            // listKeywords
            // 
            this.listKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listKeywords.FormattingEnabled = true;
            this.listKeywords.Location = new System.Drawing.Point(97, 62);
            this.listKeywords.Name = "listKeywords";
            this.listKeywords.Size = new System.Drawing.Size(517, 121);
            this.listKeywords.TabIndex = 11;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(10, 78);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(81, 23);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Speach Rate (-10 to 10):";
            // 
            // checkSynthesizeSpeech
            // 
            this.checkSynthesizeSpeech.AutoSize = true;
            this.checkSynthesizeSpeech.Location = new System.Drawing.Point(10, 19);
            this.checkSynthesizeSpeech.Name = "checkSynthesizeSpeech";
            this.checkSynthesizeSpeech.Size = new System.Drawing.Size(117, 17);
            this.checkSynthesizeSpeech.TabIndex = 1;
            this.checkSynthesizeSpeech.Text = "Synthesize Speech";
            this.checkSynthesizeSpeech.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboSelectedVoice);
            this.groupBox2.Controls.Add(this.labelSpeachRateDisplay);
            this.groupBox2.Controls.Add(this.scrollSpeachRate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkSynthesizeSpeech);
            this.groupBox2.Location = new System.Drawing.Point(0, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sound Settings";
            // 
            // labelSpeachRateDisplay
            // 
            this.labelSpeachRateDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSpeachRateDisplay.Location = new System.Drawing.Point(137, 38);
            this.labelSpeachRateDisplay.Name = "labelSpeachRateDisplay";
            this.labelSpeachRateDisplay.Size = new System.Drawing.Size(48, 18);
            this.labelSpeachRateDisplay.TabIndex = 7;
            this.labelSpeachRateDisplay.Text = "-1";
            this.labelSpeachRateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollSpeachRate
            // 
            this.scrollSpeachRate.LargeChange = 1;
            this.scrollSpeachRate.Location = new System.Drawing.Point(188, 39);
            this.scrollSpeachRate.Maximum = 20;
            this.scrollSpeachRate.Name = "scrollSpeachRate";
            this.scrollSpeachRate.Size = new System.Drawing.Size(189, 17);
            this.scrollSpeachRate.TabIndex = 6;
            this.scrollSpeachRate.Value = 9;
            this.scrollSpeachRate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollSpeachRate_Scroll);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Under Construction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Select Window Color Scheme";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Dark"});
            this.comboBox1.Location = new System.Drawing.Point(159, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Default";
            // 
            // checkSettingsLastTab
            // 
            this.checkSettingsLastTab.AutoSize = true;
            this.checkSettingsLastTab.Location = new System.Drawing.Point(8, 19);
            this.checkSettingsLastTab.Name = "checkSettingsLastTab";
            this.checkSettingsLastTab.Size = new System.Drawing.Size(119, 17);
            this.checkSettingsLastTab.TabIndex = 3;
            this.checkSettingsLastTab.Text = "Settings is Last Tab";
            this.checkSettingsLastTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkUpgrateOnStartup);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.checkSettingsLastTab);
            this.groupBox3.Location = new System.Drawing.Point(1, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 95);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UI Settings";
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(10, 4);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(462, 26);
            this.labelError.TabIndex = 5;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(478, 4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(68, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "&Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(552, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(69, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textReadLogsAferSeconds
            // 
            this.textReadLogsAferSeconds.Location = new System.Drawing.Point(139, 44);
            this.textReadLogsAferSeconds.Name = "textReadLogsAferSeconds";
            this.textReadLogsAferSeconds.Size = new System.Drawing.Size(100, 20);
            this.textReadLogsAferSeconds.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(245, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(371, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Enter Modified Within in seconds (between 0 seconds and 1 days)";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(245, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(371, 26);
            this.label10.TabIndex = 7;
            this.label10.Text = "Enter refresh cycle in seconds (between 1 and 3600 seconds).";
            // 
            // textRefreshRate
            // 
            this.textRefreshRate.Location = new System.Drawing.Point(139, 69);
            this.textRefreshRate.Name = "textRefreshRate";
            this.textRefreshRate.Size = new System.Drawing.Size(100, 20);
            this.textRefreshRate.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Log Refresh Rate:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Logs Modified Within: ";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(590, 15);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(26, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textEVELogDirectory
            // 
            this.textEVELogDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textEVELogDirectory.Location = new System.Drawing.Point(139, 17);
            this.textEVELogDirectory.Name = "textEVELogDirectory";
            this.textEVELogDirectory.Size = new System.Drawing.Size(445, 20);
            this.textEVELogDirectory.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Chat Log Directory:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.textReadLogsAferSeconds);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textRefreshRate);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.buttonBrowse);
            this.groupBox4.Controls.Add(this.textEVELogDirectory);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(1, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(623, 133);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Channel Log Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 522);
            this.panel1.TabIndex = 9;
            // 
            // comboSelectedVoice
            // 
            this.comboSelectedVoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboSelectedVoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSelectedVoice.FormattingEnabled = true;
            this.comboSelectedVoice.Location = new System.Drawing.Point(225, 15);
            this.comboSelectedVoice.Name = "comboSelectedVoice";
            this.comboSelectedVoice.Size = new System.Drawing.Size(152, 21);
            this.comboSelectedVoice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selected Voice:";
            // 
            // checkUpgrateOnStartup
            // 
            this.checkUpgrateOnStartup.AutoSize = true;
            this.checkUpgrateOnStartup.Location = new System.Drawing.Point(8, 38);
            this.checkUpgrateOnStartup.Name = "checkUpgrateOnStartup";
            this.checkUpgrateOnStartup.Size = new System.Drawing.Size(187, 17);
            this.checkUpgrateOnStartup.TabIndex = 7;
            this.checkUpgrateOnStartup.Text = "Check for new versions on startup";
            this.checkUpgrateOnStartup.UseVisualStyleBackColor = true;
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonApply);
            this.Name = "SettingsUI";
            this.Size = new System.Drawing.Size(630, 561);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelKeywordsDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textKeywords;
        private System.Windows.Forms.CheckBox checkAutoLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDefaultChannel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkSynthesizeSpeech;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkSettingsLastTab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textReadLogsAferSeconds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textRefreshRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textEVELogDirectory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.HScrollBar scrollSpeachRate;
        private System.Windows.Forms.Label labelSpeachRateDisplay;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ListBox listKeywords;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboSelectedVoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkUpgrateOnStartup;
    }
}
