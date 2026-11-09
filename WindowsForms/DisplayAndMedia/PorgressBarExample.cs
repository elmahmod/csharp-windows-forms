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
    public partial class PorgressBarExample : Form
    {
        public PorgressBarExample()
        {
            InitializeComponent();
        }

        private void PorgressBarExample_Load(object sender, EventArgs e)
        {
            InitializeTimer();
            Reset();
        }

        void InitializeTimer()
        {
            timerBar.Interval = 1000;
            timerBar.Stop();
        }

        void UpdatePrecentage()
        {
            lblPercentage.Text = ((float)progressBar1.Value / progressBar1.Maximum * 100).ToString() + "%";
        }

        void Reset()
        {
            lblStatus.Text = "Ready";

            progressBar1.Value = 0;

            UpdatePrecentage();

            timerBar.Stop();

            btnPause.Tag = "Pause";
            btnPause.Text = "Pause";
            btnPause.Enabled = false;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            Reset();

            timerBar.Start();

            lblStatus.Text = "Downloading...";
            btnPause.Enabled = true;
        }

        private void timerBar_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
                UpdatePrecentage();
            }

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timerBar.Stop();
                lblStatus.Text = "Completed!";
                btnPause.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void UpdateStatus(Button btn)
        {
            if (btn.Tag.ToString() == "Pause")
            {
                timerBar.Stop();
                btn.Tag = "Resume"; // next step
                lblStatus.Text = "Paused";
            }
            else
            {
                timerBar.Start();
                btn.Tag = "Pause"; // next step
                lblStatus.Text = "Downloading...";
            }

            btn.Text = btn.Tag.ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            UpdateStatus((Button)sender);
        }
    }
}
