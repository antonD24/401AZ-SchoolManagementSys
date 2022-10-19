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


        private void btnHome_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void Addresses_Load(object sender, EventArgs e)
        {
            
            dgvAddr.DataSource = dm.toDataTable(conn.getAddresses();
        }
    }

}

        
    
