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
    public partial class LinkLabel_example : Form
    {
        public LinkLabel_example()
        {
            InitializeComponent();
        }

        private void LinkLabel_example_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Youtube");
            comboBox1.Items.Add("Facebook");
            comboBox1.Items.Add("Github");
            comboBox1.SelectedIndex = 0;

            comboBox1.ForeColor = Color.Black;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Youtube":
                    linkLabel1.Text = "https://www.youtube.com/";
                    comboBox1.ForeColor = Color.Red;
                    break;
                case "Facebook":
                    linkLabel1.Text = "https://www.facebook.com/";
                    comboBox1.ForeColor = Color.Blue;
                    break;
                case "Github":
                    linkLabel1.Text = "https://www.github.com/";
                    comboBox1.ForeColor = Color.Purple;
                    break;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
