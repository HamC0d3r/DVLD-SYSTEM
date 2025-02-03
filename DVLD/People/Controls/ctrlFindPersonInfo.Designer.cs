namespace DLVD_Project
{
    partial class ctrlFindPersonInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlPersonCard1 = new DLVD_Project.ctrlPersonCard();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbfilterType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(5, 77);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(932, 413);
            this.ctrlPersonCard1.TabIndex = 25;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.btnAddNewPerson);
            this.groupBoxFilter.Controls.Add(this.btnFind);
            this.groupBoxFilter.Controls.Add(this.cbfilterType);
            this.groupBoxFilter.Controls.Add(this.label2);
            this.groupBoxFilter.Controls.Add(this.tbFilter);
            this.groupBoxFilter.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(932, 67);
            this.groupBoxFilter.TabIndex = 24;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.Image = global::DLVD_Project.Properties.Resources.search_profile;
            this.btnAddNewPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewPerson.Location = new System.Drawing.Point(578, 24);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(100, 37);
            this.btnAddNewPerson.TabIndex = 23;
            this.btnAddNewPerson.Text = "Add Person";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Image = global::DLVD_Project.Properties.Resources.search_profile;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(472, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 37);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbfilterType
            // 
            this.cbfilterType.BackColor = System.Drawing.SystemColors.Window;
            this.cbfilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilterType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfilterType.FormattingEnabled = true;
            this.cbfilterType.Items.AddRange(new object[] {
            "Person ID",
            "Natonal No"});
            this.cbfilterType.Location = new System.Drawing.Point(80, 30);
            this.cbfilterType.Name = "cbfilterType";
            this.cbfilterType.Size = new System.Drawing.Size(172, 26);
            this.cbfilterType.TabIndex = 20;
            this.cbfilterType.SelectedIndexChanged += new System.EventHandler(this.cbfilterType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Find By:";
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(258, 30);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(204, 26);
            this.tbFilter.TabIndex = 21;
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // ctrlFindPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.groupBoxFilter);
            this.Name = "ctrlFindPersonInfo";
            this.Size = new System.Drawing.Size(943, 509);
            this.Load += new System.EventHandler(this.frmFindPersonInfo_Load);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbfilterType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilter;
    }
}
