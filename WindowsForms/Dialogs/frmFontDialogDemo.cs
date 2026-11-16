using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class frmFontDialogDemo : Form
    {
        public frmFontDialogDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog2.Font = textBox1.Font;
            fontDialog2.Color = textBox1.ForeColor;

            if (fontDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog2.Font;
                textBox1.ForeColor = fontDialog2.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog3.Font = textBox1.Font;
            fontDialog3.Color = textBox1.ForeColor;

            if (fontDialog3.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog3.Font;
                textBox1.ForeColor = fontDialog3.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fontDialog4.Font = textBox1.Font;
            fontDialog4.Color = textBox1.ForeColor;

            if (fontDialog4.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog4.Font;
                textBox1.ForeColor = fontDialog4.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            FontDialog font = (FontDialog)sender;

            textBox1.Font = font.Font;
            textBox1.ForeColor = font.Color;
        }
    }
}
