using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EVEIntelManager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            settingsUI.CloseWindowRequested += delegate { CloseWindow(); };
            this.CancelButton = settingsUI.ButtonCancel;
            this.AcceptButton = settingsUI.ButtonOK;
        }

        private void CloseWindow()
        {
            this.Close();
        }

        public void ReadProperties()
        {
            settingsUI.ReadProperties();
        }

        private void SettingsForm_Activated(object sender, EventArgs e)
        {
            settingsUI.ActivatedUI();
        }
    }
}
