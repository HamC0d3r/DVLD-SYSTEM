using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataLayer
{
    public class clsTestTypes_DA
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM TestTypes;";

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
            finally { connection.Close(); }

            return dt;

        }

        public static bool GetTestTypeByID(int TestTypeID, ref string TestTypeTitle,ref string TesttTypeDescription , ref float TestTypeFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TesttTypeDescription = (string)reader["TestTypeDescription"];
                    if (float.TryParse(reader["TestTypeFees"].ToString(), out float fees))
                        TestTypeFees = fees;
                }

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;

        }

        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update TestTypes
                            SET TestTypeTitle = @TestTypeTitle ,
                                TestTypeDescription = @TestTypeDescription,
                                TestTypeFees = @TestTypeFees
                            WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
