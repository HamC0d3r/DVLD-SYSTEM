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
    public partial class frmShowPersonDetails : Form
    {
        int PersonID;
        public frmShowPersonDetails(int PersonID) 
        {
            InitializeComponent();
            this.PersonID = PersonID;
            
        }
        private void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(this.PersonID);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
