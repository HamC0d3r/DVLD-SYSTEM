using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataLayer
{
    public class clsTestAppointments_DA
    {
        public static DataTable GetAllTestAppointments() 
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments
                            order by AppointmentDate Desc";

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
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return dt;
        }
        public static bool GetTestAppointmentByID(int TestAppointmentID , ref int TestTypeID , ref int LDLApplicationID,
                                                    ref DateTime AppointmentDate , ref float PaidFees , ref int CreatedByUserID,ref bool IsLocked, ref int RetakeTestApplicationID) 
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read()) 
                {
                    isFound = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    LDLApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    
                    if (reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                }


                reader.Close();
            }
            catch (Exception)
            {

            } finally{ connection.Close(); }

            return isFound;

        }
        public static bool GetLastTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID,
                         ref int TestAppointmentID, ref DateTime AppointmentDate,
                         ref float PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT       top 1 *
                FROM            TestAppointments
                WHERE        (TestTypeID = @TestTypeID) 
                AND (LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                order by TestAppointmentID Desc";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];

                    if (reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT TestAppointmentID, AppointmentDate,PaidFees, IsLocked
                        FROM TestAppointments
                        WHERE  
                        (TestTypeID = @TestTypeID) 
                        AND (LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
                        order by TestAppointmentID desc;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static int AddNewTestAppointment(int TestTypeID,int LDLApplicationID,DateTime AppointmentDate,
                                                 float PaidFees, int CreatedByUserID,int RetakeTestApplicationID) 
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [TestAppointments]
                                   ([TestTypeID]
                                   ,[LocalDrivingLicenseApplicationID]
                                   ,[AppointmentDate]
                                   ,[PaidFees]
                                   ,[CreatedByUserID]
                                   ,[IsLocked]
                                   ,[RetakeTestApplicationID])
                             VALUES
                             (@TestTypeID,@LocalDrivingLicenseApplicationID,
                              @AppointmentDate,@PaidFees,@CreatedByUserID,0,@RetakeTestApplicationID); 
                                SELECT SCOPE_IDENTITY();";
            
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            if (RetakeTestApplicationID == -1)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int insertID)) 
                {
                    TestAppointmentID = insertID;
                }
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return TestAppointmentID;
        }
        public static bool UpdateTestAppointment(int TestAppointmentID,int TestTypeID, int LDLApplicationID, DateTime AppointmentDate,
                                                 float PaidFees, int CreatedByUserID, bool IsLocked,int RetakeTestApplicationID)
        {
            int rowsAffectNumber = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [TestAppointments]
                               SET [TestTypeID] = @TestTypeID
                                  ,[LocalDrivingLicenseApplicationID] = @LDLApplicationID
                                  ,[AppointmentDate] = @AppointmentDate
                                  ,[PaidFees] = @PaidFees
                                  ,[CreatedByUserID] = @CreatedByUserID
                                  ,[IsLocked] = @IsLocked
                                  ,RetakeTestApplicationID=@RetakeTestApplicationID
                             WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID == -1)

                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            
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
        public static int GetTestID(int TestAppointmentID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TestID from Tests where TestAppointmentID=@TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                connection.Close();
            }


            return TestID;

        }
        public static bool UpdateLocked(int TestAppointmentID , int Locked)
        {
            int rowsAffectNumber = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [TestAppointments]
                               SET
                                  [IsLocked] = @IsLocked
                             WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IsLocked", Locked);


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
        public static bool isLocked(int TestAppointmentID , int TestTypeID) 
        {
            bool isLocked = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" SELECT IsLocked FROM TestAppointments INNER JOIN TestTypes ON TestAppointments.TestTypeID = TestTypes.TestTypeID
                                WHERE TestAppointmentID = @TestAppointmentID AND TestTypes.TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                isLocked = (bool)reader["isLocked"];

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return isLocked == true;
        }


    }

}
