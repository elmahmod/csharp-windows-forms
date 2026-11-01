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

        private void frmTaskManager_Load(object sender, EventArgs e)
        {
            InitializeCategories();
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
    }
}
