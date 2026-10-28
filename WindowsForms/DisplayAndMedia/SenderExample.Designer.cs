namespace DisplayAndMedia
{
    partial class SenderExample
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
            this.pbSwitcher = new System.Windows.Forms.PictureBox();
            this.rbDrakMode = new System.Windows.Forms.RadioButton();
            this.rbLightMode = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitcher)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSwitcher
            // 
            this.pbSwitcher.Location = new System.Drawing.Point(111, 60);
            this.pbSwitcher.Name = "pbSwitcher";
            this.pbSwitcher.Size = new System.Drawing.Size(268, 179);
            this.pbSwitcher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSwitcher.TabIndex = 0;
            this.pbSwitcher.TabStop = false;
            // 
            // rbDrakMode
            // 
            this.rbDrakMode.AutoSize = true;
            this.rbDrakMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrakMode.Location = new System.Drawing.Point(65, 285);
            this.rbDrakMode.Name = "rbDrakMode";
            this.rbDrakMode.Size = new System.Drawing.Size(142, 29);
            this.rbDrakMode.TabIndex = 1;
            this.rbDrakMode.TabStop = true;
            this.rbDrakMode.Tag = "Dark";
            this.rbDrakMode.Text = "Dark Mode";
            this.rbDrakMode.UseVisualStyleBackColor = true;
            this.rbDrakMode.CheckedChanged += new System.EventHandler(this.rbTheme_CheckedChanged);
            // 
            // rbLightMode
            // 
            this.rbLightMode.AutoSize = true;
            this.rbLightMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLightMode.Location = new System.Drawing.Point(261, 285);
            this.rbLightMode.Name = "rbLightMode";
            this.rbLightMode.Size = new System.Drawing.Size(144, 29);
            this.rbLightMode.TabIndex = 2;
            this.rbLightMode.TabStop = true;
            this.rbLightMode.Tag = "Light";
            this.rbLightMode.Text = "Light Mode";
            this.rbLightMode.UseVisualStyleBackColor = true;
            this.rbLightMode.CheckedChanged += new System.EventHandler(this.rbTheme_CheckedChanged);
            // 
            // SenderExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 369);
            this.Controls.Add(this.rbLightMode);
            this.Controls.Add(this.rbDrakMode);
            this.Controls.Add(this.pbSwitcher);
            this.Name = "SenderExample";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SenderExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSwitcher;
        private System.Windows.Forms.RadioButton rbDrakMode;
        private System.Windows.Forms.RadioButton rbLightMode;
    }
}