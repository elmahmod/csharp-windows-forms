namespace Basics
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
            this.btnShowPart2 = new System.Windows.Forms.Button();
            this.btnShowPart3 = new System.Windows.Forms.Button();
            this.btnShowPart4 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowPart5 = new System.Windows.Forms.Button();
            this.btnShowPart6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPart2
            // 
            this.btnShowPart2.Location = new System.Drawing.Point(31, 51);
            this.btnShowPart2.Name = "btnShowPart2";
            this.btnShowPart2.Size = new System.Drawing.Size(170, 60);
            this.btnShowPart2.TabIndex = 0;
            this.btnShowPart2.Text = "Part 2";
            this.btnShowPart2.UseVisualStyleBackColor = true;
            this.btnShowPart2.Click += new System.EventHandler(this.btnShowPart2_Click);
            // 
            // btnShowPart3
            // 
            this.btnShowPart3.Location = new System.Drawing.Point(31, 153);
            this.btnShowPart3.Name = "btnShowPart3";
            this.btnShowPart3.Size = new System.Drawing.Size(170, 60);
            this.btnShowPart3.TabIndex = 1;
            this.btnShowPart3.Text = "Part 3";
            this.btnShowPart3.UseVisualStyleBackColor = true;
            this.btnShowPart3.Click += new System.EventHandler(this.btnShowPart3_Click);
            // 
            // btnShowPart4
            // 
            this.btnShowPart4.Location = new System.Drawing.Point(31, 255);
            this.btnShowPart4.Name = "btnShowPart4";
            this.btnShowPart4.Size = new System.Drawing.Size(170, 60);
            this.btnShowPart4.TabIndex = 2;
            this.btnShowPart4.Text = "Show Part 4 as dialog";
            this.btnShowPart4.UseVisualStyleBackColor = true;
            this.btnShowPart4.Click += new System.EventHandler(this.btnShowPart4_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Location = new System.Drawing.Point(919, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 82);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowPart5
            // 
            this.btnShowPart5.Location = new System.Drawing.Point(31, 357);
            this.btnShowPart5.Name = "btnShowPart5";
            this.btnShowPart5.Size = new System.Drawing.Size(170, 60);
            this.btnShowPart5.TabIndex = 4;
            this.btnShowPart5.Text = "Part 5";
            this.btnShowPart5.UseVisualStyleBackColor = true;
            this.btnShowPart5.Click += new System.EventHandler(this.btnShowPart5_Click);
            // 
            // btnShowPart6
            // 
            this.btnShowPart6.Location = new System.Drawing.Point(31, 463);
            this.btnShowPart6.Name = "btnShowPart6";
            this.btnShowPart6.Size = new System.Drawing.Size(170, 60);
            this.btnShowPart6.TabIndex = 5;
            this.btnShowPart6.Text = "Part 6";
            this.btnShowPart6.UseVisualStyleBackColor = true;
            this.btnShowPart6.Click += new System.EventHandler(this.btnShowPart6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 650);
            this.Controls.Add(this.btnShowPart6);
            this.Controls.Add(this.btnShowPart5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowPart4);
            this.Controls.Add(this.btnShowPart3);
            this.Controls.Add(this.btnShowPart2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPart2;
        private System.Windows.Forms.Button btnShowPart3;
        private System.Windows.Forms.Button btnShowPart4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowPart5;
        private System.Windows.Forms.Button btnShowPart6;
    }
}

