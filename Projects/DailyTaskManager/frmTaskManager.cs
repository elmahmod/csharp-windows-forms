using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTaskManager
{
    public partial class frmTaskManager : Form
    {
        public frmTaskManager()
        {
            InitializeComponent();
        }
        class TaskItem
        {
            public string name { get; set; }
            public string category { get; set; }
            public DateTime dueDate { get; set; }
            public bool isReminded { get; set; } = false;
            public override string ToString()
            {
                return $"[{category}] {name} - {dueDate:dd/MM/yyyy (HH:mm)}";
            }
        }
        private void frmTaskManager_Load(object sender, EventArgs e)
        {
            InitializeCategories();
            InitializeTimer();
            InitializeNotify();
            UpdateSummary();
        }
        void InitializeCategories()
        {
            cbCategory.Items.Add("Study");
            cbCategory.Items.Add("Work");
            cbCategory.Items.Add("Personal");
            cbCategory.Items.Add("Shopping");
            cbCategory.Items.Add("Other");

            cbCategory.SelectedIndex = 0;
        }

        void InitializeTimer()
        {
            tmrReminders.Interval = 1000;
            tmrReminders.Start();
        }

        void InitializeNotify()
        {
            notifyTask.Icon = SystemIcons.Information;
            notifyTask.Visible = true;
        }

        TaskItem GetTaskItem()
        {
            TaskItem taskItem = new TaskItem();
            taskItem.name = txtTaskName.Text;
            taskItem.category = cbCategory.SelectedItem.ToString();
            taskItem.dueDate = dtpTaskDate.Value;
            return taskItem;
        }

        bool ValidateTask()
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Please enter a task name.");
                txtTaskName.Focus();
                return false;
            }

            if (dtpTaskDate.Value < DateTime.Now)
            {
                MessageBox.Show("Please enter a valid date.");
                dtpTaskDate.Focus();
                return false;

            }
            return true;
        }
        void AddTask()
        {
            if (!ValidateTask())
                return;

            clbTasks.Items.Add(GetTaskItem());
            txtTaskName.Text = "";
            txtTaskName.Focus();
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTask();
            UpdateSummary();
        }

        void UpdateSummary()
        {
            UpdateTotal(); UpdateRemaining(); UpdateCompleted();
        }

        void UpdateTotal()
        {
            lblTotal.Text = clbTasks.Items.Count.ToString()
                + Environment.NewLine + "Total";
        }
        void UpdateRemaining()
        {
            lblRemaining.Text = (clbTasks.Items.Count - clbTasks.CheckedItems.Count).ToString()
                + Environment.NewLine + "Remaining";
        }
        void UpdateCompleted()
        {
            lblCompleted.Text = clbTasks.CheckedItems.Count.ToString()
                + Environment.NewLine + "Completed"; ;
        }

        private void btnClearCompleted_Click(object sender, EventArgs e)
        {
            if (clbTasks.CheckedItems.Count <= 0)
                return;

            for (int i = clbTasks.Items.Count - 1; i >= 0; i--)
            {
                if (clbTasks.GetItemChecked(i))
                {
                    clbTasks.Items.RemoveAt(i);
                }
            }
            UpdateSummary();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (clbTasks.SelectedIndex == -1)
                return;

            clbTasks.Items.Remove(clbTasks.SelectedItem);
            UpdateSummary();
        }

        private void clbTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(new Action(UpdateSummary));
        }

        void ShowNotify(TaskItem task)
        {
            notifyTask.BalloonTipTitle = "Task Reminder";
            notifyTask.BalloonTipText = "it's time to " + task.name;

            notifyTask.ShowBalloonTip(3000);
        }

        void CheckReminders()
        {
            for (int i = 0; i < clbTasks.Items.Count; i++)
            {
                TaskItem task = (TaskItem)clbTasks.Items[i];

                if (!task.isReminded && !clbTasks.GetItemChecked(i) && task.dueDate <= DateTime.Now)
                {
                    ShowNotify(task);
                    task.isReminded = true;
                }
            }
        }

        private void tmrReminders_Tick(object sender, EventArgs e)
        {
            CheckReminders();
        }
    }
}
