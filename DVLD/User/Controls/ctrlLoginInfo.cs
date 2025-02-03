using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVD_Project
{
    public partial class ctrlLoginInfo : UserControl
    {
        private clsUsers UserInfo;
        public ctrlLoginInfo()
        {
            InitializeComponent();
        }
        public void LoadLoginInfo(int UserID) 
        {
            UserInfo = clsUsers.FindUserByID(UserID);

            lbUserID.Text = UserInfo.UserID.ToString();
            lbUserName.Text = UserInfo.UserName;
           
            if(UserInfo.IsActive == true)
            {
                lbActiveStatus.Text = "Is Active";
                lbActiveStatus.ForeColor = Color.Green;
            }
            else 
            {
                lbActiveStatus.Text = "Not Active";
                lbActiveStatus.ForeColor = Color.Red;
            }
        }

    }
    

}
