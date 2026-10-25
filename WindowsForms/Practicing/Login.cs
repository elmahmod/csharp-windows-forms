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
    public partial class Login : Form
    {
        private string adminName = "Admin";
        private string password = "22";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == adminName && txtPassword.Text == password)
            {
                this.Hide();

                Form mainForm = new MainForm();
                mainForm.Tag = adminName;
                mainForm.ShowDialog();

                this.Show();
            }
            else
            {
                txtPassword.Clear();
                txtPassword.Focus();
                
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
