using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLDDataLayer
{
    public class clsApplicationTypes_DA
    {
        public static DataTable GetAllApplicationTypes() 
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows) 
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return dt;

        }

        public static bool GetApplicationType(int ApplicationTypeID, ref string ApplicationTypeTitle, ref float ApplicationFees) 
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read()) 
                {
                    isFound = true;
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    if(float.TryParse(reader["ApplicationFees"].ToString() , out float fees))
                        ApplicationFees = fees;
                }
                
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;
            
        }
        public static bool UpdateAppalicationType(int ApplicationTypeID,string ApplicationTypeTitle ,float ApplicationFees) 
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update ApplicationTypes
                            SET ApplicationFees = @ApplicationFees ,
                                ApplicationTypeTitle = @ApplicationTypeTitle
                            WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return (rowsAffected > 0);
        }

    }
}
