using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Models
{
    internal class Timetable
    {
        public int Timetable_ID { get; set; }

        public string TimetableName { get; set; }

        public byte[] TimetableData { get; set; }
    }
}
