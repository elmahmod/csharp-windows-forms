using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            InitializeStartValues();
        }

        void InitializeStartValues()
        {
            rbSmall.Checked = true;
            rbThin.Checked = true;
            rbEatIn.Checked = true;
            lblToppingsValue.Text = "No Toppings";

            btnReOrder.Enabled = false;

            UpdateOrderSummary();
        }

        private float GetSelectedSizePricing()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);

            if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);

            if (rbLarge.Checked)
                return Convert.ToSingle(rbLarge.Tag);

            // Default value if none are checked
            return 0f;
        }

        private float GetSelectedCrustPricing()
        {
            if (rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);

            if (rbThick.Checked)
                return Convert.ToSingle(rbThick.Tag);

            // Default value if none are checked
            return 0f;
        }

        private float GetSelectedToppingsPricing()
        {
            float totalToppingsPrice = 0;

            if (chkExtraCheese.Checked)
                totalToppingsPrice += Convert.ToSingle(chkExtraCheese.Tag);

            if (chkGreenPeppers.Checked)
                totalToppingsPrice += Convert.ToSingle(chkGreenPeppers.Tag);

            if (chkMushrooms.Checked)
                totalToppingsPrice += Convert.ToSingle(chkMushrooms.Tag);

            if (chkOlives.Checked)
                totalToppingsPrice += Convert.ToSingle(chkOlives.Tag);

            if (chkOnion.Checked)
                totalToppingsPrice += Convert.ToSingle(chkOnion.Tag);

            if (chkTomatoes.Checked)
                totalToppingsPrice += Convert.ToSingle(chkTomatoes.Tag);

            return totalToppingsPrice;
        }

        private float CalculateTotalPrice()
        {
            return GetSelectedSizePricing() + GetSelectedCrustPricing() + GetSelectedToppingsPricing();
        }

        void UpdateTotalPrice()
        {
            lblTotalPriceValue.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
                lblSizeValue.Text = rbSmall.Text;

            if (rbMedium.Checked)
                lblSizeValue.Text = rbMedium.Text;

            if (rbLarge.Checked)
                lblSizeValue.Text = rbLarge.Text;
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
                lblCrustTypeValue.Text = rbThin.Text;

            if (rbThick.Checked)
                lblCrustTypeValue.Text = rbThick.Text;
        }

        void UpdateWhereToEat()
        {

            if (rbEatIn.Checked)
                lblWhereToEatValue.Text = rbEatIn.Text;

            if (rbTakeOut.Checked)
                lblWhereToEatValue.Text = rbTakeOut.Text;
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string toppings = "";
            if (chkExtraCheese.Checked)
                toppings += ", " + chkExtraCheese.Text;

            if (chkGreenPeppers.Checked)
                toppings += ", " + chkGreenPeppers.Text;

            if (chkMushrooms.Checked)
                toppings += ", " + chkMushrooms.Text;

            if (chkOlives.Checked)
                toppings += ", " + chkOlives.Text;

            if (chkTomatoes.Checked)
                toppings += ", " + chkTomatoes.Text;

            if (chkOnion.Checked)
                toppings += ", " + chkOnion.Text;

            if (toppings == "")
                lblToppingsValue.Text = "No Toppings";
            else
                lblToppingsValue.Text = toppings.TrimStart(',', ' ');
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order",
                "Confirm",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Order placed successfully",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                grpCrustType.Enabled = false;
                grpSize.Enabled = false;
                grpToppings.Enabled = false;
                grpWhereToEat.Enabled = false;

                btnOrderPizza.Enabled = false;
                btnResetForm.Enabled = false;
                btnReOrder.Enabled = true;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpToppings.Controls)
            {
                if (c is CheckBox chk)
                    chk.Checked = false;
            }

            rbSmall.Checked = true;
            rbThin.Checked = true;
            rbEatIn.Checked = true;
        }

        private void btnReOrder_Click(object sender, EventArgs e)
        {
            btnResetForm_Click(sender, e);

            btnReOrder.Enabled = false;

            grpCrustType.Enabled = true;
            grpSize.Enabled = true;
            grpToppings.Enabled = true;
            grpWhereToEat.Enabled = true;

            btnOrderPizza.Enabled = true;
            btnResetForm.Enabled = true;
        }
    }
}
