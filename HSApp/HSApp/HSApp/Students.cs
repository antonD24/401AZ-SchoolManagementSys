using HSApp.Connectors;
using HSApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSApp
{
    public partial class Students : Form
    {
        DataManager dm;
        StudentConn conn;
        

        public Students()
        {
            InitializeComponent();
            dm = new DataManager();
            conn = new StudentConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }

        
        private void refreshData()
        {
            stData.DataSource = dm.toDataTable(conn.getStudents());
        }
        private void PopulateForm()
        {
            if (stData.Rows.Count > 0)
            {
                stuID.Text = stData.SelectedCells[0].Value.ToString();
                sFname.Text = stData.SelectedCells[1].Value.ToString();
                sLname.Text = stData.SelectedCells[2].Value.ToString();
                sDOB.Text = stData.SelectedCells[3].Value.ToString();
                sGender.Text = stData.SelectedCells[4].Value.ToString();
                sEmail.Text = stData.SelectedCells[5].Value.ToString();
                sPhone.Text = stData.SelectedCells[6].Value.ToString();
                sAddr.Text = stData.SelectedCells[7].Value.ToString();
                
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sFname.Enabled = true;
            sLname.Enabled = true;
            sDOB.Enabled = true;
            sGender.Enabled = true;
            sEmail.Enabled = true;
            sPhone.Enabled = true;
            sAddr.Enabled = true;
            
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
            stuID.Text = null;
            sFname.Text = null;
            sLname.Text = null;
            sDOB.Text = null;
            sGender.Text = null;
            sEmail.Text =null;
            sPhone.Text = null;
            sAddr.Text = null;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student stu = new Student();
                stu.Sfname = sFname.Text;
                stu.Slname = sLname.Text;
                stu.DOB = sDOB.Value;
                stu.Sgender = sGender.Text;
                stu.SEmail = sEmail.Text;
                stu.SPhone = sPhone.Text;
                stu.AddressID = Convert.ToInt32(sAddr.Text);
                
                conn.insertStudent(stu);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }
            stuID.Enabled = false;
            sFname.Enabled = false;
            sLname.Enabled = false;
            sDOB.Enabled = false;
            sGender.Enabled = false;
            sEmail.Enabled = false;
            sPhone.Enabled = false;
            sAddr.Enabled = false;
            
            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = true;
            PopulateForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            stuID.Enabled = true;
            sFname.Enabled = true;
            sLname.Enabled = true;
            sDOB.Enabled = true;
            sGender.Enabled = true;
            sEmail.Enabled = true;
            sPhone.Enabled = true;
            sAddr.Enabled = true;
            
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSUP.Enabled = true;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
        }

        private void stData_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    Student stu = new Student();
                    stu.studentID = Convert.ToInt32(stuID.Text);

                    conn.DeleteStudent(stu);
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
                Student stu = new Student();
                stu.studentID = Convert.ToInt32(stuID.Text);
                stu.Sfname = sFname.Text;
                stu.Slname = sLname.Text;
                stu.DOB = sDOB.Value;
                stu.Sgender = sGender.Text;
                stu.SEmail = sEmail.Text;
                stu.SPhone = sPhone.Text;
                stu.AddressID = Convert.ToInt32(sAddr.Text);

                
                conn.UpdateStudent(stu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }
            sFname.Enabled = false;
            sLname.Enabled = false;
            sDOB.Enabled = false;
            sGender.Enabled = false;
            sEmail.Enabled = false;
            sPhone.Enabled = false;
            sAddr.Enabled = false;
            
            btnSUP.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDel.Enabled = false;
            PopulateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sFname.Enabled = false;
            sLname.Enabled = false;
            sDOB.Enabled = false;
            sGender.Enabled = false;
            sEmail.Enabled = false;
            sPhone.Enabled = false;
            sAddr.Enabled = false;
            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnSUP.Enabled = false;
            PopulateForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }
    }
}
