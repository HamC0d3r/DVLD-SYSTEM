using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVD_Project
{
    public partial class frmManageApplicationTypes : Form
    {
        DataTable dtApplicationTypes;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _dgvAplicationTypesSettings() 
        {
            dgvApplicationTypes.Columns[0].HeaderText = "Application Type ID";
            //dgvApplicationTypes.Columns[0].Width = 1;

            dgvApplicationTypes.Columns[1].HeaderText = "Application Title";
            //dgvApplicationTypes.Columns[1].Width = 5;

            dgvApplicationTypes.Columns[2].HeaderText = "Application Fees";
            //dgvApplicationTypes.Columns[2].Width = 5;
        }
        private void _LoadData() 
        {
            dtApplicationTypes = clsApplicationTypes.GetAllApplicationTypes();

            dgvApplicationTypes.DataSource = dtApplicationTypes;
            _dgvAplicationTypesSettings();

            lbCountRecords.Text = dtApplicationTypes.Rows.Count.ToString();

        }
        private void frmManageApplications_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }
    }
}
