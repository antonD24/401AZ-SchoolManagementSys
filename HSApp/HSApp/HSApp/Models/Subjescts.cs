using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Models
{
    public abstract class Subjescts
    {
        public int SubjectID { get; set; }

        public string SubjectName { get; set; }

        public string SubjectDesc { get; set; }

        public DateTime CStartDate { get; set; }

        public DateTime CEndDate { get; set; }
        
        public string BuildingName { get; set; }

    }
}
