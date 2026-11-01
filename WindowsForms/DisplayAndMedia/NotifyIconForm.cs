using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayAndMedia
{
    public partial class NotifyIconForm : Form
    {
        public NotifyIconForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;

            notifyIcon1.BalloonTipTitle = "Hello!";
            notifyIcon1.BalloonTipText = "This is a test";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {
            this.Text = "Notification Shown";
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Text = "Notification Clicked";
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            this.Text = "Notification Closed";
        }
    }
}
