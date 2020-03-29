using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SixthClient
{
    /// <summary>
    /// class: Intermediate class between windows form and  database
    /// </summary>
    class ClassInteractingWithDB
    {
        /// <summary>
        /// function: retreive id, if emailid is verified
        /// </summary>
        /// <param name="emailid"></param>
        /// <returns></returns>
        public int SignupEmailIDValidation(string emailid)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SixthClient.Properties.Settings.acerNitroDBConnectionString"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SignupEmailIDValidation_SP", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@emailid", emailid);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        sqlDataReader.Read();
                        if (sqlDataReader.HasRows)
                            return Convert.ToInt32(sqlDataReader["id"]);
                    }
                }
                return 0;
            }
        }
        /// <summary>
        /// function: read emailid and password from db and store it to the list
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// function: reterieve if, if emailid and password is verified
        /// </summary>
        /// <param name="emailid"></param>
        /// <param name="password"></param>
        /// <param name="vs"></param>
        /// <returns></returns>
        public int LoginEmailidPasswordValidation(string emailid, string password, out byte[] vs)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SixthClient.Properties.Settings.acerNitroDBConnectionString"].ConnectionString))
            {
                vs = null;
                connection.Open();
                using (SqlCommand command = new SqlCommand("LoginEmailIDPasswordVerification_SP", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@emailid", emailid);
                    command.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        sqlDataReader.Read();
                        if (sqlDataReader.HasRows)
                        {
                            if(!sqlDataReader.IsDBNull(1))
                            {
                                vs = (Byte[])sqlDataReader["imageFile"];
                            }
                            return Convert.ToInt32(sqlDataReader["id"]);
                        }
                    }
                }
            }
            return 0;
        }
        /// <summary>
        /// function: storing the data to the db
        /// </summary>
        /// <param name="emailID"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="salary"></param>
        /// <param name="contactNo"></param>
        /// <param name="imageFile"></param>
        /// <returns></returns>
        public bool WrittingDataToDB(string emailID, string password, string name, int age, int salary, string contactNo, string imageFile)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SixthClient.Properties.Settings.acerNitroDBConnectionString"].ConnectionString))
            {
                Byte[] vs= null;
                if (imageFile != null)
                {
                    FileStream fileStream = null;
                    try
                    {
                        fileStream = new FileStream(imageFile, FileMode.Open, FileAccess.Read);
                        vs = new Byte[fileStream.Length];
                        fileStream.Read(vs, 0, vs.Length);
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        if (fileStream != null)
                            fileStream.Close();
                    }
                }
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
                    if (vs != null)
                    {
                        command.Parameters.AddWithValue("@imageFile", vs);
                    }
                    if (command.ExecuteNonQuery() == 1)
                        return true;
                    else
                        return false;
                }
            }
        }   
    }
}
