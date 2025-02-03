using DVLDBusinessLayer;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVD_Project
{
    public partial class frmAddEditUser : Form
    {
        private int _PersonID;
        //private clsPeople _Person;
        private int _UserID;
        private clsUsers _User;

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddEditUser(int UserID , int PersonID) 
        {
            InitializeComponent();
            _UserID = UserID;
            _PersonID = PersonID;
            _Mode = enMode.Update;
        }

        private void _LoadUserInfo() 
        {
            
            this._User = clsUsers.FindUserByID(_UserID);

            lbUserID.Text = _User.UserID.ToString();
            tbUserName.Text = _User.UserName;
            
            if(_User.IsActive) 
            {
                checkBoxIsActive.Checked = true;
            }
        }
        private void _SettingUpdateMode()
        {
            _Mode = enMode.Update;
            lbMode.Text = "Update User";
        }
        private void _SettingAddNewMode()
        {
            _Mode = enMode.AddNew;
            lbMode.Text = "Add New User";
        }
        private void _LoadDefualtData() 
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _SettingAddNewMode();
                    


                    break;
                case enMode.Update:
                    _SettingUpdateMode();

                    ctrlFindPersonInfo1.LoadPersonInfo(_PersonID);
                    _LoadUserInfo();
                    break;
            }
        }
        private clsUsers _CollecteNewUserInfo() 
        {
            _User.UserID = _UserID;

            if (ctrlFindPersonInfo1.Person != null)
                _User.PeopleInfo = ctrlFindPersonInfo1.Person;
            else
            {
                MessageBox.Show("Not Found Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _User.UserName = tbUserName.Text;
            _User.Password = tbPassword.Text;
            _User.IsActive = checkBoxIsActive.Checked;
            
            return _User;
        }

        private void _Save() 
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _User = new clsUsers();
                    if (_CollecteNewUserInfo().Save())
                        MessageBox.Show("Add is successfuly");
                    else
                        MessageBox.Show("PLZ Enter All Fileds ...");

                    //return mode to update
                    _SettingUpdateMode();
                    
                    _UserID = _User.UserID;
                    lbUserID.Text = _UserID.ToString();

                    break;
                case enMode.Update:
                    _User = new clsUsers(_UserID);

                    if (_CollecteNewUserInfo().Save())
                        MessageBox.Show("Update is successfuly");
                    else
                        MessageBox.Show("PLZ Enter All Fileds ...");

                    //fill data after edit
                    _LoadUserInfo();

                    break;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadDefualtData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (clsUsers.IsPersonIDExistUsers(ctrlFindPersonInfo1.PersonID)) 
            {
                MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                tabControl1.SelectedIndex = 1;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(tbConfirmPassword.Text != tbPassword.Text) 
            {
                e.Cancel = false;
                //tbConfirmPassword.Focus();
                errorProvider1.SetError(tbConfirmPassword, "Not Matched Password");
            }
            else 
            {
                errorProvider1.Clear();
            }
        }
        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                e.Cancel = false;
                tbPassword.Focus();
                errorProvider1.SetError(tbPassword, "Not Matched Password");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

    }
}