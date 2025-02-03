using DVLDDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsTests
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public clsTestAppointments TestAppointment;
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public clsTests() 
        {
            TestID = -1; 
            TestAppointmentID = -1;
            TestResult = false;
            Notes = "";
            CreatedByUserID = -1;
            _Mode = enMode.AddNew;
        }
        private clsTests(int testID, int testAppointmentID,bool testResult, string notes, int createdByUserID)
        {
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestAppointment = clsTestAppointments.Find(TestAppointmentID);
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;
            _Mode = enMode.Update;
        }
        public static DataTable GetAllTests() 
        {
            return clsTests_DA.GetAllTests();
        }
        public static clsTests Find(int TestsID) 
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            if (clsTests_DA.GetTestInfoByID(TestsID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID)) 
            {
                return new clsTests(TestsID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            return null;
        }
        private bool _Update() 
        {
            return clsTests_DA.UpdateTest(this.TestID,this.TestAppointmentID,this.TestResult,this.Notes,this.CreatedByUserID);
        }
        private bool _AddNew() 
        {
            this.TestID = clsTests_DA.AddNewTest( this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            
            return TestID != -1;
        }
        public static int CountHowMuchPassedTest(int LDLApplicationID)
        {
            return clsTests_DA.CountHowMuchPassedTest(LDLApplicationID);
        }

        public bool Save() 
        {
            switch (_Mode) 
            {
                case enMode.AddNew: return _AddNew();

                case enMode.Update: return _Update();
            }
            return false;
        }

        public static clsTests FindLastTestPerPersonAndTestTypeAndLicenseClass(int PersonID,int LicenseClassID,clsTestTypes.enTestType TestTypeID)
        {
            int TestID = -1;
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            if (clsTests_DA.GetLastTestByPersonAndTestTypeAndLicenseClass(PersonID, LicenseClassID, (int)TestTypeID,
                ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTests(TestID,
                        TestAppointmentID, TestResult,
                        Notes, CreatedByUserID);
            }
            else return null;
        } 

        public static bool PassedAllTests(int LDLApplicationID) 
        {
            return (clsTests_DA.CountHowMuchPassedTest(LDLApplicationID) == 3);
        }

        
    }
}
