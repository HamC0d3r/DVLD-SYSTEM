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

namespace DLVD_Project.Applications.Local_Driving_License.Controls
{
    public partial class ctrlLDLApplicationInfo : UserControl
    {
        clsLDLApplications _LDLApplication;
        public ctrlLDLApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadLDLApplicationInfo(int LDLApplicationID) 
        {
            _LDLApplication = clsLDLApplications.FindByLDLApplicationID(LDLApplicationID);

            lbLDLAppID.Text = _LDLApplication.LDLApplicationID.ToString();
            lbAppliedForLicense.Text = _LDLApplication.LicenseClassInfo.ClassName;
            lbPassdTestCount.Text = clsTests.CountHowMuchPassedTest(LDLApplicationID).ToString();

            ctrlBaseApplicationInfo1.LoadApplicationInfo(_LDLApplication.ApplicationID);

        }

    }
}
