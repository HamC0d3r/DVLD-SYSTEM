namespace DLVD_Project
{
    partial class frmManageLDApplication
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
            this.dgvLDLApplications = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbpagename = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbfilterType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultRecordsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNew = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleTestsMenue = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleWritenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLDLApplications
            // 
            this.dgvLDLApplications.AllowUserToAddRows = false;
            this.dgvLDLApplications.AllowUserToDeleteRows = false;
            this.dgvLDLApplications.AllowUserToOrderColumns = true;
            this.dgvLDLApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLDLApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLDLApplications.Location = new System.Drawing.Point(6, 265);
            this.dgvLDLApplications.Name = "dgvLDLApplications";
            this.dgvLDLApplications.ReadOnly = true;
            this.dgvLDLApplications.RowHeadersWidth = 51;
            this.dgvLDLApplications.RowTemplate.Height = 26;
            this.dgvLDLApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDLApplications.Size = new System.Drawing.Size(1415, 461);
            this.dgvLDLApplications.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.ScheduleTestsMenue,
            this.issueDrivingToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(391, 272);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // lbpagename
            // 
            this.lbpagename.AutoSize = true;
            this.lbpagename.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpagename.ForeColor = System.Drawing.Color.Red;
            this.lbpagename.Location = new System.Drawing.Point(571, 102);
            this.lbpagename.Name = "lbpagename";
            this.lbpagename.Size = new System.Drawing.Size(498, 34);
            this.lbpagename.TabIndex = 18;
            this.lbpagename.Text = "Local Driving License Applications ";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(264, 224);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(191, 24);
            this.tbFilter.TabIndex = 21;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // cbfilterType
            // 
            this.cbfilterType.BackColor = System.Drawing.SystemColors.Window;
            this.cbfilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilterType.FormattingEnabled = true;
            this.cbfilterType.Items.AddRange(new object[] {
            "None",
            "L.D.L ApplicationID",
            "National No",
            "Full Name",
            "Status"});
            this.cbfilterType.Location = new System.Drawing.Point(86, 224);
            this.cbfilterType.Name = "cbfilterType";
            this.cbfilterType.Size = new System.Drawing.Size(172, 24);
            this.cbfilterType.TabIndex = 20;
            this.cbfilterType.SelectedIndexChanged += new System.EventHandler(this.cbfilterType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Filter By:";
            // 
            // lbResultRecordsNum
            // 
            this.lbResultRecordsNum.AutoSize = true;
            this.lbResultRecordsNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultRecordsNum.Location = new System.Drawing.Point(108, 742);
            this.lbResultRecordsNum.Name = "lbResultRecordsNum";
            this.lbResultRecordsNum.Size = new System.Drawing.Size(31, 18);
            this.lbResultRecordsNum.TabIndex = 23;
            this.lbResultRecordsNum.Text = "[?]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 742);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "# Records:";
            // 
            // AddNew
            // 
            this.AddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNew.Image = global::DLVD_Project.Properties.Resources.file;
            this.AddNew.Location = new System.Drawing.Point(1354, 194);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(67, 65);
            this.AddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddNew.TabIndex = 30;
            this.AddNew.TabStop = false;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DLVD_Project.Properties.Resources.work;
            this.pictureBox1.Location = new System.Drawing.Point(359, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showApplicationDetailsToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.focus;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(390, 30);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editApplicationToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.resume;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(390, 30);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteApplicationToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.delete;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(390, 30);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelApplicationToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.cancel;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(390, 30);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // ScheduleTestsMenue
            // 
            this.ScheduleTestsMenue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechduleVisionTestToolStripMenuItem,
            this.sechduleWritenToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.ScheduleTestsMenue.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleTestsMenue.Image = global::DLVD_Project.Properties.Resources.test__2_;
            this.ScheduleTestsMenue.Name = "ScheduleTestsMenue";
            this.ScheduleTestsMenue.Size = new System.Drawing.Size(390, 30);
            this.ScheduleTestsMenue.Text = "Schedule Tests";
            // 
            // sechduleVisionTestToolStripMenuItem
            // 
            this.sechduleVisionTestToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.search;
            this.sechduleVisionTestToolStripMenuItem.Name = "sechduleVisionTestToolStripMenuItem";
            this.sechduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(285, 30);
            this.sechduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.sechduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleVisionTestToolStripMenuItem_Click);
            // 
            // sechduleWritenToolStripMenuItem
            // 
            this.sechduleWritenToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.test__3_;
            this.sechduleWritenToolStripMenuItem.Name = "sechduleWritenToolStripMenuItem";
            this.sechduleWritenToolStripMenuItem.Size = new System.Drawing.Size(285, 30);
            this.sechduleWritenToolStripMenuItem.Text = "Schedule Writen Test";
            this.sechduleWritenToolStripMenuItem.Click += new System.EventHandler(this.sechduleWritenToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.driving_test;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(285, 30);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // issueDrivingToolStripMenuItem
            // 
            this.issueDrivingToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDrivingToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.driving_license;
            this.issueDrivingToolStripMenuItem.Name = "issueDrivingToolStripMenuItem";
            this.issueDrivingToolStripMenuItem.Size = new System.Drawing.Size(390, 30);
            this.issueDrivingToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLicenseToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.driving_license;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(390, 30);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DLVD_Project.Properties.Resources.history_book;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(390, 30);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // frmManageLDApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 784);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.lbResultRecordsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbfilterType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbpagename);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvLDLApplications);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageLDApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmManageLDApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLDLApplications;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbpagename;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbfilterType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultRecordsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestsMenue;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox AddNew;
        private System.Windows.Forms.ToolStripMenuItem sechduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleWritenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
    }
}