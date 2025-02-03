using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DVLDDataLayer;

namespace DVLDBusinessLayer
{
    public class clsPeople
    {
        public enum enMode {AddNew = 0,Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string NatonalNo { set; get; }
        public string FirstName {set; get;}
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get
            {
                return this.FirstName + this.SecondName + this.ThirdName + this.LastName;
            }
        }
        public DateTime DateOfBirth { set; get; }
        public int Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        clsCountry CountryInfo { set; get; }
        public string ImagePath { set; get; }

        public clsPeople() 
        {
            this.PersonID = -1;
            this.NatonalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Gendor = -1;
            this.DateOfBirth = DateTime.Now;
            this.NationalityCountryID = -1;
            this.CountryInfo = null;
            this.Phone = "";
            this.Email = "";
            this.ImagePath = "";
            this.Address = "";
            
            Mode = enMode.AddNew;
        }
        public clsPeople(int PersonID) 
        {
            this.PersonID = PersonID;

            Mode = enMode.Update;
        }
        private clsPeople(int PersonID, string NatonalNo, string FirstName, string SecondName, string ThirdName, string LastName,
                int Gendor, DateTime DateOfBirth, int NationalityCountryID, string Phone, string Email, string ImagePath, string Address)
        {
            this.PersonID = PersonID;
            this.NatonalNo = NatonalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Gendor = Gendor;
            this.DateOfBirth = DateOfBirth;
            this.NationalityCountryID = NationalityCountryID;
            this.CountryInfo = clsCountry.FindByCountryID(NationalityCountryID);
            this.Phone = Phone;
            this.Email = Email;
            this.ImagePath = ImagePath;
            this.Address = Address;

            Mode = enMode.Update;
        }
        public static clsPeople Find(int PersonID) 
        {
            string NatonalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            int Gendor = -1;
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            string Phone = "";
            string Email = "";
            string ImagePath = "";
            string Address = "";
            if (clsPeople_DA.GetPeopleByPersonID(PersonID, ref NatonalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Gendor, ref DateOfBirth, ref NationalityCountryID, ref Phone, ref Email, ref ImagePath,ref Address) )
            {
                return new clsPeople(PersonID, NatonalNo, FirstName, SecondName, ThirdName, LastName,
                 Gendor, DateOfBirth, NationalityCountryID, Phone, Email , ImagePath, Address);
            }
            else { return null; }

        }

        public static clsPeople FindByNationalNo(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            int Gendor = -1;
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            string Phone = "";
            string Email = "";
            string ImagePath = "";
            string Address = "";
            if (clsPeople_DA.GetPeopleByNationalNo(ref PersonID, NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Gendor, ref DateOfBirth, ref NationalityCountryID, ref Phone, ref Email, ref ImagePath, ref Address))
            {
                return new clsPeople(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                 Gendor, DateOfBirth, NationalityCountryID, Phone, Email, ImagePath, Address);
            }
            else { return null; }

        }

        public static DataTable GetAllPeople()
        {
            return clsPeople_DA.GetAllPeople();
        }

        private bool _UpdatePerson() 
        {
            return clsPeople_DA.UpdatePerson(this.PersonID, this.NatonalNo, this.FirstName, this.SecondName, this.ThirdName,
            this.LastName, this.Gendor, this.DateOfBirth, this.NationalityCountryID, this.Phone, this.Email, this.ImagePath, this.Address);
        }

        private bool _AddNewPerson()
        {
            this.PersonID =  clsPeople_DA.AddNewPerson( this.NatonalNo, this.FirstName, this.SecondName, this.ThirdName,
                             this.LastName, this.Gendor, this.DateOfBirth, this.NationalityCountryID, this.Phone, this.Email, this.ImagePath, this.Address);
            
            return (this.PersonID != -1);
        
        }

        public bool Save() 
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return _AddNewPerson();

                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }

        public static bool DeletePerson(int PersonID) 
        {
            return clsPeople_DA.DeletePerson(PersonID);
        }

    }
}

