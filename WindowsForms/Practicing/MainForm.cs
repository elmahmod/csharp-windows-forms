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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = this.Tag.ToString();
        }

        private void btnShowClickForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form clickCounter = new ClickCounter();
            clickCounter.ShowDialog();
            this.Show();
        }

        private void btnShowCountForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form countCharacters = new CountCharacters();
            countCharacters.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form themeSwitcher = new ThemeSwitcher();
            themeSwitcher.ShowDialog();
            this.Show();
        }
    }
}
