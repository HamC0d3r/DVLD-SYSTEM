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
    public partial class ctrlFindPersonInfo : UserControl
    {
        public int PersonID = -1;
        public clsPeople Person;
        enum enTypesFilter
        {
            PersonID = 0,
            NationalNo = 1
        };
        private enTypesFilter _ModeTypeFilter;
        public ctrlFindPersonInfo()
        {
            InitializeComponent();
        }
        //Define the event to action in person selected
        public event Action<int> OnPersonSelected;
        //create pretected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID) 
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null) 
            {
                handler(PersonID); //Raise the event with the parameter
            }
        } 
        public void LoadPersonInfo(int PersonID) 
        {
            groupBoxFilter.Enabled = false;
            Person = clsPeople.Find(PersonID);
            this.PersonID = Person.PersonID;
            ctrlPersonCard1.LoadPersonInfo(this.PersonID);
        }
        private enTypesFilter _ChangeFilterType()
        {
            switch (cbfilterType.SelectedIndex)
            {
                case 0:
                    return enTypesFilter.PersonID;
                case 1: return enTypesFilter.NationalNo;
            }
            return enTypesFilter.PersonID;
        }
        private bool _ResultFindPerson()
        {
            switch (_ModeTypeFilter)
            {
                case enTypesFilter.PersonID:
                    if (int.TryParse(tbFilter.Text, out PersonID))
                    {
                        Person = ctrlPersonCard1.LoadPersonInfo(PersonID);
                    }

                    break;
                case enTypesFilter.NationalNo:

                    Person = ctrlPersonCard1.LoadPersonInfo(tbFilter.Text);
                    PersonID = Person.PersonID;

                    break;
            }
            if (OnPersonSelected != null) 
            {
                PersonSelected(ctrlPersonCard1.PersonID);
            }
            return false;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            _ResultFindPerson();
        }
        private void cbfilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ModeTypeFilter = _ChangeFilterType();
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            //open the add new person form
            frmAddEditPersonInfo frm = new frmAddEditPersonInfo();
            frm.DataBack += frmAddEditPerson_DataBack;
            frm.ShowDialog();
        }
        private void frmAddEditPerson_DataBack(object sender, int PersonID)
        {
            //Handle the data received from frmAddEditPersonInfo
            ctrlPersonCard1.LoadPersonInfo(PersonID);

        }
        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_ModeTypeFilter == enTypesFilter.PersonID)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Prevent the character from being entered into the control
                }
            }
        }
        private void frmFindPersonInfo_Load(object sender, EventArgs e)
        {
            cbfilterType.SelectedIndex = 0;
        }


    }
}
