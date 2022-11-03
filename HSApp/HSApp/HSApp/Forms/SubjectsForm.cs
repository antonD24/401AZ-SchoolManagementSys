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
    public partial class SubjectsForm : Form
    {
        DataManager dm;
        SubConn conn;

        public SubjectsForm()
        {
            
            InitializeComponent();
            dm = new DataManager();
            conn = new SubConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
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
            dgvSub.DataSource = dm.toDataTable(conn.getSubjects());
        }

        private void PopulateForm()
        {
            if (dgvSub.Rows.Count > 0)
            {
                Subid.Text = dgvSub.SelectedCells[0].Value.ToString();
                Subname.Text = dgvSub.SelectedCells[1].Value.ToString();
                SubDesc.Text = dgvSub.SelectedCells[2].Value.ToString();
                StartD.Text = dgvSub.SelectedCells[3].Value.ToString();
                EndD.Text = dgvSub.SelectedCells[4].Value.ToString();
                Bname.Text = dgvSub.SelectedCells[5].Value.ToString();
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Subname.Enabled = true;
            StartD.Enabled = true;
            EndD.Enabled = true;
            Bname.Enabled = true;
            SubDesc.Enabled = true;
            

            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnRefresh.Enabled = false;
            btnDel.Enabled = false;
            Subid.Text = null;
            Subname.Text = null;
            StartD.Text = null;
            EndD.Text = null;
            Bname.Text = null;
            SubDesc.Text = null;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Subject sub = new Subject();
                sub.SubjectName = Subname.Text;
                sub.SubjectDesc = SubDesc.Text;
                sub.CStartDate= StartD.Value;
                sub.CEndDate = EndD.Value;
                sub.BuildingName = Bname.Text;
                
                

                conn.InsertSub(sub);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }
            Subname.Enabled = false;
            StartD.Enabled = false;
            EndD.Enabled = false;
            Bname.Enabled = false;
            Subname.Enabled = false;
            

            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = true;
            PopulateForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Subname.Enabled = true;
            StartD.Enabled = true;
            EndD.Enabled = true;
            Bname.Enabled = true;
            SubDesc.Enabled = true;
            

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
                    Subject sub = new Subject();
                    sub.SubjectID = Convert.ToInt32(Subid.Text);

                    conn.DeleteSubject(sub);
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
                Subject subject = new Subject();
                subject.SubjectID = Convert.ToInt32(Subid.Text);
                subject.SubjectName = Subname.Text;
                subject.SubjectDesc = SubDesc.Text;
                subject.CStartDate = StartD.Value;
                subject.CEndDate = EndD.Value;
                subject.BuildingName = Bname.Text;
                
                


                conn.UpdateSubject(subject);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update, Please check data or internet connection" + ex);
            }
            Subname.Enabled = false;
            StartD.Enabled = false;
            EndD.Enabled = false;
            Bname.Enabled = false;
            SubDesc.Enabled = false;
            

            btnSUP.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDel.Enabled = false;
            PopulateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Subname.Enabled = false;
            StartD.Enabled = false;
            EndD.Enabled = false;
            Bname.Enabled = false;
            SubDesc.Enabled = false;
            
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
