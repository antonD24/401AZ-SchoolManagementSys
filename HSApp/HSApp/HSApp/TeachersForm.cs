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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace HSApp
{
    public partial class TeachersForm : Form
    {
        

        DataManager dm;
        TConn conn;


        public TeachersForm()
        {
            InitializeComponent();
            dm = new DataManager();
            conn = new TConn();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }



        private void TeachersForm_Load(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }
        private void refreshData()
        {
            Tdata.DataSource = dm.toDataTable(conn.getTeachers());
        }
        private void PopulateForm()
        {
            if (Tdata.Rows.Count > 0)
            {
                teachID.Text = Tdata.SelectedCells[0].Value.ToString();
                Tfname.Text = Tdata.SelectedCells[1].Value.ToString();
                Tlname.Text = Tdata.SelectedCells[2].Value.ToString();
                Tdob.Text = Tdata.SelectedCells[3].Value.ToString();
                Tgender.Text = Tdata.SelectedCells[4].Value.ToString();
                Temail.Text = Tdata.SelectedCells[5].Value.ToString();
                Tphone.Text = Tdata.SelectedCells[6].Value.ToString();
                Taddr.Text = Tdata.SelectedCells[7].Value.ToString();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            teachID.Enabled = true;
            Tfname.Enabled = true;
            Tlname.Enabled = true;
            Tdob.Enabled = true;
            Tgender.Enabled = true;
            Temail.Enabled = true;
            Tphone.Enabled = true;
            Taddr.Enabled = true;

            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
            teachID.Text = null;
            Tfname.Text = null;
            Tlname.Text = null;
            Tdob.Text = null;
            Tgender.Text = null;
            Temail.Text = null;
            Tphone.Text = null;
            Taddr.Text = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Teachers teachers = new Teachers();
                teachers.TeacherFName = Tfname.Text;
                teachers.TeacherLname = Tlname.Text;
                teachers.DOB = Tdob.Value;
                teachers.Tgender = Tgender.Text;
                teachers.Temail = Temail.Text;
                teachers.Tphone = Tphone.Text;
                teachers.Addr = Convert.ToInt32(Taddr.Text);

                conn.insertTeacher(teachers);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }
            teachID.Enabled = false;
            Tfname.Enabled = false;
            Tlname.Enabled = false;
            Tdob.Enabled = false;
            Tgender.Enabled = false;
            Temail.Enabled = false;
            Tphone.Enabled = false;
            Taddr.Enabled = false;

            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = true;
            PopulateForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            teachID.Enabled = true;
            Tfname.Enabled = true;
            Tlname.Enabled = true;
            Tdob.Enabled = true;
            Tgender.Enabled = true;
            Temail.Enabled = true;
            Tphone.Enabled = true;
            Taddr.Enabled = true;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSUP.Enabled = true;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
        }

        private void Tdata_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    Teachers teachers = new Teachers();
                    teachers.TeacherID = Convert.ToInt32(teachID.Text);

                    conn.DeleteTeacher(teachers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete, Please check data or internet connection" + ex);
                }
            }
        }

        private void btnSUP_Click(object sender, EventArgs e)
        {
            try
            {
                Teachers teacher = new Teachers();
                teacher.TeacherID = Convert.ToInt32(teachID.Text);
                teacher.TeacherFName = Tfname.Text;
                teacher.TeacherLname = Tlname.Text;
                teacher.DOB = Tdob.Value;
                teacher.Tgender = Tgender.Text;
                teacher.Temail = Temail.Text;
                teacher.Tphone = Tphone.Text;
                teacher.Addr = Convert.ToInt32(Taddr.Text);

                conn.UpdateTeacher(teacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update, Please check data or internet connection" + ex);
            }
            Tfname.Enabled = false;
            Tlname.Enabled = false;
            Tdob.Enabled = false;
            Tgender.Enabled = false;
            Temail.Enabled = false;
            Tphone.Enabled = false;
            Taddr.Enabled = false;

            btnSUP.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDel.Enabled = false;
            PopulateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tfname.Enabled = false;
            Tlname.Enabled = false;
            Tdob.Enabled = false;
            Tgender.Enabled = false;
            Temail.Enabled = false;
            Tphone.Enabled = false;
            Taddr.Enabled = false;

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

