using HSApp.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Connectors
{
    internal class ClassConn
    {
        private string connString = "Server= database401az.c24bjpnpsv1x.us-east-1.rds.amazonaws.com; User ID = admin; Password=02041957; Database=H_SEducateDB";
        // Connection string that provides the necesarry server address and authentication and links the Forms application to the SQL Database hosted on AWS

        public List<CLASS> getClass()  // getClass method that uses a stored procedure in the DB to pull information
                                       // and display the contents of that table
                                        
                                       
        {
            List<CLASS> cls = new List<CLASS>();    
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("CALL sp_getClass()", conn)) //Sql Command that allows use of a stored procedure syntax
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        cls.Add(new CLASS
                        {
                            ClassID = reader.GetInt32(0),
                            Room = reader.GetString(1),
                            TeacherID = reader.GetInt32(2),
                            TeacherFName = reader.GetString(3),
                            TeacherLname = reader.GetString(4),
                            EnrollmentID = reader.GetInt32(5),
                            StudentID = reader.GetInt32(6),
                            Sfname = reader.GetString(7),
                            Slname = reader.GetString(8),
                            Timetable_ID = reader.GetInt32(9),
                            TimetableName = reader.GetString(10),
                            
                            Material_ID = reader.GetInt32(11),
                            MaterialName = reader.GetString(12),
                            
                            // values provided by the "get" accessor in the CLASS.cs class.

                        });
                    }
            }
            return cls;

        }

        //

        async public void InsertClass(CLASS cls) // method used for inserting new information in the DB
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_InsertClass(@p1,@p2,@p3,@p4,@p5)"; // stored procedure for inserting new parameters in the Class table
                    cmd.Parameters.AddWithValue("p1", cls.Room);
                    cmd.Parameters.AddWithValue("p2", cls.TeacherID);
                    cmd.Parameters.AddWithValue("p3", cls.EnrollmentID);
                    cmd.Parameters.AddWithValue("p4", cls.Timetable_ID);
                    cmd.Parameters.AddWithValue("p5", cls.Material_ID);



                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void UpdateClass(CLASS cls) //method for updating existing entries in the tables 
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_UpdateClass(@p1,@p2,@p3,@p4,@p5,@p6)";
                    cmd.Parameters.AddWithValue("p1", cls.ClassID);
                    cmd.Parameters.AddWithValue("p2", cls.Room);
                    cmd.Parameters.AddWithValue("p3", cls.TeacherID);
                    cmd.Parameters.AddWithValue("p4", cls.EnrollmentID);
                    cmd.Parameters.AddWithValue("p5", cls.Timetable_ID);
                    cmd.Parameters.AddWithValue("p6", cls.Material_ID);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void DeleteClass(CLASS cls) // method for deleting existing entries and information assigned to a numerical ID
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_deleteClass(@p1)";
                    cmd.Parameters.AddWithValue("p1", cls.ClassID);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
