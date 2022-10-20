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

                using (var cmd = new MySqlCommand("CALL sp_getAddresses()", conn))
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
            using (var conn = new MySqlConnection(connString))
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
                    cmd.CommandText = "CALL sp_deleteAddresses(@p1)";
                    cmd.Parameters.AddWithValue("p1", add.AddressID);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("CALL sp_getStudents()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            studentID = reader.GetInt32(0),
                            Sfname = reader.GetString(1),
                            Slname = reader.GetString(2),
                            DOB = reader.GetDateTime(3),
                            Sgender = reader.GetString(4),
                            SEmail = reader.GetString(5),
                            SPhone = reader.GetString(6),
                            
                        });
                    }
            }
            return students;
        }


            async public void insertStudent(Student stud)
            {
                using (var conn = new MySqlConnection(connString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "CALL sp_InsertStudent(@p1,@p2,@p3,@p4,@p5,@p6)";
                        cmd.Parameters.AddWithValue("p1", stud.Sfname);
                        cmd.Parameters.AddWithValue("p2", stud.Slname);
                        cmd.Parameters.AddWithValue("p3", stud.DOB);
                        cmd.Parameters.AddWithValue("p4", stud.Sgender);
                        cmd.Parameters.AddWithValue("p5", stud.SEmail);
                        cmd.Parameters.AddWithValue("p6", stud.SPhone);
                        
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }

            async public void UpdateStudent(Student stu)
            {
                using (var conn = new MySqlConnection(connString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "CALL sp_UpdateStudents(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                        cmd.Parameters.AddWithValue("p1", stu.studentID);
                        cmd.Parameters.AddWithValue("p2", stu.Sfname);
                        cmd.Parameters.AddWithValue("p3", stu.Slname);
                        cmd.Parameters.AddWithValue("p4", stu.DOB);
                        cmd.Parameters.AddWithValue("p5", stu.Sgender);
                        cmd.Parameters.AddWithValue("p6", stu.SEmail);
                        cmd.Parameters.AddWithValue("p7", stu.SPhone);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }

            async public void DeleteStudent(Student stu)
            {
                using (var conn = new MySqlConnection(connString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "CALL sp_deleteStudent(@p1)";
                        cmd.Parameters.AddWithValue("p1", stu.studentID);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }


        

        
    }

            
                






 } 
    




