namespace TenSecondStop
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
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblLastResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
            this.pnlTimer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTimer
            // 
            this.pnlTimer.BackColor = System.Drawing.Color.Firebrick;
            this.pnlTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTimer.Controls.Add(this.lblTarget);
            this.pnlTimer.Controls.Add(this.lblTimer);
            this.pnlTimer.Location = new System.Drawing.Point(42, 21);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(521, 219);
            this.pnlTimer.TabIndex = 0;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(42, 264);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(521, 58);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "START";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(174, 102);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(176, 41);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Timer (s)";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarget.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTarget.Location = new System.Drawing.Point(120, 28);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(282, 32);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "TARGET: 10.000 SECONDS";
            this.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLastResult});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(597, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblLastResult
            // 
            this.lblLastResult.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastResult.ForeColor = System.Drawing.Color.White;
            this.lblLastResult.Name = "lblLastResult";
            this.lblLastResult.Size = new System.Drawing.Size(582, 23);
            this.lblLastResult.Spring = true;
            this.lblLastResult.Text = "Last Result";
            this.lblLastResult.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tmrDisplay
            // 
            this.tmrDisplay.Interval = 10;
            this.tmrDisplay.Tick += new System.EventHandler(this.tmrDisplay_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(597, 410);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.pnlTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLastResult;
        private System.Windows.Forms.Timer tmrDisplay;
    }
}

