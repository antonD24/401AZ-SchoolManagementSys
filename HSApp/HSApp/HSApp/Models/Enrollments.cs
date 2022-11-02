using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Models
{
    internal class Enrollments
    {
        public int EnrollmentID { get; set; }

        private Student _student = new Student();

        public int StudentID { get; set; }

        public string Sfname { get; set; }

        public string Slname { get; set; }

        private Courses _courses = new Courses();
        public int CourseID { get; set; }

        public int SubjectID { get; set; }

        public string SubjectName { get; set; }

        public DateTime DOE { get; set; }


    }
}
