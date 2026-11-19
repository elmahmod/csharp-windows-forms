using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenSecondStop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum ClickPlay
        {
            Start,
            Stop
        }

        ClickPlay currentClick;

        Stopwatch stopwatch = new Stopwatch();

        double lastResult = 0.0;

        void UpdateLastResult()
        {
            if (lastResult == 0)
                lblLastResult.Text = $"Last Result [?]";
            else
                lblLastResult.Text = $"Last Result [{lastResult:F3}]";

        }

        bool IsWinner()
        {
            double difference = Math.Abs(lastResult - 10);
            return difference <= 0.100;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (currentClick == ClickPlay.Start)
            {

                stopwatch.Restart();
                tmrDisplay.Start();

                btnStartStop.Text = "stop";
                currentClick = ClickPlay.Stop;

                UpdateLastResult();
            }
            else if (currentClick == ClickPlay.Stop)
            {
                stopwatch.Stop();
                tmrDisplay.Stop();

                btnStartStop.Text = "start";
                currentClick = ClickPlay.Start;

                lastResult = stopwatch.Elapsed.TotalSeconds;
                lblTimer.Text = lastResult.ToString("F3");

                UpdateLastResult();

                if (IsWinner())
                {
                    pnlTimer.BackColor = Color.Green;
                    MessageBox.Show("You Win!");
                }
                else
                {
                    pnlTimer.BackColor = Color.Red;
                    MessageBox.Show("You Failed");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentClick = ClickPlay.Start;

            UpdateLastResult();
        }

        private void tmrDisplay_Tick(object sender, EventArgs e)
        {
            double seconds = stopwatch.Elapsed.TotalSeconds;
            lblTimer.Text = seconds.ToString("F3");
        }
    }
}
