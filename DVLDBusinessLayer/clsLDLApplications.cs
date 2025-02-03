using DVLDDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDBusinessLayer
{
    public class clsLDLApplications : clsApplications
    {
        public int LDLApplicationID {  get; set; }
        public int LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo;

        public string PersonFullName
        {
            get
            {
                return clsPeople.Find(ApplicantPersonID).FullName;
            }
        }
        enum enMode
        {
            AddNew = 0 , Update = 1 
        };
        enMode Mode;
        public clsLDLApplications() 
        {
            this.LDLApplicationID = -1; 
            this.ApplicationID = -1;
            this.LicenseClassID = -1;

            Mode = enMode.AddNew;
        }
        public clsLDLApplications(int LDLApplicationID) 
        {
            this.LDLApplicationID= LDLApplicationID;
            
            Mode = enMode.Update;
        }
        private clsLDLApplications(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID, int LicenseClassID)

        {
            this.LDLApplicationID = LocalDrivingLicenseApplicationID; ;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = (int)ApplicationTypeID;
            this.ApplicationType = clsApplicationTypes.Find(ApplicationTypeID);

            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            Mode = enMode.Update;
        }
        public static DataTable GetAllLDLApplications() 
        {
            return clsLDLApplications_DA.GetAllLDLApplications();
        } 
        public static clsLDLApplications FindByLDLApplicationID(int LDLApplicationID) 
        {  
            int ApplicationID = -1;
            int LicenseClassID = -1;

            bool IsFound = clsLDLApplications_DA.GetLDLApplicationInfoByID(LDLApplicationID, ref ApplicationID, ref LicenseClassID) ;


            if (IsFound)
            {
                //now we find the base application
                clsApplications Application = clsApplications.FindBaseApplication(ApplicationID);

                //we return new object of that person with the right data
                return new clsLDLApplications(
                    LDLApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                        Application.ApplicationDate, Application.ApplicationTypeID,
                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                        Application.PaidFees, Application.CreatedByUserID, LicenseClassID);
            }
            else
                return null;
        }
        public static clsLDLApplications FindByApplicationID(int ApplicationID)
        {
            int LDLApplicationID = -1;
            int LicenseClassID = -1;

            bool IsFound = clsLDLApplications_DA.GetLDLApplicationByApplicationID(ApplicationID, ref LDLApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                //now we find the base application
                clsApplications Application = clsApplications.FindBaseApplication(ApplicationID);

                //we return new object of that person with the right data
                return new clsLDLApplications(
                    LDLApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                            Application.ApplicationDate, Application.ApplicationTypeID,
                        (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                            Application.PaidFees, Application.CreatedByUserID, LicenseClassID);
            }
            else
                return null;
        }
        private bool _AddNewLDLApplication()
        {
            this.LDLApplicationID = clsLDLApplications_DA.AddNewLDLApplication(this.LDLApplicationID, this.ApplicationID, this.LicenseClassID);

            return (LDLApplicationID != -1);
        }
        private bool _UpdateLDLApplication() 
        {
            return clsLDLApplications_DA.UpdateLDLApplication(this.LDLApplicationID,this.ApplicationID,this.LicenseClassID);
        }
        public bool Save() 
        {
            //Because of inheritance first we call the save method in the base class,
            //it will take care of adding all information to the application table.
            base.Mode = (clsApplications.enMode)Mode;
            if (!base.Save())
                return false;


            //After we save the main application now we save the sub application.
            switch (Mode)
            {
                case enMode.AddNew:
                    return _AddNewLDLApplication();
                case enMode.Update:
                    return _UpdateLDLApplication();
            }
            return false;
            
        }
        public bool Delete()
        {
            bool IsLocalDrivingApplicationDeleted = false;
            bool IsBaseApplicationDeleted = false;
            //First we delete the Local Driving License Application
            IsLocalDrivingApplicationDeleted = clsLDLApplications_DA.DeleteLocalDrivingLicenseApplication(this.LDLApplicationID);

            if (!IsLocalDrivingApplicationDeleted)
                return false;
            //Then we delete the base Application
            IsBaseApplicationDeleted = base.Delete();
            return IsBaseApplicationDeleted;

        }

        public bool DoesAttendTestType(clsTestTypes.enTestType TestTypeID)
        {
            return clsLDLApplications_DA.DoesAttendTestType(this.LDLApplicationID, (int)TestTypeID);
        }
        public byte TotalTrialsPerTest(clsTestTypes.enTestType TestTypeID) 
        {
            return clsLDLApplications_DA.TotalTrialsPerTest(this.LDLApplicationID, (int)TestTypeID);
        }
        public static bool IsThereAnActiveScheduledTest(int LDLApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            return clsLDLApplications_DA.IsThereAnActiveScheduledTest(LDLApplicationID, (int)TestTypeID);
        }

        public bool IsThereAnActiveScheduledTest(clsTestTypes.enTestType TestTypeID)

        {
            return clsLDLApplications_DA.IsThereAnActiveScheduledTest(this.LDLApplicationID, (int)TestTypeID);
        }

        public bool DoesPassTestType(clsTestTypes.enTestType TestTypeID) 
        {
            return clsLDLApplications_DA.DoesPassTestType(this.LDLApplicationID,(int)TestTypeID);
        }
        public clsTests GetLastTestPerTestType(clsTestTypes.enTestType TestType) 
        {
            return clsTests.FindLastTestPerPersonAndTestTypeAndLicenseClass(this.ApplicantPersonID, this.LicenseClassID, TestType);
        }
       
    }
}
