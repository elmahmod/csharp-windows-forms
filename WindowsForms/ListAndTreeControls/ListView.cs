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
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void ListView_Load(object sender, EventArgs e)
        {
            rbDetails.Checked = true;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.SmallImageList = imageListSmall;
            listView1.LargeImageList = imageListLarge;

            btnSave.Enabled = false;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                return;
            }

            ListViewItem item = new ListViewItem(txtId.Text);
            item.SubItems.Add(txtName.Text);

            if (rbMale.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;

            listView1.Items.Add(item);

            txtId.Text = "";
            txtName.Text = "";
            txtId.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add("person " + (i + 1));
                if (i % 2 == 0)
                    item.ImageIndex = 0;
                else
                    item.ImageIndex = 1;

                listView1.Items.Add(item);
            }
        }

        private void rbView_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;

            if (!btn.Checked)
                return;

            if (btn == rbDetails)
                listView1.View = View.Details;
            else if (btn == rbTitle)
                listView1.View = View.Tile;
            else if (btn == rbSmallIcon)
                listView1.View = View.SmallIcon;
            else if (btn == rbLargeIcon)
                listView1.View = View.LargeIcon;
            else if (btn == rbList)
                listView1.View = View.List;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
                return;

            btnAdd.Enabled = false;
            btnSave.Enabled = true;


            txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;

            if (listView1.SelectedItems[0].ImageIndex == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                return;
            }

            listView1.SelectedItems[0].SubItems[0].Text = txtId.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txtName.Text;

            if (rbMale.Checked)
                listView1.SelectedItems[0].ImageIndex = 0;
            else
                listView1.SelectedItems[0].ImageIndex = 1;

            txtId.Clear();
            txtName.Clear();

            btnAdd.Enabled = true;
            btnSave.Enabled = false;

            txtId.Focus();
        }
    }
}
