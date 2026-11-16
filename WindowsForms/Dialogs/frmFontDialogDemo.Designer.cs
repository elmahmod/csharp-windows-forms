namespace Dialogs
{
    partial class frmFontDialogDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.fontDialog3 = new System.Windows.Forms.FontDialog();
            this.fontDialog4 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Change Font";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowEffects = false;
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 136);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "HELLOOO";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 59);
            this.button2.TabIndex = 8;
            this.button2.Text = "Change Font";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(341, 59);
            this.button3.TabIndex = 9;
            this.button3.Text = "Change Font";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 505);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(341, 59);
            this.button4.TabIndex = 10;
            this.button4.Text = "Change Font";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fontDialog2
            // 
            this.fontDialog2.ShowApply = true;
            this.fontDialog2.ShowColor = true;
            this.fontDialog2.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // fontDialog3
            // 
            this.fontDialog3.FontMustExist = true;
            this.fontDialog3.ScriptsOnly = true;
            this.fontDialog3.ShowApply = true;
            this.fontDialog3.ShowColor = true;
            this.fontDialog3.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // fontDialog4
            // 
            this.fontDialog4.FixedPitchOnly = true;
            this.fontDialog4.ShowApply = true;
            this.fontDialog4.ShowColor = true;
            this.fontDialog4.ShowHelp = true;
            this.fontDialog4.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // FontDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 605);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FontDialog";
            this.Text = "FontDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.FontDialog fontDialog3;
        private System.Windows.Forms.FontDialog fontDialog4;
    }
}