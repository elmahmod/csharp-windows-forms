using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputControls
{
    public partial class NumericUpDownForm : Form
    {
        public NumericUpDownForm()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
        }

        private void NumericUpDownForm_Load(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
        }
    }
}
