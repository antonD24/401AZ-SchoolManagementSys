﻿using HSApp.Connectors;
using HSApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HSApp
{
    public partial class TeachMatForm : Form
    {
        DataManager dm;
        MaterialConn conn;

        public TeachMatForm()
        {
            InitializeComponent();
            dm = new DataManager();
            conn = new MaterialConn();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }

        private void TeachMatForm_Load(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }

        
        
        private void refreshData()
        {
            Mdata.DataSource = dm.toDataTable(conn.getMaterial());
        }

        private void PopulateForm()
        {
            if (Mdata.Rows.Count > 0)
            {
                Mid.Text = Mdata.SelectedCells[0].Value.ToString();

                Mname.Text = Mdata.SelectedCells[1].Value.ToString();



            }



        }

        private void Mdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshData();
            PopulateForm();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            Byte[] bytes;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Powerpoint files (*.pptx)|*.pptx | All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filename = openFileDialog.SafeFileName;
                    bytes = File.ReadAllBytes(filename);

                    Materials mt = new Materials();
                    mt.MaterialName = filename;
                    mt.MaterialData = bytes;

                    conn.InsertFile(mt);
                    PopulateForm();


                }
            }




        }

        
    }

}
