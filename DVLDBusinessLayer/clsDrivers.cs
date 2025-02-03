using DVLDDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsDrivers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public clsPeople PersonInfo;
        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { get; }

        public clsDrivers(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)

        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this.PersonInfo = clsPeople.Find(PersonID);

            Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            //call DataAccess Layer 

            this.DriverID = clsDrivers_DA.AddNewDriver(PersonID, CreatedByUserID);


            return (this.DriverID != -1);
        }

        private bool _UpdateDriver()
        {
            //call DataAccess Layer 

            return clsDrivers_DA.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID);
        }

        public static clsDrivers FindByDriverID(int DriverID)
        {

            int PersonID = -1; int CreatedByUserID = -1; DateTime CreatedDate = DateTime.Now;

            if (clsDrivers_DA.GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))

                return new clsDrivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }

        public static clsDrivers FindByPersonID(int PersonID)
        {

            int DriverID = -1; int CreatedByUserID = -1; DateTime CreatedDate = DateTime.Now;

            if (clsDrivers_DA.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))

                return new clsDrivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }

        public static DataTable GetAllDrivers()
        {
            return clsDrivers_DA.GetAllDrivers();

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDriver();

            }

            return false;
        }
    }
}
