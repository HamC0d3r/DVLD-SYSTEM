using DVLDDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsApplications
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public clsPeople PersonInfo;
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsApplicationTypes ApplicationType;
        public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUsers CreatedByUserInfo;
        public enum enMode { AddNew = 0 , Update = 1  }
        public enMode Mode = enMode.AddNew;

        public enum enApplicationStatus 
        { New = 1, Cancelled = 2, Completed = 3 }

        public enApplicationStatus ApplicationStatus { set; get; }
        public string StatusText
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }
        public clsApplications() 
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;

            ApplicationDate = DateTime.Now;
            
            ApplicationTypeID = -1;

            ApplicationStatus = enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }
        private clsApplications(int applicationID, int applicantPersonID, DateTime applicationDate, 
            int applicationTypeID, enApplicationStatus applicationStatus, DateTime lastStatusDate, 
            float paidFees, int createdByUserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            PersonInfo = clsPeople.Find(applicantPersonID);
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationType = clsApplicationTypes.Find(ApplicationTypeID);
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            CreatedByUserInfo = clsUsers.FindUserByID(CreatedByUserID);
            Mode = enMode.Update;
        }
        public static clsApplications FindBaseApplication(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now; int ApplicationTypeID = -1;
            byte ApplicationStatus = 1; DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0; int CreatedByUserID = -1;

            bool IsFound = clsApplications_DA.GetApplicationInfoByID
                                (
                                    ApplicationID, ref ApplicantPersonID,
                                    ref ApplicationDate, ref ApplicationTypeID,
                                    ref ApplicationStatus, ref LastStatusDate,
                                    ref PaidFees, ref CreatedByUserID
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsApplications(ApplicationID, ApplicantPersonID,
                                     ApplicationDate, ApplicationTypeID,
                                    (enApplicationStatus)ApplicationStatus, LastStatusDate,
                                     PaidFees, CreatedByUserID);
            else
                return null;
        }
        public static DataTable GetAllApplications() 
        {
            return clsApplications.GetAllApplications();
        }
        private bool _AddNewApplication()
        {
            //call DataAccess Layer 

            this.ApplicationID = clsApplications_DA.AddNewApplication(
                this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, (byte)this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }
        private bool _UpdateApplication()
        {
            //call DataAccess Layer 

            return clsApplications_DA.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, (byte)this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

        }

        public bool Cancel()

        {
            return clsApplications_DA.UpdateStatus(ApplicationID, 2);
        }

        public bool SetComplete()

        {
            return clsApplications_DA.UpdateStatus(ApplicationID, 3);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();
            }
            return false;
        }

        public bool Delete()
        {
            return clsApplications_DA.DeleteApplication(this.ApplicationID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID) 
        {
            return clsApplications_DA.GetActiveApplicationIDForLicenseClass(PersonID, ApplicationTypeID, LicenseClassID);
        }
        

    }
}
