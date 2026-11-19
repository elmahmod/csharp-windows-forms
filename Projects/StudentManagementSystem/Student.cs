using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string PhotoPath { get; set; }

        public string Department { get; set; }
        public int AcademicYear { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string StudentStatus { get; set; }
    }
}
