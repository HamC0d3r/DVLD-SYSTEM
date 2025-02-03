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
    public partial class frmScheduleTest : Form
    {
        private int _LDLApplicationID = -1;
        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        private int _AppointmentID = -1;
        public frmScheduleTest()
        {
            InitializeComponent();
        }
        public frmScheduleTest(int LDLApplicationID, clsTestTypes.enTestType TestTypeID, int AppointmentID = -1)
        {
            InitializeComponent();
            _LDLApplicationID = LDLApplicationID;
            _TestTypeID = TestTypeID;
            _AppointmentID = AppointmentID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            
            ctrlScheduleTest1.TestTypeID = _TestTypeID;
            ctrlScheduleTest1.LoadInfo(_LDLApplicationID, _AppointmentID);
        }
    }
}
