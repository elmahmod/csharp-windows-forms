using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicing
{
    public partial class MiniDownloadManager : Form
    {
        public MiniDownloadManager()
        {
            InitializeComponent();
        }

        private void MiniDownloadManager_Load(object sender, EventArgs e)
        {
            InitializeControls();
        }

        enum DownloadStatus
        {
            Ready,
            Downloading,
            Paused,
            Completed

        }
        DownloadStatus currentStatus = DownloadStatus.Ready;
        int currentFile = 0;
        int totalFiles = 0;
        void InitializeControls()
        {
            // progressDownload
            progressDownload.Minimum = 0;
            progressDownload.Maximum = 100;
            progressDownload.Step = 5; // for .PerformStep()

            // nudFileCount
            nudFileCount.Minimum = 1;
            nudFileCount.Maximum = 5;

            // btnPauseResume
            btnPauseResume.Tag = "Pause";
            btnPauseResume.Enabled = false;

            // lvHistory
            lvHistory.MultiSelect = false;
            lvHistory.GridLines = true;
            lvHistory.View = View.Details;

            // chkNotify
            chkNotify.Checked = false;

            // tbSpeed
            tbSpeed.Minimum = 1;
            tbSpeed.Maximum = 10;
            tbSpeed.TickStyle = TickStyle.TopLeft;
            tbSpeed.TickFrequency = 1;
            tbSpeed.LargeChange = tbSpeed.Maximum / 2;
            tbSpeed.SmallChange = 1;

            // tmrDownlaod
            tmrDownlaod.Interval = 200;
            tmrDownlaod.Enabled = false;

            // errorProvider1
            errorProvider1.BlinkRate = 500;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            // notifyCompleted
            notifyCompleted.Icon = SystemIcons.Information;
            notifyCompleted.Visible = false;

            // downloading percentage
            UpdateDownloadPercentage();

            // Downlading Status
            UpdateDownloadStatus();

            // Numeric
            UpdateCurrentFile();

            // lbl speed
            lblSpeedValue.Text = tbSpeed.Value.ToString();
        }

        void StartDownload()
        {
            currentFile = 1;
            totalFiles = (int)nudFileCount.Value;
            UpdateCurrentFile();

            progressDownload.Value = 0;
            UpdateDownloadPercentage();

            btnPauseResume.Text = "Pause";
            btnPauseResume.Enabled = true;

            txtFileName.Enabled = false;
            nudFileCount.Enabled = false;

            currentStatus = DownloadStatus.Downloading;
            UpdateDownloadStatus();

            tmrDownlaod.Start();
        }

        void UpgradePorgressBar()
        {
            progressDownload.Value = Math.Min(progressDownload.Value + tbSpeed.Value, progressDownload.Maximum);
            UpdateDownloadPercentage();
        }

        void NotifyMe(string title, string caption)
        {
            notifyCompleted.BalloonTipTitle = title;
            notifyCompleted.BalloonTipText = caption;
            notifyCompleted.BalloonTipIcon = ToolTipIcon.Info;
            notifyCompleted.Visible = true;
            notifyCompleted.ShowBalloonTip(500);
        }

        void CompletedDownload()
        {
            tmrDownlaod.Stop();

            currentStatus = DownloadStatus.Completed;
            UpdateDownloadStatus();

            btnPauseResume.Enabled = false;

            txtFileName.Enabled = true;
            nudFileCount.Enabled = true;

            MessageBox.Show("Download Compelted");

            if (chkNotify.Checked)
                NotifyMe(txtFileName.Text, "Completed.");
        }

        bool IsValidateTextBox()
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                errorProvider1.SetError(txtFileName, "Enter file name!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtFileName, "");
                return true;
            }
        }

        bool IsCompleted()
        {
            return progressDownload.Value == progressDownload.Maximum;
        }

        void ResetNewDownload()
        {
            // Stop Timer
            tmrDownlaod.Stop();

            // Reset Progress
            progressDownload.Value = progressDownload.Minimum;

            // Reset File Count
            nudFileCount.Value = nudFileCount.Minimum;

            // Reset Pause/Resume Button
            btnPauseResume.Text = "Pause";
            btnPauseResume.Enabled = false;

            // Clear Inputs and Errors
            txtFileName.Clear();
            errorProvider1.Clear();

            // Reset Status
            currentStatus = DownloadStatus.Ready;

            // Reset File Numbers
            currentFile = 0;
            totalFiles = 0;
            UpdateCurrentFile();

            txtFileName.Enabled = true;
            nudFileCount.Enabled = true;

            // Update UI
            UpdateDownloadPercentage();
            UpdateDownloadStatus();
        }

        void UpdateDownloadPercentage()
        {
            lblPercentage.Text = progressDownload.Value.ToString() + "%";
        }

        void UpdateCurrentFile()
        {
            lblCurrentFile.Text = $"{currentFile} of {totalFiles}";
        }

        void UpdateDownloadStatus()
        {
            lblStatus.Text = currentStatus.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!IsValidateTextBox())
                return;

            if (currentStatus == DownloadStatus.Downloading || currentStatus == DownloadStatus.Paused)
                return;

            StartDownload();
        }

        void StartNextFile()
        {
            currentFile++;
            progressDownload.Value = 0;

            UpdateCurrentFile();
            UpdateDownloadPercentage();
        }

        void AddItemToHistory()
        {
            ListViewItem item = new ListViewItem(txtFileName.Text);
            item.SubItems.Add(currentFile.ToString());
            item.SubItems.Add("Completed");
            lvHistory.Items.Add(item);
        }

        private void tmrDownlaod_Tick(object sender, EventArgs e)
        {
            if (!IsCompleted())
            {
                UpgradePorgressBar();
            }

            if (IsCompleted())
            {
                AddItemToHistory();
                if (currentFile < totalFiles)
                {
                    StartNextFile();
                }
                else
                {
                    CompletedDownload();
                }
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                errorProvider1.SetError(txtFileName, "");
            }
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            if (currentStatus == DownloadStatus.Downloading)
            {
                tmrDownlaod.Stop();
                currentStatus = DownloadStatus.Paused;

                btnPauseResume.Text = "Resume";
            }
            else if (currentStatus == DownloadStatus.Paused)
            {
                tmrDownlaod.Start();
                currentStatus = DownloadStatus.Downloading;

                btnPauseResume.Text = "Pause";
            }

            UpdateDownloadStatus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetNewDownload();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lvHistory.Items.Clear();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lvHistory.SelectedItems.Count <= 0)
                return;
            ListViewItem item = lvHistory.SelectedItems[0];
            lvHistory.Items.Remove(item);
        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            chkNotify.Checked = false;
            tbSpeed.Value = tbSpeed.Minimum;
            lblSpeedValue.Text = tbSpeed.Value.ToString();
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            lblSpeedValue.Text = tbSpeed.Value.ToString();
        }

    }
}
