using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class frmStudentDetails : Form
    {
        public frmStudentDetails(List<Student> _studentsList)
        {
            InitializeComponent();
            currentMode = FormMode.AddMode;
            studentsList = _studentsList;
        }

        public frmStudentDetails(Student _student)
        {
            InitializeComponent();
            currentMode = FormMode.EditMode;
            currentStudent = _student;
        }

        // Variables
        List<Student> studentsList;

        Student currentStudent;

        enum FormMode
        {
            EditMode,
            AddMode
        }
        FormMode currentMode;

        // load
        private void frmStudentDetails_Load(object sender, EventArgs e)
        {
            if (currentMode == FormMode.EditMode)
            {
                LoadStudentDetails();
                this.Text = "Edit Student";
                btnSaveStudent.Text = "Save Changes";
                txtStudentID.ReadOnly = true;

                this.Icon = new Icon(new MemoryStream(Properties.Resources.user_edit_icon_241064));
            }
            else
            {
                this.Text = "Add Student";
                btnSaveStudent.Text = "Save Student";
                this.Icon = new Icon(new MemoryStream(Properties.Resources.add_user_icon_184116));
            }
        }

        // methods
        void LoadStudentDetails()
        {
            txtStudentID.Text = currentStudent.StudentID.ToString();
            txtFullName.Text = currentStudent.FullName;
            if (currentStudent.Gender == rbFemale.Text)
                rbFemale.Checked = true;
            else
                rbMale.Checked = true;
            dtpBirthDate.Value = currentStudent.BirthDate;
            pbStudentPhoto.ImageLocation = currentStudent.PhotoPath;

            cbDepartment.SelectedItem = currentStudent.Department;
            cbStudentStatus.SelectedItem = currentStudent.StudentStatus;
            nudYear.Value = currentStudent.AcademicYear;
            dtpEnrollmentDate.Value = currentStudent.EnrollmentDate;
        }

        bool IsValidFullName()
        {
            foreach (char c in txtFullName.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckPersonalInfoInputs()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || !int.TryParse(txtStudentID.Text, out int ID) || ID <= 0)
            {
                errorProvider1.SetError(txtStudentID, "Required!!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || !IsValidFullName())
            {
                errorProvider1.SetError(txtFullName, "Required!!");
                return false;
            }

            if (!rbFemale.Checked && !rbMale.Checked)
            {
                errorProvider1.SetError(lblGender, "Choose!");
                return false;
            }

            if (dtpBirthDate.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpBirthDate, "uncorrect date!");
                return false;
            }

            if (pbStudentPhoto.Image == null)
            {
                errorProvider1.SetError(pbStudentPhoto, "Select Picture!");
                return false;
            }

            return true;
        }

        bool CheckAcademicInfoInputs()
        {
            if (cbDepartment.SelectedIndex < 0)
            {
                errorProvider1.SetError(cbDepartment, "Select One!");
                return false;
            }

            if (cbStudentStatus.SelectedIndex < 0)
            {
                errorProvider1.SetError(cbStudentStatus, "Select One!");
                return false;
            }

            return true;
        }

        void RemoveErrorProvider(Control sender)
        {
            errorProvider1.SetError(sender, "");
        }

        bool DoesStudentExist(int studentId)
        {
            foreach (Student student in studentsList)
            {
                if (student.StudentID == studentId)
                {
                    return true;
                }
            }
            return false;
        }

        Student GetStudentDetails()
        {
            Student student = new Student();
            student.StudentID = int.Parse(txtStudentID.Text);
            student.FullName = txtFullName.Text;
            if (rbFemale.Checked)
                student.Gender = rbFemale.Text;
            else
                student.Gender = rbMale.Text;
            student.PhotoPath = openFileDialog1.FileName;
            student.BirthDate = dtpBirthDate.Value;

            student.Department = cbDepartment.SelectedItem.ToString();
            student.StudentStatus = cbStudentStatus.SelectedItem.ToString();
            student.AcademicYear = (int)nudYear.Value;
            student.EnrollmentDate = dtpEnrollmentDate.Value;

            return student;
        }

        // Events
        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStudentID.Text) && int.TryParse(txtStudentID.Text, out int ID) && ID > 0)
            {
                RemoveErrorProvider(txtStudentID);
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFullName.Text) && IsValidFullName())
            {
                RemoveErrorProvider(txtFullName);
            }
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (!CheckPersonalInfoInputs())
            {
                tabsStudentInfo.SelectedIndex = 0;
                return;
            }

            if (!CheckAcademicInfoInputs())
            {
                tabsStudentInfo.SelectedIndex = 1;
                return;
            }

            if (currentMode == FormMode.AddMode)
            {
                Student student = GetStudentDetails();

                if (DoesStudentExist(student.StudentID))
                {
                    MessageBox.Show($"Student with [{student.StudentID}] Already Exists Try Another");
                    tabsStudentInfo.SelectedIndex = 0;
                    txtStudentID.Focus();
                    return;
                }

                studentsList.Add(student);
            }
            else
            {
                currentStudent.FullName = txtFullName.Text;
                if (rbFemale.Checked)
                    currentStudent.Gender = rbFemale.Text;
                else
                    currentStudent.Gender = rbMale.Text;
                if (!string.IsNullOrWhiteSpace( openFileDialog1.FileName))
                    currentStudent.PhotoPath = openFileDialog1.FileName;
                currentStudent.BirthDate = dtpBirthDate.Value;

                currentStudent.Department = cbDepartment.SelectedItem.ToString();
                currentStudent.StudentStatus = cbStudentStatus.SelectedItem.ToString();
                currentStudent.AcademicYear = (int)nudYear.Value;
                currentStudent.EnrollmentDate = dtpEnrollmentDate.Value;
            }



            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void rbFemaleAndMale_CheckedChanged(object sender, EventArgs e)
        {
            RemoveErrorProvider(lblGender);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBirthDate.Value <= DateTime.Now)
                RemoveErrorProvider(dtpBirthDate);

        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbStudentPhoto.ImageLocation = openFileDialog1.FileName;
                if (pbStudentPhoto.Image != null)
                    RemoveErrorProvider(pbStudentPhoto);
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedIndex >= 0)
                RemoveErrorProvider(cbDepartment);
        }

        private void cbStudentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudentStatus.SelectedIndex >= 0)
                RemoveErrorProvider(cbStudentStatus);
        }
    }
}
