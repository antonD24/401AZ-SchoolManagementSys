namespace HSApp
{
    partial class EnrollmentsForm
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
            this.Cid = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Sid = new System.Windows.Forms.TextBox();
            this.Eid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Edate = new System.Windows.Forms.DateTimePicker();
            this.btnSUP = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.EData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EData)).BeginInit();
            this.SuspendLayout();
            // 
            // Cid
            // 
            this.Cid.Enabled = false;
            this.Cid.Location = new System.Drawing.Point(263, 127);
            this.Cid.Name = "Cid";
            this.Cid.Size = new System.Drawing.Size(100, 20);
            this.Cid.TabIndex = 125;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(795, 306);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 123;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 118;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sid
            // 
            this.Sid.Enabled = false;
            this.Sid.Location = new System.Drawing.Point(263, 101);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(100, 20);
            this.Sid.TabIndex = 117;
            // 
            // Eid
            // 
            this.Eid.Enabled = false;
            this.Eid.Location = new System.Drawing.Point(263, 76);
            this.Eid.Name = "Eid";
            this.Eid.Size = new System.Drawing.Size(100, 20);
            this.Eid.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(197, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(184, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Enrollment ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(200, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Course ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(160, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Date of Enrollment:";
            // 
            // Edate
            // 
            this.Edate.Enabled = false;
            this.Edate.Location = new System.Drawing.Point(263, 156);
            this.Edate.Name = "Edate";
            this.Edate.Size = new System.Drawing.Size(134, 20);
            this.Edate.TabIndex = 127;
            // 
            // btnSUP
            // 
            this.btnSUP.Enabled = false;
            this.btnSUP.Location = new System.Drawing.Point(454, 295);
            this.btnSUP.Name = "btnSUP";
            this.btnSUP.Size = new System.Drawing.Size(75, 34);
            this.btnSUP.TabIndex = 134;
            this.btnSUP.Text = "Save";
            this.btnSUP.UseVisualStyleBackColor = true;
            this.btnSUP.Click += new System.EventHandler(this.btnSUP_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(289, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 133;
            this.btnSave.Text = "Save New";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(535, 295);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(73, 34);
            this.btnDel.TabIndex = 132;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(208, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 131;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(614, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 31);
            this.button4.TabIndex = 130;
            this.button4.Text = "Clear Selection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(370, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 129;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EData
            // 
            this.EData.AllowUserToAddRows = false;
            this.EData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EData.Location = new System.Drawing.Point(9, 335);
            this.EData.Name = "EData";
            this.EData.ReadOnly = true;
            this.EData.RowHeadersWidth = 82;
            this.EData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EData.Size = new System.Drawing.Size(866, 314);
            this.EData.TabIndex = 128;
            this.EData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EData_CellClick);
            // 
            // EnrollmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnSUP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.EData);
            this.Controls.Add(this.Edate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cid);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sid);
            this.Controls.Add(this.Eid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "EnrollmentsForm";
            this.Text = "Enrollments";
            this.Load += new System.EventHandler(this.EnrollmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cid;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Sid;
        private System.Windows.Forms.TextBox Eid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Edate;
        private System.Windows.Forms.Button btnSUP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView EData;
    }
}