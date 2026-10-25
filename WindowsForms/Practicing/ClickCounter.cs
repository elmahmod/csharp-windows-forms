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
    public partial class ClickCounter : Form
    {
        private int counter = 0;
        public ClickCounter()
        {
            InitializeComponent();
        }

        private void ClickCounter_Load(object sender, EventArgs e)
        {
            lblCounter.Text = counter.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            counter++;
            lblCounter.Text = counter.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                MessageBox.Show(
                    "Counter cannot be less than zero.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                ); return;
            }
            counter--;
            lblCounter.Text = counter.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            counter = 0;
            lblCounter.Text = counter.ToString();
        }
    }
}
