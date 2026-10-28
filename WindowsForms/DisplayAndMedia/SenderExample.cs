using DisplayAndMedia.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayAndMedia
{
    public partial class SenderExample : Form
    {
        public SenderExample()
        {
            InitializeComponent();
        }

        private void SenderExample_Load(object sender, EventArgs e)
        {
            rbDrakMode.Checked = true;
            pbSwitcher.Image = Resources.Dark;
        }

        private void rbTheme_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (!rb.Checked)
                return;

            pbSwitcher.Image = (Image)Resources.ResourceManager.GetObject(rb.Tag.ToString());

            this.Text = rb.Text.ToString();

            if (rb.Tag.ToString() == "Dark")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }
    }
}
