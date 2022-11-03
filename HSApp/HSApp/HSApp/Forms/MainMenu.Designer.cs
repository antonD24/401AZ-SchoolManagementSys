namespace HSApp
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnAddresses = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btnEnrollments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnStudent.Location = new System.Drawing.Point(12, 282);
            this.btnStudent.MaximumSize = new System.Drawing.Size(150, 30);
            this.btnStudent.MinimumSize = new System.Drawing.Size(150, 30);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(150, 30);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Students";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCourses.Location = new System.Drawing.Point(12, 330);
            this.btnCourses.MaximumSize = new System.Drawing.Size(150, 30);
            this.btnCourses.MinimumSize = new System.Drawing.Size(150, 30);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(150, 30);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnAddresses
            // 
            this.btnAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddresses.Location = new System.Drawing.Point(12, 375);
            this.btnAddresses.MaximumSize = new System.Drawing.Size(150, 30);
            this.btnAddresses.MinimumSize = new System.Drawing.Size(150, 30);
            this.btnAddresses.Name = "btnAddresses";
            this.btnAddresses.Size = new System.Drawing.Size(150, 30);
            this.btnAddresses.TabIndex = 2;
            this.btnAddresses.Text = "Addresses";
            this.btnAddresses.UseVisualStyleBackColor = true;
            this.btnAddresses.Click += new System.EventHandler(this.btnAddresses_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTeachers.Location = new System.Drawing.Point(222, 282);
            this.btnTeachers.MaximumSize = new System.Drawing.Size(150, 30);
            this.btnTeachers.MinimumSize = new System.Drawing.Size(150, 30);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(150, 30);
            this.btnTeachers.TabIndex = 3;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSubjects.Location = new System.Drawing.Point(222, 330);
            this.btnSubjects.MaximumSize = new System.Drawing.Size(150, 30);
            this.btnSubjects.MinimumSize = new System.Drawing.Size(150, 30);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(150, 30);
            this.btnSubjects.TabIndex = 4;
            this.btnSubjects.Text = "Subjects";
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnClasses
            // 
            this.btnClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClasses.Location = new System.Drawing.Point(222, 375);
            this.btnClasses.MaximumSize = new System.Drawing.Size(150, 30);
            this.btnClasses.MinimumSize = new System.Drawing.Size(150, 30);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(150, 30);
            this.btnClasses.TabIndex = 5;
            this.btnClasses.Text = "Classes";
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnEnrollments
            // 
            this.btnEnrollments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEnrollments.Location = new System.Drawing.Point(116, 411);
            this.btnEnrollments.MaximumSize = new System.Drawing.Size(150, 30);
            this.btnEnrollments.MinimumSize = new System.Drawing.Size(150, 30);
            this.btnEnrollments.Name = "btnEnrollments";
            this.btnEnrollments.Size = new System.Drawing.Size(150, 30);
            this.btnEnrollments.TabIndex = 6;
            this.btnEnrollments.Text = "Enrollments";
            this.btnEnrollments.UseVisualStyleBackColor = true;
            this.btnEnrollments.Click += new System.EventHandler(this.btnEnrollments_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.btnEnrollments);
            this.Controls.Add(this.btnClasses);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnAddresses);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnStudent);
            this.Font = new System.Drawing.Font("MS Outlook", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(400, 490);
            this.MinimumSize = new System.Drawing.Size(400, 490);
            this.Name = "MainMenu";
            this.Text = "H&S Educate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnAddresses;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnEnrollments;
    }
}

