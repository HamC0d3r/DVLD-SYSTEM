using DLVD_Project.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DLVD_Project.Tests.Controls
{
    public partial class ctrlScheduledTest : UserControl
    {
        private int _TestAppointmentID = -1;
        private clsLDLApplications _LDLApplication;
        clsTestAppointments _TestAppointment;
        clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        int _TestID;
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
                        gpTestType.Text = "Vision Test";
                        pbTestTypeImage.Image = Resources.search;
                        break;
                    case clsTestTypes.enTestType.WrittenTest:
                        gpTestType.Text = "Written Test";
                        pbTestTypeImage.Image = Resources.test__3_;
                        break;
                    case clsTestTypes.enTestType.StreetTest:
                        gpTestType.Text = "Street Test";
                        pbTestTypeImage.Image = Resources.driving_test;
                        break;
                }
            }
        }
        public ctrlScheduledTest()
        {
            InitializeComponent();
        }
        public int TestID
        {
            get { return _TestID; }
        }

        public void LoadInfo(int TestAppointmentID) 
        {
            _TestAppointmentID = TestAppointmentID;

            _TestAppointment = clsTestAppointments.Find(TestAppointmentID);
            //incase we did not find any appointment.
            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentID.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }
            _LDLApplication = clsLDLApplications.FindByLDLApplicationID(_TestAppointment.LDLApplicationID);

            if (_LDLApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LDLApplication.LDLApplicationID.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestID = _TestAppointment.TestID;

            lbLDLAppID.Text = _TestAppointment.LDLApplicationID.ToString();
            lbClass.Text = _LDLApplication.LicenseClassInfo.ClassName;
            lbName.Text = _LDLApplication.PersonFullName;
            lbTrial.Text = _LDLApplication.TotalTrialsPerTest(_TestAppointment.TestTypeID).ToString();
            lbDate.Text = _TestAppointment.AppointmentDate.ToString("d");
            lbFees.Text = _TestAppointment.PaidFees.ToString();

            lbTestID.Text = _TestID != -1 ? _TestID.ToString() : "Dont Take.";

        }
    }
}
