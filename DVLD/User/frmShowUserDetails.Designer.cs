namespace DLVD_Project
{
    partial class frmShowUserDetails
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
            this.ctrlLoginInfo1 = new DLVD_Project.ctrlLoginInfo();
            this.ctrlPersonCard1 = new DLVD_Project.ctrlPersonCard();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlLoginInfo1
            // 
            this.ctrlLoginInfo1.Location = new System.Drawing.Point(71, 462);
            this.ctrlLoginInfo1.Name = "ctrlLoginInfo1";
            this.ctrlLoginInfo1.Size = new System.Drawing.Size(750, 115);
            this.ctrlLoginInfo1.TabIndex = 0;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(-1, 28);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(938, 439);
            this.ctrlPersonCard1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Details";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(375, 583);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(124, 46);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 631);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.ctrlLoginInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowUserDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.frmShowUserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLoginInfo ctrlLoginInfo1;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
    }
}