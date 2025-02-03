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
    public partial class frmAddEditLocalDrivingLicenseApp : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private int _LDLApplicationID = -1;

        private int _SelectedPersonID = -1;

        private clsLDLApplications _LDLApplication;
        public frmAddEditLocalDrivingLicenseApp()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddEditLocalDrivingLicenseApp(int LDLApplicationID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _LDLApplicationID = LDLApplicationID;
        }
        private void _FillcbLiceseClass() 
        {
            DataTable AllLicenseClass = clsLicenseClass.GetAllLicenseClasses();
            foreach (DataRow row in AllLicenseClass.Rows) 
            {
                cbLicenseClass.Items.Add(row["ClassName"]);
            }
        }
        private void _LoadData() 
        {
            _LDLApplication = clsLDLApplications.FindByLDLApplicationID(this._LDLApplicationID);

            if (_LDLApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LDLApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            ctrlFindPersonInfo1.LoadPersonInfo(_LDLApplication.ApplicantPersonID);
            lbLDLApplicationID.Text = _LDLApplication.LDLApplicationID.ToString();
            lbApplicationDate.Text = _LDLApplication.ApplicationDate.ToString("d");
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassName);
            lbApplicationFees.Text = _LDLApplication.PaidFees.ToString();
            lbCreateBy.Text = clsUsers.FindUserByID(_LDLApplication.CreatedByUserID).UserName;
        }
        private void _ResetDefualtValues() 
        {
            _FillcbLiceseClass();
            
            if (_Mode == enMode.AddNew)
            {
                lbTitle.Text = "New Local Driving License Application";
                tpApplicationInfo.Enabled = false;
                btSave.Enabled = false;

                _LDLApplication = new clsLDLApplications();
                _LDLApplication.ApplicationType = clsApplicationTypes.Find(1); // 1 -> this index record New Driving License 
                
                lbApplicationDate.Text = DateTime.Now.ToString("d");
                cbLicenseClass.SelectedIndex = 2; // default class selected
                lbApplicationFees.Text = _LDLApplication.ApplicationType.ApplicationFees.ToString();
                lbCreateBy.Text = Global.CurrentUser.UserName;
            }
            else 
            {
                
                lbTitle.Text = "Update Local Driving License Application";
                tpApplicationInfo.Enabled = true;

            }
            

        }


        private void _Save() 
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int LicenseClassID = clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID;

            int ActiveApplicationID = clsApplications.GetActiveApplicationIDForLicenseClass(ctrlFindPersonInfo1.PersonID, _LDLApplication.ApplicationType.ApplicationTypeID, LicenseClassID);
            
            if(ActiveApplicationID != -1) 
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClass.Focus();
                return;
            }

            ///////// if(clsL)
            _LDLApplication.ApplicantPersonID = ctrlFindPersonInfo1.PersonID;
            _LDLApplication.ApplicationDate = DateTime.Now;
            _LDLApplication.ApplicationTypeID = 1; // New Driving License
            _LDLApplication.ApplicationStatus = clsApplications.enApplicationStatus.New;
            _LDLApplication.LastStatusDate = DateTime.Now;
            _LDLApplication.PaidFees = Convert.ToSingle(lbApplicationFees.Text);
            _LDLApplication.CreatedByUserID = Global.CurrentUser.UserID;
            _LDLApplication.LicenseClassID = LicenseClassID;

            if (_LDLApplication.Save()) 
            {
                lbLDLApplicationID.Text = _LDLApplication.LDLApplicationID.ToString();

                //change form mode to update.
                _Mode = enMode.Update;
                lbTitle.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmAddEditLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                btSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tabControl1.SelectTab(tpApplicationInfo);
                return;
            }


            //incase of add new mode.
            if (ctrlFindPersonInfo1.PersonID != -1)
            {

                btSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tabControl1.SelectTab(tpApplicationInfo);

            }

            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
