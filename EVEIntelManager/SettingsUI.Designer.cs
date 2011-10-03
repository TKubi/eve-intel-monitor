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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Speech");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Analysis");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Intelegance", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("User Interface");
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageIntelegance = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listKeywords = new System.Windows.Forms.ListBox();
            this.checkAutoLoad = new System.Windows.Forms.CheckBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemoveChannel = new System.Windows.Forms.Button();
            this.textKeywords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKeywordsDesc = new System.Windows.Forms.Label();
            this.textDefaultChannel = new System.Windows.Forms.ComboBox();
            this.buttonAddChannel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageSpeech = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkSynthesizeSpeech = new System.Windows.Forms.CheckBox();
            this.comboSelectedVoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollSpeachRate = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSpeachRateDisplay = new System.Windows.Forms.Label();
            this.tabPageAnalysis = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkUpgrateOnStartup = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textReadLogsAferSeconds = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textRefreshRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textEVELogDirectory = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPageUserInterface = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkShowStatusBar = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxIntelGrid = new System.Windows.Forms.CheckBox();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageIntelegance.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSpeech.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageAnalysis.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPageUserInterface.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeMenu);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelGeneral);
            this.splitContainer.Size = new System.Drawing.Size(618, 356);
            this.splitContainer.SplitterDistance = 135;
            this.splitContainer.TabIndex = 0;
            // 
            // treeMenu
            // 
            this.treeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMenu.FullRowSelect = true;
            this.treeMenu.Location = new System.Drawing.Point(0, 0);
            this.treeMenu.Name = "treeMenu";
            treeNode6.Name = "inteleganceSpeechNode";
            treeNode6.Text = "Speech";
            treeNode7.Name = "inteleganceAnalysisNode";
            treeNode7.Text = "Analysis";
            treeNode8.Name = "inteleganceNode";
            treeNode8.Text = "Intelegance";
            treeNode9.Name = "generalNode";
            treeNode9.Text = "General";
            treeNode10.Name = "uiNode";
            treeNode10.Text = "User Interface";
            this.treeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            this.treeMenu.Size = new System.Drawing.Size(135, 356);
            this.treeMenu.TabIndex = 0;
            this.treeMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMenu_AfterSelect);
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.tabControl);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(479, 356);
            this.panelGeneral.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tabPageIntelegance);
            this.tabControl.Controls.Add(this.tabPageSpeech);
            this.tabControl.Controls.Add(this.tabPageAnalysis);
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageUserInterface);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(479, 356);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 15;
            // 
            // tabPageIntelegance
            // 
            this.tabPageIntelegance.Controls.Add(this.groupBox1);
            this.tabPageIntelegance.Location = new System.Drawing.Point(4, 5);
            this.tabPageIntelegance.Name = "tabPageIntelegance";
            this.tabPageIntelegance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntelegance.Size = new System.Drawing.Size(471, 347);
            this.tabPageIntelegance.TabIndex = 6;
            this.tabPageIntelegance.Text = "Intelegance";
            this.tabPageIntelegance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listKeywords);
            this.groupBox1.Controls.Add(this.checkAutoLoad);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonRemoveChannel);
            this.groupBox1.Controls.Add(this.textKeywords);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelKeywordsDesc);
            this.groupBox1.Controls.Add(this.textDefaultChannel);
            this.groupBox1.Controls.Add(this.buttonAddChannel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 231);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intel Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Default Channel:";
            // 
            // listKeywords
            // 
            this.listKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listKeywords.FormattingEnabled = true;
            this.listKeywords.Location = new System.Drawing.Point(95, 94);
            this.listKeywords.Name = "listKeywords";
            this.listKeywords.Size = new System.Drawing.Size(358, 121);
            this.listKeywords.TabIndex = 15;
            // 
            // checkAutoLoad
            // 
            this.checkAutoLoad.AutoSize = true;
            this.checkAutoLoad.Location = new System.Drawing.Point(95, 71);
            this.checkAutoLoad.Name = "checkAutoLoad";
            this.checkAutoLoad.Size = new System.Drawing.Size(214, 17);
            this.checkAutoLoad.TabIndex = 0;
            this.checkAutoLoad.Text = "Auto-load the channels in the startup list";
            this.checkAutoLoad.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(6, 111);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(81, 23);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemoveChannel
            // 
            this.buttonRemoveChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveChannel.Location = new System.Drawing.Point(432, 11);
            this.buttonRemoveChannel.Name = "buttonRemoveChannel";
            this.buttonRemoveChannel.Size = new System.Drawing.Size(21, 23);
            this.buttonRemoveChannel.TabIndex = 14;
            this.buttonRemoveChannel.Text = "-";
            this.buttonRemoveChannel.UseVisualStyleBackColor = true;
            this.buttonRemoveChannel.Click += new System.EventHandler(this.buttonRemoveChannel_Click);
            // 
            // textKeywords
            // 
            this.textKeywords.Location = new System.Drawing.Point(96, 95);
            this.textKeywords.Multiline = true;
            this.textKeywords.Name = "textKeywords";
            this.textKeywords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textKeywords.Size = new System.Drawing.Size(217, 122);
            this.textKeywords.TabIndex = 3;
            this.textKeywords.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(93, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Default channel list that would be loaded at strartup. \r\nPress [ctrl+alt+A] or us" +
                "e \"+\" to add a new channel.";
            // 
            // labelKeywordsDesc
            // 
            this.labelKeywordsDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKeywordsDesc.Location = new System.Drawing.Point(320, 95);
            this.labelKeywordsDesc.Name = "labelKeywordsDesc";
            this.labelKeywordsDesc.Size = new System.Drawing.Size(133, 71);
            this.labelKeywordsDesc.TabIndex = 9;
            this.labelKeywordsDesc.Text = "Enter keywords to search for in the intel (separatede by new lines)\r\nIn here you " +
                "can enter system names, partial names or other keywords that you want to match i" +
                "ntel agaist.\r\n";
            this.labelKeywordsDesc.Visible = false;
            // 
            // textDefaultChannel
            // 
            this.textDefaultChannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textDefaultChannel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textDefaultChannel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textDefaultChannel.FormattingEnabled = true;
            this.textDefaultChannel.Location = new System.Drawing.Point(96, 13);
            this.textDefaultChannel.Name = "textDefaultChannel";
            this.textDefaultChannel.Size = new System.Drawing.Size(302, 21);
            this.textDefaultChannel.TabIndex = 13;
            this.textDefaultChannel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textDefaultChannel_KeyUp);
            // 
            // buttonAddChannel
            // 
            this.buttonAddChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddChannel.Location = new System.Drawing.Point(404, 11);
            this.buttonAddChannel.Name = "buttonAddChannel";
            this.buttonAddChannel.Size = new System.Drawing.Size(22, 23);
            this.buttonAddChannel.TabIndex = 12;
            this.buttonAddChannel.Text = "+";
            this.buttonAddChannel.UseVisualStyleBackColor = true;
            this.buttonAddChannel.Click += new System.EventHandler(this.buttonAddChannel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Keywords:";
            // 
            // tabPageSpeech
            // 
            this.tabPageSpeech.Controls.Add(this.groupBox2);
            this.tabPageSpeech.Location = new System.Drawing.Point(4, 5);
            this.tabPageSpeech.Name = "tabPageSpeech";
            this.tabPageSpeech.Size = new System.Drawing.Size(471, 347);
            this.tabPageSpeech.TabIndex = 7;
            this.tabPageSpeech.Text = "Speech";
            this.tabPageSpeech.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkSynthesizeSpeech);
            this.groupBox2.Controls.Add(this.comboSelectedVoice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.scrollSpeachRate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelSpeachRateDisplay);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 125);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sound and Speech Settings";
            // 
            // checkSynthesizeSpeech
            // 
            this.checkSynthesizeSpeech.AutoSize = true;
            this.checkSynthesizeSpeech.Location = new System.Drawing.Point(139, 19);
            this.checkSynthesizeSpeech.Name = "checkSynthesizeSpeech";
            this.checkSynthesizeSpeech.Size = new System.Drawing.Size(117, 17);
            this.checkSynthesizeSpeech.TabIndex = 1;
            this.checkSynthesizeSpeech.Text = "Synthesize Speech";
            this.checkSynthesizeSpeech.UseVisualStyleBackColor = true;
            // 
            // comboSelectedVoice
            // 
            this.comboSelectedVoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboSelectedVoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSelectedVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectedVoice.FormattingEnabled = true;
            this.comboSelectedVoice.Location = new System.Drawing.Point(139, 37);
            this.comboSelectedVoice.Name = "comboSelectedVoice";
            this.comboSelectedVoice.Size = new System.Drawing.Size(240, 21);
            this.comboSelectedVoice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selected Voice:";
            // 
            // scrollSpeachRate
            // 
            this.scrollSpeachRate.LargeChange = 1;
            this.scrollSpeachRate.Location = new System.Drawing.Point(190, 71);
            this.scrollSpeachRate.Maximum = 20;
            this.scrollSpeachRate.Name = "scrollSpeachRate";
            this.scrollSpeachRate.Size = new System.Drawing.Size(189, 17);
            this.scrollSpeachRate.TabIndex = 6;
            this.scrollSpeachRate.Value = 9;
            this.scrollSpeachRate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollSpeachRate_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Speach Rate (-10 to 10):";
            // 
            // labelSpeachRateDisplay
            // 
            this.labelSpeachRateDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSpeachRateDisplay.Location = new System.Drawing.Point(139, 72);
            this.labelSpeachRateDisplay.Name = "labelSpeachRateDisplay";
            this.labelSpeachRateDisplay.Size = new System.Drawing.Size(48, 18);
            this.labelSpeachRateDisplay.TabIndex = 7;
            this.labelSpeachRateDisplay.Text = "-1";
            this.labelSpeachRateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAnalysis
            // 
            this.tabPageAnalysis.Controls.Add(this.label8);
            this.tabPageAnalysis.Location = new System.Drawing.Point(4, 5);
            this.tabPageAnalysis.Name = "tabPageAnalysis";
            this.tabPageAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnalysis.Size = new System.Drawing.Size(471, 347);
            this.tabPageAnalysis.TabIndex = 8;
            this.tabPageAnalysis.Text = "Analysis";
            this.tabPageAnalysis.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Under Construction";
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.groupBox5);
            this.tabPageGeneral.Controls.Add(this.groupBox4);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 5);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(471, 347);
            this.tabPageGeneral.TabIndex = 3;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.checkUpgrateOnStartup);
            this.groupBox5.Location = new System.Drawing.Point(6, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(459, 103);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Update Settings";
            // 
            // checkUpgrateOnStartup
            // 
            this.checkUpgrateOnStartup.AutoSize = true;
            this.checkUpgrateOnStartup.Location = new System.Drawing.Point(10, 19);
            this.checkUpgrateOnStartup.Name = "checkUpgrateOnStartup";
            this.checkUpgrateOnStartup.Size = new System.Drawing.Size(187, 17);
            this.checkUpgrateOnStartup.TabIndex = 8;
            this.checkUpgrateOnStartup.Text = "Check for new versions on startup";
            this.checkUpgrateOnStartup.UseVisualStyleBackColor = true;
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
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 133);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Channel Log Settings";
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
            this.label9.Size = new System.Drawing.Size(207, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Enter Modified Within in seconds (between 0 seconds and 1 days)";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(245, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 26);
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
            this.buttonBrowse.Location = new System.Drawing.Point(426, 15);
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
            this.textEVELogDirectory.Size = new System.Drawing.Size(281, 20);
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
            // tabPageUserInterface
            // 
            this.tabPageUserInterface.Controls.Add(this.groupBox3);
            this.tabPageUserInterface.Location = new System.Drawing.Point(4, 5);
            this.tabPageUserInterface.Name = "tabPageUserInterface";
            this.tabPageUserInterface.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserInterface.Size = new System.Drawing.Size(471, 347);
            this.tabPageUserInterface.TabIndex = 4;
            this.tabPageUserInterface.Text = "User Interface";
            this.tabPageUserInterface.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkBoxIntelGrid);
            this.groupBox3.Controls.Add(this.checkShowStatusBar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 131);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UI Settings";
            // 
            // checkShowStatusBar
            // 
            this.checkShowStatusBar.AutoSize = true;
            this.checkShowStatusBar.Location = new System.Drawing.Point(9, 19);
            this.checkShowStatusBar.Name = "checkShowStatusBar";
            this.checkShowStatusBar.Size = new System.Drawing.Size(102, 17);
            this.checkShowStatusBar.TabIndex = 8;
            this.checkShowStatusBar.Text = "Show status bar";
            this.checkShowStatusBar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Under Construction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
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
            this.comboBox1.Location = new System.Drawing.Point(160, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Default";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.labelError);
            this.panelButtons.Controls.Add(this.buttonOK);
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Controls.Add(this.buttonApply);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 374);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(642, 38);
            this.panelButtons.TabIndex = 17;
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(9, 6);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(374, 26);
            this.labelError.TabIndex = 6;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(389, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(470, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(551, 8);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "&Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // checkBoxIntelGrid
            // 
            this.checkBoxIntelGrid.AutoSize = true;
            this.checkBoxIntelGrid.Location = new System.Drawing.Point(9, 42);
            this.checkBoxIntelGrid.Name = "checkBoxIntelGrid";
            this.checkBoxIntelGrid.Size = new System.Drawing.Size(161, 17);
            this.checkBoxIntelGrid.TabIndex = 9;
            this.checkBoxIntelGrid.Text = "Show \'Grid View\' in Intel Tab";
            this.checkBoxIntelGrid.UseVisualStyleBackColor = true;
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.splitContainer);
            this.Name = "SettingsUI";
            this.Size = new System.Drawing.Size(642, 412);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageIntelegance.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSpeech.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageAnalysis.ResumeLayout(false);
            this.tabPageAnalysis.PerformLayout();
            this.tabPageGeneral.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPageUserInterface.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeMenu;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button buttonRemoveChannel;
        private System.Windows.Forms.ComboBox textDefaultChannel;
        private System.Windows.Forms.Button buttonAddChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkAutoLoad;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textKeywords;
        private System.Windows.Forms.Label labelKeywordsDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageUserInterface;
        private System.Windows.Forms.TabPage tabPageIntelegance;
        private System.Windows.Forms.ListBox listKeywords;
        private System.Windows.Forms.TabPage tabPageSpeech;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSelectedVoice;
        private System.Windows.Forms.CheckBox checkSynthesizeSpeech;
        private System.Windows.Forms.Label labelSpeachRateDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar scrollSpeachRate;
        private System.Windows.Forms.CheckBox checkUpgrateOnStartup;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textReadLogsAferSeconds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textRefreshRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textEVELogDirectory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkShowStatusBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TabPage tabPageAnalysis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxIntelGrid;

    }
}