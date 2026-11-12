
using Practicing.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practicing
{
    public partial class VolumeAndRGBController : Form
    {
        public VolumeAndRGBController()
        {
            InitializeComponent();
        }

        private void VolumeAndRGBController_Load(object sender, EventArgs e)
        {
            InitializeControls();
            Reset();
        }

        void InitializeControls()
        {
            // Volume
            tbVolume.Minimum = 0;
            tbVolume.Maximum = 100;
            tbVolume.SmallChange = 1;
            tbVolume.LargeChange = 20;

            // Red
            tbRed.Minimum = 0;
            tbRed.Maximum = 255;

            // Green
            tbGreen.Minimum = 0;
            tbGreen.Maximum = 255;

            // Blue
            tbBlue.Minimum = 0;
            tbBlue.Maximum = 255;

            //RGB Text
            txtColorRGB.ReadOnly = true;


            //Hexa Text
            txtColorHexa.ReadOnly = true;
        }

        void UpdateVolume()
        {
            lblVolume.Text = tbVolume.Value.ToString() + "%";

            if (tbVolume.Value > 70)
                pbVolume.Image = Resources.max;
            else if (tbVolume.Value >= 50)
                pbVolume.Image = Resources.mid;
            else if (tbVolume.Value > 0)
                pbVolume.Image = Resources.min;
            else
                pbVolume.Image = Resources.mute;
        }

        void UpdateColor()
        {
            lblRed.Text = tbRed.Value.ToString();
            lblGreen.Text = tbGreen.Value.ToString();
            lblBlue.Text = tbBlue.Value.ToString();

            pnlColorPreview.BackColor = Color.FromArgb(
                tbRed.Value,
                tbGreen.Value,
                tbBlue.Value
            );

            UpdateColorRGBText();
            UpdateColorHexaText();
        }

        void Reset()
        {
            tbVolume.Value = 50;
            prevValue = 50;

            tbRed.Value = 0;
            tbGreen.Value = 0;
            tbBlue.Value = 0;

            UpdateVolume();
            UpdateColor();
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            UpdateVolume();
        }

        private void tbRGB_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void UpdateColorRGBText()
        {
            txtColorRGB.Text = $"Color [A={255}, R={tbRed.Value}, G={tbGreen.Value}, B={tbBlue.Value}]";
        }

        void UpdateColorHexaText()
        {
            txtColorHexa.Text = $"#{tbRed.Value:X2}{tbGreen.Value:X2}{tbBlue.Value:X2}";
        }

        private void btnCopyHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtColorHexa.Text);
        }

        int prevValue = 50;
        private void pbVolume_Click(object sender, EventArgs e)
        {
            if (tbVolume.Value != 0)
            {
                prevValue = tbVolume.Value;
                tbVolume.Value = 0;
            }
            else
            {
                tbVolume.Value = prevValue;
            }
            UpdateVolume();
        }

        private Random random = new Random();

        void GenerateRandomColor()
        {
            tbRed.Value = random.Next(0, 256);
            tbGreen.Value = random.Next(0, 256);
            tbBlue.Value = random.Next(0, 256);

            UpdateColor();
        }

        private void btnRandomColor_Click(object sender, EventArgs e)
        {
            GenerateRandomColor();
        }
    }
}
