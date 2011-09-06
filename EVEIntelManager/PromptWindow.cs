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

        public PromptWindow()
        {
            InitializeComponent();
            validator = NumericInputValidator;
        }

        public InputValidator Validator
        {
            set { this.validator = value; }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            string value = textInput.Text;
            if (!validator(value))
            {
                labelError.Text = "Invalid value, please try again";
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

        public static string Show(IWin32Window parent, string title, string message, double defaultValue, InputValidator validator)
        {
            PromptWindow window = new PromptWindow();
            window.Text = title;
            window.labelMessage.Text = message;
            window.textInput.Text = defaultValue.ToString();

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
    }
}
