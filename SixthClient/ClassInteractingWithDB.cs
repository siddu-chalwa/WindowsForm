using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SixthClient
{
    class ClassInteractingWithDB
    {
        public List<KeyValuePair<string, string>> ReteriveEmailIDPassword()
        {
            List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SixthClient.Properties.Settings.acerNitroDBConnectionString"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ReteriveEmailIDPassword_SP", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            keyValuePairs.Add(new KeyValuePair<string, string>(sqlDataReader["emailid"].ToString(), sqlDataReader["password"].ToString()));
                        }
                    }
                }
            }
            return keyValuePairs;

        }
        public bool WrittingDataToDB(string emailID, string password, string name, int age, int salary, string contactNo)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SixthClient.Properties.Settings.acerNitroDBConnectionString"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("NewUesrJoin_SP", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@emailid", emailID);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@mobileNo", contactNo);
                    if (command.ExecuteNonQuery() == 1)
                        return true;
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public int retrievingDataFormDB(string emailid, string password)
        {
            int newjoin = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SixthClient.Properties.Settings.acerNitroDBConnectionString"].ConnectionString))
            {
                connection.Open();
                bool value1, value2;
                using (SqlCommand command = new SqlCommand("EmailidValidation_SP", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@emailid", emailid);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        value1 = sqlDataReader.HasRows;
                        sqlDataReader.Close();
                        command.Dispose();
                    }
                }
                using (SqlCommand command = new SqlCommand("PasswordValidation_SP", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        value2 = sqlDataReader.HasRows;
                        sqlDataReader.Close();
                        command.Dispose();
                    }
                }
                if (value1 && value2)
                {
                    newjoin = 2;
                }
                else if (value1 || value2)
                {
                    newjoin = 1;
                }
            }
            return newjoin;
        }
    }
}
