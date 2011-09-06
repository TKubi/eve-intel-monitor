namespace EVEIntelManager
{
    partial class PromptWindow
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
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttobnCancel = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 37);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(82, 13);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "This is message";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Location = new System.Drawing.Point(286, 142);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "&Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttobnCancel
            // 
            this.buttobnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttobnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttobnCancel.Location = new System.Drawing.Point(367, 142);
            this.buttobnCancel.Name = "buttobnCancel";
            this.buttobnCancel.Size = new System.Drawing.Size(75, 23);
            this.buttobnCancel.TabIndex = 2;
            this.buttobnCancel.Text = "&Cancel";
            this.buttobnCancel.UseVisualStyleBackColor = true;
            // 
            // textInput
            // 
            this.textInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textInput.Location = new System.Drawing.Point(5, 118);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(437, 20);
            this.textInput.TabIndex = 3;
            // 
            // labelError
            // 
            this.labelError.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(0, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(453, 13);
            this.labelError.TabIndex = 4;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PromptWindow
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttobnCancel;
            this.ClientSize = new System.Drawing.Size(453, 168);
            this.ControlBox = false;
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.buttobnCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.labelMessage);
            this.Name = "PromptWindow";
            this.Text = "Prompt Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttobnCancel;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label labelError;
    }
}