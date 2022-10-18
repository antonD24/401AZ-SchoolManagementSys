using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Models
{
    internal class Students : Address
    {
        public int studentID { get; set; }

        public string Sfname { get; set; }
        
        public string Slanem { get; set; }

        public DateTime DOB  { get; set; }

        public string Sgender { get; set; }

        public int Addr { get; set; }
    }
}
