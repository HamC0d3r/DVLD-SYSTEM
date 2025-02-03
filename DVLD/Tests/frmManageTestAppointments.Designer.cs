namespace DLVD_Project.Tests
{
    partial class frmManageTestAppointments
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            this.pbImgTypeTest = new System.Windows.Forms.PictureBox();
            this.ctrlLDLApplicationInfo1 = new DLVD_Project.Applications.Local_Driving_License.Controls.ctrlLDLApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgTypeTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointments:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(418, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(294, 28);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Type Test Appointments";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 512);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.RowTemplate.Height = 26;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(1058, 219);
            this.dgvAppointments.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.retakeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 60);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(120, 28);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // retakeToolStripMenuItem
            // 
            this.retakeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.retakeToolStripMenuItem.Name = "retakeToolStripMenuItem";
            this.retakeToolStripMenuItem.Size = new System.Drawing.Size(120, 28);
            this.retakeToolStripMenuItem.Text = "Take";
            this.retakeToolStripMenuItem.Click += new System.EventHandler(this.retakeToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(953, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 52);
            this.button1.TabIndex = 139;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 734);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 140;
            this.label2.Text = "Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(80, 734);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(20, 18);
            this.lblRecordsCount.TabIndex = 141;
            this.lblRecordsCount.Text = "#";
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAppointment.Image = global::DLVD_Project.Properties.Resources.AddAppointment_32;
            this.btnAddNewAppointment.Location = new System.Drawing.Point(1028, 466);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(42, 40);
            this.btnAddNewAppointment.TabIndex = 138;
            this.btnAddNewAppointment.UseVisualStyleBackColor = true;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // pbImgTypeTest
            // 
            this.pbImgTypeTest.Image = global::DLVD_Project.Properties.Resources.search;
            this.pbImgTypeTest.Location = new System.Drawing.Point(335, 3);
            this.pbImgTypeTest.Name = "pbImgTypeTest";
            this.pbImgTypeTest.Size = new System.Drawing.Size(86, 81);
            this.pbImgTypeTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgTypeTest.TabIndex = 3;
            this.pbImgTypeTest.TabStop = false;
            // 
            // ctrlLDLApplicationInfo1
            // 
            this.ctrlLDLApplicationInfo1.Location = new System.Drawing.Point(12, 77);
            this.ctrlLDLApplicationInfo1.Name = "ctrlLDLApplicationInfo1";
            this.ctrlLDLApplicationInfo1.Size = new System.Drawing.Size(1060, 386);
            this.ctrlLDLApplicationInfo1.TabIndex = 0;
            // 
            // frmManageTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 793);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.pbImgTypeTest);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLDLApplicationInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageTestAppointments";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Appointments";
            this.Load += new System.EventHandler(this.frmVisionTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgTypeTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Local_Driving_License.Controls.ctrlLDLApplicationInfo ctrlLDLApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbImgTypeTest;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeToolStripMenuItem;
    }
}