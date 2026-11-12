using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainersAndMenus
{
    public partial class TabControl : Form
    {
        public TabControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabPages.Count - 1)
            {
                tabControl1.SelectedIndex++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex--;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        void UpdateButtons()
        {
            foreach (Control c in tabControl1.SelectedTab.Controls)
            {
                if (c is Button btn)
                {
                    if (btn.Text == "prev")
                        btn.Enabled = tabControl1.SelectedIndex > 0;

                    else if (btn.Text == "next")
                        btn.Enabled = tabControl1.SelectedIndex <
                            tabControl1.TabPages.Count - 1;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void TabControl_Load(object sender, EventArgs e)
        {
            UpdateButtons();
        }

    }
}
