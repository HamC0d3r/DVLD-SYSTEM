namespace DLVD_Project.Tests
{
    partial class frmScheduleTest
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
            this.ctrlScheduleTest1 = new DLVD_Project.Tests.Controls.ctrlScheduleTest();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            this.ctrlScheduleTest1.Location = new System.Drawing.Point(2, -2);
            this.ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            this.ctrlScheduleTest1.Size = new System.Drawing.Size(565, 618);
            this.ctrlScheduleTest1.TabIndex = 0;
            this.ctrlScheduleTest1.TestTypeID = DVLDBusinessLayer.clsTestTypes.enTestType.VisionTest;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(221, 622);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 49);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 679);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlScheduleTest1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScheduleTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleTest";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlScheduleTest ctrlScheduleTest1;
        private System.Windows.Forms.Button btnClose;
    }
}