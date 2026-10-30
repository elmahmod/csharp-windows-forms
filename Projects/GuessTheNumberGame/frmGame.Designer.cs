namespace GuessTheNumberGame
{
    partial class frmGame
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(123, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUN GUESS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(193, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "( 0 - 50 ) : ";
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Bold);
            this.txtGuess.ForeColor = System.Drawing.Color.Crimson;
            this.txtGuess.Location = new System.Drawing.Point(304, 173);
            this.txtGuess.MaxLength = 2;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(105, 34);
            this.txtGuess.TabIndex = 3;
            this.txtGuess.Tag = "";
            this.txtGuess.Text = "55";
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCheck
            // 
            this.btCheck.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCheck.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btCheck.FlatAppearance.BorderSize = 0;
            this.btCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCheck.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btCheck.Location = new System.Drawing.Point(227, 240);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(160, 47);
            this.btCheck.TabIndex = 4;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = false;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Simplified Arabic", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(438, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "GIVE UP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRestart
            // 
            this.btRestart.AutoSize = true;
            this.btRestart.BackColor = System.Drawing.Color.Transparent;
            this.btRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRestart.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestart.Font = new System.Drawing.Font("Simplified Arabic", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestart.ForeColor = System.Drawing.Color.Black;
            this.btRestart.Location = new System.Drawing.Point(75, 328);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(66, 34);
            this.btRestart.TabIndex = 6;
            this.btRestart.Text = "Restart";
            this.btRestart.UseVisualStyleBackColor = false;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessTheNumberGame.Properties.Resources.playingGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 388);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmGame";
            this.Text = "Guess The Number";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRestart;
    }
}

