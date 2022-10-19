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
        }
        private void button5_Click(object sender, EventArgs e)
        {
            refreshData();
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

        

         
    }

}

        
    
