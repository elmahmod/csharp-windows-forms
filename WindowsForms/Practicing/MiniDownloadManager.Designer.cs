namespace Practicing
{
    partial class MiniDownloadManager
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabNewDownload = new System.Windows.Forms.TabPage();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.nudFileCount = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressDownload = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.lvHistory = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.chkNotify = new System.Windows.Forms.CheckBox();
            this.lblSpeedValue = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tmrDownlaod = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyCompleted = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabMain.SuspendLayout();
            this.tabNewDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFileCount)).BeginInit();
            this.tabHistory.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabNewDownload);
            this.tabMain.Controls.Add(this.tabHistory);
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(635, 431);
            this.tabMain.TabIndex = 0;
            // 
            // tabNewDownload
            // 
            this.tabNewDownload.Controls.Add(this.lblCurrentFile);
            this.tabNewDownload.Controls.Add(this.btnPauseResume);
            this.tabNewDownload.Controls.Add(this.nudFileCount);
            this.tabNewDownload.Controls.Add(this.btnReset);
            this.tabNewDownload.Controls.Add(this.btnStart);
            this.tabNewDownload.Controls.Add(this.lblPercentage);
            this.tabNewDownload.Controls.Add(this.lblStatus);
            this.tabNewDownload.Controls.Add(this.progressDownload);
            this.tabNewDownload.Controls.Add(this.label2);
            this.tabNewDownload.Controls.Add(this.txtFileName);
            this.tabNewDownload.Controls.Add(this.label1);
            this.tabNewDownload.Location = new System.Drawing.Point(4, 29);
            this.tabNewDownload.Name = "tabNewDownload";
            this.tabNewDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewDownload.Size = new System.Drawing.Size(627, 398);
            this.tabNewDownload.TabIndex = 0;
            this.tabNewDownload.Text = "New Downlaod";
            this.tabNewDownload.UseVisualStyleBackColor = true;
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(132, 180);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(33, 20);
            this.lblCurrentFile.TabIndex = 11;
            this.lblCurrentFile.Text = "-of-";
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Enabled = false;
            this.btnPauseResume.Location = new System.Drawing.Point(324, 300);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPauseResume.Size = new System.Drawing.Size(164, 53);
            this.btnPauseResume.TabIndex = 10;
            this.btnPauseResume.Tag = "";
            this.btnPauseResume.Text = "Pause";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // nudFileCount
            // 
            this.nudFileCount.Location = new System.Drawing.Point(212, 121);
            this.nudFileCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFileCount.Name = "nudFileCount";
            this.nudFileCount.Size = new System.Drawing.Size(71, 26);
            this.nudFileCount.TabIndex = 9;
            this.nudFileCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(505, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 53);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 300);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(306, 53);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(576, 180);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(32, 20);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "0%";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 180);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "label4";
            // 
            // progressDownload
            // 
            this.progressDownload.Location = new System.Drawing.Point(12, 220);
            this.progressDownload.Name = "progressDownload";
            this.progressDownload.Size = new System.Drawing.Size(607, 37);
            this.progressDownload.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Files";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 54);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(271, 26);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.btnRemoveSelected);
            this.tabHistory.Controls.Add(this.btnClearHistory);
            this.tabHistory.Controls.Add(this.lvHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 29);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(627, 398);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(376, 240);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(235, 56);
            this.btnRemoveSelected.TabIndex = 4;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(20, 240);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(235, 56);
            this.btnClearHistory.TabIndex = 3;
            this.btnClearHistory.Text = "Clear All";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // lvHistory
            // 
            this.lvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colFileCount,
            this.colStatus});
            this.lvHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvHistory.FullRowSelect = true;
            this.lvHistory.GridLines = true;
            this.lvHistory.HideSelection = false;
            this.lvHistory.Location = new System.Drawing.Point(3, 3);
            this.lvHistory.MultiSelect = false;
            this.lvHistory.Name = "lvHistory";
            this.lvHistory.Size = new System.Drawing.Size(621, 208);
            this.lvHistory.TabIndex = 2;
            this.lvHistory.UseCompatibleStateImageBehavior = false;
            this.lvHistory.View = System.Windows.Forms.View.Details;
            // 
            // colFileName
            // 
            this.colFileName.Text = "File";
            this.colFileName.Width = 125;
            // 
            // colFileCount
            // 
            this.colFileCount.DisplayIndex = 2;
            this.colFileCount.Text = "Count";
            this.colFileCount.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.DisplayIndex = 1;
            this.colStatus.Text = "Status";
            this.colStatus.Width = 125;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.btnResetSettings);
            this.tabSettings.Controls.Add(this.chkNotify);
            this.tabSettings.Controls.Add(this.lblSpeedValue);
            this.tabSettings.Controls.Add(this.tbSpeed);
            this.tabSettings.Controls.Add(this.label6);
            this.tabSettings.Location = new System.Drawing.Point(4, 29);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(627, 398);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnResetSettings.Location = new System.Drawing.Point(0, 354);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(627, 44);
            this.btnResetSettings.TabIndex = 4;
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // chkNotify
            // 
            this.chkNotify.AutoSize = true;
            this.chkNotify.Location = new System.Drawing.Point(8, 216);
            this.chkNotify.Name = "chkNotify";
            this.chkNotify.Size = new System.Drawing.Size(202, 24);
            this.chkNotify.TabIndex = 3;
            this.chkNotify.Text = "Notify When Completed";
            this.chkNotify.UseVisualStyleBackColor = true;
            // 
            // lblSpeedValue
            // 
            this.lblSpeedValue.AutoSize = true;
            this.lblSpeedValue.Location = new System.Drawing.Point(606, 46);
            this.lblSpeedValue.Name = "lblSpeedValue";
            this.lblSpeedValue.Size = new System.Drawing.Size(18, 20);
            this.lblSpeedValue.TabIndex = 2;
            this.lblSpeedValue.Text = "0";
            // 
            // tbSpeed
            // 
            this.tbSpeed.LargeChange = 2;
            this.tbSpeed.Location = new System.Drawing.Point(8, 83);
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(616, 69);
            this.tbSpeed.TabIndex = 1;
            this.tbSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Download Speed";
            // 
            // tmrDownlaod
            // 
            this.tmrDownlaod.Tick += new System.EventHandler(this.tmrDownlaod_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyCompleted
            // 
            this.notifyCompleted.Text = "notifyIcon1";
            this.notifyCompleted.Visible = true;
            // 
            // MiniDownloadManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 431);
            this.Controls.Add(this.tabMain);
            this.Name = "MiniDownloadManager";
            this.Text = "MiniDownloadManager";
            this.Load += new System.EventHandler(this.MiniDownloadManager_Load);
            this.tabMain.ResumeLayout(false);
            this.tabNewDownload.ResumeLayout(false);
            this.tabNewDownload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFileCount)).EndInit();
            this.tabHistory.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabNewDownload;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressDownload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvHistory;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudFileCount;
        private System.Windows.Forms.Timer tmrDownlaod;
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.ColumnHeader colFileCount;
        private System.Windows.Forms.Label lblSpeedValue;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.CheckBox chkNotify;
        private System.Windows.Forms.NotifyIcon notifyCompleted;
        private System.Windows.Forms.Label lblCurrentFile;
    }
}