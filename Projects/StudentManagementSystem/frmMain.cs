using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // exit
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuViewStudents_Click(object sender, EventArgs e)
        {

        }
    }
}
