using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace LogIn_SignUp_From
{
    /// <summary>
    /// class: ClassInteractingDB: intermediate class between DB and Windows Form
    /// </summary>
    class ClassInteractingToDB
    {
        /// <summary>
        /// on signup button press: this function is exe where valid data are stored to DB
        /// </summary>
        /// <param name="emailID"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="salary"></param>
        /// <returns></returns>
        public bool WrittingDataToDB(string emailID, string password, string name, int age, int salary)
        {
            bool verify = true;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command1 = new SqlCommand("EmailidValidation", connection))
                {
                    command1.CommandType = CommandType.StoredProcedure;
                    command1.Parameters.AddWithValue("@emailid", emailID);
                    using (SqlDataReader sqlDataReader = command1.ExecuteReader())
                    {
                        bool value = sqlDataReader.HasRows;
                        sqlDataReader.Close();
                        command1.Dispose();
                        if (value)
                        {
                            MessageBox.Show("Account Exist");
                        }
                        else
                        {
                            using (SqlCommand command = new SqlCommand("NewUesrJoin", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@emailid", emailID);
                                command.Parameters.AddWithValue("@password", password);
                                command.Parameters.AddWithValue("@name", name);
                                command.Parameters.AddWithValue("@age", age);
                                command.Parameters.AddWithValue("@salary", salary);
                                if (command.ExecuteNonQuery() == 1)
                                    MessageBox.Show("welcome to our organization");
                                else
                                {
                                    MessageBox.Show("Some error in creating your account: please signup again");
                                    verify = false;
                                }
                            }
                        }
                    }
                }
            }
            return verify;
        }
        /// <summary>
        /// on login button press the data are compared with the data stored in the DB
        /// </summary>
        /// <param name="emailid"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool RetrivingDataFromDB(string emailid, string password)
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
                    MessageBox.Show("Your Login was sucessfull");
                }
                else if (value1 || value2)
                {
                    MessageBox.Show("Invalid emailid or password");
                }
                else
                {
                    MessageBox.Show("join with us");
                    newjoin = true;
                }
            }
            return newjoin;
        }
    }
}
