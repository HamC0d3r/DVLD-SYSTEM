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
    public partial class frmEditTestType : Form
    {
        private int _TestTypeID;
        public frmEditTestType()
        {
            InitializeComponent();
        }
        public frmEditTestType(int TestTypeID) 
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void _LoadData() 
        {
            tbID.Text = _TestTypeID.ToString();

            clsTestTypes testType = clsTestTypes.Find((clsTestTypes.enTestType)_TestTypeID);
            if (testType != null) 
            {
                tbTitle.Text = testType.TestTypeTitle;
                tbDiscription.Text = testType.TestTypeDescription;
                tbFees.Text = testType.TestTypeFees.ToString();
            }
        }
        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private bool _Save() 
        {
            clsTestTypes testType = new clsTestTypes();

            //git value from form and fill in object
            testType.TestTypeID = (clsTestTypes.enTestType)int.Parse(tbID.Text);
            testType.TestTypeTitle = tbTitle.Text;
            testType.TestTypeDescription = tbDiscription.Text;

            if (float.TryParse(tbFees.Text, out float Fees))
                testType.TestTypeFees = Fees;
            else
                return false;

            //saving in database
            if (testType.Save())
            {
                return true;
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Save())
                MessageBox.Show("Update is Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error in Updating , Please sure your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
