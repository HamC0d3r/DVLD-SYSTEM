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
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUsers _UserInfo;
        public frmChangePassword()
        {
            InitializeComponent();
        }
        public frmChangePassword(int UserID) 
        {
            InitializeComponent();
            _UserID = UserID;

            _UserInfo = new clsUsers(_UserID);
            _UserInfo = clsUsers.FindUserByID(_UserID);
        }
        
        private bool _ValidateCurrentPassword() 
        {
            // valedate the current password from database
            if(tbCurrentPassword.Text == _UserInfo.Password) 
            {
                return true;
            }
            return false;
        }
        private bool _Save()
        {
            if (!_ValidateCurrentPassword())
            {
                return false;
            }
            _UserInfo.Password = tbConfirmPassword.Text;
            if (_UserInfo.Save()) 
            {
                return true;
            }

            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Save()) 
            {
                MessageBox.Show("Password Change is Successfuly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Error in save data.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!_ValidateCurrentPassword()) 
            { 
                e.Cancel = false;
                tbCurrentPassword.Focus();
                errorProvider1.SetError(tbCurrentPassword, "Not Correct Password");
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            
            
            ctrlPersonCard1.LoadPersonInfo(_UserInfo.PersonID);
            ctrlLoginInfo1.LoadLoginInfo(_UserID);



        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNewPassword.Text))
            {
                e.Cancel = false;
                tbNewPassword.Focus();
                errorProvider1.SetError(tbNewPassword, "Not Matched Password");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbConfirmPassword.Text != tbNewPassword.Text)
            {
                
                //tbConfirmPassword.Focus();
                errorProvider1.SetError(tbConfirmPassword, "Not Matched Password");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
