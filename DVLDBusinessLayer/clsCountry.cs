using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataLayer;

namespace DVLDBusinessLayer
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            CountryID = -1;
            CountryName = "";
        }
        public clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static clsCountry FindByCountryID(int CountryID)
        {
            string CountryName = "";

            if (clsCountry_DA.FindCountryByID(CountryID,ref CountryName)) 
            {
                return new clsCountry(CountryID, CountryName);
            }

            return null;


        }

        public static DataTable GetAllCountries() 
        {
            return clsCountry_DA.GetAllCountries();
        }
    }
}
