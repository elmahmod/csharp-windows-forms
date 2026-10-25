namespace Practicing
{
    partial class MainForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnShowClickForm = new System.Windows.Forms.Button();
            this.btnShowCountForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(521, 346);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(114, 66);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(202, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(247, 94);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "label1";
            // 
            // btnShowClickForm
            // 
            this.btnShowClickForm.Location = new System.Drawing.Point(98, 208);
            this.btnShowClickForm.Name = "btnShowClickForm";
            this.btnShowClickForm.Size = new System.Drawing.Size(114, 66);
            this.btnShowClickForm.TabIndex = 2;
            this.btnShowClickForm.Text = "Click Counter ";
            this.btnShowClickForm.UseVisualStyleBackColor = true;
            this.btnShowClickForm.Click += new System.EventHandler(this.btnShowClickForm_Click);
            // 
            // btnShowCountForm
            // 
            this.btnShowCountForm.Location = new System.Drawing.Point(261, 208);
            this.btnShowCountForm.Name = "btnShowCountForm";
            this.btnShowCountForm.Size = new System.Drawing.Size(114, 66);
            this.btnShowCountForm.TabIndex = 3;
            this.btnShowCountForm.Text = "Count Characters";
            this.btnShowCountForm.UseVisualStyleBackColor = true;
            this.btnShowCountForm.Click += new System.EventHandler(this.btnShowCountForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Theme Switcher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowCountForm);
            this.Controls.Add(this.btnShowClickForm);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogout);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnShowClickForm;
        private System.Windows.Forms.Button btnShowCountForm;
        private System.Windows.Forms.Button button1;
    }
}

