namespace DLVD_Project
{
    partial class frmAddEditPersonInfo
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
            this.lbMode = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.rdFemail = new System.Windows.Forms.RadioButton();
            this.rdMail = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.ForeColor = System.Drawing.Color.Red;
            this.lbMode.Location = new System.Drawing.Point(490, 19);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(92, 34);
            this.lbMode.TabIndex = 0;
            this.lbMode.Text = "Mode";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(206, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 26);
            this.txtEmail.TabIndex = 41;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPhone.Location = new System.Drawing.Point(612, 265);
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(200, 26);
            this.mtxtPhone.TabIndex = 40;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(891, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 26);
            this.txtLastName.TabIndex = 39;
            // 
            // txtThirdName
            // 
            this.txtThirdName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdName.Location = new System.Drawing.Point(665, 110);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(181, 26);
            this.txtThirdName.TabIndex = 38;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(439, 110);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(181, 26);
            this.txtSecondName.TabIndex = 37;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(212, 110);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 26);
            this.txtFirstName.TabIndex = 36;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalNo.Location = new System.Drawing.Point(212, 184);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(181, 26);
            this.txtNationalNo.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(436, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Date Of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Gendor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "National No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveImage);
            this.groupBox1.Controls.Add(this.btnUploadImage);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.cbCountry);
            this.groupBox1.Controls.Add(this.rdFemail);
            this.groupBox1.Controls.Add(this.rdMail);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.pbPersonImage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 526);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(895, 395);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(155, 30);
            this.btnRemoveImage.TabIndex = 53;
            this.btnRemoveImage.Text = "Remove";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(895, 359);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(155, 30);
            this.btnUploadImage.TabIndex = 52;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(121, 318);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(685, 131);
            this.txtAddress.TabIndex = 44;
            this.txtAddress.Text = "";
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(606, 272);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(200, 26);
            this.cbCountry.TabIndex = 50;
            // 
            // rdFemail
            // 
            this.rdFemail.AutoSize = true;
            this.rdFemail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemail.Location = new System.Drawing.Point(315, 199);
            this.rdFemail.Name = "rdFemail";
            this.rdFemail.Size = new System.Drawing.Size(70, 22);
            this.rdFemail.TabIndex = 48;
            this.rdFemail.TabStop = true;
            this.rdFemail.Text = "Femail";
            this.rdFemail.UseVisualStyleBackColor = true;
            this.rdFemail.CheckedChanged += new System.EventHandler(this.rdFemail_CheckedChanged);
            // 
            // rdMail
            // 
            this.rdMail.AutoSize = true;
            this.rdMail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMail.Location = new System.Drawing.Point(206, 199);
            this.rdMail.Name = "rdMail";
            this.rdMail.Size = new System.Drawing.Size(53, 22);
            this.rdMail.TabIndex = 47;
            this.rdMail.TabStop = true;
            this.rdMail.Text = "Mail";
            this.rdMail.UseVisualStyleBackColor = true;
            this.rdMail.CheckedChanged += new System.EventHandler(this.rdMail_CheckedChanged);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(606, 112);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 26);
            this.dtpDateOfBirth.TabIndex = 46;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(646, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 62);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(471, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 62);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Location = new System.Drawing.Point(840, 112);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(251, 241);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonImage.TabIndex = 31;
            this.pbPersonImage.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Person ID:";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.BackColor = System.Drawing.SystemColors.Control;
            this.lbPersonID.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbPersonID.Location = new System.Drawing.Point(96, 51);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(41, 20);
            this.lbPersonID.TabIndex = 43;
            this.lbPersonID.Text = "N/A";
            // 
            // frmAddEditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 600);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtThirdName);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtNationalNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPersonInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add | Edit Person Information";
            this.Load += new System.EventHandler(this.frmAddEditPersonInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdFemail;
        private System.Windows.Forms.RadioButton rdMail;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnUploadImage;
    }
}