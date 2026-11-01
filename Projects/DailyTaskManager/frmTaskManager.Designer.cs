namespace DailyTaskManager
{
    partial class frmTaskManager
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
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTaskDate = new System.Windows.Forms.DateTimePicker();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.grbAddTask = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnClearCompleted = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.clbTasks = new System.Windows.Forms.CheckedListBox();
            this.grbMyTasks = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.tmrReminders = new System.Windows.Forms.Timer(this.components);
            this.notifyTask = new System.Windows.Forms.NotifyIcon(this.components);
            this.grbAddTask.SuspendLayout();
            this.grbMyTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(22, 74);
            this.txtTaskName.Multiline = true;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(568, 33);
            this.txtTaskName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Due Date & Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // dtpTaskDate
            // 
            this.dtpTaskDate.CustomFormat = "  dd / MM / yyyy      HH:mm tt";
            this.dtpTaskDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTaskDate.Location = new System.Drawing.Point(295, 166);
            this.dtpTaskDate.Name = "dtpTaskDate";
            this.dtpTaskDate.Size = new System.Drawing.Size(295, 26);
            this.dtpTaskDate.TabIndex = 3;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(22, 164);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(257, 28);
            this.cbCategory.Sorted = true;
            this.cbCategory.TabIndex = 1;
            // 
            // grbAddTask
            // 
            this.grbAddTask.Controls.Add(this.btnAddTask);
            this.grbAddTask.Controls.Add(this.cbCategory);
            this.grbAddTask.Controls.Add(this.dtpTaskDate);
            this.grbAddTask.Controls.Add(this.label3);
            this.grbAddTask.Controls.Add(this.label2);
            this.grbAddTask.Controls.Add(this.txtTaskName);
            this.grbAddTask.Controls.Add(this.label1);
            this.grbAddTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbAddTask.Location = new System.Drawing.Point(0, 0);
            this.grbAddTask.Name = "grbAddTask";
            this.grbAddTask.Size = new System.Drawing.Size(611, 272);
            this.grbAddTask.TabIndex = 0;
            this.grbAddTask.TabStop = false;
            this.grbAddTask.Text = "Add Task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.AutoSize = true;
            this.btnAddTask.Location = new System.Drawing.Point(22, 223);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(568, 49);
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "Add Task +";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnClearCompleted
            // 
            this.btnClearCompleted.Location = new System.Drawing.Point(22, 244);
            this.btnClearCompleted.Name = "btnClearCompleted";
            this.btnClearCompleted.Size = new System.Drawing.Size(267, 44);
            this.btnClearCompleted.TabIndex = 1;
            this.btnClearCompleted.Text = "Clear Completed";
            this.btnClearCompleted.UseVisualStyleBackColor = true;
            this.btnClearCompleted.Click += new System.EventHandler(this.btnClearCompleted_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(323, 244);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(267, 44);
            this.btnRemoveSelected.TabIndex = 2;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(18, 339);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(86, 40);
            this.lblCompleted.TabIndex = 8;
            this.lblCompleted.Text = "1\r\nCompleted\r\n";
            this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clbTasks
            // 
            this.clbTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTasks.FormattingEnabled = true;
            this.clbTasks.Location = new System.Drawing.Point(22, 37);
            this.clbTasks.Name = "clbTasks";
            this.clbTasks.Size = new System.Drawing.Size(568, 188);
            this.clbTasks.TabIndex = 0;
            this.clbTasks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbTasks_ItemCheck);
            // 
            // grbMyTasks
            // 
            this.grbMyTasks.Controls.Add(this.lblTotal);
            this.grbMyTasks.Controls.Add(this.lblRemaining);
            this.grbMyTasks.Controls.Add(this.clbTasks);
            this.grbMyTasks.Controls.Add(this.lblCompleted);
            this.grbMyTasks.Controls.Add(this.btnRemoveSelected);
            this.grbMyTasks.Controls.Add(this.btnClearCompleted);
            this.grbMyTasks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbMyTasks.Location = new System.Drawing.Point(0, 312);
            this.grbMyTasks.Name = "grbMyTasks";
            this.grbMyTasks.Size = new System.Drawing.Size(611, 436);
            this.grbMyTasks.TabIndex = 1;
            this.grbMyTasks.TabStop = false;
            this.grbMyTasks.Text = "My Tasks";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(504, 339);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 40);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "1\r\nTotal";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(265, 339);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(85, 40);
            this.lblRemaining.TabIndex = 12;
            this.lblRemaining.Text = "1\r\nRemaining";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrReminders
            // 
            this.tmrReminders.Tick += new System.EventHandler(this.tmrReminders_Tick);
            // 
            // notifyTask
            // 
            this.notifyTask.Text = "notifyIcon1";
            this.notifyTask.Visible = true;
            // 
            // frmTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 748);
            this.Controls.Add(this.grbMyTasks);
            this.Controls.Add(this.grbAddTask);
            this.DoubleBuffered = true;
            this.Name = "frmTaskManager";
            this.Text = "Daily Task Manager";
            this.Load += new System.EventHandler(this.frmTaskManager_Load);
            this.grbAddTask.ResumeLayout(false);
            this.grbAddTask.PerformLayout();
            this.grbMyTasks.ResumeLayout(false);
            this.grbMyTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTaskDate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox grbAddTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnClearCompleted;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.CheckedListBox clbTasks;
        private System.Windows.Forms.GroupBox grbMyTasks;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Timer tmrReminders;
        private System.Windows.Forms.NotifyIcon notifyTask;
    }
}

