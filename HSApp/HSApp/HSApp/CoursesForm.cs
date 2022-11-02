using HSApp.Connectors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using HSApp.Models;

namespace HSApp
{
    public partial class CoursesForm : Form
    {
        DataManager dm;
        CoursesConn conn;

        public CoursesForm()
        {
            InitializeComponent();
            dm = new DataManager();
            conn = new CoursesConn();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }

        private void refreshData()
        {
            CUData.DataSource = dm.toDataTable(conn.getCourse());
        }
        private void PopulateForm()
        {
            if (CUData.Rows.Count > 0)
            {
                cID.Text = CUData.SelectedCells[0].Value.ToString();

                SubID.Text = CUData.SelectedCells[1].Value.ToString();
                AddID.Text = CUData.SelectedCells[2].Value.ToString();
                teachID.Text = CUData.SelectedCells[3].Value.ToString();
                

            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SubID.Enabled = true;
            AddID.Enabled = true;
            teachID.Enabled = true;
            
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
            cID.Text = null;
            SubID.Text = null;
            AddID.Text = null;
            teachID.Text = null;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Courses cu = new Courses();
                cu.SubjectID = Convert.ToInt32(SubID.Text);
                cu.AddressID = Convert.ToInt32 (AddID.Text);
                cu.TeacherID = Convert.ToInt32(teachID.Text);
                

                conn.InsertCourse(cu);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }
            
            SubID.Enabled = false;
            AddID.Enabled = false;
            teachID.Enabled = false;
            

            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = true;
            PopulateForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            SubID.Enabled = true;
            AddID.Enabled = true;
            teachID.Enabled = true;
            

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSUP.Enabled = true;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
        }

        private void CUData_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    Courses cu = new Courses();
                    cu.CourseID = Convert.ToInt32(cID.Text);

                    conn.DeleteCourse(cu);
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
                Courses cu = new Courses();
                cu.CourseID = Convert.ToInt32(cID.Text);
                cu.SubjectID = Convert.ToInt32(SubID.Text);
                cu.AddressID = Convert.ToInt32(AddID.Text);
                cu.TeacherID = Convert.ToInt32(teachID.Text);
                


                conn.UpdateCourse(cu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }
            SubID.Enabled = false;
            AddID.Enabled = false;
            teachID.Enabled = false;
            

            btnSUP.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDel.Enabled = false;
            PopulateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubID.Enabled = false;
            AddID.Enabled = false;
            teachID.Enabled = false;
            
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