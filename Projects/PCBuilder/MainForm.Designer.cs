namespace PCBuilder
{
    partial class frmPCBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPCBuilder));
            this.grpProcessor = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbIntelCoreI7 = new System.Windows.Forms.RadioButton();
            this.rbIntelCoreI5 = new System.Windows.Forms.RadioButton();
            this.rbIntelCoreI3 = new System.Windows.Forms.RadioButton();
            this.btnOrderPC = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReOrder = new System.Windows.Forms.Button();
            this.chkRGBLighting = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRAM = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rb32GB = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.rb16GB = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.rb8GB = new System.Windows.Forms.RadioButton();
            this.grpStorage = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rb1TB = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.rb512GB = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.rb256GB = new System.Windows.Forms.RadioButton();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkWin11 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chkWiFiCard = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblExtrasValue = new System.Windows.Forms.Label();
            this.lblStorageValue = new System.Windows.Forms.Label();
            this.lblRAMValue = new System.Windows.Forms.Label();
            this.lblProcessorValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpProcessor.SuspendLayout();
            this.grpRAM.SuspendLayout();
            this.grpStorage.SuspendLayout();
            this.grpExtras.SuspendLayout();
            this.grpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProcessor
            // 
            this.grpProcessor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpProcessor.Controls.Add(this.label13);
            this.grpProcessor.Controls.Add(this.label12);
            this.grpProcessor.Controls.Add(this.label11);
            this.grpProcessor.Controls.Add(this.rbIntelCoreI7);
            this.grpProcessor.Controls.Add(this.rbIntelCoreI5);
            this.grpProcessor.Controls.Add(this.rbIntelCoreI3);
            this.grpProcessor.Location = new System.Drawing.Point(44, 21);
            this.grpProcessor.Name = "grpProcessor";
            this.grpProcessor.Size = new System.Drawing.Size(255, 208);
            this.grpProcessor.TabIndex = 1;
            this.grpProcessor.TabStop = false;
            this.grpProcessor.Text = "Processor (CPU)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 5;
            this.label13.Tag = "60";
            this.label13.Text = "(+$60)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 4;
            this.label12.Tag = "40";
            this.label12.Text = "(+$40)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 3;
            this.label11.Tag = "20";
            this.label11.Text = "(+$20)";
            // 
            // rbIntelCoreI7
            // 
            this.rbIntelCoreI7.AutoSize = true;
            this.rbIntelCoreI7.Location = new System.Drawing.Point(17, 139);
            this.rbIntelCoreI7.Name = "rbIntelCoreI7";
            this.rbIntelCoreI7.Size = new System.Drawing.Size(119, 24);
            this.rbIntelCoreI7.TabIndex = 2;
            this.rbIntelCoreI7.TabStop = true;
            this.rbIntelCoreI7.Tag = "60";
            this.rbIntelCoreI7.Text = "Intel Core i7";
            this.rbIntelCoreI7.UseVisualStyleBackColor = true;
            this.rbIntelCoreI7.CheckedChanged += new System.EventHandler(this.rbIntelCoreI7_CheckedChanged);
            // 
            // rbIntelCoreI5
            // 
            this.rbIntelCoreI5.AutoSize = true;
            this.rbIntelCoreI5.Location = new System.Drawing.Point(17, 88);
            this.rbIntelCoreI5.Name = "rbIntelCoreI5";
            this.rbIntelCoreI5.Size = new System.Drawing.Size(119, 24);
            this.rbIntelCoreI5.TabIndex = 1;
            this.rbIntelCoreI5.TabStop = true;
            this.rbIntelCoreI5.Tag = "40";
            this.rbIntelCoreI5.Text = "Intel Core i5";
            this.rbIntelCoreI5.UseVisualStyleBackColor = true;
            this.rbIntelCoreI5.CheckedChanged += new System.EventHandler(this.rbIntelCoreI5_CheckedChanged);
            // 
            // rbIntelCoreI3
            // 
            this.rbIntelCoreI3.AutoSize = true;
            this.rbIntelCoreI3.Location = new System.Drawing.Point(17, 37);
            this.rbIntelCoreI3.Name = "rbIntelCoreI3";
            this.rbIntelCoreI3.Size = new System.Drawing.Size(119, 24);
            this.rbIntelCoreI3.TabIndex = 0;
            this.rbIntelCoreI3.TabStop = true;
            this.rbIntelCoreI3.Tag = "20";
            this.rbIntelCoreI3.Text = "Intel Core i3";
            this.rbIntelCoreI3.UseVisualStyleBackColor = true;
            this.rbIntelCoreI3.CheckedChanged += new System.EventHandler(this.rbIntelCoreI3_CheckedChanged);
            // 
            // btnOrderPC
            // 
            this.btnOrderPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPC.Location = new System.Drawing.Point(55, 520);
            this.btnOrderPC.Name = "btnOrderPC";
            this.btnOrderPC.Size = new System.Drawing.Size(246, 61);
            this.btnOrderPC.TabIndex = 0;
            this.btnOrderPC.Text = "Order PC";
            this.btnOrderPC.UseVisualStyleBackColor = false;
            this.btnOrderPC.Click += new System.EventHandler(this.btnOrderPC_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(339, 520);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(285, 61);
            this.btnReset.TabIndex = 6;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReOrder
            // 
            this.btnReOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReOrder.Location = new System.Drawing.Point(656, 520);
            this.btnReOrder.Name = "btnReOrder";
            this.btnReOrder.Size = new System.Drawing.Size(295, 61);
            this.btnReOrder.TabIndex = 7;
            this.btnReOrder.TabStop = false;
            this.btnReOrder.Text = "Re-Order";
            this.btnReOrder.UseVisualStyleBackColor = false;
            this.btnReOrder.Click += new System.EventHandler(this.btnReOrder_Click);
            // 
            // chkRGBLighting
            // 
            this.chkRGBLighting.AutoSize = true;
            this.chkRGBLighting.Location = new System.Drawing.Point(17, 36);
            this.chkRGBLighting.Name = "chkRGBLighting";
            this.chkRGBLighting.Size = new System.Drawing.Size(131, 24);
            this.chkRGBLighting.TabIndex = 0;
            this.chkRGBLighting.Tag = "2";
            this.chkRGBLighting.Text = "RGB Lighting";
            this.chkRGBLighting.UseVisualStyleBackColor = true;
            this.chkRGBLighting.CheckedChanged += new System.EventHandler(this.chkRGBLighting_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processor";
            // 
            // grpRAM
            // 
            this.grpRAM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpRAM.Controls.Add(this.label14);
            this.grpRAM.Controls.Add(this.rb32GB);
            this.grpRAM.Controls.Add(this.label18);
            this.grpRAM.Controls.Add(this.rb16GB);
            this.grpRAM.Controls.Add(this.label19);
            this.grpRAM.Controls.Add(this.rb8GB);
            this.grpRAM.Location = new System.Drawing.Point(328, 21);
            this.grpRAM.Name = "grpRAM";
            this.grpRAM.Size = new System.Drawing.Size(255, 208);
            this.grpRAM.TabIndex = 3;
            this.grpRAM.TabStop = false;
            this.grpRAM.Text = "RAM (Memory)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(151, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 5;
            this.label14.Tag = "20";
            this.label14.Text = "(+$20)";
            // 
            // rb32GB
            // 
            this.rb32GB.AutoSize = true;
            this.rb32GB.Location = new System.Drawing.Point(17, 139);
            this.rb32GB.Name = "rb32GB";
            this.rb32GB.Size = new System.Drawing.Size(76, 24);
            this.rb32GB.TabIndex = 2;
            this.rb32GB.TabStop = true;
            this.rb32GB.Tag = "20";
            this.rb32GB.Text = "32GB";
            this.rb32GB.UseVisualStyleBackColor = true;
            this.rb32GB.CheckedChanged += new System.EventHandler(this.rb32GB_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(151, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 20);
            this.label18.TabIndex = 4;
            this.label18.Tag = "12";
            this.label18.Text = "(+$12)";
            // 
            // rb16GB
            // 
            this.rb16GB.AutoSize = true;
            this.rb16GB.Location = new System.Drawing.Point(17, 88);
            this.rb16GB.Name = "rb16GB";
            this.rb16GB.Size = new System.Drawing.Size(76, 24);
            this.rb16GB.TabIndex = 1;
            this.rb16GB.TabStop = true;
            this.rb16GB.Tag = "12";
            this.rb16GB.Text = "16GB";
            this.rb16GB.UseVisualStyleBackColor = true;
            this.rb16GB.CheckedChanged += new System.EventHandler(this.rb16GB_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(151, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 20);
            this.label19.TabIndex = 3;
            this.label19.Tag = "6";
            this.label19.Text = "(+$6)";
            // 
            // rb8GB
            // 
            this.rb8GB.AutoSize = true;
            this.rb8GB.Location = new System.Drawing.Point(17, 37);
            this.rb8GB.Name = "rb8GB";
            this.rb8GB.Size = new System.Drawing.Size(67, 24);
            this.rb8GB.TabIndex = 0;
            this.rb8GB.TabStop = true;
            this.rb8GB.Tag = "6";
            this.rb8GB.Text = "8GB";
            this.rb8GB.UseVisualStyleBackColor = true;
            this.rb8GB.CheckedChanged += new System.EventHandler(this.rb8GB_CheckedChanged);
            // 
            // grpStorage
            // 
            this.grpStorage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpStorage.Controls.Add(this.label15);
            this.grpStorage.Controls.Add(this.rb1TB);
            this.grpStorage.Controls.Add(this.label16);
            this.grpStorage.Controls.Add(this.rb512GB);
            this.grpStorage.Controls.Add(this.label17);
            this.grpStorage.Controls.Add(this.rb256GB);
            this.grpStorage.Location = new System.Drawing.Point(44, 268);
            this.grpStorage.Name = "grpStorage";
            this.grpStorage.Size = new System.Drawing.Size(255, 208);
            this.grpStorage.TabIndex = 2;
            this.grpStorage.TabStop = false;
            this.grpStorage.Text = "Storage (SSD)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(151, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 5;
            this.label15.Tag = "40";
            this.label15.Text = "(+$40)";
            // 
            // rb1TB
            // 
            this.rb1TB.AutoSize = true;
            this.rb1TB.Location = new System.Drawing.Point(17, 137);
            this.rb1TB.Name = "rb1TB";
            this.rb1TB.Size = new System.Drawing.Size(63, 24);
            this.rb1TB.TabIndex = 2;
            this.rb1TB.TabStop = true;
            this.rb1TB.Tag = "40";
            this.rb1TB.Text = "1TB";
            this.rb1TB.UseVisualStyleBackColor = true;
            this.rb1TB.CheckedChanged += new System.EventHandler(this.rb1TB_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(151, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 4;
            this.label16.Tag = "30";
            this.label16.Text = "(+$30)";
            // 
            // rb512GB
            // 
            this.rb512GB.AutoSize = true;
            this.rb512GB.Location = new System.Drawing.Point(17, 86);
            this.rb512GB.Name = "rb512GB";
            this.rb512GB.Size = new System.Drawing.Size(85, 24);
            this.rb512GB.TabIndex = 1;
            this.rb512GB.TabStop = true;
            this.rb512GB.Tag = "30";
            this.rb512GB.Text = "512GB";
            this.rb512GB.UseVisualStyleBackColor = true;
            this.rb512GB.CheckedChanged += new System.EventHandler(this.rb512GB_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(151, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 3;
            this.label17.Tag = "20";
            this.label17.Text = "(+$20)";
            // 
            // rb256GB
            // 
            this.rb256GB.AutoSize = true;
            this.rb256GB.Location = new System.Drawing.Point(17, 35);
            this.rb256GB.Name = "rb256GB";
            this.rb256GB.Size = new System.Drawing.Size(85, 24);
            this.rb256GB.TabIndex = 0;
            this.rb256GB.TabStop = true;
            this.rb256GB.Tag = "20";
            this.rb256GB.Text = "256GB";
            this.rb256GB.UseVisualStyleBackColor = true;
            this.rb256GB.CheckedChanged += new System.EventHandler(this.rb256GB_CheckedChanged);
            // 
            // grpExtras
            // 
            this.grpExtras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpExtras.Controls.Add(this.label20);
            this.grpExtras.Controls.Add(this.chkWin11);
            this.grpExtras.Controls.Add(this.label21);
            this.grpExtras.Controls.Add(this.chkWiFiCard);
            this.grpExtras.Controls.Add(this.label22);
            this.grpExtras.Controls.Add(this.chkRGBLighting);
            this.grpExtras.Location = new System.Drawing.Point(328, 268);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Size = new System.Drawing.Size(255, 208);
            this.grpExtras.TabIndex = 4;
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Extras (Optional)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(151, 137);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 20);
            this.label20.TabIndex = 5;
            this.label20.Tag = "6";
            this.label20.Text = "(+$6)";
            // 
            // chkWin11
            // 
            this.chkWin11.AutoSize = true;
            this.chkWin11.Location = new System.Drawing.Point(17, 138);
            this.chkWin11.Name = "chkWin11";
            this.chkWin11.Size = new System.Drawing.Size(121, 24);
            this.chkWin11.TabIndex = 2;
            this.chkWin11.Tag = "6";
            this.chkWin11.Text = "Windows 11";
            this.chkWin11.UseVisualStyleBackColor = true;
            this.chkWin11.CheckedChanged += new System.EventHandler(this.chkWin11_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(151, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 20);
            this.label21.TabIndex = 4;
            this.label21.Tag = "4";
            this.label21.Text = "(+$4)";
            // 
            // chkWiFiCard
            // 
            this.chkWiFiCard.AutoSize = true;
            this.chkWiFiCard.Location = new System.Drawing.Point(17, 87);
            this.chkWiFiCard.Name = "chkWiFiCard";
            this.chkWiFiCard.Size = new System.Drawing.Size(109, 24);
            this.chkWiFiCard.TabIndex = 1;
            this.chkWiFiCard.Tag = "4";
            this.chkWiFiCard.Text = "Wi-Fi Card";
            this.chkWiFiCard.UseVisualStyleBackColor = true;
            this.chkWiFiCard.CheckedChanged += new System.EventHandler(this.chkWiFiCard_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(151, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 20);
            this.label22.TabIndex = 3;
            this.label22.Tag = "2";
            this.label22.Text = "(+$2)";
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpOrderSummary.Controls.Add(this.lblTotalPrice);
            this.grpOrderSummary.Controls.Add(this.lblExtrasValue);
            this.grpOrderSummary.Controls.Add(this.lblStorageValue);
            this.grpOrderSummary.Controls.Add(this.lblRAMValue);
            this.grpOrderSummary.Controls.Add(this.lblProcessorValue);
            this.grpOrderSummary.Controls.Add(this.label5);
            this.grpOrderSummary.Controls.Add(this.label4);
            this.grpOrderSummary.Controls.Add(this.label3);
            this.grpOrderSummary.Controls.Add(this.label2);
            this.grpOrderSummary.Controls.Add(this.label1);
            this.grpOrderSummary.Location = new System.Drawing.Point(607, 21);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(362, 455);
            this.grpOrderSummary.TabIndex = 5;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalPrice.Location = new System.Drawing.Point(224, 333);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(115, 32);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "label10";
            // 
            // lblExtrasValue
            // 
            this.lblExtrasValue.Location = new System.Drawing.Point(193, 206);
            this.lblExtrasValue.Name = "lblExtrasValue";
            this.lblExtrasValue.Size = new System.Drawing.Size(162, 78);
            this.lblExtrasValue.TabIndex = 8;
            this.lblExtrasValue.Text = "label9";
            // 
            // lblStorageValue
            // 
            this.lblStorageValue.AutoSize = true;
            this.lblStorageValue.Location = new System.Drawing.Point(193, 156);
            this.lblStorageValue.Name = "lblStorageValue";
            this.lblStorageValue.Size = new System.Drawing.Size(51, 20);
            this.lblStorageValue.TabIndex = 7;
            this.lblStorageValue.Text = "label8";
            // 
            // lblRAMValue
            // 
            this.lblRAMValue.AutoSize = true;
            this.lblRAMValue.Location = new System.Drawing.Point(193, 105);
            this.lblRAMValue.Name = "lblRAMValue";
            this.lblRAMValue.Size = new System.Drawing.Size(51, 20);
            this.lblRAMValue.TabIndex = 6;
            this.lblRAMValue.Text = "label7";
            // 
            // lblProcessorValue
            // 
            this.lblProcessorValue.AutoSize = true;
            this.lblProcessorValue.Location = new System.Drawing.Point(193, 56);
            this.lblProcessorValue.Name = "lblProcessorValue";
            this.lblProcessorValue.Size = new System.Drawing.Size(51, 20);
            this.lblProcessorValue.TabIndex = 5;
            this.lblProcessorValue.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(14, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Extras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Storage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM";
            // 
            // frmPCBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 617);
            this.Controls.Add(this.grpOrderSummary);
            this.Controls.Add(this.grpExtras);
            this.Controls.Add(this.grpStorage);
            this.Controls.Add(this.grpRAM);
            this.Controls.Add(this.btnReOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrderPC);
            this.Controls.Add(this.grpProcessor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPCBuilder";
            this.Text = "PC Builder";
            this.Load += new System.EventHandler(this.frmPCBuilder_Load);
            this.grpProcessor.ResumeLayout(false);
            this.grpProcessor.PerformLayout();
            this.grpRAM.ResumeLayout(false);
            this.grpRAM.PerformLayout();
            this.grpStorage.ResumeLayout(false);
            this.grpStorage.PerformLayout();
            this.grpExtras.ResumeLayout(false);
            this.grpExtras.PerformLayout();
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProcessor;
        private System.Windows.Forms.RadioButton rbIntelCoreI7;
        private System.Windows.Forms.RadioButton rbIntelCoreI5;
        private System.Windows.Forms.RadioButton rbIntelCoreI3;
        private System.Windows.Forms.Button btnOrderPC;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReOrder;
        private System.Windows.Forms.CheckBox chkRGBLighting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRAM;
        private System.Windows.Forms.RadioButton rb32GB;
        private System.Windows.Forms.RadioButton rb16GB;
        private System.Windows.Forms.RadioButton rb8GB;
        private System.Windows.Forms.GroupBox grpStorage;
        private System.Windows.Forms.RadioButton rb1TB;
        private System.Windows.Forms.RadioButton rb512GB;
        private System.Windows.Forms.RadioButton rb256GB;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.CheckBox chkWin11;
        private System.Windows.Forms.CheckBox chkWiFiCard;
        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblExtrasValue;
        private System.Windows.Forms.Label lblStorageValue;
        private System.Windows.Forms.Label lblRAMValue;
        private System.Windows.Forms.Label lblProcessorValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

