using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basics
{
    public partial class part6 : Form
    {
        public part6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkDisableButton.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //    button1.Enabled = false;
            //else
            //    button1.Enabled = true;

            button1.Enabled = !chkDisableButton.Checked;
        }

        private void chkBackground_CheckedChanged(object sender, EventArgs e)
        {
            // Change button background and text colors
            if (chkBackground.Checked)
            {
                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton1.Checked.ToString());
        }
    }
}