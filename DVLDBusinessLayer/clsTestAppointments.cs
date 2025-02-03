using DVLDDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsTestAppointments
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { set; get; }
        public clsTestTypes.enTestType TestTypeID { set; get; }
        public int LDLApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public clsApplications RetakeTestAppInfo { set; get; }

        public int TestID
        {
            get { return GetTestID(); }        
        }
        public clsTestAppointments() 
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = clsTestTypes.enTestType.VisionTest;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;
        }
        public clsTestAppointments(int TestAppointmentID, clsTestTypes.enTestType TestTypeID,
            int LDLApplicationID, DateTime AppointmentDate, float PaidFees,
            int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LDLApplicationID = LDLApplicationID;

            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeTestAppInfo = clsApplications.FindBaseApplication(RetakeTestApplicationID);
            Mode = enMode.Update;
        }
        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointments_DA.GetAllTestAppointments();

        }
        public static clsTestAppointments Find(int TestAppointmentID) 
        {
            int TestTypeID = -1, LDLApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;
            
            if( clsTestAppointments_DA.GetTestAppointmentByID(TestAppointmentID, ref TestTypeID, ref LDLApplicationID, ref AppointmentDate
                , ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID ))
            {
                return new clsTestAppointments(TestAppointmentID,(clsTestTypes.enTestType)TestTypeID, LDLApplicationID, AppointmentDate
                                            , PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else return null;
        }
        
        private bool _AddNewTestAppointment()
        {

            this.TestAppointmentID = clsTestAppointments_DA.AddNewTestAppointment((int)this.TestTypeID, this.LDLApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }
        private bool _UpdateTestAppointment() 
        {
            return (clsTestAppointments_DA.UpdateTestAppointment(this.TestAppointmentID, (int)this.TestTypeID, this.LDLApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID,IsLocked, this.RetakeTestApplicationID));
        }

        public static clsTestAppointments GetLastTestAppointment(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            int TestAppointmentID = -1;
            DateTime AppointmentDate = DateTime.Now; float PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (clsTestAppointments_DA.GetLastTestAppointment(LocalDrivingLicenseApplicationID, (int)TestTypeID,
                ref TestAppointmentID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppointments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }
        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            return clsTestAppointments_DA.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointment();

            }

            return false;
        }

        int GetTestID() 
        {
            return clsTestAppointments_DA.GetTestID(this.TestAppointmentID);
        }

    }
}
