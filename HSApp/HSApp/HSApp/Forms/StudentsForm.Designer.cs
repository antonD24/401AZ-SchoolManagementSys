namespace HSApp
{
    partial class StudentsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stuID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sDOB = new System.Windows.Forms.DateTimePicker();
            this.sFname = new System.Windows.Forms.TextBox();
            this.sLname = new System.Windows.Forms.TextBox();
            this.sGender = new System.Windows.Forms.TextBox();
            this.sEmail = new System.Windows.Forms.TextBox();
            this.sPhone = new System.Windows.Forms.TextBox();
            this.sAddr = new System.Windows.Forms.TextBox();
            this.stData = new System.Windows.Forms.DataGridView();
            this.btnSUP = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(219, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(234, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(219, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(486, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(448, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "E-mail Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(465, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Address ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stuID
            // 
            this.stuID.Enabled = false;
            this.stuID.Location = new System.Drawing.Point(286, 81);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(138, 20);
            this.stuID.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(211, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(219, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name:";
            // 
            // sDOB
            // 
            this.sDOB.Enabled = false;
            this.sDOB.Location = new System.Drawing.Point(286, 158);
            this.sDOB.Name = "sDOB";
            this.sDOB.Size = new System.Drawing.Size(138, 20);
            this.sDOB.TabIndex = 23;
            // 
            // sFname
            // 
            this.sFname.Enabled = false;
            this.sFname.Location = new System.Drawing.Point(286, 105);
            this.sFname.Name = "sFname";
            this.sFname.Size = new System.Drawing.Size(138, 20);
            this.sFname.TabIndex = 25;
            // 
            // sLname
            // 
            this.sLname.Enabled = false;
            this.sLname.Location = new System.Drawing.Point(286, 131);
            this.sLname.Name = "sLname";
            this.sLname.Size = new System.Drawing.Size(138, 20);
            this.sLname.TabIndex = 26;
            // 
            // sGender
            // 
            this.sGender.Enabled = false;
            this.sGender.Location = new System.Drawing.Point(285, 184);
            this.sGender.Name = "sGender";
            this.sGender.Size = new System.Drawing.Size(138, 20);
            this.sGender.TabIndex = 27;
            // 
            // sEmail
            // 
            this.sEmail.Enabled = false;
            this.sEmail.Location = new System.Drawing.Point(532, 81);
            this.sEmail.Name = "sEmail";
            this.sEmail.Size = new System.Drawing.Size(170, 20);
            this.sEmail.TabIndex = 28;
            // 
            // sPhone
            // 
            this.sPhone.Enabled = false;
            this.sPhone.Location = new System.Drawing.Point(532, 107);
            this.sPhone.Name = "sPhone";
            this.sPhone.Size = new System.Drawing.Size(170, 20);
            this.sPhone.TabIndex = 29;
            // 
            // sAddr
            // 
            this.sAddr.Enabled = false;
            this.sAddr.Location = new System.Drawing.Point(532, 138);
            this.sAddr.Name = "sAddr";
            this.sAddr.Size = new System.Drawing.Size(97, 20);
            this.sAddr.TabIndex = 30;
            // 
            // stData
            // 
            this.stData.AllowUserToAddRows = false;
            this.stData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stData.Location = new System.Drawing.Point(12, 327);
            this.stData.Name = "stData";
            this.stData.ReadOnly = true;
            this.stData.RowHeadersWidth = 82;
            this.stData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stData.Size = new System.Drawing.Size(860, 422);
            this.stData.TabIndex = 31;
            this.stData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stData_CellClick);
            // 
            // btnSUP
            // 
            this.btnSUP.Enabled = false;
            this.btnSUP.Location = new System.Drawing.Point(451, 274);
            this.btnSUP.Name = "btnSUP";
            this.btnSUP.Size = new System.Drawing.Size(75, 34);
            this.btnSUP.TabIndex = 38;
            this.btnSUP.Text = "Save";
            this.btnSUP.UseVisualStyleBackColor = true;
            this.btnSUP.Click += new System.EventHandler(this.btnSUP_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(286, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save New";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(532, 274);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(73, 34);
            this.btnDel.TabIndex = 36;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(611, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 31);
            this.button4.TabIndex = 34;
            this.button4.Text = "Clear Selection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(367, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(924, 534);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(797, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSUP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.stData);
            this.Controls.Add(this.sAddr);
            this.Controls.Add(this.sPhone);
            this.Controls.Add(this.sEmail);
            this.Controls.Add(this.sGender);
            this.Controls.Add(this.sLname);
            this.Controls.Add(this.sFname);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.sDOB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(900, 800);
            this.MinimumSize = new System.Drawing.Size(900, 800);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox stuID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker sDOB;
        private System.Windows.Forms.TextBox sFname;
        private System.Windows.Forms.TextBox sLname;
        private System.Windows.Forms.TextBox sGender;
        private System.Windows.Forms.TextBox sEmail;
        private System.Windows.Forms.TextBox sPhone;
        private System.Windows.Forms.TextBox sAddr;
        private System.Windows.Forms.DataGridView stData;
        private System.Windows.Forms.Button btnSUP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button2;
    }
}