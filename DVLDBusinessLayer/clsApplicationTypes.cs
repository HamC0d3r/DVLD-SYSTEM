using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DVLDDataLayer;

namespace DVLDBusinessLayer
{
    public class clsApplicationTypes
    {
        public int ApplicationTypeID { set; get; }
        public string ApplicationTypeTitle { set; get; }
        public float ApplicationFees { set; get; }

        public clsApplicationTypes() 
        {
            ApplicationTypeID = -1;
            ApplicationTypeTitle = "";
            ApplicationFees = -1;
        }

        public clsApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle , float ApplicationFees)
        {                          
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }
        public static clsApplicationTypes Find(int ApplicationTypeID) 
        {
            string ApplicationTypeTitle = "";
            float ApplicationFees = -1;

            if (clsApplicationTypes_DA.GetApplicationType(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationTypes(ApplicationTypeID,ApplicationTypeTitle,ApplicationFees);
            }
            else
                return null;
        }   

        public static DataTable GetAllApplicationTypes() 
        {
            return clsApplicationTypes_DA.GetAllApplicationTypes();
        }

        private bool _Update() 
        {
            return clsApplicationTypes_DA.UpdateAppalicationType(this.ApplicationTypeID, this.ApplicationTypeTitle,this.ApplicationFees);
        }

        public bool Save() 
        {
            return _Update();
        }
    }
}
