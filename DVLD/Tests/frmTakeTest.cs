using DLVD_Project.Tests.Controls;
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
using static DVLDBusinessLayer.clsTestTypes;

namespace DLVD_Project.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _TestAppointmentID = -1;
        private clsTestTypes.enTestType _TestTypeID;
        clsTests _Test;
        public frmTakeTest()
        {
            InitializeComponent();
        }
        public frmTakeTest(int TestAppointmentID, clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();
            
            _TestAppointmentID = TestAppointmentID;
            _TestTypeID = TestTypeID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.TestTypeID = _TestTypeID;
            ctrlScheduledTest1.LoadInfo(_TestAppointmentID);


            //if have Test
            if (ctrlScheduledTest1.TestID != -1)
            {
                btnSave.Enabled = false;
                rbPass.Enabled = false;
                rbFail.Enabled = false;
                tbNotes.Enabled = false;
                lbMessage.Visible = true;

                _Test = clsTests.Find(ctrlScheduledTest1.TestID);

                if (_Test.TestResult == true)
                    rbPass.Checked = true;
                if (_Test.TestResult == false)
                    rbFail.Checked = true;

                if (_Test.Notes != null)
                {
                    tbNotes.Text = _Test.Notes;
                }
            }
            else //if dont have test
                _Test = new clsTests();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
            "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = tbNotes.Text.Trim();
            _Test.CreatedByUserID = Global.CurrentUser.UserID;

            if (_Test.Save()) 
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
