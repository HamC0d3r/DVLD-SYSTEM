namespace DLVD_Project.Applications.Local_Driving_License
{
    partial class frmShowLDLApplicationDetails
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
            this.ctrlLDLApplicationInfo1 = new DLVD_Project.Applications.Local_Driving_License.Controls.ctrlLDLApplicationInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlLDLApplicationInfo1
            // 
            this.ctrlLDLApplicationInfo1.Location = new System.Drawing.Point(5, 83);
            this.ctrlLDLApplicationInfo1.Name = "ctrlLDLApplicationInfo1";
            this.ctrlLDLApplicationInfo1.Size = new System.Drawing.Size(1064, 476);
            this.ctrlLDLApplicationInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "L.D.L Application Details";
            // 
            // frmLDLApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLDLApplicationInfo1);
            this.Name = "frmLDLApplicationDetails";
            this.Text = "frmLDLApplicationDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlLDLApplicationInfo ctrlLDLApplicationInfo1;
        private System.Windows.Forms.Label label1;
    }
}