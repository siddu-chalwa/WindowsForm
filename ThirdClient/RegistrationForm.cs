using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace ThirdClient
{
    /// <summary>
    /// delegate: delegateForPassingData: created to pass the textfields values to the another form
    /// </summary>
    /// <param name="textbox_name"></param>
    /// <param name="textbox_age"></param>
    /// <param name="textbox_salary"></param>
    /// <param name="textbox_emailid"></param>
    public delegate void delegateForPassingData(string textbox_name, string textbox_age, string textbox_salary, string textbox_emailid);
    /// <summary>
    /// partial class: RegistrationForm: accepts data from users via textboxes and writting data to a datafile.txt on local machine
    /// </summary>
    public partial class RegistrationForm : Form
    {
        /// <summary>
        /// Function: which clears text fileds
        /// </summary>
        private void ClearTextFields()
        {
            name_textbox.Clear();
            age_textbox.Clear();
            salary_textbox.Clear();
            emailid_textbox.Clear();
        }
        /// <summary>
        /// constructor: to invoke InitializerComponent funciton
        /// </summary>
        public RegistrationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// EventHandler on Register Button Press: Performs entered data validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_DataValidation(object sender, MouseEventArgs e)
        {
            bool error = true;
            ///
            // ExceptionHandling: to avoid System.ArgumentException: 'parsing "^[a-zA-Z]+[ _-.]?[a-zA-Z]*$" - [x-y] range in reverse order.'
            ///
            try
            {
                ///
                // name validation 
                ///
                /*
                 *
                 * Format: 1. optional at begining: _ 2. alphabetical characters 3. optional: _,  ,-,. 4. optional: alphabhetical characters
                 * 
                 * */
                if (string.IsNullOrWhiteSpace(name_textbox.Text))
                {
                    errorProvider_name.SetError(name_textbox, "enter your name");
                    name_textbox.Focus();
                    error = false;
                    return;
                }
                if (!(Regex.IsMatch(name_textbox.Text, @"^(_?)([a-zA-Z]+)([ _.-]?)(([a-zA-Z]+)?)$")))
                {
                    errorProvider_name.SetError(name_textbox, "Format: \n1. optional at begining: _\n2. alphabetical characters\n3. optional: _,  ,-,.\n4. optional: alphabhetical characters");
                    name_textbox.Focus();
                    error = false;
                    return;
                }
                else if (name_textbox.Text.Length <= 6)
                {
                    errorProvider_name.SetError(name_textbox, "min 6, max 25  characters allowed");
                    error = false;
                    return;
                }
                else
                {
                    errorProvider_name.SetError(name_textbox, "");
                    error = false;
                    age_textbox.Focus();
                }
                ///
                // age validation
                ///
                int ageVar;
                if (string.IsNullOrWhiteSpace(age_textbox.Text))
                {
                    errorProvider_name.SetError(age_textbox, "enter your age");
                    age_textbox.Focus();
                    error = false;
                    return;
                }
                else if (!(int.TryParse(age_textbox.Text, out ageVar)))
                {
                    errorProvider_age.SetError(age_textbox, "only digits allowed");
                    age_textbox.Focus();
                    error = false;
                    return;
                }
                else if (ageVar <= 0 || ageVar > 150)
                {
                    errorProvider_age.SetError(age_textbox, "age limit min: 1 max: 150");
                    age_textbox.Focus();
                    error = false;
                    return;
                }
                else
                {
                    errorProvider_age.SetError(age_textbox, "");
                    error = false;
                    salary_textbox.Focus();
                }
                ///
                // salary validation
                ///
                int salaryVar;
                if (string.IsNullOrWhiteSpace(salary_textbox.Text))
                {
                    errorProvider_salary.SetError(salary_textbox, "enter your salary");
                    salary_textbox.Focus();
                    error = false;
                    return;
                }
                else if (!(int.TryParse(salary_textbox.Text, out salaryVar)))
                {
                    errorProvider_salary.SetError(salary_textbox, "only digits allowed");
                    salary_textbox.Focus();
                    error = false;
                    return;
                }
                else if (salaryVar < 0)
                {
                    errorProvider_salary.SetError(salary_textbox, "salary can't be negative");
                    salary_textbox.Focus();
                    error = false;
                    return;
                }
                else if ((salaryVar >= 0 && salaryVar < 500) || salaryVar > 100000000)
                {
                    errorProvider_salary.SetError(salary_textbox, "salary limit min: 500 max: 10Lakhs");
                    salary_textbox.Focus();
                    error = false;
                    return;
                }
                else
                {
                    errorProvider_salary.SetError(salary_textbox, "");
                    error = false;
                    emailid_textbox.Focus();
                }
                ///
                // emailid validation 
                ///
                /*
                 *
                 * Format: firstName.lastName@orgnization.domain
                 * 
                 * */
                if (string.IsNullOrWhiteSpace(emailid_textbox.Text))
                {
                    errorProvider_emailid.SetError(emailid_textbox, "enter your emailid");
                    emailid_textbox.Focus();
                    error = false;
                    return;
                }
                if (!(Regex.IsMatch(emailid_textbox.Text, @"^[a-z]+\.[a-z]+@[a-z]+\.[a-z]{2,4}$")))
                {
                    errorProvider_emailid.SetError(emailid_textbox, "Format: firstName.lastName@orgnization.domain");
                    emailid_textbox.Focus();
                    error = false;
                    return;
                }
                else
                {
                    errorProvider_emailid.SetError(emailid_textbox, "");
                    error = false;
                    DisplayForm displayformRef = new DisplayForm();
                    delegateForPassingData refVar = new delegateForPassingData(displayformRef.AssignValuesToTextbox);
                    refVar(this.name_textbox.Text, this.age_textbox.Text, this.salary_textbox.Text, this.emailid_textbox.Text);
                    displayformRef.ShowDialog();
                    ClearTextFields();
                    name_textbox.Focus();
                }

            }
            catch (Exception expMsg)
            {
                MessageBox.Show("application run into an error" + expMsg.Message);
            }
            finally
            {
                if (error)
                {
                    this.Close();
                }
            }

        }
        /// <summary>
        /// EventHandler on Reset Button Press: clears the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_ClearTextFields(object sender, MouseEventArgs e)
        {
            ClearTextFields();
        }
    }
}
