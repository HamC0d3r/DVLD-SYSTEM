using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DVLDBusinessLayer;

namespace DLVD_Project
{
    public partial class frmManageUsers : Form
    {
        DataTable dtAllUsers;

        enum enTypesFilter
        {
            None = 0,
            UserID = 1,
            UserName = 2,
            PersonID = 3,
            FullName = 4,
            IsActive = 5,
        };
        private enTypesFilter _ModeTypeFilter;
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private enTypesFilter _ChangeFilterType() 
        {
            tbFilter.Visible = true;
            cbActiveStatus.Visible = false;

            switch (cbfilterType.SelectedIndex) 
            {
                case 0:
                    tbFilter.Visible = false;
                    return enTypesFilter.None;
                case 1: return enTypesFilter.UserID;
                case 2: return enTypesFilter.UserName;
                case 3: return enTypesFilter.PersonID;
                case 4: return enTypesFilter.FullName;
                case 5:
                    tbFilter.Visible = false;
                    cbActiveStatus.Visible = true;
                    return enTypesFilter.IsActive;
            }
            return enTypesFilter.None;
        }

        private bool _CheckShowTextBoxFilter()
        {
            if (_ModeTypeFilter == enTypesFilter.None || _ModeTypeFilter == enTypesFilter.IsActive) 
            {
                tbFilter.Visible = false;
                return false;
            }
            else 
            {
               tbFilter.Visible = true;
               return true;
            }
        }

        private DataView _Filter(string FilterValue) 
        {
            dgvUsers.DataSource = dtAllUsers;

            DataView dvUsers = new DataView(dtAllUsers);
            switch (_ModeTypeFilter)
            {
                case enTypesFilter.UserID:
                    if(int.TryParse(FilterValue, out int UserID))
                        dvUsers.RowFilter = $"UserID LIKE {UserID}%";
                    break;
                
                case enTypesFilter.UserName:
                    dvUsers.RowFilter = $"UserName LIKE '{FilterValue}%'";
                    break;
                
                case enTypesFilter.PersonID:
                    if (int.TryParse(FilterValue, out int PersonID))
                        dvUsers.RowFilter = $"PersonID LIKE {PersonID}%";
                    break;
                
                case enTypesFilter.FullName:
                    dvUsers.RowFilter = $"FullName LIKE '{FilterValue}%'";
                    break;
                
                case enTypesFilter.IsActive:
                    if(cbActiveStatus.SelectedIndex == 1)
                        dvUsers.RowFilter = $"IsActive = {true}";
                    else if (cbActiveStatus.SelectedIndex == 2)
                        dvUsers.RowFilter = $"IsActive = {false}";
                    else
                        dvUsers.RowFilter = $"IsActive = {true} or IsActive = {false}";
                    break;
            }
            return dvUsers;
        }
        private void _LoadListUser(string FilterValue = "") 
        {
            if (FilterValue != string.Empty)
                dgvUsers.DataSource = _Filter(FilterValue);
            else // get all data
            { 
                dtAllUsers =  clsUsers.GetAllUsers();
                dgvUsers.DataSource = dtAllUsers;
            }
                
        }
        private void _LoadDefualtData() 
        {
            //SET DEFAULT cbfiltertype
            cbfilterType.SelectedIndex = 0;
            _ModeTypeFilter = _ChangeFilterType();

            // 
            cbActiveStatus.Visible = false;

            if (_CheckShowTextBoxFilter() && _ModeTypeFilter == enTypesFilter.IsActive)
                cbActiveStatus.Visible = true;
            else
                cbActiveStatus.Visible = false;
            
            //get all data
            _LoadListUser();
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            _LoadDefualtData();
        }

        private void cbfilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ModeTypeFilter = _ChangeFilterType();
            
            if (_ModeTypeFilter == enTypesFilter.None)
                _LoadDefualtData();
            else
                _LoadListUser();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            _LoadListUser(tbFilter.Text);
        }

        private void cbActiveStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbActiveStatus.SelectedIndex = 0;

            _LoadListUser(cbActiveStatus.Text);
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUser();
            frm.ShowDialog();
            _LoadListUser();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value , (int)dgvUsers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _LoadListUser();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Sure Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUsers.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Completed Delete.", "Done Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("This Person Related", "Error Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _LoadListUser();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadListUser();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowUserDetails((int)dgvUsers.CurrentRow.Cells[1].Value , (int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadListUser();
        }
    }
}
