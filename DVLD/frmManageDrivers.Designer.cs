namespace DLVD_Project
{
    partial class frmManageDrivers
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
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.lbResultRecordsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbpagename = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbfilterType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AllowUserToOrderColumns = true;
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Location = new System.Drawing.Point(12, 226);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.RowHeadersWidth = 51;
            this.dgvDrivers.RowTemplate.Height = 26;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Size = new System.Drawing.Size(1415, 461);
            this.dgvDrivers.TabIndex = 6;
            // 
            // lbResultRecordsNum
            // 
            this.lbResultRecordsNum.AutoSize = true;
            this.lbResultRecordsNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultRecordsNum.Location = new System.Drawing.Point(108, 690);
            this.lbResultRecordsNum.Name = "lbResultRecordsNum";
            this.lbResultRecordsNum.Size = new System.Drawing.Size(31, 18);
            this.lbResultRecordsNum.TabIndex = 25;
            this.lbResultRecordsNum.Text = "[?]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 690);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "# Records:";
            // 
            // lbpagename
            // 
            this.lbpagename.AutoSize = true;
            this.lbpagename.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpagename.ForeColor = System.Drawing.Color.Red;
            this.lbpagename.Location = new System.Drawing.Point(717, 80);
            this.lbpagename.Name = "lbpagename";
            this.lbpagename.Size = new System.Drawing.Size(235, 34);
            this.lbpagename.TabIndex = 26;
            this.lbpagename.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DLVD_Project.Properties.Resources.driver;
            this.pictureBox1.Location = new System.Drawing.Point(537, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(270, 194);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(191, 24);
            this.tbFilter.TabIndex = 30;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // cbfilterType
            // 
            this.cbfilterType.BackColor = System.Drawing.SystemColors.Window;
            this.cbfilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilterType.FormattingEnabled = true;
            this.cbfilterType.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "National No",
            "Full Name",
            "Number of active licenses"});
            this.cbfilterType.Location = new System.Drawing.Point(92, 194);
            this.cbfilterType.Name = "cbfilterType";
            this.cbfilterType.Size = new System.Drawing.Size(172, 24);
            this.cbfilterType.TabIndex = 29;
            this.cbfilterType.SelectedIndexChanged += new System.EventHandler(this.cbfilterType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Filter By:";
            // 
            // frmManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 717);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbfilterType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbpagename);
            this.Controls.Add(this.lbResultRecordsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDrivers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Drivers";
            this.Load += new System.EventHandler(this.frmManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.Label lbResultRecordsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbpagename;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbfilterType;
        private System.Windows.Forms.Label label2;
    }
}