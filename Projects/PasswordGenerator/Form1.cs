using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        void ResetSettings()
        {
            tbPasswordLength.Value = tbPasswordLength.Minimum;
            lblValue.Text = tbPasswordLength.Value.ToString();

            txtPassword.Clear();
            foreach (Control control in gbIncludes.Controls)
            {
                if (control is CheckBox chk)
                {
                    chk.Checked = false;
                }
            }
        }

        bool IsAnyCharacterTypeSelected()
        {
            foreach (Control control in gbIncludes.Controls)
            {
                if (control is CheckBox chk)
                {
                    if (chk.Checked)
                        return true;
                }
            }
            return false;
        }

        char GetLowerCaseCharacter()
        {
            return Convert.ToChar(random.Next('a', 'z' + 1));
        }

        char GetUppercaseCharacter()
        {
            return Convert.ToChar(random.Next('A', 'Z' + 1));

        }

        char GetNumbersCharacter()
        {
            return Convert.ToChar(random.Next('0', '9' + 1));

        }

        char GetSymbolCharacter()
        {
            return Convert.ToChar(random.Next('!', '/' + 1));

        }

        char GetPasswordCharacter()
        {
            string characters = "";
            if (chkLowercase.Checked)
                characters += GetLowerCaseCharacter();

            if (chkUppercase.Checked)
                characters += GetUppercaseCharacter();

            if (chkNumbers.Checked)
                characters += GetNumbersCharacter();

            if (chkSymbols.Checked)
                characters += GetSymbolCharacter();

            return characters[random.Next(characters.Length)];
        }

        string GeneratePassword()
        {
            string password = "";
            for (int i = 0; i < tbPasswordLength.Value; i++)
            {
                password += GetPasswordCharacter();
            }
            return password;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            if (!IsAnyCharacterTypeSelected())
            {
                MessageBox.Show("Please select at least one character type");
                chkLowercase.Focus();
                return;
            }
            txtPassword.Text = GeneratePassword();
        }

        private void btnCoppy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
                return;

            Clipboard.SetText(txtPassword.Text);
        }

        private void tbPasswordLength_Scroll(object sender, EventArgs e)
        {
            lblValue.Text = tbPasswordLength.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblValue.Text = tbPasswordLength.Value.ToString();
        }
    }
}
