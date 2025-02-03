using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DLVD_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ctrlLoginInfo1.LoadLoginInfo(Global.CurrentUser.UserID);
        }

        private void _Logout() 
        {
            this.Hide();

            //Logout
            Form frm = new frmLogin();
            frm.ShowDialog();
        }
        private void pbLogout_Click(object sender, EventArgs e)
        {
            _Logout();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowUserDetails(Global.CurrentUser.PersonID,Global.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void chToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(Global.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Logout();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageLDApplication();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditLocalDrivingLicenseApp();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageDrivers();
            frm.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManagePeople();
            frm.ShowDialog();
        }


    }
}
