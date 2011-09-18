namespace EVEIntelManager
{
    partial class IntelUI
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
            this.panelIntellHeader = new System.Windows.Forms.Panel();
            this.buttonClearIntel = new System.Windows.Forms.Button();
            this.labelPausingIntel = new System.Windows.Forms.Label();
            this.buttonMonitorIntel = new System.Windows.Forms.Button();
            this.dataGridIntel = new System.Windows.Forms.DataGridView();
            this.backgroundIntelSound = new System.ComponentModel.BackgroundWorker();
            this.listIntel = new System.Windows.Forms.ListBox();
            this.panelIntellHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIntel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIntellHeader
            // 
            this.panelIntellHeader.Controls.Add(this.buttonClearIntel);
            this.panelIntellHeader.Controls.Add(this.labelPausingIntel);
            this.panelIntellHeader.Controls.Add(this.buttonMonitorIntel);
            this.panelIntellHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIntellHeader.Location = new System.Drawing.Point(0, 0);
            this.panelIntellHeader.Name = "panelIntellHeader";
            this.panelIntellHeader.Size = new System.Drawing.Size(545, 29);
            this.panelIntellHeader.TabIndex = 17;
            // 
            // buttonClearIntel
            // 
            this.buttonClearIntel.Location = new System.Drawing.Point(3, 3);
            this.buttonClearIntel.Name = "buttonClearIntel";
            this.buttonClearIntel.Size = new System.Drawing.Size(75, 23);
            this.buttonClearIntel.TabIndex = 8;
            this.buttonClearIntel.Text = "&Clear Intel";
            this.buttonClearIntel.UseVisualStyleBackColor = true;
            this.buttonClearIntel.Click += new System.EventHandler(this.buttonClearIntel_Click);
            // 
            // labelPausingIntel
            // 
            this.labelPausingIntel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPausingIntel.BackColor = System.Drawing.Color.Transparent;
            this.labelPausingIntel.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPausingIntel.Location = new System.Drawing.Point(84, 4);
            this.labelPausingIntel.Name = "labelPausingIntel";
            this.labelPausingIntel.Size = new System.Drawing.Size(378, 21);
            this.labelPausingIntel.TabIndex = 10;
            this.labelPausingIntel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMonitorIntel
            // 
            this.buttonMonitorIntel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMonitorIntel.Location = new System.Drawing.Point(463, 3);
            this.buttonMonitorIntel.Name = "buttonMonitorIntel";
            this.buttonMonitorIntel.Size = new System.Drawing.Size(75, 23);
            this.buttonMonitorIntel.TabIndex = 1;
            this.buttonMonitorIntel.Tag = "";
            this.buttonMonitorIntel.Text = "&Start";
            this.buttonMonitorIntel.UseVisualStyleBackColor = true;
            this.buttonMonitorIntel.Click += new System.EventHandler(this.buttonMonitorIntel_Click);
            // 
            // dataGridIntel
            // 
            this.dataGridIntel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIntel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridIntel.Location = new System.Drawing.Point(0, 29);
            this.dataGridIntel.Name = "dataGridIntel";
            this.dataGridIntel.Size = new System.Drawing.Size(545, 325);
            this.dataGridIntel.TabIndex = 18;
            // 
            // backgroundIntelSound
            // 
            this.backgroundIntelSound.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundIntelSound_DoWork);
            // 
            // listIntel
            // 
            this.listIntel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listIntel.FormattingEnabled = true;
            this.listIntel.Location = new System.Drawing.Point(0, 29);
            this.listIntel.Name = "listIntel";
            this.listIntel.Size = new System.Drawing.Size(545, 316);
            this.listIntel.TabIndex = 19;
            // 
            // IntelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listIntel);
            this.Controls.Add(this.dataGridIntel);
            this.Controls.Add(this.panelIntellHeader);
            this.Name = "IntelUI";
            this.Size = new System.Drawing.Size(545, 354);
            this.panelIntellHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIntel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIntellHeader;
        private System.Windows.Forms.Button buttonClearIntel;
        private System.Windows.Forms.Label labelPausingIntel;
        private System.Windows.Forms.Button buttonMonitorIntel;
        private System.Windows.Forms.DataGridView dataGridIntel;
        private System.ComponentModel.BackgroundWorker backgroundIntelSound;
        private System.Windows.Forms.ListBox listIntel;

    }
}
