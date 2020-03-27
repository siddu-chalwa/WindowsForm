using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SixthClient
{
    public partial class EntryForm : Form
    {
        private bool[] ErrorVerify = new bool[]{false, false, false, false};
        private string emailid, password;
        private int ageVar, salaryVar;

        private void ClearTextFields()
        {
            textBox_age.Clear();
            textBox_ContactNo.Clear();
            textBox_name.Clear();
            textBox_salary.Clear();
        }
        public EntryForm(string emailid, string password)
        {
            InitializeComponent();
            this.emailid = emailid;
            this.password = password;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!ErrorVerify[0])
                {
                    textBox_name.Focus();
                }
                else if (!ErrorVerify[1])
                {
                    textBox_age.Focus();
                }
                else if (!ErrorVerify[2])
                {
                    textBox_salary.Focus();
                }
                else if (!ErrorVerify[3])
                {
                    textBox_ContactNo.Focus();
                }
                else
                {
                    if (new ClassInteractingWithDB().WrittingDataToDB(emailid, password, textBox_name.Text, ageVar, salaryVar, textBox_ContactNo.Text))
                    {
                        MessageBox.Show("Account Created");
                        ClearTextFields();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error In Creating Account, Submit Again.");
                    }
                }
            }
            catch(Exception)
            {
                error = true;
                MessageBox.Show("application ran into a error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void RuntimeNameValidation(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (textBox_name.TextLength <= 6)
                {
                    errorProvider_name.SetError(textBox_name, "min 6, max 30  characters allowed");
                }
                else if (!(Regex.IsMatch(textBox_name.Text, @"^(_?)([a-zA-Z]+)([ _.-]?)(([a-zA-Z]+)?)$")))
                {
                    errorProvider_name.SetError(textBox_name, "Format: \n1. optional at begining: _\n2. alphabetical characters\n3. optional: _,  ,-,.\n4. optional: alphabhetical characters");
                }
                else
                {
                    errorProvider_name.Clear();
                    ErrorVerify[0] = true;
                }
            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show("application ran into a error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void textBox_age_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!(int.TryParse(textBox_age.Text, out ageVar)))
                {
                    errorProvider_age.SetError(textBox_age, "only digits allowed");
                }
                else if (ageVar <= 0 || ageVar > 150)
                {
                    errorProvider_age.SetError(textBox_age, "age limit min: 1 max: 150");
                }
                else
                {
                    ErrorVerify[1] = true;
                    errorProvider_age.Clear();
                }

            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show("application ran into a error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void textBox_salary_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!(int.TryParse(textBox_salary.Text, out salaryVar)))
                {
                    errorProvider_salary.SetError(textBox_salary, "only digits allowed");
                }
                else if (salaryVar < 0)
                {
                    errorProvider_salary.SetError(textBox_salary, "salary can't be negative");
                }
                else if ((salaryVar >= 0 && salaryVar < 500) || salaryVar > 100000000)
                {
                    errorProvider_salary.SetError(textBox_salary, "salary limit min: 500 max: 10Lakhs");
                }
                else
                {
                    ErrorVerify[2] = true;
                    errorProvider_salary.Clear();
                }
            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show("application ran into a error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void textBox_ContactNo_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!(textBox_ContactNo.TextLength == 10))
                {
                    errorProvider_contactNo.SetError(textBox_ContactNo, "only 10 digits allowed");
                }
                else
                {
                    ErrorVerify[3] = true;
                    errorProvider_contactNo.Clear();
                }
            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show("application ran into a error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void textBox_KeyPress_NoCharacterAllowed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
