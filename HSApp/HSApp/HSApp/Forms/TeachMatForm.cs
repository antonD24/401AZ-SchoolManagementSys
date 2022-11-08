using HSApp.Connectors;
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
                Matid.Text = Mdata.SelectedCells[0].Value.ToString();

                Mname.Text = Mdata.SelectedCells[1].Value.ToString();



            }



        }

        private void Mdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                    var filename = openFileDialog.FileName;
                    bytes = File.ReadAllBytes(filename);

                    Materials mt = new Materials();
                    mt.MaterialName = openFileDialog.SafeFileName;
                    mt.MaterialData = bytes;

                    conn.InsertFile(mt);
                    PopulateForm();


                }
            }




        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Materials downloadMaterial;
            try
            {
                downloadMaterial = conn.DownMaterials(Convert.ToInt32(Matid.Text));
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Title = "Save your materials";
                saveFileDialog.FileName = downloadMaterial.MaterialName;
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog.FileName != "")
                    {
                        File.WriteAllBytes(saveFileDialog.FileName,downloadMaterial.MaterialData);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            



        }
    }

}
