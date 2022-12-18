using HSApp.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSApp.Connectors
{
    internal class MaterialConn
    {

        private string connString = "Server= database401az.c24bjpnpsv1x.us-east-1.rds.amazonaws.com; User ID = admin; Password=02041957; Database=H_SEducateDB";

        public List<Materials> getMaterial()
        {
            List<Materials> mat = new List<Materials>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("CALL sp_getFiles()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        mat.Add(new Materials
                        {
                            Material_ID = reader.GetInt32(0),
                            MaterialName = reader.GetString(1),


                        });
                    }
            }
            return mat;



        }



        async public void InsertFile(Materials mt) //method for uploading an entire file to the DB 
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_InsertFile(@p1,@p2)";
                    cmd.Parameters.AddWithValue("p1", mt.MaterialName);
                    cmd.Parameters.AddWithValue("p2", MySqlDbType.VarBinary).Value = mt.MaterialData;
                    
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public Materials DownMaterials(int Mid) //method for downloading a selected file from the DB on local storage
        {
            Materials mat = new Materials();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_DownFiles(@p1)";
                    cmd.Parameters.AddWithValue("p1", Mid);
                    


                    var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            mat.Material_ID = reader.GetInt32(0);
                            mat.MaterialName = reader.GetString(1);
                            mat.MaterialData = (byte[]) reader.GetValue(2);
                        }
                }
                
                
            
            
            }
            return mat;


        }

        async public void DeleteFile(int fileID)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL sp_DeleteFile(@p1)";
                    cmd.Parameters.AddWithValue("p1", fileID);
                    

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


    }


}