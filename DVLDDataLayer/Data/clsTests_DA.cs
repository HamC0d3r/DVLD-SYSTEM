using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataLayer
{
    public class clsTests_DA
    {
        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Tests";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }

                }

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return dt;
        }
        public static bool GetTestInfoByID(int TestID, ref int TestAppointmentID,
            ref bool TestResult, ref string Notes, ref int CreatedByUserID)

        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Tests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;
        }
        public static bool UpdateTest(int TestsID, int TestAppointmentID,
            bool TestResult, string Notes, int CreatedByUserID) 
        {
            int rowsAffectNumber = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE [Tests]
                               SET [TestAppointmentID] = @TestAppointmentID
                                  ,[TestResult] = @TestResult
                                  ,[Notes] = @Notes
                                  ,[CreatedByUserID] = @CreatedByUserID
                             WHERE TestsID = @TestsID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestsID", TestsID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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
        public static int AddNewTest( int TestAppointmentID,
            bool TestResult, string Notes, int CreatedByUserID) 
        {
            int TestsID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Tests 
                                ([TestAppointmentID]
                               ,[TestResult]
                               ,[Notes]
                               ,[CreatedByUserID])
                                VALUES (@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID);
                                UPDATE TestAppointments SET IsLocked=1 WHERE TestAppointmentID = @TestAppointmentID;
                                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestsID", TestsID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID)) 
                {
                    TestsID = insertedID;
                }
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return TestsID;
        }


        public static int CountHowMuchPassedTest(int LDLApplicationID) 
        {
            int PassedTest = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT COUNT(TestResult) FROM TestAppointments 
                            INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestResult = 1;";

            SqlCommand command = new SqlCommand(query , connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLApplicationID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if(result != DBNull.Value && int.TryParse(result.ToString() , out int insertNumber)) 
                {
                    PassedTest = insertNumber;
                }
                
            }
            catch (Exception)
            {

            }finally { connection.Close(); }

            return PassedTest;

        }
        public static bool DeleteTest(int TestsID)
        {
            int rowsAffectedNumber = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE [Tests]
                               WHERE TestsID = @TestsID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestsID", TestsID);

            try
            {
                connection.Open();
                rowsAffectedNumber = command.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return (rowsAffectedNumber > 0);
        }

        public static bool GetLastTestByPersonAndTestTypeAndLicenseClass
            (int PersonID,int LicenseClassID,int TestTypeID, ref int TestID,
              ref int TestAppointmentID, ref bool TestResult,
              ref string Notes, ref int CreatedByUserID) 
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection (clsDataAccessSettings.ConnectionString);

            string query = @"SELECT top 1 * FROM Tests 
			
                    INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID 
		            INNER JOIN LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID =LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID			
		            INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
            WHERE Applications.ApplicantPersonID = @ApplicantPersonID AND TestAppointments.TestTypeID = @TestTypeID 
	            AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID Order By Tests.TestAppointmentID DESC;";

            SqlCommand command = new SqlCommand (query , connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read()) 
                {
                    isFound = true;
                    // The record was found
                    TestID = (int)reader["TestID"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] == DBNull.Value)

                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;
        }
    }
}
