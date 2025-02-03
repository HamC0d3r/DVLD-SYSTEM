namespace DLVD_Project
{
    partial class frmShowPersonDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.ctrlPersonCard1 = new DLVD_Project.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(377, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Details";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(393, 496);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(155, 51);
            this.btnCloseForm.TabIndex = 2;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(28, 51);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(943, 439);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // frmShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowPersonDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Details";
            this.Load += new System.EventHandler(this.frmShowPersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseForm;
    }
}