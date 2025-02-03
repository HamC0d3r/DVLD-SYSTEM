using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDDataLayer
{
    public class clsApplications_DA
    {
        public static DataTable GetAllApplications() 
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Applications";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                clsLoggerExDataAccess.LogToEventViewer(ex, EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return dt;
        }

        public static bool GetApplicationInfoByID(int ApplicationID,ref int ApplicantPersonID
            , ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate,
            ref float PaidFees, ref int CreatedByUserID) 
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT [ApplicationID]
                              ,[ApplicantPersonID]
                              ,[ApplicationDate]
                              ,[ApplicationTypeID]
                              ,[ApplicationStatus]
                              ,[LastStatusDate]
                              ,[PaidFees]
                              ,[CreatedByUserID]
                          FROM [Applications] WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read()) 
                {
                    isFound = true;

                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                clsLoggerExDataAccess.LogToEventViewer(ex, EventLogEntryType.Error);
            }
            finally { connection.Close(); }


            return isFound;
        }
        public static int AddNewApplication( int ApplicantPersonID
            ,DateTime ApplicationDate ,int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate,
            float PaidFees , int CreatedByUserID) 
        {
            int ApplicationID = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [Applications]
                               ([ApplicantPersonID]
                               ,[ApplicationDate]
                               ,[ApplicationTypeID]
                               ,[ApplicationStatus]
                               ,[LastStatusDate]
                               ,[PaidFees]
                               ,[CreatedByUserID])
                            VALUES
                               (@ApplicantPersonID
                               ,@ApplicationDate
                               ,@ApplicationTypeID
                               ,@ApplicationStatus
                               ,@LastStatusDate
                               ,@PaidFees
                               ,@CreatedByUserID); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString() , out int insertID)) 
                {
                    ApplicationID = insertID;
                }
            }
            catch (Exception ex)
            {
                clsLoggerExDataAccess.LogToEventViewer(ex, EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return ApplicationID;
        }

        public static bool UpdateApplication(int ApplicationID , int ApplicantPersonID
            , DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate,
            float PaidFees, int CreatedByUserID)
        {
            int rowsAffectNumber = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [Applications]
                           SET [ApplicantPersonID] = @ApplicantPersonID
                              ,[ApplicationDate] = @ApplicationDate
                              ,[ApplicationTypeID] = @ApplicationTypeID
                              ,[ApplicationStatus] = @ApplicationStatus
                              ,[LastStatusDate] = @LastStatusDate
                              ,[PaidFees] = @PaidFees
                              ,[CreatedByUserID] = @CreatedByUserID
                           WHERE  ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                rowsAffectNumber = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsLoggerExDataAccess.LogToEventViewer(ex, EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return rowsAffectNumber > 0;
        }
        public static bool UpdateStatus(int ApplicationID, short NewStatus)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Applications  
                            set 
                                ApplicationStatus = @NewStatus, 
                                LastStatusDate = @LastStatusDate
                            where ApplicationID=@ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);
            command.Parameters.AddWithValue("LastStatusDate", DateTime.Now);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
        public static bool DeleteApplication(int ApplicationID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Applications 
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID) 
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select ActiveApplicationID = Applications.ApplicationID FROM Applications 
                                    INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
                            
                            WHERE  ApplicantPersonID = @ApplicantPersonID AND
	                               ApplicationTypeID = @ApplicationTypeID AND
	                               LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
	                               AND ApplicationStatus = 1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception)
            {
                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }
    }
}
