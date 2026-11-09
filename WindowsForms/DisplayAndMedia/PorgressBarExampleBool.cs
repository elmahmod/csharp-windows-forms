
using System;
using System.Windows.Forms;

namespace DisplayAndMedia
{
    public partial class PorgressBarExampleBool : Form
    {
        private bool isPaused = false;

        public PorgressBarExampleBool()
        {
            InitializeComponent();
        }

        private void PorgressBarExample_Load(object sender, EventArgs e)
        {
            InitializeTimer();
            Reset();
        }

        // ========================================
        // Initialize Timer
        // ========================================

        void InitializeTimer()
        {
            timerBar.Interval = 1000;
            timerBar.Stop();
        }

        // ========================================
        // Update Percentage
        // ========================================

        void UpdatePercentage()
        {
            float percentage = (float)progressBar1.Value
                               / progressBar1.Maximum * 100;

            lblPercentage.Text = percentage.ToString("0") + "%";
        }

        // ========================================
        // Reset
        // ========================================

        void Reset()
        {
            timerBar.Stop();

            progressBar1.Value = 0;
            UpdatePercentage();

            isPaused = false;

            lblStatus.Text = "Ready";

            btnPause.Text = "Pause";
            btnPause.Enabled = false;
        }

        // ========================================
        // Start
        // ========================================

        private void btnStart_Click(object sender, EventArgs e)
        {
            Reset();

            timerBar.Start();

            lblStatus.Text = "Downloading...";
            btnPause.Enabled = true;
        }

        // ========================================
        // Timer Tick
        // ========================================

        private void timerBar_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value = Math.Min(
                    progressBar1.Value + 10,
                    progressBar1.Maximum
                );

                UpdatePercentage();
            }

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timerBar.Stop();

                lblStatus.Text = "Completed!";
                btnPause.Enabled = false;
            }
        }

        // ========================================
        // Pause / Resume
        // ========================================

        void UpdateStatus()
        {
            if (!isPaused)
            {
                timerBar.Stop();

                isPaused = true;

                btnPause.Text = "Resume";
                lblStatus.Text = "Paused";
            }
            else
            {
                timerBar.Start();

                isPaused = false;

                btnPause.Text = "Pause";
                lblStatus.Text = "Downloading...";
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        // ========================================
        // Reset Button
        // ========================================

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
