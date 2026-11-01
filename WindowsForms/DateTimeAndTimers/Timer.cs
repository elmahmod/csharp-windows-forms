using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeAndTimers
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }
        private int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
