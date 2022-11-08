namespace HSApp
{
    partial class TeachMatForm
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
            this.menu = new System.Windows.Forms.Button();
            this.Mdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Matid = new System.Windows.Forms.TextBox();
            this.Mname = new System.Windows.Forms.TextBox();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mdata)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(12, 21);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 23);
            this.menu.TabIndex = 0;
            this.menu.Text = "Main Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Mdata
            // 
            this.Mdata.AllowUserToAddRows = false;
            this.Mdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mdata.Location = new System.Drawing.Point(12, 264);
            this.Mdata.Name = "Mdata";
            this.Mdata.ReadOnly = true;
            this.Mdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Mdata.Size = new System.Drawing.Size(460, 285);
            this.Mdata.TabIndex = 0;
            this.Mdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mdata_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(111, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Material ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(94, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Material Name:";
            // 
            // Matid
            // 
            this.Matid.Enabled = false;
            this.Matid.Location = new System.Drawing.Point(178, 80);
            this.Matid.Name = "Matid";
            this.Matid.Size = new System.Drawing.Size(100, 20);
            this.Matid.TabIndex = 4;
            // 
            // Mname
            // 
            this.Mname.Enabled = false;
            this.Mname.Location = new System.Drawing.Point(178, 131);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(100, 20);
            this.Mname.TabIndex = 5;
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(12, 223);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(75, 23);
            this.btnUP.TabIndex = 6;
            this.btnUP.Text = "Upload";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(93, 223);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Download";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(397, 223);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TeachMatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.Matid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mdata);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "TeachMatForm";
            this.Text = "Teaching Materials";
            this.Load += new System.EventHandler(this.TeachMatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.DataGridView Mdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Matid;
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
    }
}