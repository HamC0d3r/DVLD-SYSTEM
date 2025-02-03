using DLVD_Project.Properties;
using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVD_Project.Tests
{
    public partial class frmManageTestAppointments : Form
    {
        private DataTable _dtTestAppointments;
        private int _LDLApplicationID;
        private clsTestTypes.enTestType _TestType = clsTestTypes.enTestType.VisionTest;

        public frmManageTestAppointments()
        {
            InitializeComponent();
        }
        public frmManageTestAppointments(int LDLApplicationID,clsTestTypes.enTestType TestType) 
        {
            InitializeComponent();
            _LDLApplicationID = LDLApplicationID;
            _TestType = TestType;
        }
        private string _LoadTitleAndImage() 
        {
            switch (_TestType) 
            {
                case clsTestTypes.enTestType.WrittenTest:
                    pbImgTypeTest.Image = Resources.test__3_; 
                    return "Written Test Appointment";
                case clsTestTypes.enTestType.StreetTest:
                    pbImgTypeTest.Image = Resources.driving_test;
                    return "Street Test Appointment";
            }
            pbImgTypeTest.Image = Resources.search;
            return "Vistion Test Appointment";
        }
        private void _LoadData() 
        {
            lbTitle.Text = _LoadTitleAndImage();

            ctrlLDLApplicationInfo1.LoadLDLApplicationInfo(_LDLApplicationID);

            _dtTestAppointments = clsTestAppointments.GetApplicationTestAppointmentsPerTestType(_LDLApplicationID,_TestType);
            dgvAppointments.DataSource = _dtTestAppointments;

            dgvAppointments.DataSource = _dtTestAppointments;
            lblRecordsCount.Text = dgvAppointments.Rows.Count.ToString();

            if (dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvAppointments.Columns[0].Width = 150;

                dgvAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvAppointments.Columns[1].Width = 200;

                dgvAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvAppointments.Columns[2].Width = 150;

                dgvAppointments.Columns[3].HeaderText = "Is Locked";
                dgvAppointments.Columns[3].Width = 100;
            }
        }

        private void frmVisionTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        { 
            clsLDLApplications LDLApplication = clsLDLApplications.FindByLDLApplicationID(_LDLApplicationID);

            if (LDLApplication.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clsTests LastTest = LDLApplication.GetLastTestPerTestType(_TestType);
            if (LastTest == null) 
            {
                Form frm = new frmScheduleTest(_LDLApplicationID, _TestType);
                frm.ShowDialog();
                _LoadData();
                return;
            }

            //if person already passed the last test he cannot retake it 
            if(LastTest.TestResult == true) 
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmScheduleTest frm2 = new frmScheduleTest(LastTest.TestAppointment.LDLApplicationID, _TestType);
            frm2.ShowDialog();
            _LoadData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

            Form frm = new frmScheduleTest(_LDLApplicationID,_TestType, TestAppointmentID);
            frm.ShowDialog();
            _LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void retakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            Form frm = new frmTakeTest(TestAppointmentID, _TestType);
            frm.ShowDialog();   
        }
    }
}
