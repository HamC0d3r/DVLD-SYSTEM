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
    public partial class frmEditApplicationType : Form
    {
        private int _ApplictionTypeID;
        public frmEditApplicationType()
        {
            InitializeComponent();
        }
        public frmEditApplicationType(int applictionTypeID)
        {
            InitializeComponent();

            _ApplictionTypeID = applictionTypeID;
        }
        private bool _Save() 
        {
            clsApplicationTypes AppType = new clsApplicationTypes();

            //git value from form and fill in object
            AppType.ApplicationTypeID = int.Parse(tbID.Text);
            AppType.ApplicationTypeTitle = tbTitle.Text;

            if (float.TryParse(tbFees.Text, out float Fees))
                AppType.ApplicationFees = Fees;
            else
                return false;

            //saving in database
            if (AppType.Save())
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

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            //load last info 
            tbID.Text = _ApplictionTypeID.ToString();

            clsApplicationTypes LastAppTypeInfo = clsApplicationTypes.Find(_ApplictionTypeID);
            tbTitle.Text = LastAppTypeInfo.ApplicationTypeTitle;
            tbFees.Text = LastAppTypeInfo.ApplicationFees.ToString();
        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Disallow the character
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
