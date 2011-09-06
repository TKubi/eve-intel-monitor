namespace EVEIntelManager
{
    partial class LogReaderUI
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
            this.labelChannelLabel = new System.Windows.Forms.Label();
            this.monitorToggle = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.CheckedListBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.labelListenerLabel = new System.Windows.Forms.Label();
            this.labelChannel = new System.Windows.Forms.Label();
            this.labelListener = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelChannelLabel
            // 
            this.labelChannelLabel.AutoSize = true;
            this.labelChannelLabel.Location = new System.Drawing.Point(4, 11);
            this.labelChannelLabel.Name = "labelChannelLabel";
            this.labelChannelLabel.Size = new System.Drawing.Size(49, 13);
            this.labelChannelLabel.TabIndex = 16;
            this.labelChannelLabel.Text = "Channel:";
            // 
            // monitorToggle
            // 
            this.monitorToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monitorToggle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.monitorToggle.Location = new System.Drawing.Point(406, 6);
            this.monitorToggle.Name = "monitorToggle";
            this.monitorToggle.Size = new System.Drawing.Size(75, 23);
            this.monitorToggle.TabIndex = 10;
            this.monitorToggle.Text = "&Pause";
            this.monitorToggle.UseVisualStyleBackColor = true;
            this.monitorToggle.Click += new System.EventHandler(this.monitorToggle_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRemoveAll.Location = new System.Drawing.Point(7, 268);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(75, 24);
            this.buttonRemoveAll.TabIndex = 15;
            this.buttonRemoveAll.Text = "Clear";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // eventList
            // 
            this.eventList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.eventList.BackColor = System.Drawing.SystemColors.Window;
            this.eventList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.eventList.FormattingEnabled = true;
            this.eventList.Location = new System.Drawing.Point(7, 31);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(474, 229);
            this.eventList.TabIndex = 9;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRefresh.Location = new System.Drawing.Point(406, 268);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 24);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRemove.Location = new System.Drawing.Point(88, 268);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 24);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 5000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // refreshBackgroundWorker
            // 
            this.refreshBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.refreshBackgroundWorker_DoWork);
            // 
            // labelListenerLabel
            // 
            this.labelListenerLabel.AutoSize = true;
            this.labelListenerLabel.Location = new System.Drawing.Point(157, 11);
            this.labelListenerLabel.Name = "labelListenerLabel";
            this.labelListenerLabel.Size = new System.Drawing.Size(47, 13);
            this.labelListenerLabel.TabIndex = 17;
            this.labelListenerLabel.Text = "Listener:";
            // 
            // labelChannel
            // 
            this.labelChannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(59, 11);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(53, 13);
            this.labelChannel.TabIndex = 18;
            this.labelChannel.Text = "Unknown";
            // 
            // labelListener
            // 
            this.labelListener.AutoSize = true;
            this.labelListener.Location = new System.Drawing.Point(210, 11);
            this.labelListener.Name = "labelListener";
            this.labelListener.Size = new System.Drawing.Size(53, 13);
            this.labelListener.TabIndex = 19;
            this.labelListener.Text = "Unknown";
            // 
            // LogReaderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.monitorToggle);
            this.Controls.Add(this.labelListenerLabel);
            this.Controls.Add(this.labelListener);
            this.Controls.Add(this.labelChannel);
            this.Controls.Add(this.labelChannelLabel);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonRemove);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LogReaderUI";
            this.Size = new System.Drawing.Size(484, 295);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChannelLabel;
        private System.Windows.Forms.Button monitorToggle;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.CheckedListBox eventList;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Timer refreshTimer;
        private System.ComponentModel.BackgroundWorker refreshBackgroundWorker;
        private System.Windows.Forms.Label labelListenerLabel;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label labelListener;
    }
}
