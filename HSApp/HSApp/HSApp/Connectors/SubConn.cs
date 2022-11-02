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
    public class SubConn
    {
        private string connString = "Server= database401az.c24bjpnpsv1x.us-east-1.rds.amazonaws.com; User ID = admin; Password=02041957; Database=H_SEducateDB";

        public List<Subject> getSubjects()
        {
            List<Subject> sub = new List<Subject>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("CALL sp_getSubjects()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        sub.Add(new Subject
                        {
                             SubjectID = reader.GetInt32(0),
                            SubjectName = reader.GetString(1),
                            SubjectDesc = reader.GetString(2),
                            CStartDate = reader.GetDateTime(3),
                            CEndDate = reader.GetDateTime(4),
                            BuildingName = reader.GetString(5),
                            
                        });
                    }
            }
            return sub;

        }
        async public void InsertSub(Subject sub)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_InsertSubject(@p1,@p2,@p3,@p4,@p5)";
                    cmd.Parameters.AddWithValue("p1", sub.SubjectName);
                    cmd.Parameters.AddWithValue("p2", sub.SubjectDesc);
                    cmd.Parameters.AddWithValue("p3", sub.CStartDate);
                    cmd.Parameters.AddWithValue("p4", sub.CEndDate);
                    cmd.Parameters.AddWithValue("p5", sub.BuildingName);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void UpdateSubject(Subject sub)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_UpdateSubject(@p1,@p2,@p3,@p4,@p5,@p6)";
                    cmd.Parameters.AddWithValue("p1", sub.SubjectID);
                    cmd.Parameters.AddWithValue("p2", sub.SubjectName);
                    cmd.Parameters.AddWithValue("p3", sub.SubjectDesc);
                    cmd.Parameters.AddWithValue("p4", sub.CStartDate);
                    cmd.Parameters.AddWithValue("p5", sub.CEndDate);
                    cmd.Parameters.AddWithValue("p6", sub.BuildingName);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void DeleteSubject(Subject sub)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_deleteSubject(@p1)";
                    cmd.Parameters.AddWithValue("p1", sub.SubjectID);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }






    }









}





