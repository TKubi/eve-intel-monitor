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
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttobnCancel = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Location = new System.Drawing.Point(329, 169);
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
            this.buttobnCancel.Location = new System.Drawing.Point(409, 169);
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
            this.textInput.Location = new System.Drawing.Point(8, 171);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(315, 20);
            this.textInput.TabIndex = 3;
            // 
            // textMessage
            // 
            this.textMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textMessage.Location = new System.Drawing.Point(8, 12);
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.Size = new System.Drawing.Size(476, 153);
            this.textMessage.TabIndex = 4;
            this.textMessage.Text = "";
            // 
            // PromptWindow
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttobnCancel;
            this.ClientSize = new System.Drawing.Size(493, 201);
            this.ControlBox = false;
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.buttobnCancel);
            this.Controls.Add(this.buttonAccept);
            this.Name = "PromptWindow";
            this.Text = "Prompt Window";
            this.Shown += new System.EventHandler(this.PromptWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttobnCancel;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.RichTextBox textMessage;
    }
}