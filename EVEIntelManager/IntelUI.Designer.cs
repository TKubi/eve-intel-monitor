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
            this.components = new System.ComponentModel.Container();
            this.panelIntellHeader = new System.Windows.Forms.Panel();
            this.buttonClearIntel = new System.Windows.Forms.Button();
            this.labelPausingIntel = new System.Windows.Forms.Label();
            this.buttonMonitorIntel = new System.Windows.Forms.Button();
            this.dataGridIntel = new System.Windows.Forms.DataGridView();
            this.intelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundIntelSound = new System.ComponentModel.BackgroundWorker();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noVisualDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.channelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelIntellHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIntel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelBindingSource)).BeginInit();
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
            this.dataGridIntel.AllowUserToAddRows = false;
            this.dataGridIntel.AllowUserToDeleteRows = false;
            this.dataGridIntel.AllowUserToOrderColumns = true;
            this.dataGridIntel.AutoGenerateColumns = false;
            this.dataGridIntel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIntel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timestampDataGridViewTextBoxColumn,
            this.systemDataGridViewTextBoxColumn,
            this.playersDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.reportedByDataGridViewTextBoxColumn,
            this.clearDataGridViewCheckBoxColumn,
            this.noVisualDataGridViewCheckBoxColumn,
            this.channelDataGridViewTextBoxColumn});
            this.dataGridIntel.DataSource = this.intelBindingSource;
            this.dataGridIntel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridIntel.Location = new System.Drawing.Point(0, 29);
            this.dataGridIntel.Name = "dataGridIntel";
            this.dataGridIntel.ReadOnly = true;
            this.dataGridIntel.Size = new System.Drawing.Size(545, 325);
            this.dataGridIntel.TabIndex = 18;
            // 
            // intelBindingSource
            // 
            this.intelBindingSource.DataSource = typeof(EVEIntelAnalyzer.Intel);
            // 
            // backgroundIntelSound
            // 
            this.backgroundIntelSound.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundIntelSound_DoWork);
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // systemDataGridViewTextBoxColumn
            // 
            this.systemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.systemDataGridViewTextBoxColumn.DataPropertyName = "SystemName";
            this.systemDataGridViewTextBoxColumn.HeaderText = "System";
            this.systemDataGridViewTextBoxColumn.Name = "systemDataGridViewTextBoxColumn";
            this.systemDataGridViewTextBoxColumn.ReadOnly = true;
            this.systemDataGridViewTextBoxColumn.Width = 66;
            // 
            // playersDataGridViewTextBoxColumn
            // 
            this.playersDataGridViewTextBoxColumn.DataPropertyName = "Players";
            this.playersDataGridViewTextBoxColumn.HeaderText = "Players";
            this.playersDataGridViewTextBoxColumn.Name = "playersDataGridViewTextBoxColumn";
            this.playersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageDataGridViewTextBoxColumn.Width = 75;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportedByDataGridViewTextBoxColumn
            // 
            this.reportedByDataGridViewTextBoxColumn.DataPropertyName = "ReportedBy";
            this.reportedByDataGridViewTextBoxColumn.HeaderText = "ReportedBy";
            this.reportedByDataGridViewTextBoxColumn.Name = "reportedByDataGridViewTextBoxColumn";
            this.reportedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clearDataGridViewCheckBoxColumn
            // 
            this.clearDataGridViewCheckBoxColumn.DataPropertyName = "Clear";
            this.clearDataGridViewCheckBoxColumn.HeaderText = "Clear";
            this.clearDataGridViewCheckBoxColumn.Name = "clearDataGridViewCheckBoxColumn";
            this.clearDataGridViewCheckBoxColumn.ReadOnly = true;
            this.clearDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // noVisualDataGridViewCheckBoxColumn
            // 
            this.noVisualDataGridViewCheckBoxColumn.DataPropertyName = "NoVisual";
            this.noVisualDataGridViewCheckBoxColumn.HeaderText = "NoVisual";
            this.noVisualDataGridViewCheckBoxColumn.Name = "noVisualDataGridViewCheckBoxColumn";
            this.noVisualDataGridViewCheckBoxColumn.ReadOnly = true;
            this.noVisualDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // channelDataGridViewTextBoxColumn
            // 
            this.channelDataGridViewTextBoxColumn.DataPropertyName = "Channel";
            this.channelDataGridViewTextBoxColumn.HeaderText = "Channel";
            this.channelDataGridViewTextBoxColumn.Name = "channelDataGridViewTextBoxColumn";
            this.channelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IntelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridIntel);
            this.Controls.Add(this.panelIntellHeader);
            this.Name = "IntelUI";
            this.Size = new System.Drawing.Size(545, 354);
            this.panelIntellHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIntel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIntellHeader;
        private System.Windows.Forms.Button buttonClearIntel;
        private System.Windows.Forms.Label labelPausingIntel;
        private System.Windows.Forms.Button buttonMonitorIntel;
        private System.Windows.Forms.DataGridView dataGridIntel;
        private System.ComponentModel.BackgroundWorker backgroundIntelSound;
        private System.Windows.Forms.BindingSource intelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clearDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn noVisualDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn channelDataGridViewTextBoxColumn;

    }
}
