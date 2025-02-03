namespace DLVD_Project
{
    partial class frmManagePeople
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
            this.components = new System.ComponentModel.Container();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.cmActionsData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbfilterType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResultRecordsNum = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.cmActionsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.cmActionsData;
            this.dgvPeople.Location = new System.Drawing.Point(29, 217);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPeople.RowTemplate.Height = 26;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1380, 378);
            this.dgvPeople.TabIndex = 0;
            // 
            // cmActionsData
            // 
            this.cmActionsData.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmActionsData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPersonsToolStripMenuItem,
            this.toolStripSeparator2,
            this.editPersonToolStripMenuItem,
            this.toolStripSeparator3,
            this.deletePersonToolStripMenuItem});
            this.cmActionsData.Name = "contextMenuStrip1";
            this.cmActionsData.ShowCheckMargin = true;
            this.cmActionsData.Size = new System.Drawing.Size(259, 182);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.AutoSize = false;
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.showDetailsToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.focus;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.ShowShortcutKeys = false;
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
            // 
            // addNewPersonsToolStripMenuItem
            // 
            this.addNewPersonsToolStripMenuItem.AutoSize = false;
            this.addNewPersonsToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPersonsToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.add_group;
            this.addNewPersonsToolStripMenuItem.Name = "addNewPersonsToolStripMenuItem";
            this.addNewPersonsToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.addNewPersonsToolStripMenuItem.Text = "Add New Persons";
            this.addNewPersonsToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(255, 6);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.AutoSize = false;
            this.editPersonToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.editPersonToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editPersonToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.resume;
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.editPersonToolStripMenuItem.Text = "Edit Person";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(255, 6);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.AutoSize = false;
            this.deletePersonToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.deletePersonToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.delete;
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.deletePersonToolStripMenuItem.Text = "Delete Person";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(599, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By:";
            // 
            // cbfilterType
            // 
            this.cbfilterType.BackColor = System.Drawing.SystemColors.Window;
            this.cbfilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilterType.FormattingEnabled = true;
            this.cbfilterType.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "Natonal No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.cbfilterType.Location = new System.Drawing.Point(147, 177);
            this.cbfilterType.Name = "cbfilterType";
            this.cbfilterType.Size = new System.Drawing.Size(172, 24);
            this.cbfilterType.TabIndex = 3;
            this.cbfilterType.TextChanged += new System.EventHandler(this.cbfilterType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "# Records:";
            // 
            // lbResultRecordsNum
            // 
            this.lbResultRecordsNum.AutoSize = true;
            this.lbResultRecordsNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultRecordsNum.Location = new System.Drawing.Point(122, 620);
            this.lbResultRecordsNum.Name = "lbResultRecordsNum";
            this.lbResultRecordsNum.Size = new System.Drawing.Size(31, 18);
            this.lbResultRecordsNum.TabIndex = 6;
            this.lbResultRecordsNum.Text = "[?]";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(325, 177);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(191, 24);
            this.tbFilter.TabIndex = 7;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DLVD_Project.Properties.Resources.group;
            this.pictureBox3.Location = new System.Drawing.Point(12, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DLVD_Project.Properties.Resources.management;
            this.pictureBox2.Location = new System.Drawing.Point(632, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DLVD_Project.Properties.Resources.add_group;
            this.pictureBox1.Location = new System.Drawing.Point(1318, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 672);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lbResultRecordsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbfilterType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPeople);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagePeople";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.cmActionsData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbfilterType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResultRecordsNum;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ContextMenuStrip cmActionsData;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}