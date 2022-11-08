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

namespace HSApp.Forms
{
    public partial class TimetableForm : Form
    {
        DataManager dm;
        TimeConn conn;

        public TimetableForm()
        {
            
            InitializeComponent();
            dm = new DataManager();
            conn = new TimeConn();
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

        private void TimetableForm_Load(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }

        private void refreshData()
        {
            Timedata.DataSource = dm.toDataTable(conn.getTime());
        }

        private void PopulateForm()
        {
            if (Timedata.Rows.Count > 0)
            {
                TimeID.Text = Timedata.SelectedCells[0].Value.ToString();
                TimeName.Text = Timedata.SelectedCells[1].Value.ToString();
            }



        }

        private void Timedata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateForm();
        }
        
        private void btnUP_Click(object sender, EventArgs e)
        {
            Byte[] bytes;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Word Document files (*.docx)|*.docx | All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filename = openFileDialog.FileName;
                    bytes = File.ReadAllBytes(filename);

                    Timetable tm = new Timetable();
                    tm.TimetableName = openFileDialog.SafeFileName;
                    tm.TimetableData = bytes;

                    conn.InsertTime(tm);
                    PopulateForm();


                }
            }




        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Timetable downloadTime;
            try
            {
                downloadTime = conn.DownTime(Convert.ToInt32(TimeID.Text));
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Title = "Save your timetable";
                saveFileDialog.FileName = downloadTime.TimetableName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog.FileName != "")
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, downloadTime.TimetableData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.DeleteTime(Convert.ToInt32(TimeID.Text));
            PopulateForm();
        }



    }

}
