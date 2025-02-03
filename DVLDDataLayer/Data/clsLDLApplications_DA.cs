using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace DVLDDataLayer
{
    public class clsLDLApplications_DA
    {
        public static DataTable GetAllLDLApplications() 
        {
            DataTable dt = new DataTable();
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"SELECT * FROM LocalDrivingLicenseApplications_View";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows) 
                {
                    dt.Load(reader);
                }
            }
            catch (Exception)
            {

                
            }finally { connection.Close(); }
            
            return dt;
        }
        public static bool GetLDLApplicationInfoByID(int LDLApplicationID, ref int ApplicationID , ref int LicenseClassID)
        {
            bool isFound = false;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                }
            }
            catch (Exception)
            {

            }
            finally {  connection.Close(); }
            
            return isFound;
        }
        public static bool GetLDLApplicationByApplicationID(int ApplicationID, ref int LDLApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    LDLApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                }

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;
        }

        public static int AddNewLDLApplication(int LDLApplicationID, int ApplicationID, int LicenseClassID) 
        {
            SqlConnection connection = new SqlConnection (clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                            VALUES (@ApplicationID,@LicenseClassID);
                            SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                Object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    LDLApplicationID = insertID;
                }
            }
            catch (Exception)
            {
                return LDLApplicationID;
            }
            finally { connection.Close(); }


            return LDLApplicationID;

        }

        public static bool UpdateLDLApplication(int LDLApplicationID, int ApplicationID, int LicenseClassID) 
        {
            int rowsAffectNumber = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update LocalDrivingLicenseApplications
                            SET
                              ApplicationID = @ApplicationID
                              ,LicenseClassID = @LicenseClassID
                                WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                rowsAffectNumber = command.ExecuteNonQuery();
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return rowsAffectNumber > 0;

        }
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete LocalDrivingLicenseApplications 
                                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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

        public static bool DoesAttendTestType(int LDLApplicationID,int TestTypeID) 
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT TOP 1 Found=1 FROM LocalDrivingLicenseApplications inner join TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
						                                Inner Join Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                WHERE (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) AND (TestAppointments.TestTypeID = @TestTypeID);";
            SqlCommand command = new SqlCommand(query , connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
                }
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return IsFound;
        }

        public static byte TotalTrialsPerTest(int LDLApplicationID,int TestTypeID) 
        {

            byte TotalTrialsPerTest = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" SELECT TotalTrialsPerTest = count(TestID)
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Trials))
                {
                    TotalTrialsPerTest = Trials;
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                connection.Close();
            }

            return TotalTrialsPerTest;

        }

        public static bool IsThereAnActiveScheduledTest(int LDLApplicationID,int TestTypeID) 
        {
            bool Result = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Found = 1 FROM LocalDrivingLicenseApplications INNER JOIN TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                                WHERE (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
                                AND (TestAppointments.TestTypeID = @TestTypeID) AND (TestAppointments.IsLocked = 0)
                                ORDER BY TestAppointments.TestAppointmentID desc;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    Result = true;
                }

            }

            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return Result;
        }
        public static bool DoesPassTestType(int LDLApplicationID, int TestTypeID)
        {
            bool Result = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                {
                    Result = returnedResult;
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                connection.Close();
            }

            return Result;
        }

    }

}
