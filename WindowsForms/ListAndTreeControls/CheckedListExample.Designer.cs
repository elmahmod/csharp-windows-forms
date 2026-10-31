namespace ListAndTreeControls
{
    partial class CheckedListExample
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
            this.chklistTaks = new System.Windows.Forms.CheckedListBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemoveCheckedTask = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRemainingTask = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCompletedTasks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTasksNumber = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chklistTaks
            // 
            this.chklistTaks.FormattingEnabled = true;
            this.chklistTaks.Location = new System.Drawing.Point(560, 89);
            this.chklistTaks.Name = "chklistTaks";
            this.chklistTaks.Size = new System.Drawing.Size(337, 280);
            this.chklistTaks.TabIndex = 0;
            this.chklistTaks.SelectedIndexChanged += new System.EventHandler(this.chklistTaks_SelectedIndexChanged);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(50, 103);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(148, 39);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnRemoveCheckedTask
            // 
            this.btnRemoveCheckedTask.Location = new System.Drawing.Point(78, 262);
            this.btnRemoveCheckedTask.Name = "btnRemoveCheckedTask";
            this.btnRemoveCheckedTask.Size = new System.Drawing.Size(188, 48);
            this.btnRemoveCheckedTask.TabIndex = 2;
            this.btnRemoveCheckedTask.Text = "Remove checked list";
            this.btnRemoveCheckedTask.UseVisualStyleBackColor = true;
            this.btnRemoveCheckedTask.Click += new System.EventHandler(this.btnRemoveCheckedTask_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(315, 262);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(188, 48);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remaining Tasks: ";
            // 
            // lblRemainingTask
            // 
            this.lblRemainingTask.AutoSize = true;
            this.lblRemainingTask.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRemainingTask.Location = new System.Drawing.Point(739, 425);
            this.lblRemainingTask.Name = "lblRemainingTask";
            this.lblRemainingTask.Size = new System.Drawing.Size(134, 20);
            this.lblRemainingTask.TabIndex = 5;
            this.lblRemainingTask.Text = "lblRemainingTask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "you have completed";
            // 
            // lblCompletedTasks
            // 
            this.lblCompletedTasks.AutoSize = true;
            this.lblCompletedTasks.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblCompletedTasks.Location = new System.Drawing.Point(239, 561);
            this.lblCompletedTasks.Name = "lblCompletedTasks";
            this.lblCompletedTasks.Size = new System.Drawing.Size(51, 20);
            this.lblCompletedTasks.TabIndex = 7;
            this.lblCompletedTasks.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "out of ";
            // 
            // lblTasksNumber
            // 
            this.lblTasksNumber.AutoSize = true;
            this.lblTasksNumber.Location = new System.Drawing.Point(417, 561);
            this.lblTasksNumber.Name = "lblTasksNumber";
            this.lblTasksNumber.Size = new System.Drawing.Size(51, 20);
            this.lblTasksNumber.TabIndex = 9;
            this.lblTasksNumber.Text = "label4";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(217, 116);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(274, 26);
            this.txtTask.TabIndex = 10;
            // 
            // CheckedList_example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 653);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTasksNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCompletedTasks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRemainingTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveCheckedTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.chklistTaks);
            this.DoubleBuffered = true;
            this.Name = "CheckedList_example";
            this.Text = "to do list";
            this.Load += new System.EventHandler(this.CheckedList_example_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklistTaks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveCheckedTask;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRemainingTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCompletedTasks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTasksNumber;
        private System.Windows.Forms.TextBox txtTask;
    }
}