using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HSApp.Models
{
    public class Courses 
    {
        public int CourseID { get; set; }

        private Subject _subject = new Subject();
        public int SubjectID { get; set; }

        public string SubjectName { get; set; }

        public string BuildingName { get; set; }

        private Teachers _teachers = new Teachers();
        public int TeacherID { get; set; }
        public string TeacherFName { get; set; }

        public string TeacherLname { get; set; }

        private Address _address = new Address();
        public int AddressID { get; set; }

        public string Address1 { get; set; }

        public string County { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }

        



    }
    


}
