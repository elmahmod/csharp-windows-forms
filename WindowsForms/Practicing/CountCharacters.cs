using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicing
{
    public partial class CountCharacters : Form
    {
        public CountCharacters()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblCharacters.Text = txtInput.Text.Length.ToString();

            int spaces = 0;
            int letters = 0;
            int digits = 0;

            foreach (char c in txtInput.Text)
            {
                if (char.IsLetter(c))
                    letters++;
                if (c == ' ')
                    spaces++;
                if (char.IsDigit(c))
                    digits++;
            }

            lblLetters.Text = letters.ToString();
            lblSpaces.Text = spaces.ToString();
            lblDigits.Text = digits.ToString();
        }
    }
}
