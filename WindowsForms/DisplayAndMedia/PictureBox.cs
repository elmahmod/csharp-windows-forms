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
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Computer;
            //lblTitle.Text = "Computer";
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Laptop;
            //lblTitle.Text = "Laptop";
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Phone;
            //lblTitle.Text = "Phone";
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void PictureBox_Load(object sender, EventArgs e)
        {

        }
    }
}
