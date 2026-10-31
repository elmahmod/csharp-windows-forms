using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAndTreeControls
{
    public partial class CheckedListExample : Form
    {
        public CheckedListExample()
        {
            InitializeComponent();
        }

        void CalculateRemainingTask()
        {
            lblRemainingTask.Text = (chklistTaks.Items.Count - chklistTaks.CheckedItems.Count).ToString();
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTask.Text))
                return;

            chklistTaks.Items.Add(txtTask.Text);
            txtTask.Text = "";
            txtTask.Focus();
            CalculateRemainingTask();
            lblTasksNumber.Text = chklistTaks.Items.Count.ToString();

        }

        private void CheckedList_example_Load(object sender, EventArgs e)
        {
            CalculateRemainingTask();
            CalculateCompletedTask();
            lblTasksNumber.Text = chklistTaks.Items.Count.ToString();
        }

        private void chklistTaks_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateRemainingTask();
            CalculateCompletedTask();
        }

        private void btnRemoveCheckedTask_Click(object sender, EventArgs e)
        {
            for (int i = chklistTaks.Items.Count; i >= 0; i--)
            {
                if (chklistTaks.GetItemChecked(i))
                {
                    chklistTaks.Items.RemoveAt(i);
                }
            }
            CalculateRemainingTask();
            CalculateCompletedTask();
            lblTasksNumber.Text = chklistTaks.Items.Count.ToString();
        }

        void CalculateCompletedTask()
        {
            lblCompletedTasks.Text = chklistTaks.CheckedItems.Count.ToString();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < chklistTaks.Items.Count; i++)
            //{
            //    chklistTaks.Items.RemoveAt(i);
            //}
            chklistTaks.Items.Clear();
            lblTasksNumber.Text = chklistTaks.Items.Count.ToString();
            CalculateRemainingTask();
            CalculateCompletedTask();
        }
    }
}
