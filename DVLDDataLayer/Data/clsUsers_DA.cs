using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using Microsoft.SqlServer.Server;
using System.Security.Cryptography;
namespace DVLDDataLayer
{
    public class clsUsers_DA
    {
        public static DataTable GetAllUsers() 
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Users.UserID, Users.PersonID,
                             FullName = People.FirstName + ' ' +People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName
                             ,Users.UserName , Users.IsActive
                             FROM Users INNER JOIN People ON Users.PersonID = People.PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

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

            }
            finally{ connection.Close(); }

            return dt;
        }

        public static bool GetUserInfoByID(int UserID, ref int PersonID,ref string UserName , ref string Password, ref bool IsActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserId", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

                    isFound = true;
                }
            }
            catch (Exception)
            {

            }

            return isFound;
        }

        public static bool GetUserByUserNameAndPass(ref int UserID , ref int PersonID ,string UserName, string Password , ref bool IsActive) 
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];

                    isFound = true;
                }
            }
            catch (Exception)
            {

            }

            return isFound;
        }
        public static int AddNewUser(int PersonID, string Password, string UserName, bool IsActive)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (PersonID ,UserName, Password , IsActive)
                            VALUES (@PersonID,@UserName, @Password,@IsActive);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int insertID)) 
                {
                    UserID = insertID;
                }
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID,string UserName, string Password, bool IsActive)
        {
            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Users
                         SET PersonID = @PersonID,
                             UserName = @UserName,
                             Password = @Password,
                             IsActive = @IsActive 
                         WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                rowsAffect = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return (rowsAffect > 0);
        }

        public static bool DeleteUser(int UserID) 
        {
            int rowsAffectNumber = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffectNumber = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return (rowsAffectNumber > 0);
        }
        public static bool IsPersonIDExistUsers(int PersonID) 
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found = 1 FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally { connection.Close(); }

            return isFound;
        }

        //public static bool IsActive(UserName)
        
    }


}
