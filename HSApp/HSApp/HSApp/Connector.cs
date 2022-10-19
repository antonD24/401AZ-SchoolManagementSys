using HSApp.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSApp
{
    public class Connector 
    {
        private string connString = "Server= database401az.c24bjpnpsv1x.us-east-1.rds.amazonaws.com; User ID = admin; Password=02041957; Database=H_SEducateDB;";

        List<Address> getAddresses()
        {
            List<Address> addresses = new List<Address>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("CALL sp_getAddresses()" ,conn))
                    using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        addresses.Add(new Address
                        {
                            AddressID = reader.GetInt32(0),
                            Address1 = reader.GetString(1),
                            County = reader.GetString(2),
                            City = reader.GetString(3),
                            Postcode = reader.GetString(4),
                        });
                    }
            }
            return addresses;
        }
    }
}
