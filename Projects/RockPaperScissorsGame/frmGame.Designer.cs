namespace RockPaperScissorsGame
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
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.btRock = new System.Windows.Forms.Button();
            this.btPaper = new System.Windows.Forms.Button();
            this.btScissors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer.Image = global::RockPaperScissorsGame.Properties.Resources.QuestionMark;
            this.pbPlayer.Location = new System.Drawing.Point(236, 131);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(185, 162);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Tag = "?";
            // 
            // btRock
            // 
            this.btRock.BackColor = System.Drawing.Color.Transparent;
            this.btRock.BackgroundImage = global::RockPaperScissorsGame.Properties.Resources.Rock;
            this.btRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRock.FlatAppearance.BorderSize = 0;
            this.btRock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btRock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRock.Location = new System.Drawing.Point(158, 459);
            this.btRock.Name = "btRock";
            this.btRock.Size = new System.Drawing.Size(193, 128);
            this.btRock.TabIndex = 2;
            this.btRock.Tag = "Rock";
            this.btRock.UseVisualStyleBackColor = false;
            this.btRock.Click += new System.EventHandler(this.btChoice_Click);
            // 
            // btPaper
            // 
            this.btPaper.BackColor = System.Drawing.Color.Transparent;
            this.btPaper.BackgroundImage = global::RockPaperScissorsGame.Properties.Resources.Paper;
            this.btPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPaper.FlatAppearance.BorderSize = 0;
            this.btPaper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPaper.Location = new System.Drawing.Point(459, 459);
            this.btPaper.Name = "btPaper";
            this.btPaper.Size = new System.Drawing.Size(193, 128);
            this.btPaper.TabIndex = 3;
            this.btPaper.Tag = "Paper";
            this.btPaper.UseVisualStyleBackColor = false;
            this.btPaper.Click += new System.EventHandler(this.btChoice_Click);
            // 
            // btScissors
            // 
            this.btScissors.BackColor = System.Drawing.Color.Transparent;
            this.btScissors.BackgroundImage = global::RockPaperScissorsGame.Properties.Resources.Scissors;
            this.btScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btScissors.FlatAppearance.BorderSize = 0;
            this.btScissors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btScissors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btScissors.Location = new System.Drawing.Point(760, 459);
            this.btScissors.Name = "btScissors";
            this.btScissors.Size = new System.Drawing.Size(193, 128);
            this.btScissors.TabIndex = 4;
            this.btScissors.Tag = "Scissors";
            this.btScissors.UseVisualStyleBackColor = false;
            this.btScissors.Click += new System.EventHandler(this.btChoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(257, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbComputer
            // 
            this.pbComputer.BackColor = System.Drawing.Color.Transparent;
            this.pbComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbComputer.Image = global::RockPaperScissorsGame.Properties.Resources.QuestionMark;
            this.pbComputer.Location = new System.Drawing.Point(667, 131);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(185, 162);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputer.TabIndex = 8;
            this.pbComputer.TabStop = false;
            this.pbComputer.Tag = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(660, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Computer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Ravie", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.IndianRed;
            this.button4.Location = new System.Drawing.Point(413, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(278, 50);
            this.button4.TabIndex = 11;
            this.button4.Text = "Choose";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RockPaperScissorsGame.Properties.Resources.playingGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1056, 689);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btScissors);
            this.Controls.Add(this.btPaper);
            this.Controls.Add(this.btRock);
            this.Controls.Add(this.pbPlayer);
            this.DoubleBuffered = true;
            this.Name = "frmGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Button btRock;
        private System.Windows.Forms.Button btPaper;
        private System.Windows.Forms.Button btScissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}

