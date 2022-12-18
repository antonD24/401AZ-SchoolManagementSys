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
        AddrConnector conn;
        
        //DataManager and the Connector classes are declared 



        public Addresses()
        {
            InitializeComponent();
            dm = new DataManager();
            conn = new AddrConnector();
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
            // the DataManager takes the data provided by the connector and gets displayed upon window load or 
            // by using the refresh button that reloads the table and populates it with the most up-to-date data from the DB
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            // button used to bring up the Main Menu of the application for navigation between forms
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
            // this bit of code populates each text box with it's assigned cell if the row count is > 0
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
            btnDel.Enabled = false;
            addID.Text = null;
            addLine.Text = null;
            addCounty.Text = null;
            addCity.Text = null;
            addPost.Text = null;

            // clicking the Add button activates the text boxes and sets the to a null state 
            // in which data can be entered
            // also the add, refresh and delete buttons are disabled so that they can't interfere with the application while data is entered
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
            btnDel.Enabled = true;
            btnSUP.Enabled = false;
            PopulateForm ();

            // the refresh buttons resets the buttons to their original state
            // populates the form with the newest data available 
            // populates the text boxes that also get disabled
            
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
            btnDel.Enabled=true;
            PopulateForm();

        }
        // the Save button triggers the InsertAddr method in the connector file, 
        // taking the information entered in the text boxes and then writing it to the database

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
            btnDel.Enabled = false;
        }
        // after selecting a row and clicking the Update button 
        // the text boxes become available allowing for data editing 

        private void dgvAddr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            PopulateForm();
            btnDel.Enabled = true;

            // upon clicking on a cell, the whole row is highlighted
            // populates the text boxes and enables the Delete button
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete selection?","Delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Address add = new Address();
                    add.AddressID = Convert.ToInt32(addID.Text);
                    
                    conn.DeleteAddr(add);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete, Please check data or internet connection" + ex);
                }   
                // clicking the delete button displays a dialog window asking to confirm the action
                // after confirmation the "DeleteAddr" method is triggered int the connector that calls the stored procedure in the 
                // database and deletes the information

            }
            
            
        }


        private void btnSUP_Click(object sender, EventArgs e)
        {
            try
            {
                Address add = new Address();
                add.AddressID = Convert.ToInt32(addID.Text);
                add.Address1 = addLine.Text;
                add.County = addCounty.Text;
                add.City = addCity.Text;
                add.Postcode = addPost.Text;
                conn.UpdateAddr(add);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert, Please check data or internet connection" + ex);
            }
            addLine.Enabled = false;
            addCounty.Enabled = false;
            addCity.Enabled = false;
            addPost.Enabled = false;
            btnSUP.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDel.Enabled = false;
            PopulateForm();
        }
    }
        // after editing the data in the fields clicking the "Save" button the the method in the connector is triggered
        // the stored procedure is called and the iformation is overwritten in the table stored in the database
}

        
    
