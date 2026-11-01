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
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker4.Value.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker4.Value.ToLongDateString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker4.Value.ToShortTimeString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker4.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker4.Value.ToLongTimeString());

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker4.Text + Environment.NewLine;
            label1.Text += dateTimePicker4.Value.ToString("d/M//y") + Environment.NewLine;
            label1.Text += dateTimePicker4.Value.ToString("dd/MM/yy") + Environment.NewLine;
            label1.Text += dateTimePicker4.Value.ToString("ddd/MMM/yyy") + Environment.NewLine;
            label1.Text += dateTimePicker4.Value.ToString("dddd/MMMM/yyyy") + Environment.NewLine;

            /*
                d = 1
                dd = 01
                ddd = sun
                dddd = sunday

                M = 11
                MM = 11
                MMM = Nov
                MMMM = November

                y = 26
                yy = 26
                yyy = 2026
                yyyy = 2026
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
