namespace EVEIntelManager
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingsUI = new EVEIntelManager.SettingsUI();
            this.SuspendLayout();
            // 
            // settingsUI
            // 
            this.settingsUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsUI.Location = new System.Drawing.Point(0, 0);
            this.settingsUI.Name = "settingsUI";
            this.settingsUI.Size = new System.Drawing.Size(601, 407);
            this.settingsUI.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 407);
            this.Controls.Add(this.settingsUI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "EVE Intel Monitor Settings";
            this.Activated += new System.EventHandler(this.SettingsForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private SettingsUI settingsUI;
    }
}