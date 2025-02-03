using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVD_Project.Applications.Local_Driving_License
{
    public partial class frmShowLDLApplicationDetails : Form
    {
        public frmShowLDLApplicationDetails()
        {
            InitializeComponent();
        }
        public frmShowLDLApplicationDetails(int LDLApplicationID)
        {
            InitializeComponent();
            ctrlLDLApplicationInfo1.LoadLDLApplicationInfo(LDLApplicationID);
        }
    }
}
