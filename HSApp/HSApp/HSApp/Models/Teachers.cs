﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Models
{
    public class Teachers : Address
    {
        public int TeacherID  { get; set; }

        public string TeacherFName { get; set; }

        public string TeacherLname { get; set; }

        public DateTime DOB { get; set; }

        public string Tgender { get; set; }

        public string Temail { get; set; }

        public string Tphone { get; set; }
        


    
    }   
}
