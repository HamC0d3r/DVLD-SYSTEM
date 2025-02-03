using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVD_Project
{
    public partial class frmManageTestTypes : Form
    {
        DataTable dtAllTestTypes;
        public frmManageTestTypes()
        {
            InitializeComponent();
        }
        private void _LoadData() 
        {
            dtAllTestTypes = clsTestTypes.GetAllTestTypes();
            dgvTestTypes.DataSource = dtAllTestTypes;

            lbCountRecords.Text = dtAllTestTypes.Rows.Count.ToString();
        }
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditTestType((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }
    }
}
