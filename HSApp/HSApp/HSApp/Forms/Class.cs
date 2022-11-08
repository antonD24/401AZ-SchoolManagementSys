using HSApp.Connectors;
using HSApp.Forms;
using HSApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSApp
{
    public partial class Class : Form
    {
        DataManager dm;
        ClassConn conn;
        public Class()
        {
            InitializeComponent();
            dm = new DataManager();
            conn = new ClassConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void file_Click(object sender, EventArgs e)
        {
            TeachMatForm filesform = new TeachMatForm();
            filesform.Show();
        }

        private void TimeBtn_Click(object sender, EventArgs e)
        {
            TimetableForm timetable= new TimetableForm();
            timetable.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }
        private void refreshData()
        {
            ClsData.DataSource = dm.toDataTable(conn.getClass());
        }
        private void PopulateForm()
        {
            if (ClsData.Rows.Count > 0)
            {
                CID.Text = ClsData.SelectedCells[0].Value.ToString();
                Room.Text = ClsData.SelectedCells[1].Value.ToString();
                TID.Text = ClsData.SelectedCells[2].Value.ToString();

                EID.Text = ClsData.SelectedCells[5].Value.ToString();
                TimeID.Text = ClsData.SelectedCells[9].Value.ToString();
                MatID.Text = ClsData.SelectedCells[11].Value.ToString();

            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Room.Enabled = true;
            TID.Enabled = true;
            EID.Enabled = true;
            TimeID.Enabled = true;
            MatID.Enabled = true;

            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
            Room.Text = null;
            TID.Text = null;
            EID.Text = null;
            TimeID.Text = null;
            MatID.Text = null;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CLASS cls = new CLASS();
                cls.Room = Room.Text;
                cls.TeacherID = Convert.ToInt32(TID.Text);
                cls.EnrollmentID = Convert.ToInt32(EID.Text);
                cls.Timetable_ID = Convert.ToInt32(TimeID.Text);
                cls.Material_ID = Convert.ToInt32(MatID.Text);


                conn.InsertClass(cls);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }

            Room.Enabled = false;
            TID.Enabled = false;
            EID.Enabled = false;
            TimeID.Enabled = false;
            MatID.Enabled = false;


            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = true;
            PopulateForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Room.Enabled = true;
            TID.Enabled = true;
            EID.Enabled = true;
            TimeID.Enabled = true;
            MatID.Enabled = true;


            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSUP.Enabled = true;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
        }

        private void ClsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateForm();
            btnDel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete selection?", "Delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    CLASS cls = new CLASS();
                    cls.ClassID = Convert.ToInt32(CID.Text);

                    conn.DeleteClass(cls);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Delete, Please check data or internet connection" + ex);
                }
            }
        }

        private void btnSUP_Click(object sender, EventArgs e)
        {
            try
            {
                CLASS cls = new CLASS();
                cls.ClassID = Convert.ToInt32(CID.Text);
                cls.Room = Room.Text;
                cls.TeacherID = Convert.ToInt32(TID.Text);
                cls.EnrollmentID = Convert.ToInt32(EID.Text);
                cls.Timetable_ID = Convert.ToInt32(TimeID.Text);
                cls.Material_ID = Convert.ToInt32(MatID.Text);



                conn.UpdateClass(cls);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update, Please check data or internet connection" + ex);
            }
            Room.Enabled = false;
            TID.Enabled = false;
            EID.Enabled = false;
            TimeID.Enabled = false;
            MatID.Enabled = false;


            btnSUP.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDel.Enabled = false;
            PopulateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Room.Enabled = false;
            TID.Enabled = false;
            EID.Enabled = false;
            TimeID.Enabled = false;
            MatID.Enabled = false;

            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnSUP.Enabled = false;
            PopulateForm();
        }
    }
}
