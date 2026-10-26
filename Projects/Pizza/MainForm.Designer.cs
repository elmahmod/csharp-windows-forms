namespace Pizza
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaOrder));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.grpCrustType = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.grpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblWhereToEatValue = new System.Windows.Forms.Label();
            this.lblCrustTypeValue = new System.Windows.Forms.Label();
            this.lblToppingsValue = new System.Windows.Forms.Label();
            this.lblSizeValue = new System.Windows.Forms.Label();
            this.lblTotalPriceTitle = new System.Windows.Forms.Label();
            this.lblWhereToEatTitle = new System.Windows.Forms.Label();
            this.lblCrustTypeTitle = new System.Windows.Forms.Label();
            this.lblToppingsTitle = new System.Windows.Forms.Label();
            this.lblSizeTitle = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnReOrder = new System.Windows.Forms.Button();
            this.grpSize.SuspendLayout();
            this.grpCrustType.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpWhereToEat.SuspendLayout();
            this.grpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(305, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(642, 81);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MAKE YOUR PIZZA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseMnemonic = false;
            this.lblTitle.UseWaitCursor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rbLarge);
            this.grpSize.Controls.Add(this.rbMedium);
            this.grpSize.Controls.Add(this.rbSmall);
            this.grpSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(62, 196);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(192, 192);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(50, 136);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(75, 24);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "10";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(50, 88);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(90, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "8";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(50, 40);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(73, 24);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "5";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // grpCrustType
            // 
            this.grpCrustType.Controls.Add(this.rbThick);
            this.grpCrustType.Controls.Add(this.rbThin);
            this.grpCrustType.Location = new System.Drawing.Point(62, 460);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(192, 149);
            this.grpCrustType.TabIndex = 2;
            this.grpCrustType.TabStop = false;
            this.grpCrustType.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(50, 106);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(71, 24);
            this.rbThick.TabIndex = 1;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "3";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(50, 53);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(64, 24);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkGreenPeppers);
            this.grpToppings.Controls.Add(this.chkOlives);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkTomatoes);
            this.grpToppings.Controls.Add(this.chkMushrooms);
            this.grpToppings.Controls.Add(this.chkExtraCheese);
            this.grpToppings.Location = new System.Drawing.Point(337, 196);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(325, 192);
            this.grpToppings.TabIndex = 3;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(163, 143);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(143, 24);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "1";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(163, 94);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(77, 24);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "1";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(163, 45);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(77, 24);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "1";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(15, 145);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(106, 24);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "1";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(15, 95);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(118, 24);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "1";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(15, 45);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(122, 24);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "2";
            this.chkExtraCheese.Text = "Extra Chees";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // grpWhereToEat
            // 
            this.grpWhereToEat.Controls.Add(this.rbTakeOut);
            this.grpWhereToEat.Controls.Add(this.rbEatIn);
            this.grpWhereToEat.Location = new System.Drawing.Point(337, 460);
            this.grpWhereToEat.Name = "grpWhereToEat";
            this.grpWhereToEat.Size = new System.Drawing.Size(192, 149);
            this.grpWhereToEat.TabIndex = 4;
            this.grpWhereToEat.TabStop = false;
            this.grpWhereToEat.Text = "Where to eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(6, 103);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(96, 24);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Tag = "0";
            this.rbTakeOut.Text = "Take out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(6, 54);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(75, 24);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "0";
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.Controls.Add(this.lblTotalPriceValue);
            this.grpOrderSummary.Controls.Add(this.lblWhereToEatValue);
            this.grpOrderSummary.Controls.Add(this.lblCrustTypeValue);
            this.grpOrderSummary.Controls.Add(this.lblToppingsValue);
            this.grpOrderSummary.Controls.Add(this.lblSizeValue);
            this.grpOrderSummary.Controls.Add(this.lblTotalPriceTitle);
            this.grpOrderSummary.Controls.Add(this.lblWhereToEatTitle);
            this.grpOrderSummary.Controls.Add(this.lblCrustTypeTitle);
            this.grpOrderSummary.Controls.Add(this.lblToppingsTitle);
            this.grpOrderSummary.Controls.Add(this.lblSizeTitle);
            this.grpOrderSummary.Location = new System.Drawing.Point(745, 196);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(421, 527);
            this.grpOrderSummary.TabIndex = 5;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPriceValue.Location = new System.Drawing.Point(160, 382);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(208, 43);
            this.lblTotalPriceValue.TabIndex = 17;
            this.lblTotalPriceValue.Text = "lblTotalPrice";
            // 
            // lblWhereToEatValue
            // 
            this.lblWhereToEatValue.AutoSize = true;
            this.lblWhereToEatValue.Location = new System.Drawing.Point(160, 316);
            this.lblWhereToEatValue.Name = "lblWhereToEatValue";
            this.lblWhereToEatValue.Size = new System.Drawing.Size(128, 20);
            this.lblWhereToEatValue.TabIndex = 16;
            this.lblWhereToEatValue.Text = "LBLWhereToEat";
            // 
            // lblCrustTypeValue
            // 
            this.lblCrustTypeValue.AutoSize = true;
            this.lblCrustTypeValue.Location = new System.Drawing.Point(153, 264);
            this.lblCrustTypeValue.Name = "lblCrustTypeValue";
            this.lblCrustTypeValue.Size = new System.Drawing.Size(96, 20);
            this.lblCrustTypeValue.TabIndex = 15;
            this.lblCrustTypeValue.Text = "lblCrustType";
            // 
            // lblToppingsValue
            // 
            this.lblToppingsValue.Location = new System.Drawing.Point(160, 126);
            this.lblToppingsValue.Name = "lblToppingsValue";
            this.lblToppingsValue.Size = new System.Drawing.Size(229, 114);
            this.lblToppingsValue.TabIndex = 14;
            this.lblToppingsValue.Text = "lblToppings";
            // 
            // lblSizeValue
            // 
            this.lblSizeValue.AutoSize = true;
            this.lblSizeValue.Location = new System.Drawing.Point(160, 78);
            this.lblSizeValue.Name = "lblSizeValue";
            this.lblSizeValue.Size = new System.Drawing.Size(55, 20);
            this.lblSizeValue.TabIndex = 13;
            this.lblSizeValue.Text = "lblSize";
            // 
            // lblTotalPriceTitle
            // 
            this.lblTotalPriceTitle.AutoSize = true;
            this.lblTotalPriceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceTitle.Location = new System.Drawing.Point(20, 393);
            this.lblTotalPriceTitle.Name = "lblTotalPriceTitle";
            this.lblTotalPriceTitle.Size = new System.Drawing.Size(94, 20);
            this.lblTotalPriceTitle.TabIndex = 12;
            this.lblTotalPriceTitle.Text = "Total Price";
            // 
            // lblWhereToEatTitle
            // 
            this.lblWhereToEatTitle.AutoSize = true;
            this.lblWhereToEatTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEatTitle.Location = new System.Drawing.Point(20, 316);
            this.lblWhereToEatTitle.Name = "lblWhereToEatTitle";
            this.lblWhereToEatTitle.Size = new System.Drawing.Size(113, 20);
            this.lblWhereToEatTitle.TabIndex = 11;
            this.lblWhereToEatTitle.Text = "Where to eat";
            // 
            // lblCrustTypeTitle
            // 
            this.lblCrustTypeTitle.AutoSize = true;
            this.lblCrustTypeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustTypeTitle.Location = new System.Drawing.Point(20, 264);
            this.lblCrustTypeTitle.Name = "lblCrustTypeTitle";
            this.lblCrustTypeTitle.Size = new System.Drawing.Size(95, 20);
            this.lblCrustTypeTitle.TabIndex = 10;
            this.lblCrustTypeTitle.Text = "Crust Type";
            // 
            // lblToppingsTitle
            // 
            this.lblToppingsTitle.AutoSize = true;
            this.lblToppingsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsTitle.Location = new System.Drawing.Point(20, 126);
            this.lblToppingsTitle.Name = "lblToppingsTitle";
            this.lblToppingsTitle.Size = new System.Drawing.Size(82, 20);
            this.lblToppingsTitle.TabIndex = 9;
            this.lblToppingsTitle.Text = "Toppings";
            // 
            // lblSizeTitle
            // 
            this.lblSizeTitle.AutoSize = true;
            this.lblSizeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeTitle.Location = new System.Drawing.Point(20, 78);
            this.lblSizeTitle.Name = "lblSizeTitle";
            this.lblSizeTitle.Size = new System.Drawing.Size(44, 20);
            this.lblSizeTitle.TabIndex = 8;
            this.lblSizeTitle.Text = "Size";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(237, 695);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(140, 73);
            this.btnOrderPizza.TabIndex = 0;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResetForm.Location = new System.Drawing.Point(1022, 744);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(112, 53);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.TabStop = false;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnReOrder
            // 
            this.btnReOrder.Location = new System.Drawing.Point(460, 695);
            this.btnReOrder.Name = "btnReOrder";
            this.btnReOrder.Size = new System.Drawing.Size(140, 73);
            this.btnReOrder.TabIndex = 7;
            this.btnReOrder.Text = "Re Order Pizza";
            this.btnReOrder.UseVisualStyleBackColor = true;
            this.btnReOrder.Click += new System.EventHandler(this.btnReOrder_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1228, 834);
            this.Controls.Add(this.btnReOrder);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.grpOrderSummary);
            this.Controls.Add(this.grpWhereToEat);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpCrustType);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPizzaOrder";
            this.Text = "6";
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpWhereToEat.ResumeLayout(false);
            this.grpWhereToEat.PerformLayout();
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.GroupBox grpCrustType;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.GroupBox grpWhereToEat;
        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label lblToppingsTitle;
        private System.Windows.Forms.Label lblSizeTitle;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Label lblWhereToEatValue;
        private System.Windows.Forms.Label lblCrustTypeValue;
        private System.Windows.Forms.Label lblToppingsValue;
        private System.Windows.Forms.Label lblSizeValue;
        private System.Windows.Forms.Label lblTotalPriceTitle;
        private System.Windows.Forms.Label lblWhereToEatTitle;
        private System.Windows.Forms.Label lblCrustTypeTitle;
        private System.Windows.Forms.Button btnReOrder;
    }
}

