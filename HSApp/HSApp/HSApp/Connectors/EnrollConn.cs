﻿using HSApp.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Connectors
{
    internal class EnrollConn
    {
        private string connString = "Server= dbassign.csgx7vmsu0ih.us-east-1.rds.amazonaws.com; User ID = admin; Password=02041957; Database=HS_Educate";

        public List<Enrollments> getEnrollment()
        {
            List<Enrollments> enroll = new List<Enrollments>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("CALL sp_getEnrollment()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        enroll.Add(new Enrollments
                        {
                            EnrollmentID = reader.GetInt32(0),
                            StudentID = reader.GetInt32(1),
                            Sfname = reader.GetString(2),
                            Slname = reader.GetString(3),
                            CourseID = reader.GetInt32(4),
                            SubjectID = reader.GetInt32(5),
                            SubjectName = reader.GetString(6),
                            DOE = reader.GetDateTime(7),

                        });
                    }
            }
            return enroll;

        }
        async public void InsertEnrollment(Enrollments enroll)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_InsertEnrollment(@p1,@p2,@p3)";
                    cmd.Parameters.AddWithValue("p1", enroll.StudentID);
                    cmd.Parameters.AddWithValue("p2", enroll.CourseID);
                    cmd.Parameters.AddWithValue("p3", enroll.DOE);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void UpdateEnrollment(Enrollments enroll)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_UpdateEnrollment(@p1,@p2,@p3,@p4)";
                    cmd.Parameters.AddWithValue("p1", enroll.EnrollmentID);
                    cmd.Parameters.AddWithValue("p2", enroll.StudentID);
                    cmd.Parameters.AddWithValue("p3", enroll.CourseID);
                    cmd.Parameters.AddWithValue("p4", enroll.DOE);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        async public void DeleteEnrollment(Enrollments enroll)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_deleteEnrollment(@p1)";
                    cmd.Parameters.AddWithValue("p1", enroll.EnrollmentID);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
