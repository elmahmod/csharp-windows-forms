namespace Practicing
{
    partial class ThemeSwitcher
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
            this.rbDark = new System.Windows.Forms.RadioButton();
            this.rbLight = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbDark
            // 
            this.rbDark.AutoSize = true;
            this.rbDark.Location = new System.Drawing.Point(66, 66);
            this.rbDark.Name = "rbDark";
            this.rbDark.Size = new System.Drawing.Size(68, 24);
            this.rbDark.TabIndex = 0;
            this.rbDark.TabStop = true;
            this.rbDark.Text = "Dark";
            this.rbDark.UseVisualStyleBackColor = true;
            this.rbDark.CheckedChanged += new System.EventHandler(this.rbDark_CheckedChanged);
            // 
            // rbLight
            // 
            this.rbLight.AutoSize = true;
            this.rbLight.Location = new System.Drawing.Point(66, 147);
            this.rbLight.Name = "rbLight";
            this.rbLight.Size = new System.Drawing.Size(69, 24);
            this.rbLight.TabIndex = 1;
            this.rbLight.TabStop = true;
            this.rbLight.Text = "Light";
            this.rbLight.UseVisualStyleBackColor = true;
            this.rbLight.CheckedChanged += new System.EventHandler(this.rbLight_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ThemeSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbLight);
            this.Controls.Add(this.rbDark);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ThemeSwitcher";
            this.Text = "ThemeSwitcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDark;
        private System.Windows.Forms.RadioButton rbLight;
        private System.Windows.Forms.Label label1;
    }
}