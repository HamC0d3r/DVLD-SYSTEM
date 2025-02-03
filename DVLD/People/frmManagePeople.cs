using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DLVD_Project
{
    public partial class frmManagePeople : Form
    {


        //bulding retrave the Data And set of Data to DataView
        private static DataTable _dtAllPeople = clsPeople.GetAllPeople();

        private static DataTable _filteredTable = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName",
                                                                                    "LastName", "GendorCaption", "CountryName", "Phone", "Email");
        private DataView _dvPeople = new DataView(_filteredTable);

        private void _RefreshAllPeopleList() 
        {
            _dtAllPeople = clsPeople.GetAllPeople();

            _filteredTable = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName",
                                                                                    "LastName", "GendorCaption", "CountryName", "Phone", "Email");
            _dvPeople = new DataView(_filteredTable);

            dgvPeople.DataSource = _dvPeople;
    }
        enum enTypesFilter
        {
            None = 0,
            PersonID = 1,
            NatonalNo = 2,
            FirstName = 3,
            SecondName = 4,
            ThirdName = 5,
            LastName = 6,
            Nationality = 7,
            Gendor = 8,
            Phone = 9,
            Email = 10,
        };
        enTypesFilter _ModeTypeFilter;
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void _ChangeModeTypeFilter(int SelectedIndexOnCompoBox)
        {
            tbFilter.Visible = true;

            switch (SelectedIndexOnCompoBox)
            {
                case 0:
                    _ModeTypeFilter = enTypesFilter.None;
                    tbFilter.Visible = false;
                    break;
                case 1:
                    _ModeTypeFilter = enTypesFilter.PersonID; break;
                case 2:
                    _ModeTypeFilter = enTypesFilter.NatonalNo; break;
                case 3:
                    _ModeTypeFilter = enTypesFilter.FirstName; break;
                case 4:
                    _ModeTypeFilter = enTypesFilter.SecondName; break;
                case 5:
                    _ModeTypeFilter = enTypesFilter.ThirdName; break;
                case 6:
                    _ModeTypeFilter = enTypesFilter.SecondName; break;
                case 7:
                    _ModeTypeFilter = enTypesFilter.Nationality; break;
                case 8:
                    _ModeTypeFilter = enTypesFilter.Gendor; break;
                case 9:
                    _ModeTypeFilter = enTypesFilter.Phone; break;
                case 10:
                    _ModeTypeFilter = enTypesFilter.Email; break;

            }
        }
        private void _ShowPeopleListAfterFilterAffect(string filter = "")
        {
            if (string.IsNullOrEmpty(filter))
            {
                _dvPeople.RowFilter = string.Empty; // Clear any existing filter
            }
            else
            {
                try 
                {
                    _dvPeople.RowFilter = filter;
                }
                catch(Exception) 
                {
                    
                }
                
            }
            dgvPeople.DataSource = _dvPeople;
        }
        private void _Fillter()
        {
            if (string.IsNullOrWhiteSpace(tbFilter.Text) || _ModeTypeFilter == enTypesFilter.None)
                _ShowPeopleListAfterFilterAffect();
            else
                switch (_ModeTypeFilter)
                {
                    case enTypesFilter.PersonID:
                        if (int.TryParse(tbFilter.Text, out int ID))
                            _ShowPeopleListAfterFilterAffect($"PersonID = {ID}");
                        break;
                    case enTypesFilter.NatonalNo:
                        _ShowPeopleListAfterFilterAffect($"NationalNo = '{tbFilter.Text}'");
                        break;
                    case enTypesFilter.FirstName:
                        _ShowPeopleListAfterFilterAffect($"FirstName = '{tbFilter.Text}'"); 
                        break;
                    case enTypesFilter.SecondName:
                        _ShowPeopleListAfterFilterAffect($"SecondName = '{tbFilter.Text}'");
                        break;
                    case enTypesFilter.ThirdName: _ShowPeopleListAfterFilterAffect($"ThirdName = '{tbFilter.Text}'");
                        break;
                    case enTypesFilter.LastName:
                        _ShowPeopleListAfterFilterAffect($"LastName = '{tbFilter.Text}'");
                        break;
                    case enTypesFilter.Nationality:
                        _ShowPeopleListAfterFilterAffect($"CountryName = '{tbFilter.Text}'");
                        break;
                    case enTypesFilter.Gendor:
                        _ShowPeopleListAfterFilterAffect($"GendorCaption = '{tbFilter.Text}'");
                        break;
                    case enTypesFilter.Phone:
                        _ShowPeopleListAfterFilterAffect($"Phone = '{tbFilter.Text}'");
                        break;
                    case enTypesFilter.Email:
                        _ShowPeopleListAfterFilterAffect($"Email = '{tbFilter.Text}'");
                        break;

                }

        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _ChangeModeTypeFilter(0);
            _RefreshAllPeopleList();

        }
        private void cbfilterType_TextChanged(object sender, EventArgs e)
        {
            _ChangeModeTypeFilter(cbfilterType.SelectedIndex);
            _ShowPeopleListAfterFilterAffect();
        }
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            _ChangeModeTypeFilter(cbfilterType.SelectedIndex);
            _Fillter();
        }
        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        { 

            //handling : if the user enter chars in PersonID Type filter
            if (_ModeTypeFilter == enTypesFilter.PersonID)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Prevent the character from being entered into the control
                }
            }

        }
        
        
        
        //  
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void addNewPersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersonInfo();
            frm.ShowDialog();
            _RefreshAllPeopleList();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersonInfo();
            frm.ShowDialog();
            _RefreshAllPeopleList();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Sure Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsPeople.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Completed Delete.", "Done Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshAllPeopleList();
                }
                else 
                {
                    MessageBox.Show("This Person Related", "Error Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void editPersonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshAllPeopleList();
        }


    }
}
