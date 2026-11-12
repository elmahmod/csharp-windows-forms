namespace Practicing
{
    partial class VolumeAndRGBController
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.pbVolume = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBlue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.lblGreen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlColorPreview = new System.Windows.Forms.Panel();
            this.txtColorRGB = new System.Windows.Forms.TextBox();
            this.txtColorHexa = new System.Windows.Forms.TextBox();
            this.btnCopyHex = new System.Windows.Forms.Button();
            this.btnRandomColor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "volume";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(976, 42);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(32, 20);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "0%";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbVolume);
            this.panel1.Controls.Add(this.pbVolume);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 152);
            this.panel1.TabIndex = 2;
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(40, 75);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(980, 69);
            this.tbVolume.TabIndex = 3;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // pbVolume
            // 
            this.pbVolume.Image = global::Practicing.Properties.Resources.min;
            this.pbVolume.Location = new System.Drawing.Point(40, 27);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(69, 42);
            this.pbVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVolume.TabIndex = 2;
            this.pbVolume.TabStop = false;
            this.pbVolume.Click += new System.EventHandler(this.pbVolume_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume Controller";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBlue);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbBlue);
            this.panel2.Controls.Add(this.pbBlue);
            this.panel2.Controls.Add(this.tbGreen);
            this.panel2.Controls.Add(this.pbGreen);
            this.panel2.Controls.Add(this.lblGreen);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbRed);
            this.panel2.Controls.Add(this.pbRed);
            this.panel2.Controls.Add(this.lblRed);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(30, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 417);
            this.panel2.TabIndex = 4;
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(976, 284);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(32, 20);
            this.lblBlue.TabIndex = 11;
            this.lblBlue.Text = "0%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Blue";
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(40, 319);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(980, 69);
            this.tbBlue.TabIndex = 9;
            this.tbBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBlue.Scroll += new System.EventHandler(this.tbRGB_Scroll);
            // 
            // pbBlue
            // 
            this.pbBlue.Image = global::Practicing.Properties.Resources.blue;
            this.pbBlue.Location = new System.Drawing.Point(40, 272);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(69, 42);
            this.pbBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBlue.TabIndex = 8;
            this.pbBlue.TabStop = false;
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(40, 197);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(980, 69);
            this.tbGreen.TabIndex = 7;
            this.tbGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGreen.Scroll += new System.EventHandler(this.tbRGB_Scroll);
            // 
            // pbGreen
            // 
            this.pbGreen.Image = global::Practicing.Properties.Resources.green;
            this.pbGreen.Location = new System.Drawing.Point(40, 139);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(69, 42);
            this.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGreen.TabIndex = 6;
            this.pbGreen.TabStop = false;
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(976, 154);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(32, 20);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "0%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Green";
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(40, 75);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(980, 69);
            this.tbRed.TabIndex = 3;
            this.tbRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbRed.Scroll += new System.EventHandler(this.tbRGB_Scroll);
            // 
            // pbRed
            // 
            this.pbRed.Image = global::Practicing.Properties.Resources.red;
            this.pbRed.Location = new System.Drawing.Point(40, 27);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(69, 42);
            this.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRed.TabIndex = 2;
            this.pbRed.TabStop = false;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(976, 42);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(32, 20);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "RED";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "RGB Controller";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1170, 50);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(245, 63);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlColorPreview
            // 
            this.pnlColorPreview.Location = new System.Drawing.Point(1154, 265);
            this.pnlColorPreview.Name = "pnlColorPreview";
            this.pnlColorPreview.Size = new System.Drawing.Size(292, 238);
            this.pnlColorPreview.TabIndex = 7;
            // 
            // txtColorRGB
            // 
            this.txtColorRGB.Location = new System.Drawing.Point(1154, 527);
            this.txtColorRGB.Name = "txtColorRGB";
            this.txtColorRGB.Size = new System.Drawing.Size(292, 26);
            this.txtColorRGB.TabIndex = 8;
            this.txtColorRGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtColorHexa
            // 
            this.txtColorHexa.Location = new System.Drawing.Point(1154, 584);
            this.txtColorHexa.Name = "txtColorHexa";
            this.txtColorHexa.Size = new System.Drawing.Size(158, 26);
            this.txtColorHexa.TabIndex = 9;
            this.txtColorHexa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCopyHex
            // 
            this.btnCopyHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyHex.Location = new System.Drawing.Point(1350, 580);
            this.btnCopyHex.Name = "btnCopyHex";
            this.btnCopyHex.Size = new System.Drawing.Size(77, 35);
            this.btnCopyHex.TabIndex = 10;
            this.btnCopyHex.Text = "Copy HEX Color";
            this.btnCopyHex.UseVisualStyleBackColor = true;
            this.btnCopyHex.Click += new System.EventHandler(this.btnCopyHex_Click);
            // 
            // btnRandomColor
            // 
            this.btnRandomColor.Location = new System.Drawing.Point(1154, 643);
            this.btnRandomColor.Name = "btnRandomColor";
            this.btnRandomColor.Size = new System.Drawing.Size(292, 39);
            this.btnRandomColor.TabIndex = 11;
            this.btnRandomColor.Text = "Random Color";
            this.btnRandomColor.UseVisualStyleBackColor = true;
            this.btnRandomColor.Click += new System.EventHandler(this.btnRandomColor_Click);
            // 
            // VolumeAndRGBController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 739);
            this.Controls.Add(this.btnRandomColor);
            this.Controls.Add(this.btnCopyHex);
            this.Controls.Add(this.txtColorHexa);
            this.Controls.Add(this.txtColorRGB);
            this.Controls.Add(this.pnlColorPreview);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "VolumeAndRGBController";
            this.Text = "VolumeAndRGBController";
            this.Load += new System.EventHandler(this.VolumeAndRGBController_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.PictureBox pbVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlColorPreview;
        private System.Windows.Forms.TextBox txtColorRGB;
        private System.Windows.Forms.TextBox txtColorHexa;
        private System.Windows.Forms.Button btnCopyHex;
        private System.Windows.Forms.Button btnRandomColor;
    }
}