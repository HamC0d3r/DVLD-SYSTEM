using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDBusinessLayer;
using System.Data;
using DVLDDataLayer;

namespace DVLDBusinessLayer
{
    public class clsUsers
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int UserID { set; get; }
        public int PersonID { set; get; }
        public clsPeople PeopleInfo { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public clsUsers() 
        {
            UserID = -1;
            PersonID = -1;
            PeopleInfo = new clsPeople();
            UserName = "";
            Password = "";
            IsActive = false;
            Mode = enMode.AddNew;
        }
        public clsUsers(int UserID)
        {
            this.UserID = UserID;
 
            Mode = enMode.Update;
        }
        public clsUsers(int UserID , int PersonID , clsPeople PeopleInfo , string UserName,string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PeopleInfo = PeopleInfo;   
            this.UserName = UserName;   
            this.Password = Password;   
            this.IsActive = IsActive;   
        }
        public static DataTable GetAllUsers() 
        {
            return clsUsers_DA.GetAllUsers();
        } 
        public static clsUsers FindUserByID(int UserID)
        {
            
            int PersonID = -1;
            
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            if (clsUsers_DA.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                clsPeople PeopleInfo = clsPeople.Find(PersonID);
                return new clsUsers(UserID, PersonID, PeopleInfo, UserName, Password, IsActive);
            }
            else return null;
        }
        public static clsUsers FindUserByUserNameAndPass(string UserName , string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;

            if (clsUsers_DA.GetUserByUserNameAndPass(ref UserID, ref PersonID, UserName, Password, ref IsActive))
            {
                clsPeople PeopleInfo = clsPeople.Find(PersonID);
                return new clsUsers(UserID, PersonID, PeopleInfo, UserName, Password, IsActive);
            }
            else return null;
        }
        private bool _UpdateUser() 
        {
            this.PersonID = this.PeopleInfo.PersonID;
            return clsUsers_DA.UpdateUser(this.UserID, this.PersonID,this.UserName,this.Password, this.IsActive);
        }

        private bool _AddNewUser()
        {
            this.PersonID = this.PeopleInfo.PersonID;
            this.UserID = clsUsers_DA.AddNewUser(this.PersonID, this.Password, this.UserName, this.IsActive); ;
            return UserID != -1; 
        }

        public bool Save() 
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return _AddNewUser();

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool IsPersonIDExistUsers(int PersonID)
        {
            return clsUsers_DA.IsPersonIDExistUsers(PersonID);
        }
        public static bool DeleteUser(int UserID) 
        {
            return clsUsers_DA.DeleteUser(UserID);
        }
    }


}
