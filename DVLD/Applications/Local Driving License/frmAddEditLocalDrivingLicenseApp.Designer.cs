namespace DLVD_Project
{
    partial class frmAddEditLocalDrivingLicenseApp
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lbCreateBy = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbLDLApplicationID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlFindPersonInfo1 = new DLVD_Project.ctrlFindPersonInfo();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(225, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(548, 34);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpApplicationInfo);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 558);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlFindPersonInfo1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Information";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(369, 596);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 50);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(516, 596);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 50);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(775, 446);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(144, 49);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tpApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lbCreateBy);
            this.tpApplicationInfo.Controls.Add(this.lbApplicationFees);
            this.tpApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.tpApplicationInfo.Controls.Add(this.lbLDLApplicationID);
            this.tpApplicationInfo.Controls.Add(this.label6);
            this.tpApplicationInfo.Controls.Add(this.label5);
            this.tpApplicationInfo.Controls.Add(this.label4);
            this.tpApplicationInfo.Controls.Add(this.label3);
            this.tpApplicationInfo.Controls.Add(this.label2);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 25);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(956, 529);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Information";
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(385, 228);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(236, 29);
            this.cbLicenseClass.TabIndex = 9;
            // 
            // lbCreateBy
            // 
            this.lbCreateBy.AutoSize = true;
            this.lbCreateBy.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateBy.Location = new System.Drawing.Point(381, 351);
            this.lbCreateBy.Name = "lbCreateBy";
            this.lbCreateBy.Size = new System.Drawing.Size(36, 22);
            this.lbCreateBy.TabIndex = 8;
            this.lbCreateBy.Text = "[?]";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(381, 287);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(36, 22);
            this.lbApplicationFees.TabIndex = 7;
            this.lbApplicationFees.Text = "[?]";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(381, 170);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(36, 22);
            this.lbApplicationDate.TabIndex = 6;
            this.lbApplicationDate.Text = "[?]";
            // 
            // lbLDLApplicationID
            // 
            this.lbLDLApplicationID.AutoSize = true;
            this.lbLDLApplicationID.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLDLApplicationID.ForeColor = System.Drawing.Color.Red;
            this.lbLDLApplicationID.Location = new System.Drawing.Point(381, 117);
            this.lbLDLApplicationID.Name = "lbLDLApplicationID";
            this.lbLDLApplicationID.Size = new System.Drawing.Size(36, 22);
            this.lbLDLApplicationID.TabIndex = 5;
            this.lbLDLApplicationID.Text = "[?]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Create By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "License Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L Application ID:";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btClose.Location = new System.Drawing.Point(364, 645);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(126, 50);
            this.btClose.TabIndex = 28;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btSave.Location = new System.Drawing.Point(515, 645);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(125, 50);
            this.btSave.TabIndex = 27;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DLVD_Project.Properties.Resources.file;
            this.pictureBox1.Location = new System.Drawing.Point(155, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlFindPersonInfo1
            // 
            this.ctrlFindPersonInfo1.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlFindPersonInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlFindPersonInfo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlFindPersonInfo1.Name = "ctrlFindPersonInfo1";
            this.ctrlFindPersonInfo1.Size = new System.Drawing.Size(959, 533);
            this.ctrlFindPersonInfo1.TabIndex = 0;
            // 
            // frmAddEditLocalDrivingLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 701);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditLocalDrivingLicenseApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving License Application";
            this.Load += new System.EventHandler(this.frmAddEditLocalDrivingLicenseApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ctrlFindPersonInfo ctrlFindPersonInfo1;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbLDLApplicationID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Label lbCreateBy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}