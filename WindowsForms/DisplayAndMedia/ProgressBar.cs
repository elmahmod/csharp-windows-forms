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
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.Value += 10;
                    label1.Text = progressBar1.Value.ToString() + "%";
                }
                else
                {
                    break;
                }
            }
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;


            label1.Text = "0%";

            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 5;
                float preceentage = (float)progressBar1.Value / progressBar1.Maximum * 100;
                //label1.Text = progressBar1.Value.ToString() + "%";

                label1.Text = preceentage.ToString() + "%";

            }

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            label1.Text = "0%";
            progressBar1.Value = 0;
        }
    }
}
