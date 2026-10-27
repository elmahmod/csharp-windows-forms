using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public partial class frmPCBuilder : Form
    {
        public frmPCBuilder()
        {
            InitializeComponent();
        }

        private void frmPCBuilder_Load(object sender, EventArgs e)
        {
            InitializeStartup();
        }

        void InitializeStartup()
        {
            rb8GB.Checked = true;
            rb256GB.Checked = true;
            rbIntelCoreI3.Checked = true;
            btnReOrder.Enabled = false;

            UpdateOrderSummary();
        }


        void UpdateOrderSummary()
        {
            UpdateProcessor();
            UpdateRAM();
            UpdateStorage();
            UpdateExtras();
            UpdateTotalPricing();
        }


        float GetSelectedProcessorPricing()
        {
            if (rbIntelCoreI3.Checked)
                return Convert.ToSingle(rbIntelCoreI3.Tag);

            if (rbIntelCoreI5.Checked)
                return Convert.ToSingle(rbIntelCoreI5.Tag);

            if (rbIntelCoreI7.Checked)
                return Convert.ToSingle(rbIntelCoreI7.Tag);

            return 0f;
        }

        float GetSelectedRAMPricing()
        {
            if (rb8GB.Checked)
                return Convert.ToSingle(rb8GB.Tag);

            if (rb16GB.Checked)
                return Convert.ToSingle(rb16GB.Tag);

            if (rb32GB.Checked)
                return Convert.ToSingle(rb32GB.Tag);


            return 0f;
        }

        float GetSelectedStoragePricing()
        {
            if (rb256GB.Checked)
                return Convert.ToSingle(rb256GB.Tag);

            if (rb512GB.Checked)
                return Convert.ToSingle(rb512GB.Tag);

            if (rb1TB.Checked)
                return Convert.ToSingle(rb1TB.Tag);

            return 0f;
        }

        float GetSelectedExtrasPricing()
        {
            float totalExtrasPrice = 0;

            if (chkRGBLighting.Checked)
                totalExtrasPrice += Convert.ToSingle(chkRGBLighting.Tag);

            if (chkWiFiCard.Checked)
                totalExtrasPrice += Convert.ToSingle(chkWiFiCard.Tag);

            if (chkWin11.Checked)
                totalExtrasPrice += Convert.ToSingle(chkWin11.Tag);

            return totalExtrasPrice;
        }

        float GetTotalPricing()
        {
            return GetSelectedProcessorPricing()
                + GetSelectedRAMPricing()
                + GetSelectedStoragePricing()
                + GetSelectedExtrasPricing();
        }

        void UpdateProcessor()
        {
            if (rbIntelCoreI3.Checked)
                lblProcessorValue.Text = rbIntelCoreI3.Text;

            if (rbIntelCoreI5.Checked)
                lblProcessorValue.Text = rbIntelCoreI5.Text;

            if (rbIntelCoreI7.Checked)
                lblProcessorValue.Text = rbIntelCoreI7.Text;
        }

        void UpdateRAM()
        {
            if (rb8GB.Checked)
                lblRAMValue.Text = rb8GB.Text;

            if (rb16GB.Checked)
                lblRAMValue.Text = rb16GB.Text;

            if (rb32GB.Checked)
                lblRAMValue.Text = rb32GB.Text;
        }

        void UpdateStorage()
        {
            if (rb256GB.Checked)
                lblStorageValue.Text = rb256GB.Text;

            if (rb512GB.Checked)
                lblStorageValue.Text = rb512GB.Text;

            if (rb1TB.Checked)
                lblStorageValue.Text = rb1TB.Text;
        }

        void UpdateExtras()
        {
            string extras = "";

            if (chkRGBLighting.Checked)
                extras += ", " + chkRGBLighting.Text;

            if (chkWiFiCard.Checked)
                extras += ", " + chkWiFiCard.Text;

            if (chkWin11.Checked)
                extras += ", " + chkWin11.Text;

            if (extras == "")
                extras = "No Extras";

            lblExtrasValue.Text = extras.TrimStart(',', ' ');

        }

        void UpdateTotalPricing()
        {
            lblTotalPrice.Text = "$" + GetTotalPricing().ToString();
        }

        private void rbIntelCoreI3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateProcessor();
        }

        private void rbIntelCoreI5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateProcessor();
        }

        private void rbIntelCoreI7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateProcessor();
        }

        private void rb256GB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateStorage();
        }

        private void rb512GB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateStorage();
        }

        private void rb1TB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateStorage();
        }

        private void rb8GB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateRAM();
        }

        private void rb16GB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateRAM();
        }

        private void rb32GB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateRAM();
        }

        private void chkRGBLighting_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateExtras();
        }

        private void chkWiFiCard_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateExtras();
        }

        private void chkWin11_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPricing();
            UpdateExtras();
        }

        private void btnOrderPC_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                btnReOrder.Enabled = true;

                btnOrderPC.Enabled = false;

                btnReset.Enabled = false;

                grpRAM.Enabled = false;
                grpStorage.Enabled = false;
                grpProcessor.Enabled = false;
                grpExtras.Enabled = false;
            }
        }

        void Reset()
        {
            rbIntelCoreI3.Checked = true;
            rb8GB.Checked = true;
            rb256GB.Checked = true;

            foreach (Control control in grpExtras.Controls)
            {
                if (control is CheckBox chk)
                {
                    chk.Checked = false;
                }
            }

            UpdateOrderSummary();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnReOrder_Click(object sender, EventArgs e)
        {
            Reset();
            btnOrderPC.Enabled = true;

            btnReOrder.Enabled = false;

            btnReset.Enabled = true;

            grpRAM.Enabled = true;
            grpStorage.Enabled = true;
            grpProcessor.Enabled = true;
            grpExtras.Enabled = true;
        }
    }
}