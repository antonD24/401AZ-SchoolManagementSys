using HSApp.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSApp
{
    public class Connector 
    {
        private string connString = "Server= database401az.c24bjpnpsv1x.us-east-1.rds.amazonaws.com; User ID = admin; Password=02041957; Database=H_SEducateDB";

        public List<Address> getAddresses()
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
         async public void InsertAddr(Address add)
            {
            using(var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_InsertAddress(@p1,@p2,@p3,@p4)";
                    cmd.Parameters.AddWithValue("p1", add.Address1);
                    cmd.Parameters.AddWithValue("p2", add.County);
                    cmd.Parameters.AddWithValue("p3", add.City);
                    cmd.Parameters.AddWithValue("p4", add.Postcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void UpdateAddr(Address add)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_UpdateAddress(@p1,@p2,@p3,@p4,@p5)";
                    cmd.Parameters.AddWithValue("p1", add.AddressID);
                    cmd.Parameters.AddWithValue("p2", add.Address1);
                    cmd.Parameters.AddWithValue("p3", add.County);
                    cmd.Parameters.AddWithValue("p4", add.City);
                    cmd.Parameters.AddWithValue("p5", add.Postcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void DeleteAddr(Address add)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_deleteAddress(@p1)";
                    cmd.Parameters.AddWithValue("p1", add.AddressID);
                    
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }







    } 
    



}
