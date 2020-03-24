using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FifthAssignment
{
    /// <summary>
    /// Class: ClassInteractingToDB
    /// </summary>
    class ClassInteractingToDB
    {
        /// <summary>
        /// Function: retreivingdataFromDB: it compares the data entered by user & the data stored in DB, returning bool.
        /// </summary>
        /// <param name="emailid"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool retrievingDataFormDB(string emailid, string password)
        {
            bool newjoin = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString))
            {
                connection.Open();
                bool value1, value2;
                using (SqlCommand command = new SqlCommand("EmailidValidation_SP", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_emailid", emailid);
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
                    command.Parameters.AddWithValue("@_password", password);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        value2 = sqlDataReader.HasRows;
                        sqlDataReader.Close();
                        command.Dispose();
                    }
                }
                if (value1 && value2)
                {
                    newjoin = true;
                }
                else if (value1 || value2)
                {
                    newjoin = false;
                }
            }
            return newjoin;
        }
    }
}
