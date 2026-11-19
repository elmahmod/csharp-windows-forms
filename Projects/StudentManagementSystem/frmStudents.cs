using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class frmStudents : Form
    {
        public frmStudents(List<Student> _studentsList)
        {
            InitializeComponent();
            studentsList = _studentsList;
        }

        // variables
        List<Student> studentsList;

        // load
        private void frmStudents_Load(object sender, EventArgs e)
        {
            cbView.SelectedIndex = 0;
            this.Icon = new Icon(new MemoryStream(Properties.Resources.school_students_icon_144607));
            UpdateStudentList();
        }

        // methods
        ListViewItem GetStudentItemToList(Student student)
        {
            ListViewItem item = new ListViewItem(student.StudentID.ToString());
            item.SubItems.Add(student.FullName);
            item.SubItems.Add(student.Department);
            item.SubItems.Add(student.AcademicYear.ToString());
            item.SubItems.Add(student.Gender);
            item.SubItems.Add(student.BirthDate.ToShortDateString());
            item.SubItems.Add(student.StudentStatus);
            item.SubItems.Add(student.EnrollmentDate.ToShortDateString());
            return item;
        }

        public void UpdateStudentList()
        {
            lvStudents.Items.Clear();
            imgStudentPhotos.Images.Clear();

            foreach (Student student in studentsList)
            {
                if (student.FullName.ToLower().Contains(txtSearch.Text.ToLower()) || student.StudentID.ToString().Contains(txtSearch.Text))
                {
                    ListViewItem item = GetStudentItemToList(student);

                    if (File.Exists(student.PhotoPath))
                    {
                        imgStudentPhotos.Images.Add(Image.FromFile(student.PhotoPath));
                        item.ImageIndex = imgStudentPhotos.Images.Count - 1;
                    }

                    lvStudents.Items.Add(item);
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmStudentDetails studentDetails = new frmStudentDetails(studentsList);
            if (studentDetails.ShowDialog() == DialogResult.Yes)
            {
                frmMain mainForm = (frmMain)this.MdiParent;
                mainForm.OnStudentsAdded();
                UpdateStudentList();
            }
            studentDetails.Dispose();

        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a student first!");
                return;
            }

            int selectedStudentId = int.Parse(lvStudents.SelectedItems[0].Text);
            Student selectedStudent = null;

            foreach (Student student in studentsList)
            {
                if (student.StudentID == selectedStudentId)
                {
                    selectedStudent = student;
                    break;
                }
            }

            if (selectedStudent == null)
            {
                MessageBox.Show("student Not Found!");
                return;
            }


            frmStudentDetails studentDetails = new frmStudentDetails(selectedStudent);
            if (studentDetails.ShowDialog() == DialogResult.Yes)
            {
                frmMain mainForm = (frmMain)this.MdiParent;
                mainForm.OnStudentUpdated();
                UpdateStudentList();
            }
            studentDetails.Dispose();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count < 1)
                return;

            if (MessageBox.Show(
                "Are you sure you want to delete the selected students?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            bool isDeleted = false;

            foreach (ListViewItem item in lvStudents.SelectedItems)
            {
                int studentId = int.Parse(item.Text);

                Student selectedStudent = null;

                foreach (Student student in studentsList)
                {
                    if (studentId == student.StudentID)
                    {
                        selectedStudent = student;
                        break;
                    }
                }

                if (selectedStudent != null)
                {
                    studentsList.Remove(selectedStudent);
                    isDeleted = true;
                }
            }

            if (!isDeleted)
                return;

            frmMain mainForm = (frmMain)this.MdiParent;
            mainForm.OnStudentsDeleted();

            UpdateStudentList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateStudentList();
        }

        private void mnuEditStudent_Click(object sender, EventArgs e)
        {
            btnEditStudent.PerformClick();
        }

        private void mnuDeleteStudent_Click(object sender, EventArgs e)
        {
            btnDeleteStudent.PerformClick();
        }

        private void lvStudents_DoubleClick(object sender, EventArgs e)
        {
            btnEditStudent.PerformClick();
        }

        private void cbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbView.SelectedIndex == 0)
            {
                lvStudents.View = View.Details;
            }
            else if (cbView.SelectedIndex == 1)
            {
                lvStudents.View = View.LargeIcon;
            }
            else
            {
                lvStudents.View = View.Tile;
            }
        }
    }
}
