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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowPart2_Click(object sender, EventArgs e)
        {
            Form part2 = new part2();
            part2.Show();
        }

        private void btnShowPart3_Click(object sender, EventArgs e)
        {
            Form part3 = new part3();
            part3.Show();
        }

        private void btnShowPart4_Click(object sender, EventArgs e)
        {
            Form part4 = new part4();
            part4.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPart5_Click(object sender, EventArgs e)
        {
            Form part5 = new part5();
            part5.ShowDialog();
        }

        private void btnShowPart6_Click(object sender, EventArgs e)
        {
            Form part6 = new part6();
            part6.ShowDialog();
        }
    }
}
