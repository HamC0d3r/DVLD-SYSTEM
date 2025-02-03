namespace DLVD_Project
{
    partial class frmChangePassword
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
            this.ctrlPersonCard1 = new DLVD_Project.ctrlPersonCard();
            this.ctrlLoginInfo1 = new DLVD_Project.ctrlLoginInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(2, 1);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(943, 439);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlLoginInfo1
            // 
            this.ctrlLoginInfo1.Location = new System.Drawing.Point(90, 434);
            this.ctrlLoginInfo1.Name = "ctrlLoginInfo1";
            this.ctrlLoginInfo1.Size = new System.Drawing.Size(758, 115);
            this.ctrlLoginInfo1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbConfirmPassword);
            this.groupBox1.Controls.Add(this.tbNewPassword);
            this.groupBox1.Controls.Add(this.tbCurrentPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(90, 550);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.Location = new System.Drawing.Point(371, 159);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(213, 28);
            this.tbConfirmPassword.TabIndex = 5;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.tbConfirmPassword_TextChanged);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.Location = new System.Drawing.Point(371, 94);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(213, 28);
            this.tbNewPassword.TabIndex = 4;
            this.tbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPassword_Validating);
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentPassword.Location = new System.Drawing.Point(371, 33);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(213, 28);
            this.tbCurrentPassword.TabIndex = 3;
            this.tbCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrentPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(477, 773);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 49);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(283, 773);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 49);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 825);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlLoginInfo1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private ctrlLoginInfo ctrlLoginInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}