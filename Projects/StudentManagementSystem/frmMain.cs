using StudentManagementSystem.Properties;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            studentsForm = new frmStudents(studentsList);
        }

        // variables
        frmStudents studentsForm;

        List<Student> studentsList = new List<Student>();
        Random random = new Random();

        enum StatusAction
        {
            Ready,
            Added,
            Updated,
            Deleted
        }

        StatusAction currentStatus;

        // load
        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeForm();

            UpdateTotalStudentCount();
            UpdateStatus();
        }

        // methods
        void InitializeForm()
        {
            currentStatus = StatusAction.Ready;
            this.Icon = new Icon(new MemoryStream( Properties.Resources.student_3540));
        }

        void UpdateTotalStudentCount()
        {
            lblTotalStudents.Text = "Total Students [" + studentsList.Count.ToString() + "]";
        }

        void UpdateStatus()
        {
            switch (currentStatus)
            {
                case StatusAction.Ready:
                    lblStatus.Text = "Ready";
                    break;
                case StatusAction.Updated:
                    lblStatus.Text = "Student Updated Successfully";
                    break;
                case StatusAction.Added:
                    lblStatus.Text = "Student Added Successfully";
                    break;
                case StatusAction.Deleted:
                    lblStatus.Text = "Student Deleted Successfully";
                    break;
                default:
                    lblStatus.Text = "NONE";
                    break;
            }
        }

        Student GetRandomStudent()
        {
            string[] names =
            {
        "Ahmed Ali",
        "Mohammed Hassan",
        "Omar Khaled",
        "Sara Ahmed",
        "Fatima Ali",
        "Yusuf Ibrahim",
        "Zainab Mahmoud",
        "Ali Mustafa"
    };

            string[] departments =
            {
        "Computer Engineering",
        "Software Engineering",
        "Electrical Engineering",
        "Mechanical Engineering",
        "Civil Engineering"
    };

            string[] statuses =
            {
        "Active",
        "Graduated",
        "Suspended"
    };

            string[] genders = { "Male", "Female" };

            Student student = new Student();

            // Generate Unique Student ID
            bool exists;

            do
            {
                student.StudentID = random.Next(1000, 100000);
                exists = false;

                foreach (Student s in studentsList)
                {
                    if (s.StudentID == student.StudentID)
                    {
                        exists = true;
                        break;
                    }
                }

            } while (exists);

            // Personal Information
            student.FullName = names[random.Next(names.Length)];
            student.Gender = genders[random.Next(genders.Length)];

            student.BirthDate = new DateTime(
                random.Next(2000, 2008),
                random.Next(1, 13),
                random.Next(1, 29)
            );

            // photo
            string folderName = student.Gender == "Male" ? "boys" : "girls";

            string folderPath = Path.Combine(
                @"C:\Users\horo\Desktop\Repos\csharp-windows-forms\Projects\StudentManagementSystem\images",
                folderName
            );

            if (Directory.Exists(folderPath))
            {
                string[] photos = Directory.GetFiles(folderPath);

                if (photos.Length > 0)
                    student.PhotoPath = photos[random.Next(photos.Length)];
            }

            // Academic Information
            student.Department = departments[random.Next(departments.Length)];
            student.AcademicYear = random.Next(1, 5);
            student.StudentStatus = statuses[random.Next(statuses.Length)];
            student.EnrollmentDate = DateTime.Today.AddDays(-random.Next(0, 1460));

            return student;
        }

        public void OnStudentsDeleted()
        {
            currentStatus = StatusAction.Deleted;
            UpdateStatus();
            UpdateTotalStudentCount();
        }
        public void OnStudentsAdded()
        {
            currentStatus = StatusAction.Added;
            UpdateStatus();
            UpdateTotalStudentCount();
        }
        public void OnStudentUpdated()
        {
            currentStatus = StatusAction.Updated;
            UpdateStatus();
            UpdateTotalStudentCount();
        }

        // Events
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuViewStudents_Click(object sender, EventArgs e)
        {
            if (studentsForm.IsDisposed)
            {
                studentsForm = new frmStudents(studentsList);
            }

            studentsForm.MdiParent = this;
            studentsForm.Show();
            studentsForm.Activate();
        }

        private void mnuAddStudents_Click(object sender, EventArgs e)
        {
            frmStudentDetails studentDetailsForm = new frmStudentDetails(studentsList);

            if (studentDetailsForm.ShowDialog(this) == DialogResult.Yes)
            {
                if (!studentsForm.IsDisposed)
                    studentsForm.UpdateStudentList();

                currentStatus = StatusAction.Added;

                UpdateStatus();
                UpdateTotalStudentCount();

            }

            studentDetailsForm.Dispose();
        }

        private void fillWithRandomStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rndNumber = random.Next(5, 11);
            for (int i = 0; i < rndNumber; i++)
            {
                studentsList.Add(GetRandomStudent());
            }
            currentStatus = StatusAction.Added;

            if (!studentsForm.IsDisposed)
                studentsForm.UpdateStudentList();

            UpdateStatus();
            UpdateTotalStudentCount();
        }
    }
}
