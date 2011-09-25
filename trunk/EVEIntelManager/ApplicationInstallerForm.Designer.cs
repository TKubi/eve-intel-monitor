namespace EVEIntelManager
{
    partial class ApplicationInstallerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationInstallerForm));
            this.listVersions = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentVersion = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBarDownload = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.backgroundDownloader = new System.ComponentModel.BackgroundWorker();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textTemporaryInstallerPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVersions
            // 
            this.listVersions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listVersions.FormattingEnabled = true;
            this.listVersions.Location = new System.Drawing.Point(12, 44);
            this.listVersions.Name = "listVersions";
            this.listVersions.Size = new System.Drawing.Size(197, 225);
            this.listVersions.TabIndex = 0;
            this.listVersions.SelectedIndexChanged += new System.EventHandler(this.listVersions_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Available Versions:";
            // 
            // textDescription
            // 
            this.textDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescription.Location = new System.Drawing.Point(216, 8);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(214, 275);
            this.textDescription.TabIndex = 11;
            this.textDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Current Version:";
            // 
            // labelCurrentVersion
            // 
            this.labelCurrentVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCurrentVersion.Location = new System.Drawing.Point(100, 8);
            this.labelCurrentVersion.Name = "labelCurrentVersion";
            this.labelCurrentVersion.Size = new System.Drawing.Size(109, 14);
            this.labelCurrentVersion.TabIndex = 13;
            this.labelCurrentVersion.Text = "0.3 Beta";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarDownload,
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(430, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(198, 17);
            this.toolStripStatusLabel.Text = "Please select a version to upgrade to";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(355, 289);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload.Location = new System.Drawing.Point(274, 290);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 16;
            this.buttonDownload.Text = "&Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // backgroundDownloader
            // 
            this.backgroundDownloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundDownloader_DoWork);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(242, 290);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(26, 23);
            this.buttonBrowse.TabIndex = 18;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // textTemporaryInstallerPath
            // 
            this.textTemporaryInstallerPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textTemporaryInstallerPath.Location = new System.Drawing.Point(12, 292);
            this.textTemporaryInstallerPath.Name = "textTemporaryInstallerPath";
            this.textTemporaryInstallerPath.Size = new System.Drawing.Size(224, 20);
            this.textTemporaryInstallerPath.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Temporary Path:";
            // 
            // ApplicationInstallerForm
            // 
            this.AcceptButton = this.buttonDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(430, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textTemporaryInstallerPath);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelCurrentVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listVersions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationInstallerForm";
            this.ShowInTaskbar = false;
            this.Text = "Upgrade EVE Intel Monitor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listVersions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox textDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentVersion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBarDownload;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDownload;
        private System.ComponentModel.BackgroundWorker backgroundDownloader;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textTemporaryInstallerPath;
        private System.Windows.Forms.Label label2;
    }
}