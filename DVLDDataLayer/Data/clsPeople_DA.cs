using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;
using System.Net;
using System.Globalization;
using System.Diagnostics;

namespace DVLDDataLayer
{
    public class clsPeople_DA
    {

        public static bool GetPeopleByPersonID(int PersonID, ref string NatonalNo,
            ref string FirstName, ref string SecondName, ref string ThirdName, 
            ref string LastName,ref int Gendor, ref DateTime DateOfBirth,
            ref int NationalityCountryID, ref string Phone, ref string Email, ref string ImagePath,ref string Address)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT [PersonID],[NationalNo],[FirstName],[SecondName],[ThirdName],[LastName],[Gendor]
                ,[DateOfBirth], [NationalityCountryID] ,[Phone],[Email],[ImagePath],[Address] FROM [People] inner join Countries ON People.NationalityCountryID = Countries.CountryID
                WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    isFound = true;
                    NatonalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Address = (string)reader["address"];
                    Gendor = (int)reader["Gendor"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = string.Empty;
                    }

                }
                else 
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                clsLoggerExDataAccess.LogToEventViewer(ex,EventLogEntryType.Error);
                isFound = false;
            }
            finally { connection.Close(); }
            
            return isFound;
        }
        
        public static bool GetPeopleByNationalNo (ref int  PersonID, string NationalNo,
            ref string FirstName, ref string SecondName, ref string ThirdName,
            ref string LastName, ref int Gendor, ref DateTime DateOfBirth,
            ref int NationalityCountryID, ref string Phone, ref string Email, ref string ImagePath, ref string Address)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT [PersonID],[NationalNo],[FirstName],[SecondName],[ThirdName],[LastName],[Gendor]
                ,[DateOfBirth], [NationalityCountryID] ,[Phone],[Email],[ImagePath],[Address] FROM [People] inner join Countries ON People.NationalityCountryID = Countries.CountryID
                WHERE NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Address = (string)reader["address"];
                    Gendor = (int)reader["Gendor"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = string.Empty;
                    }

                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                clsLoggerExDataAccess.LogToEventViewer(ex, EventLogEntryType.Error);
                isFound = false;
            }
            finally { connection.Close(); }

            return isFound;
        }
        public static DataTable GetAllPeople() 
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT [PersonID],[NationalNo],[FirstName],[SecondName],[ThirdName],[LastName], 
                CASE
                    WHEN Gendor = 0 THEN 'Male' 
                    WHEN Gendor = 1 THEN 'Female'
                END as GendorCaption,
                [Address],[DateOfBirth],Countries.CountryName as CountryName,[Phone],[Email],[ImagePath] FROM [People] inner join Countries ON People.NationalityCountryID = Countries.CountryID;";

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
            catch (Exception ex)
            {
                clsLoggerExDataAccess.LogToEventViewer(ex, EventLogEntryType.Error);
                //data base error

            }
            finally 
            { 
                connection.Close();
            }

            return dt;
        }

        public static bool UpdatePerson(int PersonID ,string NationalNo, string FirstName, string SecondName, string ThirdName,
            string LastName, int Gendor, DateTime DateOfBirth, int NationalityCountryID, string Phone, string Email, string ImagePath, string Address)
        {
            int rowsAffectNumber = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [People]
                    SET [NationalNo] = @NationalNo
                    ,[FirstName] = @FirstName
                    ,[SecondName] = @SecondName
                    ,[ThirdName] = @ThirdName
                    ,[LastName] = @LastName
                    ,[DateOfBirth] = @DateOfBirth
                    ,[Gendor] = @Gendor
                    ,[Address] = @Address
                    ,[Phone] = @Phone
                    ,[Email] = @Email
                    ,[NationalityCountryID] = @NationalityCountryID
                    ,[ImagePath] = @ImagePath
                    WHERE PersonID = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                rowsAffectNumber = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsLoggerExDataAccess.LogToEventViewer(ex, EventLogEntryType.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffectNumber > 0);
        }


        public static int AddNewPerson(string NatonalNo, string FirstName, string SecondName, string ThirdName,
            string LastName, int Gendor, DateTime DateOfBirth, int NationalityCountryID, string Phone, string Email, string ImagePath, string Address)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [People]
                           ([NationalNo]
                           ,[FirstName]
                           ,[SecondName]
                           ,[ThirdName]
                           ,[LastName]
                           ,[DateOfBirth]
                           ,[Gendor]
                           ,[Address]
                           ,[Phone]
                           ,[Email]
                           ,[NationalityCountryID]
                           ,[ImagePath])
                        VALUES (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,
                                @Address,@Phone,@Email,@NationalityCountryID,@ImagePath) ;
                        SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NatonalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsLoggerExDataAccess.LogToEventViewer(ex, EventLogEntryType.Error);
            }
            finally 
            {
                connection.Close();
            }

            return PersonID;

        }
        public static bool DeletePerson(int PersonID) 
        {
            int rowsAffectedNumber = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE [People]
                               WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                rowsAffectedNumber = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                clsLoggerExDataAccess.LogToEventViewer(ex, EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return (rowsAffectedNumber > 0);
        }
    }
}
