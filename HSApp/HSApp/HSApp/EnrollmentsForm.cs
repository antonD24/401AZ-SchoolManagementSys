using HSApp.Connectors;
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
using System.Xml.Linq;

namespace HSApp
{
    public partial class EnrollmentsForm : Form
    {
        DataManager dm;
        EnrollConn conn;
        public EnrollmentsForm()
        {
            InitializeComponent();
            dm = new DataManager();
            conn = new EnrollConn();
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

        private void EnrollmentsForm_Load(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }

        private void refreshData()
        {
            EData.DataSource = dm.toDataTable(conn.getEnrollment());
        }
        private void PopulateForm()
        {
            if (EData.Rows.Count > 0)
            {
                Eid.Text = EData.SelectedCells[0].Value.ToString();

                Sid.Text = EData.SelectedCells[1].Value.ToString();

                Cid.Text = EData.SelectedCells[4].Value.ToString();
                Edate.Text = EData.SelectedCells[7].Value.ToString();

            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sid.Enabled = true;
            Cid.Enabled = true;
            Edate.Enabled = true;

            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
            Eid.Text = null;
            Sid.Text = null;
            Cid.Text = null;
            Edate.Text = null;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Enrollments en = new Enrollments();
                en.StudentID = Convert.ToInt32(Sid.Text);
                en.CourseID = Convert.ToInt32(Cid.Text);
                en.DOE = Edate.Value;


                conn.InsertEnrollment(en);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }

            Sid.Enabled = false;
            Cid.Enabled = false;
            Edate.Enabled = false;


            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = true;
            PopulateForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Sid.Enabled = true;
            Cid.Enabled = true;
            Edate.Enabled = true;


            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSUP.Enabled = true;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
        }

        private void EData_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    Enrollments en = new Enrollments();
                    en.EnrollmentID = Convert.ToInt32(Eid.Text);

                    conn.DeleteEnrollment(en);
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
                Enrollments en = new Enrollments();
                en.EnrollmentID = Convert.ToInt32(Eid.Text);
                en.StudentID = Convert.ToInt32(Sid.Text);
                en.CourseID = Convert.ToInt32(Cid.Text);
                en.DOE = Edate.Value;



                conn.UpdateEnrollment(en);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }
            Sid.Enabled = false;
            Cid.Enabled = false;
            Edate.Enabled = false;


            btnSUP.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDel.Enabled = false;
            PopulateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sid.Enabled = false;
            Cid.Enabled = false;
            Edate.Enabled = false;

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
