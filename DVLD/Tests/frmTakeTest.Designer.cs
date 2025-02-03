namespace DLVD_Project.Tests
{
    partial class frmTakeTest
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
            this.label8 = new System.Windows.Forms.Label();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.tbNotes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.ctrlScheduledTest1 = new DLVD_Project.Tests.Controls.ctrlScheduledTest();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 188;
            this.label8.Text = "Result:";
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFail.ForeColor = System.Drawing.Color.Red;
            this.rbFail.Image = global::DLVD_Project.Properties.Resources.icons8_fail_50;
            this.rbFail.Location = new System.Drawing.Point(248, 482);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(124, 50);
            this.rbFail.TabIndex = 191;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Fail";
            this.rbFail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPass.ForeColor = System.Drawing.Color.ForestGreen;
            this.rbPass.Image = global::DLVD_Project.Properties.Resources.icons8_pass_50;
            this.rbPass.Location = new System.Drawing.Point(96, 482);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(130, 50);
            this.rbPass.TabIndex = 189;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(92, 548);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(386, 113);
            this.tbNotes.TabIndex = 192;
            this.tbNotes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 193;
            this.label1.Text = "Notes:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(222, 667);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.TabIndex = 194;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(353, 667);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 50);
            this.btnSave.TabIndex = 195;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(20, 455);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(154, 21);
            this.lbMessage.TabIndex = 196;
            this.lbMessage.Text = "[-] Can\'t change.";
            this.lbMessage.Visible = false;
            // 
            // ctrlScheduledTest1
            // 
            this.ctrlScheduledTest1.Location = new System.Drawing.Point(4, -1);
            this.ctrlScheduledTest1.Name = "ctrlScheduledTest1";
            this.ctrlScheduledTest1.Size = new System.Drawing.Size(500, 453);
            this.ctrlScheduledTest1.TabIndex = 0;
            this.ctrlScheduledTest1.TestTypeID = DVLDBusinessLayer.clsTestTypes.enTestType.VisionTest;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 722);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ctrlScheduledTest1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTakeTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlScheduledTest ctrlScheduledTest1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.RichTextBox tbNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbMessage;
    }
}