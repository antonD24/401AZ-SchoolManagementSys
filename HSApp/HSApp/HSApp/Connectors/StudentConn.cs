using HSApp.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Connectors
{
    internal class StudentConn
    {
        private string connString = "Server= database401az.c24bjpnpsv1x.us-east-1.rds.amazonaws.com; User ID = admin; Password=02041957; Database=H_SEducateDB";

        public List<Student> getStudents()
        {
            List<Student> stu = new List<Student>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("CALL sp_getStudent()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        stu.Add(new Student
                        {
                            studentID = reader.GetInt32(0),
                            Sfname = reader.GetString(1),
                            Slname = reader.GetString(2),
                            DOB = reader.GetDateTime(3),
                            Sgender = reader.GetString(4),
                            SEmail = reader.GetString(5),
                            SPhone = reader.GetString(6),
                            AddressID = reader.GetInt32(7),
                            Address1 = reader.GetString(8),
                            County = reader.GetString(9),
                            City = reader.GetString(10),
                            Postcode = reader.GetString(11),
                            
                            
                        });
                    }
            }
            return stu;

        }
        async public void insertStudent(Student student)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_InsertStudent(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                    cmd.Parameters.AddWithValue("p1", student.Sfname);
                    cmd.Parameters.AddWithValue("p2", student.Slname);
                    cmd.Parameters.AddWithValue("p3", student.DOB);
                    cmd.Parameters.AddWithValue("p4", student.Sgender);
                    cmd.Parameters.AddWithValue("p5", student.SEmail);
                    cmd.Parameters.AddWithValue("p6", student.SPhone);
                    cmd.Parameters.AddWithValue("p7", student.AddressID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void UpdateStudent(Student student)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_UpdateStudents(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                    cmd.Parameters.AddWithValue("p1", student.studentID);
                    cmd.Parameters.AddWithValue("p2", student.Sfname);
                    cmd.Parameters.AddWithValue("p3", student.Slname);
                    cmd.Parameters.AddWithValue("p4", student.DOB);
                    cmd.Parameters.AddWithValue("p5", student.Sgender);
                    cmd.Parameters.AddWithValue("p6", student.SEmail);
                    cmd.Parameters.AddWithValue("p7", student.SPhone);
                    cmd.Parameters.AddWithValue("p8", student.AddressID);
                    
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void DeleteStudent(Student student)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_deleteStudent(@p1)";
                    cmd.Parameters.AddWithValue("p1", student.studentID);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }






    }



}
