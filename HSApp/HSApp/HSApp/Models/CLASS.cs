using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Models
{
    internal class CLASS
    {
        public int ClassID { get; set; }

        public string Room { get; set; }

        private Teachers _teachers = new Teachers();
        
        public int TeacherID { get; set; }

        public string TeacherFName { get; set; }

        public string TeacherLname { get; set; }

        /* Since C# does not support INHERITANCE of multiple Classes,
         * Interfaces can be used to simulate INHERITANCE and achieve INNER JOINS for the information in our tables.
         */
        
        private Enrollments _erollments = new Enrollments();
        public int EnrollmentID { get; set; }

        private Student _student = new Student();

        public int StudentID { get; set; }

        public string Sfname { get; set; }

        public string Slname { get; set; }

        private Timetable _timetable = new Timetable();

        public int Timetable_ID { get; set; }

        public string TimetableName { get; set; }

        

        private Materials _materials = new Materials();

        public int Material_ID { get; set; }

        public string MaterialName { get; set; }

        


    }
}
