using HSApp.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Connectors
{
    internal class CoursesConn
    {
        private string connString = "Server= dbassign.csgx7vmsu0ih.us-east-1.rds.amazonaws.com; User ID = admin; Password=02041957; Database=HS_Educate";

        public List<Courses> getCourse()
        {
            List<Courses> course = new List<Courses>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("CALL sp_getCourse()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        course.Add(new Courses
                        {
                            CourseID = reader.GetInt32(0),
                            SubjectID = reader.GetInt32(1),
                            SubjectName = reader.GetString(2),
                            BuildingName = reader.GetString(3),
                            TeacherID = reader.GetInt32(4),
                            TeacherFName = reader.GetString(5),
                            TeacherLname = reader.GetString(6),
                            AddressID = reader.GetInt32(7),
                            Address1 = reader.GetString(8),
                            County = reader.GetString(9),
                            City = reader.GetString(10),
                            Postcode =reader.GetString(11),
                            
                        });
                    }
            }
            return course;

        }
        async public void InsertCourse(Courses course)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_InsertCourse(@p1,@p2,@p3)";
                    cmd.Parameters.AddWithValue("p1", course.SubjectID);
                    cmd.Parameters.AddWithValue("p2", course.AddressID);
                    cmd.Parameters.AddWithValue("p3", course.TeacherID);
                    
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void UpdateCourse(Courses course)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_UpdateCourse(@p1,@p2,@p3,@p4)";
                    cmd.Parameters.AddWithValue("p1", course.CourseID);
                    cmd.Parameters.AddWithValue("p2", course.SubjectID);
                    cmd.Parameters.AddWithValue("p3", course.AddressID);
                    cmd.Parameters.AddWithValue("p4", course.TeacherID);
                    
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void DeleteCourse(Courses course)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_deleteCourse(@p1)";
                    cmd.Parameters.AddWithValue("p1", course.CourseID);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }






    }

}
