namespace PasswordGenerator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordLength = new System.Windows.Forms.TrackBar();
            this.gbIncludes = new System.Windows.Forms.GroupBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.chkLowercase = new System.Windows.Forms.CheckBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmsReset = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCoppy = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbPasswordLength)).BeginInit();
            this.gbIncludes.SuspendLayout();
            this.cmsReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generated Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(28, 48);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(422, 42);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPasswordLength
            // 
            this.tbPasswordLength.Location = new System.Drawing.Point(28, 146);
            this.tbPasswordLength.Maximum = 32;
            this.tbPasswordLength.Minimum = 1;
            this.tbPasswordLength.Name = "tbPasswordLength";
            this.tbPasswordLength.Size = new System.Drawing.Size(485, 69);
            this.tbPasswordLength.TabIndex = 2;
            this.tbPasswordLength.Value = 1;
            this.tbPasswordLength.Scroll += new System.EventHandler(this.tbPasswordLength_Scroll);
            // 
            // gbIncludes
            // 
            this.gbIncludes.Controls.Add(this.chkSymbols);
            this.gbIncludes.Controls.Add(this.chkNumbers);
            this.gbIncludes.Controls.Add(this.chkUppercase);
            this.gbIncludes.Controls.Add(this.chkLowercase);
            this.gbIncludes.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbIncludes.Location = new System.Drawing.Point(28, 221);
            this.gbIncludes.Name = "gbIncludes";
            this.gbIncludes.Size = new System.Drawing.Size(485, 133);
            this.gbIncludes.TabIndex = 3;
            this.gbIncludes.TabStop = false;
            this.gbIncludes.Text = "Include";
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkSymbols.Location = new System.Drawing.Point(15, 80);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(147, 24);
            this.chkSymbols.TabIndex = 7;
            this.chkSymbols.Text = "Symbols (!@#$)";
            this.chkSymbols.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkNumbers.Location = new System.Drawing.Point(326, 80);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(136, 24);
            this.chkNumbers.TabIndex = 6;
            this.chkNumbers.Text = "Numbers (0-9)";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkUppercase.Location = new System.Drawing.Point(326, 25);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(153, 24);
            this.chkUppercase.TabIndex = 5;
            this.chkUppercase.Text = "Uppercase (A-Z)";
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkLowercase
            // 
            this.chkLowercase.AutoSize = true;
            this.chkLowercase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkLowercase.Location = new System.Drawing.Point(15, 25);
            this.chkLowercase.Name = "chkLowercase";
            this.chkLowercase.Size = new System.Drawing.Size(148, 24);
            this.chkLowercase.TabIndex = 4;
            this.chkLowercase.Text = "Lowercase (a-z)";
            this.chkLowercase.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePassword.Location = new System.Drawing.Point(28, 375);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(485, 54);
            this.btnGeneratePassword.TabIndex = 4;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(24, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password Length";
            // 
            // cmsReset
            // 
            this.cmsReset.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsReset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReset});
            this.cmsReset.Name = "cmsReset";
            this.cmsReset.Size = new System.Drawing.Size(127, 36);
            // 
            // mnuReset
            // 
            this.mnuReset.Name = "mnuReset";
            this.mnuReset.Size = new System.Drawing.Size(126, 32);
            this.mnuReset.Text = "Reset";
            this.mnuReset.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // btnCoppy
            // 
            this.btnCoppy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCoppy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoppy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.btnCoppy.Location = new System.Drawing.Point(456, 48);
            this.btnCoppy.Name = "btnCoppy";
            this.btnCoppy.Size = new System.Drawing.Size(57, 42);
            this.btnCoppy.TabIndex = 5;
            this.btnCoppy.Text = "Coppy";
            this.btnCoppy.UseVisualStyleBackColor = false;
            this.btnCoppy.Click += new System.EventHandler(this.btnCoppy_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblValue.Location = new System.Drawing.Point(489, 123);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(18, 20);
            this.lblValue.TabIndex = 9;
            this.lblValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 470);
            this.ContextMenuStrip = this.cmsReset;
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnCoppy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.gbIncludes);
            this.Controls.Add(this.tbPasswordLength);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPasswordLength)).EndInit();
            this.gbIncludes.ResumeLayout(false);
            this.gbIncludes.PerformLayout();
            this.cmsReset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TrackBar tbPasswordLength;
        private System.Windows.Forms.GroupBox gbIncludes;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.CheckBox chkLowercase;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsReset;
        private System.Windows.Forms.ToolStripMenuItem mnuReset;
        private System.Windows.Forms.Button btnCoppy;
        private System.Windows.Forms.Label lblValue;
    }
}

