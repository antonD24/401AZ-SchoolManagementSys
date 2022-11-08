using HSApp.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Connectors
{
    internal class TimeConn
    {
        private string connString = "Server= database401az.c24bjpnpsv1x.us-east-1.rds.amazonaws.com; User ID = admin; Password=02041957; Database=H_SEducateDB";

        public List<Timetable> getTime()
        {
            List<Timetable> tm = new List<Timetable>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("CALL sp_ViewTime()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        tm.Add(new Timetable
                        {
                            Timetable_ID = reader.GetInt32(0),
                            TimetableName = reader.GetString(1),


                        });
                    }
            }
            return tm;



        }



        async public void InsertTime(Timetable tm)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_InsertTime(@p1,@p2)";
                    cmd.Parameters.AddWithValue("p1", tm.TimetableName);
                    cmd.Parameters.AddWithValue("p2", MySqlDbType.VarBinary).Value = tm.TimetableData;

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public Timetable DownTime(int TimeID)
        {
            Timetable tm = new Timetable();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_GetTime(@p1)";
                    cmd.Parameters.AddWithValue("p1", TimeID);



                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tm.Timetable_ID = reader.GetInt32(0);
                        tm.TimetableName = reader.GetString(1);
                        tm.TimetableData = (byte[])reader.GetValue(2);
                    }
                }




            }


            return tm;

        }
        

        async public void DeleteTime(int TmID)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_DeleteTime(@p1)";
                    cmd.Parameters.AddWithValue("p1", TmID);


                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


    }
}

