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
    public partial class PromptWindow : Form
    {
        public delegate bool InputValidator(string input);

        private InputValidator validator;
        private string message;

        public PromptWindow()
        {
            InitializeComponent();
            validator = NumericInputValidator;
        }

        public InputValidator Validator
        {
            set { this.validator = value; }
        }

        public string Message
        {
            get { return message; }
            set { 
                this.message = value;
                textMessage.Rtf = message;
            }
        }


        private void buttonAccept_Click(object sender, EventArgs e)
        {
            string value = textInput.Text;
            if (!validator(value))
            {
                textMessage.Text = "Invalid value, please try again.";
                textMessage.ForeColor = Color.DarkRed;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        public bool NumericInputValidator(string input)
        {
            int value;
            return int.TryParse(input, out value);
        }

        public static string Show(IWin32Window parent, string title, string message, string defaultValue, InputValidator validator)
        {
            PromptWindow window = new PromptWindow();
            window.Text = title;
            window.Message = message;
            window.textInput.Text = defaultValue;
            window.Validator = validator;
           
            DialogResult result = window.ShowDialog(parent);
            if (result == DialogResult.OK)
            {
                return window.textInput.Text;
            }
            else
            {
                return null;
            }
        }

        private void PromptWindow_Shown(object sender, EventArgs e)
        {
            textInput.Focus();
        }
    }
}
