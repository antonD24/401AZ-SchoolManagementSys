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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
                 }

        private void btnAddresses_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addresses addresses = new Addresses();
            addresses.Closed += (s, args) => this.Close();
            addresses.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students students = new Students();
            students.Closed += (s, args) => this.Close();
            students.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersForm teachers = new TeachersForm();
            teachers.Closed += (s, args) => this.Close();
            teachers.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courses courses = new Courses();
            courses.Closed += (s, args) => this.Close();
            courses.Show();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects subjects = new Subjects();
            subjects.Closed += (s, args) => this.Close();
            subjects.Show();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class classes = new Class();
            classes.Closed += (s, args) => this.Close();
            classes.Show();
        }

        private void btnEnrollments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enrollments enrollments = new Enrollments();
            enrollments.Closed += (s, args) => this.Close();
            enrollments.Show();
        }
    }
}
