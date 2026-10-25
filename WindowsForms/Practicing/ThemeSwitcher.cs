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
    public partial class ThemeSwitcher : Form
    {
        public ThemeSwitcher()
        {
            InitializeComponent();
        }


        private void rbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDark.Checked)
            {
                this.ForeColor = Color.White;
                this.BackColor = Color.Black;
            }
        }

        private void rbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLight.Checked)
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;
            }
        }

    }
}
