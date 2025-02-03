using DVLDDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLDBusinessLayer
{
    public class clsTestTypes
    {
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };
        public clsTestTypes.enTestType TestTypeID { set; get; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public float TestTypeFees { set; get; }

        public clsTestTypes() 
        {
            TestTypeID = clsTestTypes.enTestType.VisionTest;
            TestTypeTitle = "";
            TestTypeDescription = "";
            TestTypeFees = -1;
        }
        private clsTestTypes(clsTestTypes.enTestType testTypeID, string testTypeTitle, string testTypeDescription, float testTypeFees)
        {
            TestTypeID = testTypeID;
            TestTypeTitle = testTypeTitle;
            TestTypeDescription = testTypeDescription;
            TestTypeFees = testTypeFees;
        }

        public static DataTable GetAllTestTypes() 
        {
            return clsTestTypes_DA.GetAllTestTypes();
        }
        public static clsTestTypes Find(clsTestTypes.enTestType TestTypeID) 
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            float TestTypeFees = -1;

            if(clsTestTypes_DA.GetTestTypeByID((int)TestTypeID ,ref TestTypeTitle,ref TestTypeDescription,ref TestTypeFees))
            {
                return new clsTestTypes(TestTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees);
            }
            else 
                return null;
        }
        private bool _Update() 
        {
            return clsTestTypes_DA.UpdateTestType((int)this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }
        public bool Save() 
        {
            return _Update();
        }
    }

}
