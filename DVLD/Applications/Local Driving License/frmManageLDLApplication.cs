using DLVD_Project.Applications.Local_Driving_License;
using DLVD_Project.Tests;
using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DLVD_Project
{
    public partial class frmManageLDApplication : Form
    {
        DataTable dtAllLDLApps = new DataTable();

        private enum FilterMode 
        {
            None = 0
            ,LDLApplicationID = 1
            ,NationalNo = 2
            ,FullName  = 3
            ,Status = 4
        };
        private FilterMode _filterType = FilterMode.None;
        public frmManageLDApplication()
        {
            InitializeComponent();
        }
        private DataView _Filter(string filterValue) 
        {
            dtAllLDLApps = clsLDLApplications.GetAllLDLApplications();
            DataView dvLDLApplications = new DataView(dtAllLDLApps);

            switch (_filterType)
            {
                case FilterMode.LDLApplicationID:
                    if(int.TryParse(filterValue,out int insertID))
                        dvLDLApplications.RowFilter = $"LocalDrivingLicenseApplicationID = {insertID}";
                    break;
                case FilterMode.NationalNo:
                    dvLDLApplications.RowFilter = $"NationalNo LIKE '{filterValue}%'";
                    break;
                case FilterMode.FullName:
                    dvLDLApplications.RowFilter = $"FullName LIKE '{filterValue}%'";
                    break;
                case FilterMode.Status:
                    dvLDLApplications.RowFilter = $"Status LIKE '{filterValue}%'";
                    break;
            }
            return dvLDLApplications;
        }
        private void _LoadData(string filterValue = "") 
        { 
            dgvLDLApplications.DataSource = _Filter(filterValue);   
            lbResultRecordsNum.Text = dgvLDLApplications.RowCount.ToString();
        }
        private void frmManageLDApplication_Load(object sender, EventArgs e)
        {
            cbfilterType.SelectedIndex = 0;
            _filterType = _ChangeFillterType();

            _LoadData();
        }
        private FilterMode _ChangeFillterType() 
        {
            _LoadData();
            tbFilter.Visible = true;

            switch (cbfilterType.SelectedIndex) 
            {
                case 0:
                    tbFilter.Visible = false;
                    return FilterMode.None;
                case 1:
                    return FilterMode.LDLApplicationID;
                case 2:
                    return FilterMode.NationalNo;
                case 3:
                    return FilterMode.FullName;
                case 4:
                    return FilterMode.Status;
                default:
                    tbFilter.Visible = false;
                    return FilterMode.None;
            }
            
        }
        private void cbfilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterType = _ChangeFillterType();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            _LoadData(tbFilter.Text);
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditLocalDrivingLicenseApp();
            frm.ShowDialog();
            _LoadData();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditLocalDrivingLicenseApp((int)dgvLDLApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLDLApplications LDLApplication = clsLDLApplications.FindByLDLApplicationID((int)dgvLDLApplications.CurrentRow.Cells[0].Value);
            
            if(LDLApplication != null)
                if (LDLApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    _LoadData();
                }
                else
                {
                    MessageBox.Show("Could not cancel applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLDLApplications LDLApplication = clsLDLApplications.FindByLDLApplicationID((int)dgvLDLApplications.CurrentRow.Cells[0].Value);

            if (LDLApplication.Delete())
            {
                MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh the form again.
                _LoadData();
                
            }
            else
            {
                MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowLDLApplicationDetails((int)dgvLDLApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void _ScheduleTest(clsTestTypes.enTestType TestType)
        {

            int LDLApplications = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;

            Form frm = new frmManageTestAppointments(LDLApplications, TestType);
            frm.ShowDialog();
            _LoadData();
        }
        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypes.enTestType.VisionTest);
        }
        private void sechduleWritenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypes.enTestType.WrittenTest);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypes.enTestType.VisionTest);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            
            clsLDLApplications LDLApplication = clsLDLApplications.FindByLDLApplicationID(LDLApplicationID);


            //Enable Disable Edit , Delete and cancel menues
            if (LDLApplication.DoesPassTestType(clsTestTypes.enTestType.VisionTest))
            {
                editApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = true;
            }
            else 
            {
                editApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = true;
            }

            if (LDLApplication.ApplicationStatus == clsApplications.enApplicationStatus.Completed ) 
                cancelApplicationToolStripMenuItem.Enabled = false;
            else 
                cancelApplicationToolStripMenuItem.Enabled = true;

            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LDLApplication.DoesPassTestType(clsTestTypes.enTestType.VisionTest); ;
            bool PassedWrittenTest = LDLApplication.DoesPassTestType(clsTestTypes.enTestType.WrittenTest);
            bool PassedStreetTest = LDLApplication.DoesPassTestType(clsTestTypes.enTestType.StreetTest);

            ScheduleTestsMenue.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LDLApplication.ApplicationStatus == clsApplications.enApplicationStatus.New);


            if (ScheduleTestsMenue.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                sechduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                sechduleWritenToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                scheduleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }

        }

        private void issueDrivingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
