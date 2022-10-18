using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Models
{
    public abstract class Address
    {
        public int AddressID { get; set; }
        public string Address1 { get; set; }

        public string County { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    }
}
