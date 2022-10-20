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
    public partial class Addresses : Form
    {
        DataManager dm;
        Connector conn;




        public Addresses()
        {
            InitializeComponent();
            dm = new DataManager();
            conn = new Connector();
        }
        private void Addresses_Load(object sender, EventArgs e)
        {

            refreshData();
            PopulateForm();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            refreshData();
            PopulateForm();
        }
        private void refreshData()
        {
            dgvAddr.DataSource = dm.toDataTable(conn.getAddresses());
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void PopulateForm()
        {
            if(dgvAddr.Rows.Count > 0)
            {
                addID.Text = dgvAddr.SelectedCells[0].Value.ToString();
                addLine.Text = dgvAddr.SelectedCells[1].Value.ToString();
                addCounty.Text = dgvAddr.SelectedCells[2].Value.ToString();
                addCity.Text = dgvAddr.SelectedCells[3].Value.ToString();
                addPost.Text = dgvAddr.SelectedCells[4].Value.ToString();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            addLine.Enabled = true;
            addCounty.Enabled = true;
            addCity.Enabled = true;
            addPost.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnRefresh.Enabled = false;
            addID.Text = null;
            addLine.Text = null;
            addCounty.Text = null;
            addCity.Text = null;
            addPost.Text = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            addLine.Enabled = false;
            addCounty.Enabled = false;
            addCity.Enabled = false;
            addPost.Enabled = false;
            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnSUP.Enabled = false;
            PopulateForm ();
            
        }

         private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Address add = new Address();
                add.Address1 = addLine.Text;
                add.County = addCounty.Text;
                add.City = addCity.Text;
                add.Postcode = addPost.Text;
                conn.InsertAddr(add);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }
            addLine.Enabled = false;
            addCounty.Enabled = false;
            addCity.Enabled = false;
            addPost.Enabled = false;
            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            PopulateForm();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            addLine.Enabled = true;
            addCounty.Enabled = true;
            addCity.Enabled = true;
            addPost.Enabled = true;
            
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSUP.Enabled = true;
            btnRefresh.Enabled = false;
            
        }

        private void dgvAddr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

}

        
    
