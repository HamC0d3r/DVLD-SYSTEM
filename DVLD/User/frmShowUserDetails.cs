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
    public partial class frmShowUserDetails : Form
    {
        private int _PersonID;
        private int _UserID;
        public frmShowUserDetails()
        {
            InitializeComponent();
        }

        public frmShowUserDetails(int PersonID, int UserID) 
        {
            InitializeComponent();

            this._PersonID = PersonID;
            this._UserID = UserID;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData() 
        {
            ctrlPersonCard1.LoadPersonInfo(_PersonID);
            ctrlLoginInfo1.LoadLoginInfo(_UserID);
        }
        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
