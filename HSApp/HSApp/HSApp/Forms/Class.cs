﻿using HSApp.Forms;
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
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
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
    }
}
