namespace HSApp
{
    partial class TeachersForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Taddr = new System.Windows.Forms.TextBox();
            this.Tphone = new System.Windows.Forms.TextBox();
            this.Temail = new System.Windows.Forms.TextBox();
            this.Tgender = new System.Windows.Forms.TextBox();
            this.Tlname = new System.Windows.Forms.TextBox();
            this.Tfname = new System.Windows.Forms.TextBox();
            this.teachID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tdob = new System.Windows.Forms.DateTimePicker();
            this.btnSUP = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Tdata = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tdata)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Taddr
            // 
            this.Taddr.Enabled = false;
            this.Taddr.Location = new System.Drawing.Point(529, 135);
            this.Taddr.Name = "Taddr";
            this.Taddr.Size = new System.Drawing.Size(138, 20);
            this.Taddr.TabIndex = 60;
            // 
            // Tphone
            // 
            this.Tphone.Enabled = false;
            this.Tphone.Location = new System.Drawing.Point(529, 109);
            this.Tphone.Name = "Tphone";
            this.Tphone.Size = new System.Drawing.Size(138, 20);
            this.Tphone.TabIndex = 59;
            // 
            // Temail
            // 
            this.Temail.Enabled = false;
            this.Temail.Location = new System.Drawing.Point(529, 81);
            this.Temail.Name = "Temail";
            this.Temail.Size = new System.Drawing.Size(138, 20);
            this.Temail.TabIndex = 58;
            // 
            // Tgender
            // 
            this.Tgender.Enabled = false;
            this.Tgender.Location = new System.Drawing.Point(282, 184);
            this.Tgender.Name = "Tgender";
            this.Tgender.Size = new System.Drawing.Size(138, 20);
            this.Tgender.TabIndex = 57;
            // 
            // Tlname
            // 
            this.Tlname.Enabled = false;
            this.Tlname.Location = new System.Drawing.Point(282, 132);
            this.Tlname.Name = "Tlname";
            this.Tlname.Size = new System.Drawing.Size(138, 20);
            this.Tlname.TabIndex = 55;
            // 
            // Tfname
            // 
            this.Tfname.Enabled = false;
            this.Tfname.Location = new System.Drawing.Point(282, 106);
            this.Tfname.Name = "Tfname";
            this.Tfname.Size = new System.Drawing.Size(138, 20);
            this.Tfname.TabIndex = 54;
            // 
            // teachID
            // 
            this.teachID.Enabled = false;
            this.teachID.Location = new System.Drawing.Point(282, 81);
            this.teachID.Name = "teachID";
            this.teachID.Size = new System.Drawing.Size(100, 20);
            this.teachID.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(461, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Address ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(444, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "E-mail Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(482, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(215, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(215, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(207, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(230, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(210, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Teacher ID:";
            // 
            // Tdob
            // 
            this.Tdob.Enabled = false;
            this.Tdob.Location = new System.Drawing.Point(282, 158);
            this.Tdob.Name = "Tdob";
            this.Tdob.Size = new System.Drawing.Size(138, 20);
            this.Tdob.TabIndex = 67;
            // 
            // btnSUP
            // 
            this.btnSUP.Enabled = false;
            this.btnSUP.Location = new System.Drawing.Point(440, 276);
            this.btnSUP.Name = "btnSUP";
            this.btnSUP.Size = new System.Drawing.Size(75, 34);
            this.btnSUP.TabIndex = 74;
            this.btnSUP.Text = "Save";
            this.btnSUP.UseVisualStyleBackColor = true;
            this.btnSUP.Click += new System.EventHandler(this.btnSUP_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(275, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "Save New";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(521, 276);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(73, 34);
            this.btnDel.TabIndex = 72;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(194, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 31);
            this.button4.TabIndex = 70;
            this.button4.Text = "Clear Selection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(356, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 69;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(918, 438);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 68;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Tdata
            // 
            this.Tdata.AllowUserToAddRows = false;
            this.Tdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tdata.Location = new System.Drawing.Point(8, 314);
            this.Tdata.Name = "Tdata";
            this.Tdata.ReadOnly = true;
            this.Tdata.RowHeadersWidth = 82;
            this.Tdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tdata.Size = new System.Drawing.Size(866, 336);
            this.Tdata.TabIndex = 75;
            this.Tdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tdata_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(797, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 76;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tdata);
            this.Controls.Add(this.btnSUP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Tdob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Taddr);
            this.Controls.Add(this.Tphone);
            this.Controls.Add(this.Temail);
            this.Controls.Add(this.Tgender);
            this.Controls.Add(this.Tlname);
            this.Controls.Add(this.Tfname);
            this.Controls.Add(this.teachID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "TeachersForm";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.TeachersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Taddr;
        private System.Windows.Forms.TextBox Tphone;
        private System.Windows.Forms.TextBox Temail;
        private System.Windows.Forms.TextBox Tgender;
        private System.Windows.Forms.TextBox Tlname;
        private System.Windows.Forms.TextBox Tfname;
        private System.Windows.Forms.TextBox teachID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Tdob;
        private System.Windows.Forms.Button btnSUP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView Tdata;
        private System.Windows.Forms.Button button2;
    }
}