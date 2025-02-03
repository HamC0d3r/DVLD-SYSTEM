using DLVD_Project.Properties;
using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVD_Project.Tests.Controls
{
    public partial class ctrlScheduleTest : UserControl
    {
        public enum enMode { AddNew =0,Update = 1 };
        private enMode _Mode = enMode.AddNew;

        public enum enCreationMode { FirstTimeSchedule = 0,RetakeTestSchedule = 1};
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        
        private clsLDLApplications _LDLApplication; 

        private int _LDLApplicationID = -1;

        private clsTestAppointments _TestAppointment;

        private int _TestAppointmentID = -1;

        public clsTestTypes.enTestType TestTypeID  // its propertiy
        {
            get 
            { 
                return _TestTypeID; 
            }

            set 
            { 
                _TestTypeID = value;

                switch (_TestTypeID)
                {
                    case clsTestTypes.enTestType.VisionTest:
                        groupBox1.Text = "Vision Test";
                        pbTestTypeImage.Image = Resources.search;
                        break;
                    case clsTestTypes.enTestType.WrittenTest:
                        groupBox1.Text = "Written Test";
                        pbTestTypeImage.Image = Resources.test__3_;
                        break;
                    case clsTestTypes.enTestType.StreetTest:
                        groupBox1.Text = "Street Test";
                        pbTestTypeImage.Image = Resources.driving_test;
                        break;
                }
            }
        }
        public ctrlScheduleTest()
        {
            InitializeComponent();
        }

        public void LoadInfo(int LDLApplicationID,int AppoinmentID = -1) 
        {
            //if the AppointmentID = -1 this mean AddNew Mode otherwise its Update Mode 
            if (AppoinmentID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            _LDLApplicationID = LDLApplicationID;
            _LDLApplication = clsLDLApplications.FindByLDLApplicationID(_LDLApplicationID);
            _TestAppointmentID = AppoinmentID;
            _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);

            if (_LDLApplication == null) 
            {
                MessageBox.Show("Error: No Local Driving License Application ID = " + _LDLApplicationID , "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            //decide if the createion mode is retake test or not based if the person attended this test before
            if (_LDLApplication.DoesAttendTestType(_TestTypeID))
                _CreationMode = enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;

            if(_CreationMode == enCreationMode.RetakeTestSchedule) 
            {
                lbRetakeAppFees.Text = clsApplicationTypes.Find(9).ApplicationFees.ToString(); // 9 is Retake Test Application
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppID.Text = "0";

                if(_TestAppointment != null)
                      dtpTestDate.MinDate = _TestAppointment.AppointmentDate;
            }
            else 
            {
                gbRetakeTestInfo.Enabled = false;
                lblTitle.Text = "Schedule Test";
                lbRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }

            lblLDLAppID.Text = _LDLApplication.LDLApplicationID.ToString();
            lblDrivingClass.Text = _LDLApplication.LicenseClassInfo.ClassName;
            lblFullName.Text = _LDLApplication.PersonFullName;

            //this will show trials for this test before
            lblTrial.Text = _LDLApplication.TotalTrialsPerTest(_TestTypeID).ToString();

            if(_Mode == enMode.AddNew)
            {
                lblFees.Text = clsTestTypes.Find(_TestTypeID).TestTypeFees.ToString();
                dtpTestDate.MinDate = DateTime.Now;
                lblRetakeTestAppID.Text = "N/A";

                _TestAppointment = new clsTestAppointments();
            }
            else 
            {
                if (!_LoadTestAppointmentData())
                    return;
            }
            
            lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lbRetakeAppFees.Text)).ToString();

            //if the person have Active Appointment befor
            if (!_HandleActiveTestAppointmentConstraint())
                return;

            //if the appointment is loked 
            if(!_HandleAppointmentLockedConstraint()) 
                return;

            //if the person taked Previous test
            if (!_HandlePrviousTestConstraint())
                return;
            
        }

        private bool _LoadTestAppointmentData() 
        {
            
            if(_TestAppointment == null ) 
            {
                MessageBox.Show("Error: No Appoinment with ID =  " + _TestAppointment, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lblFees.Text = _TestAppointment.PaidFees.ToString();

            //we compare the current date with the appointment date to set the min date
            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtpTestDate.MinDate = DateTime.Now;
            else
                dtpTestDate.MinDate = _TestAppointment.AppointmentDate;

            dtpTestDate.Value = _TestAppointment.AppointmentDate;

            // retake testاذا كان الموعد بهدف ال 
            if (_TestAppointment.RetakeTestApplicationID == -1)
            {
                lbRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }
            else 
            {
                lbRetakeAppFees.Text = _TestAppointment.PaidFees.ToString();
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
            }

            return true;
        }

        private bool _HandleActiveTestAppointmentConstraint() 
        {
            if (_Mode == enMode.AddNew && clsLDLApplications.IsThereAnActiveScheduledTest(_LDLApplicationID, _TestTypeID)) 
            {
                lblUserMessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dtpTestDate.Enabled = false;
                return false;
            }
            return true;
        }
        private bool _HandleAppointmentLockedConstraint() 
        {
            //if appoinment is locked that means the person already sat for this test
            //we cannot update locked appointment
            if (_TestAppointment.IsLocked)
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = "Person already sat for the test, appointment loacked.";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;

            }
            else
                lblUserMessage.Visible = false;

            return true;
        }
        private bool _HandlePrviousTestConstraint()
        {
            //we need to make sure that this person passed the prvious required test before apply to the new test.
            //person cannno apply for written test unless s/he passes the vision test.
            //person cannot apply for street test unless s/he passes the written test.

            switch (TestTypeID)
            {
                case clsTestTypes.enTestType.VisionTest:
                    //in this case no required prvious test to pass.
                    lblUserMessage.Visible = false;

                    return true;

                case clsTestTypes.enTestType.WrittenTest:
                    //Written Test, you cannot sechdule it before person passes the vision test.
                    //we check if pass visiontest 1.
                    if (!_LDLApplication.DoesPassTestType(clsTestTypes.enTestType.VisionTest))
                    {
                        lblUserMessage.Text = "Cannot Sechule, Vision Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }


                    return true;

                case clsTestTypes.enTestType.StreetTest:

                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.
                    if (!_LDLApplication.DoesPassTestType(clsTestTypes.enTestType.WrittenTest))
                    {
                        lblUserMessage.Text = "Cannot Sechule, Written Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }


                    return true;

            }
            return true;

        }
        private bool _HandleRetakeApplication() 
        {
            //this will decide to create a seperate application for retake test or not.
            // and will create it if needed , then it will linkit to the appoinment.

            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule) 
            {
                //incase the mode is add new and creation mode is retake test we should create a seperate application for it.
                //then we linke it with the appointment.

                //First Create Applicaiton 
                clsApplications Application = new clsApplications();

                Application.ApplicantPersonID = _LDLApplication.ApplicantPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationStatus = clsApplications.enApplicationStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = clsApplicationTypes.Find(9).ApplicationFees; // 9 is Retake test application type
                Application.CreatedByUserID = Global.CurrentUser.UserID;

                if (!Application.Save()) 
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppointment.RetakeTestApplicationID = Application.ApplicationID;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LDLApplicationID = _LDLApplication.LDLApplicationID;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            _TestAppointment.PaidFees = Convert.ToSingle(lblTotalFees.Text);
            _TestAppointment.CreatedByUserID = Global.CurrentUser.UserID;

            if (_TestAppointment.Save()) 
            {
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
