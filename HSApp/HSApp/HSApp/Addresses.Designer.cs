namespace HSApp
{
    partial class Addresses
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
            this.dgvAddr = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addID = new System.Windows.Forms.TextBox();
            this.addLine = new System.Windows.Forms.TextBox();
            this.addCounty = new System.Windows.Forms.TextBox();
            this.addCity = new System.Windows.Forms.TextBox();
            this.addPost = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSUP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddr)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddr
            // 
            this.dgvAddr.AllowUserToAddRows = false;
            this.dgvAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddr.Location = new System.Drawing.Point(354, 12);
            this.dgvAddr.Name = "dgvAddr";
            this.dgvAddr.ReadOnly = true;
            this.dgvAddr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddr.Size = new System.Drawing.Size(434, 571);
            this.dgvAddr.TabIndex = 0;
            this.dgvAddr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddr_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adress Line:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "County:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Postcode:";
            // 
            // addID
            // 
            this.addID.Enabled = false;
            this.addID.Location = new System.Drawing.Point(123, 69);
            this.addID.Name = "addID";
            this.addID.Size = new System.Drawing.Size(178, 20);
            this.addID.TabIndex = 6;
            // 
            // addLine
            // 
            this.addLine.Enabled = false;
            this.addLine.Location = new System.Drawing.Point(123, 95);
            this.addLine.Name = "addLine";
            this.addLine.Size = new System.Drawing.Size(178, 20);
            this.addLine.TabIndex = 7;
            // 
            // addCounty
            // 
            this.addCounty.Enabled = false;
            this.addCounty.Location = new System.Drawing.Point(123, 121);
            this.addCounty.Name = "addCounty";
            this.addCounty.Size = new System.Drawing.Size(178, 20);
            this.addCounty.TabIndex = 8;
            // 
            // addCity
            // 
            this.addCity.Enabled = false;
            this.addCity.Location = new System.Drawing.Point(123, 147);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(178, 20);
            this.addCity.TabIndex = 9;
            // 
            // addPost
            // 
            this.addPost.Enabled = false;
            this.addPost.Location = new System.Drawing.Point(123, 173);
            this.addPost.Name = "addPost";
            this.addPost.Size = new System.Drawing.Size(178, 20);
            this.addPost.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(273, 560);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(250, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(147, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 18;
            this.button4.Text = "Clear Selection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(40, 323);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 38);
            this.btnDel.TabIndex = 20;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Main Menu";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(147, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save New";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSUP
            // 
            this.btnSUP.Enabled = false;
            this.btnSUP.Location = new System.Drawing.Point(250, 323);
            this.btnSUP.Name = "btnSUP";
            this.btnSUP.Size = new System.Drawing.Size(75, 38);
            this.btnSUP.TabIndex = 23;
            this.btnSUP.Text = "Save";
            this.btnSUP.UseVisualStyleBackColor = true;
            this.btnSUP.Click += new System.EventHandler(this.btnSUP_Click);
            // 
            // Addresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.btnSUP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.addPost);
            this.Controls.Add(this.addCity);
            this.Controls.Add(this.addCounty);
            this.Controls.Add(this.addLine);
            this.Controls.Add(this.addID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAddr);
            this.Name = "Addresses";
            this.Text = "Addresses";
            this.Load += new System.EventHandler(this.Addresses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addID;
        private System.Windows.Forms.TextBox addLine;
        private System.Windows.Forms.TextBox addCounty;
        private System.Windows.Forms.TextBox addCity;
        private System.Windows.Forms.TextBox addPost;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSUP;
    }
}