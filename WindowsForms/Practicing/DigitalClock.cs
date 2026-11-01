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
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        void UpdateTime()
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            updateEverySecond.Interval = 1000;
            UpdateTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateEverySecond.Enabled = true;
            //updateEverySecond.Start();
            UpdateTime();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //updateEverySecond.Stop();
            updateEverySecond.Enabled = false;
        }

        private void updateEverySecond_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
    }
}
