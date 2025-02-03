using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DVLDDataLayer;
using System.Data;

namespace DVLDDataLayer
{
    public class clsCountry_DA
    {
        public static bool FindCountryByID(int CountryID , ref string CountryName) 
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    CountryName = (string)reader["CountryName"];
                }
                else
                {
                    //the record is not found
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally { connection.Close(); }
            return isFound;

        }


        public static DataTable GetAllCountries() 
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection( clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Countries";

            SqlCommand command = new SqlCommand(query,connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception)
            {
                //data base error

            }
            finally
            {
                connection.Close();
            }

            return dt;



        }
    }
}
