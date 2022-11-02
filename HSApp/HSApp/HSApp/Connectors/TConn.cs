using HSApp.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Connectors
{
    internal class TConn
    {
        private string connString = "Server= database401az.c24bjpnpsv1x.us-east-1.rds.amazonaws.com; User ID = admin; Password=02041957; Database=H_SEducateDB";

        public List<Teachers> getTeachers()
        {
            List<Teachers> teach = new List<Teachers>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("CALL sp_getTeacher()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        teach.Add(new Teachers
                        {
                            TeacherID = reader.GetInt32(0),
                            TeacherFName = reader.GetString(1),
                            TeacherLname = reader.GetString(2),
                            DOB = reader.GetDateTime(3),
                            Tgender = reader.GetString(4),
                            Temail = reader.GetString(5),
                            Tphone = reader.GetString(6),
                            AddressID = reader.GetInt32(7),
                            Address1 = reader.GetString(8),
                            County = reader.GetString(9),
                            City = reader.GetString(10),
                            Postcode = reader.GetString(11),
                        });
                    }
            }
            return teach;

        }
        async public void insertTeacher(Teachers Tconn)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_InsertTeacher(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                    cmd.Parameters.AddWithValue("p1", Tconn.TeacherFName);
                    cmd.Parameters.AddWithValue("p2", Tconn.TeacherLname);
                    cmd.Parameters.AddWithValue("p3", Tconn.DOB);
                    cmd.Parameters.AddWithValue("p4", Tconn.Tgender);
                    cmd.Parameters.AddWithValue("p5", Tconn.Temail);
                    cmd.Parameters.AddWithValue("p6", Tconn.Tphone);
                    cmd.Parameters.AddWithValue("p7", Tconn.AddressID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void UpdateTeacher(Teachers Tconn)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_UpdateTeacher(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                    cmd.Parameters.AddWithValue("p1", Tconn.TeacherID);
                    cmd.Parameters.AddWithValue("p2", Tconn.TeacherFName);
                    cmd.Parameters.AddWithValue("p3", Tconn.TeacherLname);
                    cmd.Parameters.AddWithValue("p4", Tconn.DOB);
                    cmd.Parameters.AddWithValue("p5", Tconn.Tgender);
                    cmd.Parameters.AddWithValue("p6", Tconn.Temail);
                    cmd.Parameters.AddWithValue("p7", Tconn.Tphone);
                    cmd.Parameters.AddWithValue("p8", Tconn.AddressID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void DeleteTeacher(Teachers Tconn)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_deleteTeacher(@p1)";
                    cmd.Parameters.AddWithValue("p1", Tconn.TeacherID);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }






    }



}
