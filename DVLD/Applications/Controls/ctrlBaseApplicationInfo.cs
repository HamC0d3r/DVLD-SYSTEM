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

namespace DLVD_Project.Applications.Controls
{
    public partial class ctrlBaseApplicationInfo : UserControl
    {
        clsApplications _Application;
        public ctrlBaseApplicationInfo()
        {
            InitializeComponent();
        }
        public void LoadApplicationInfo(int ApplicationID) 
        {
            _Application = clsApplications.FindBaseApplication(ApplicationID);
            if (_Application != null) 
            {
                lbID.Text = _Application.ApplicationID.ToString();
                lbStatus.Text = _Application.StatusText;
                lbFees.Text = _Application.PaidFees.ToString();
                lbType.Text = _Application.ApplicationType.ApplicationTypeTitle;
                lbApplicantPersonUserName.Text = _Application.PersonInfo.FullName;
                lbDate.Text = _Application.ApplicationDate.ToString("d");
                lbStatusDate.Text = _Application.LastStatusDate.ToString("d");
                lbCreatedByUser.Text = _Application.CreatedByUserInfo.UserName;

            }
        }
    }
}
