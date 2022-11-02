namespace HSApp
{
    partial class SubjectsForm
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
            this.StartD = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Bname = new System.Windows.Forms.TextBox();
            this.Subname = new System.Windows.Forms.TextBox();
            this.Subid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubDesc = new System.Windows.Forms.RichTextBox();
            this.EndD = new System.Windows.Forms.DateTimePicker();
            this.btnSUP = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvSub = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub)).BeginInit();
            this.SuspendLayout();
            // 
            // StartD
            // 
            this.StartD.Enabled = false;
            this.StartD.Location = new System.Drawing.Point(263, 126);
            this.StartD.Name = "StartD";
            this.StartD.Size = new System.Drawing.Size(138, 20);
            this.StartD.TabIndex = 90;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(797, 339);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 89;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 84;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bname
            // 
            this.Bname.Enabled = false;
            this.Bname.Location = new System.Drawing.Point(530, 76);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(138, 20);
            this.Bname.TabIndex = 81;
            // 
            // Subname
            // 
            this.Subname.Enabled = false;
            this.Subname.Location = new System.Drawing.Point(263, 101);
            this.Subname.Name = "Subname";
            this.Subname.Size = new System.Drawing.Size(138, 20);
            this.Subname.TabIndex = 78;
            // 
            // Subid
            // 
            this.Subid.Enabled = false;
            this.Subid.Location = new System.Drawing.Point(263, 76);
            this.Subid.Name = "Subid";
            this.Subid.Size = new System.Drawing.Size(100, 20);
            this.Subid.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(477, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Building:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(174, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Subject Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(422, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Subject Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(193, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(196, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(191, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Subject ID:";
            // 
            // SubDesc
            // 
            this.SubDesc.Enabled = false;
            this.SubDesc.Location = new System.Drawing.Point(529, 114);
            this.SubDesc.Name = "SubDesc";
            this.SubDesc.Size = new System.Drawing.Size(278, 96);
            this.SubDesc.TabIndex = 91;
            this.SubDesc.Text = "";
            // 
            // EndD
            // 
            this.EndD.Enabled = false;
            this.EndD.Location = new System.Drawing.Point(263, 152);
            this.EndD.Name = "EndD";
            this.EndD.Size = new System.Drawing.Size(138, 20);
            this.EndD.TabIndex = 92;
            // 
            // btnSUP
            // 
            this.btnSUP.Enabled = false;
            this.btnSUP.Location = new System.Drawing.Point(444, 313);
            this.btnSUP.Name = "btnSUP";
            this.btnSUP.Size = new System.Drawing.Size(80, 40);
            this.btnSUP.TabIndex = 99;
            this.btnSUP.Text = "Save";
            this.btnSUP.UseVisualStyleBackColor = true;
            this.btnSUP.Click += new System.EventHandler(this.btnSUP_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(252, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 98;
            this.btnSave.Text = "Save New";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(546, 313);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 40);
            this.btnDel.TabIndex = 97;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(158, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 96;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(653, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 40);
            this.button4.TabIndex = 95;
            this.button4.Text = "Clear Selection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 40);
            this.btnUpdate.TabIndex = 94;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvSub
            // 
            this.dgvSub.AllowUserToAddRows = false;
            this.dgvSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSub.Location = new System.Drawing.Point(12, 368);
            this.dgvSub.Name = "dgvSub";
            this.dgvSub.ReadOnly = true;
            this.dgvSub.RowHeadersWidth = 82;
            this.dgvSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSub.Size = new System.Drawing.Size(860, 231);
            this.dgvSub.TabIndex = 93;
            this.dgvSub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stData_CellClick);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.btnSUP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvSub);
            this.Controls.Add(this.EndD);
            this.Controls.Add(this.SubDesc);
            this.Controls.Add(this.StartD);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.Subname);
            this.Controls.Add(this.Subid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(900, 650);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "SubjectsForm";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.SubjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartD;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Bname;
        private System.Windows.Forms.TextBox Subname;
        private System.Windows.Forms.TextBox Subid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox SubDesc;
        private System.Windows.Forms.DateTimePicker EndD;
        private System.Windows.Forms.Button btnSUP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvSub;
    }
}