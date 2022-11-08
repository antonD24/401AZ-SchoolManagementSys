namespace HSApp
{
    partial class Class
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
            this.file = new System.Windows.Forms.Button();
            this.TimeBtn = new System.Windows.Forms.Button();
            this.btnSUP = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ClsData = new System.Windows.Forms.DataGridView();
            this.EID = new System.Windows.Forms.TextBox();
            this.TimeID = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.TID = new System.Windows.Forms.TextBox();
            this.CID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MatID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClsData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 134;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(776, 12);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(96, 49);
            this.file.TabIndex = 141;
            this.file.Text = "Teaching Materials";
            this.file.UseVisualStyleBackColor = true;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // TimeBtn
            // 
            this.TimeBtn.Location = new System.Drawing.Point(776, 76);
            this.TimeBtn.Name = "TimeBtn";
            this.TimeBtn.Size = new System.Drawing.Size(96, 41);
            this.TimeBtn.TabIndex = 142;
            this.TimeBtn.Text = "Timetables";
            this.TimeBtn.UseVisualStyleBackColor = true;
            this.TimeBtn.Click += new System.EventHandler(this.TimeBtn_Click);
            // 
            // btnSUP
            // 
            this.btnSUP.Enabled = false;
            this.btnSUP.Location = new System.Drawing.Point(454, 295);
            this.btnSUP.Name = "btnSUP";
            this.btnSUP.Size = new System.Drawing.Size(75, 34);
            this.btnSUP.TabIndex = 158;
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
            this.btnSave.TabIndex = 157;
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
            this.btnDel.TabIndex = 156;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(208, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 155;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(614, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 31);
            this.button4.TabIndex = 154;
            this.button4.Text = "Clear Selection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(370, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 153;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ClsData
            // 
            this.ClsData.AllowUserToAddRows = false;
            this.ClsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClsData.Location = new System.Drawing.Point(9, 335);
            this.ClsData.Name = "ClsData";
            this.ClsData.ReadOnly = true;
            this.ClsData.RowHeadersWidth = 82;
            this.ClsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClsData.Size = new System.Drawing.Size(861, 264);
            this.ClsData.TabIndex = 152;
            this.ClsData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClsData_CellClick);
            // 
            // EID
            // 
            this.EID.Enabled = false;
            this.EID.Location = new System.Drawing.Point(527, 72);
            this.EID.Name = "EID";
            this.EID.Size = new System.Drawing.Size(100, 20);
            this.EID.TabIndex = 151;
            // 
            // TimeID
            // 
            this.TimeID.Enabled = false;
            this.TimeID.Location = new System.Drawing.Point(527, 101);
            this.TimeID.Name = "TimeID";
            this.TimeID.Size = new System.Drawing.Size(100, 20);
            this.TimeID.TabIndex = 150;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(795, 306);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 149;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TID
            // 
            this.TID.Enabled = false;
            this.TID.Location = new System.Drawing.Point(259, 133);
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(100, 20);
            this.TID.TabIndex = 148;
            // 
            // CID
            // 
            this.CID.Enabled = false;
            this.CID.Location = new System.Drawing.Point(260, 72);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(100, 20);
            this.CID.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(185, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "Teacher ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(448, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 145;
            this.label3.Text = "Enrollment ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(451, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 144;
            this.label2.Text = "Timetable ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(200, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 143;
            this.label1.Text = "Class ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(460, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 159;
            this.label4.Text = "Material ID:";
            // 
            // MatID
            // 
            this.MatID.Enabled = false;
            this.MatID.Location = new System.Drawing.Point(527, 130);
            this.MatID.Name = "MatID";
            this.MatID.Size = new System.Drawing.Size(100, 20);
            this.MatID.TabIndex = 160;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(211, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 161;
            this.label6.Text = "Room:";
            // 
            // Room
            // 
            this.Room.Enabled = false;
            this.Room.Location = new System.Drawing.Point(259, 104);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(100, 20);
            this.Room.TabIndex = 162;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MatID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSUP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ClsData);
            this.Controls.Add(this.EID);
            this.Controls.Add(this.TimeID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeBtn);
            this.Controls.Add(this.file);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(900, 650);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "Class";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button file;
        private System.Windows.Forms.Button TimeBtn;
        private System.Windows.Forms.Button btnSUP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView ClsData;
        private System.Windows.Forms.TextBox EID;
        private System.Windows.Forms.TextBox TimeID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox TID;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MatID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Room;
    }
}