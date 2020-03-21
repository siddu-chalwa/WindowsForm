using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LogIn_SignUp_From
{
    /// <summary>
    /// class: LogIn_SignUp_Window: Accept data from user and performs control operations
    /// </summary>
    public partial class LogIn_SignUp_Window : Form 
    {
        /// <summary>
        /// constructor: initializing the instance
        /// </summary>
        public LogIn_SignUp_Window()
        {
            InitializeComponent();
        }
        /// <summary>
        /// method: TextboxCleanFunction: clears the textboxes
        /// </summary>
        private void TextboxCleanFunction()
        {
            if (checkbox.Checked)
                checkbox.Checked = false;

            emailid_textbox.Clear();
            password_textbox.Clear();
            name_textbox.Clear();
            age_textbox.Clear();
            salary_textbox.Clear();
        }
        /// <summary>
        /// eventHandler: UnhideSignupButton: on checking, the signup formalities are visiblesd and vice-versa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnhideSignupButton(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                name_label.Visible = true;
                age_label.Visible = true;
                salary_label.Visible = true;
                name_textbox.Visible = true;
                age_textbox.Visible = true;
                salary_textbox.Visible = true;
                signup_button.Visible = true;
                login_button.Visible = false;
            }
            else
            {
                name_label.Visible = false;
                age_label.Visible = false;
                salary_label.Visible = false;
                name_textbox.Visible = false;
                age_textbox.Visible = false;
                salary_textbox.Visible = false;
                signup_button.Visible = false;
                login_button.Visible = true;
            }
        }
        /// <summary>
        /// errorproviders to indicate errors 
        /// </summary>
        private void errorProviderClear_EmailT(object sender, EventArgs e)
        {
            emailid_T_errorProvider.Clear();
        }
        private void errorProvider_PasswordT(object sender, EventArgs e)
        {
            password_T_errorProvider.Clear();
        }
        private void errorProvide_NameClear(object sender, EventArgs e)
        {
            name_T_errorProvider.Clear();
        }
        private void errorProvider_AgeClear(object sender, EventArgs e)
        {
            age_T_errorProvider.Clear();
        }
        private void errorProvider_SalartClear(object sender, EventArgs e)
        {
            salary_T_errorProvider.Clear();
        }
        /// <summary>
        /// EventHandler: LoginB_Validation: validate the login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginB_Validation(object sender, MouseEventArgs e)
        {
            bool error = true;
            try
            {
                ///
                // emailid validation
                ///
                if (string.IsNullOrWhiteSpace(emailid_textbox.Text))
                {
                    emailid_T_errorProvider.SetError(emailid_textbox, "enter emailid");
                    emailid_textbox.Focus();
                    error = false;
                    return;
                }
                if (!(Regex.IsMatch(emailid_textbox.Text, @"^[a-z]+\.[a-z]+@[a-z]+\.[a-z]{2,4}$")))
                {
                    emailid_T_errorProvider.SetError(emailid_textbox, "Format: firstName.lastName@orgnization.domain");
                    emailid_textbox.Focus();
                    error = false;
                    return;
                }
                emailid_T_errorProvider.Clear();
                password_textbox.Focus();

                ///
                // password validation
                ///
                if (string.IsNullOrWhiteSpace(password_textbox.Text))
                {
                    password_T_errorProvider.SetError(password_textbox, "enter password");
                    password_textbox.Focus();
                    error = false;
                    return;
                }
                if (!(Regex.IsMatch(password_textbox.Text, @"^([@$#^&\*\-\]\.,\)\( }[|\\{])?\w+(([@$# ^&*_\-\]\.,\)\(}[|\\{])*)([a-zA-Z]+)$")))
                {
                    password_T_errorProvider.SetError(password_textbox, "Format: min: 8 max:22 characters\n1. optional: special character - only 1\n2. a-z A-Z _\n3. special characters\n4. alphabet character");
                    password_textbox.Focus();
                    error = false;
                    return;
                }
                password_T_errorProvider.Clear();

                if (new ClassInteractingToDB().RetrivingDataFromDB(emailid_textbox.Text, password_textbox.Text))
                {
                    checkbox.Checked = true;
                    name_textbox.Focus();
                    error = false;
                }
                else
                {
                    TextboxCleanFunction();
                    emailid_textbox.Focus();
                    error = false;
                }
            }
            catch(Exception expMsg)
            {
                MessageBox.Show("application run into an error: " + expMsg);
            }
            finally
            {
                if(error)
                    this.Close();
            }
        }
        /// <summary>
        /// eventhandler: Signup_validation: perform signup functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Signup_validation(object sender, MouseEventArgs e)
        {
            bool error = true;
            try
            {
                ///
                // emailid validation
                ///
                if (string.IsNullOrWhiteSpace(emailid_textbox.Text))
                {
                    emailid_T_errorProvider.SetError(emailid_textbox, "enter emailid");
                    emailid_textbox.Focus();
                    error = false;
                    return;
                }
                if (!(Regex.IsMatch(emailid_textbox.Text, @"^[a-z]+\.[a-z]+@[a-z]+\.[a-z]{2,4}$")))
                {
                    emailid_T_errorProvider.SetError(emailid_textbox, "Format: firstName.lastName@orgnization.domain");
                    emailid_textbox.Focus();
                    error = false;
                    return;
                }
                emailid_T_errorProvider.Clear();
                password_textbox.Focus();

                ///
                // password validation
                ///
                if (string.IsNullOrWhiteSpace(password_textbox.Text))
                {
                    password_T_errorProvider.SetError(password_textbox, "enter password");
                    password_textbox.Focus();
                    error = false;
                    return;
                }
                if (!(Regex.IsMatch(password_textbox.Text, @"^([@$#^&\*\-\]\.,\)\( }[|\\{])?\w+(([@$# ^&*_\-\]\.,\)\(}[|\\{])*)([a-zA-Z]+)$")))
                {
                    password_T_errorProvider.SetError(password_textbox, "Format: min: 8 max:22 characters\n1. optional: special character - only 1\n2. a-z A-Z _\n3. special characters\n4. alphabet character");
                    password_textbox.Focus();
                    error = false;
                    return;
                }
                password_T_errorProvider.Clear();

                ///
                // name validation
                ///
                if (string.IsNullOrWhiteSpace(name_textbox.Text))
                {
                    name_T_errorProvider.SetError(name_textbox, "enter name");
                    name_textbox.Focus();
                    error = false;
                    return;
                }
                if (!(Regex.IsMatch(name_textbox.Text, @"^(_?)([a-zA-Z]+)([ _.-]?)(([a-zA-Z]+)?)$")))
                {
                    name_T_errorProvider.SetError(name_textbox, "Format: \n1. optional at begining: _\n2. alphabetical characters\n3. optional: _,  ,-,.\n4. optional: alphabhetical characters");
                    name_textbox.Focus();
                    error = false;
                    return;
                }
                if (name_textbox.Text.Length <= 6)
                {
                    name_T_errorProvider.SetError(name_textbox, "min 6, max 20  characters allowed");
                    name_textbox.Focus();
                    error = false;
                    return;
                }
                name_T_errorProvider.Clear();
                age_textbox.Focus();

                ///
                // age validation
                ///
                int ageVar;
                if (string.IsNullOrWhiteSpace(age_textbox.Text))
                {
                    age_T_errorProvider.SetError(age_textbox, "enter age");
                    age_textbox.Focus();
                    error = false;
                    return;
                }
                else if (!(int.TryParse(age_textbox.Text, out ageVar)))
                {
                    age_T_errorProvider.SetError(age_textbox, "only digits allowed");
                    age_textbox.Focus();
                    error = false;
                    return;
                }
                else if (ageVar <= 0 || ageVar > 150)
                {
                    age_T_errorProvider.SetError(age_textbox, "age limit min: 1 max: 150");
                    age_textbox.Focus();
                    error = false;
                    return;
                }
                age_T_errorProvider.Clear();
                salary_textbox.Focus();

                ///
                // salary validation
                ///
                int salaryVar;
                if (string.IsNullOrWhiteSpace(salary_textbox.Text))
                {
                    salary_T_errorProvider.SetError(salary_textbox, "enter salary");
                    salary_textbox.Focus();
                    error = false;
                    return;
                }
                if (!(int.TryParse(salary_textbox.Text, out salaryVar)))
                {
                    salary_T_errorProvider.SetError(salary_textbox, "only digits allowed");
                    salary_textbox.Focus();
                    error = false;
                    return;
                }
                if (salaryVar < 0)
                {
                    salary_T_errorProvider.SetError(salary_textbox, "salary can't be negative");
                    salary_textbox.Focus();
                    error = false;
                    return;
                }
                if ((salaryVar >= 0 && salaryVar < 500) || salaryVar > 100000000)
                {
                    salary_T_errorProvider.SetError(salary_textbox, "salary limit min: 500 max: 10Lakhs");
                    salary_textbox.Focus();
                    error = false;
                    return;
                }
                salary_T_errorProvider.Clear();
                
                if(new ClassInteractingToDB().WrittingDataToDB(emailid_textbox.Text, password_textbox.Text, name_textbox.Text, ageVar, salaryVar))
                    checkbox.Checked = false;
                TextboxCleanFunction();
                emailid_textbox.Focus();
                error = false;
            }
            catch (Exception expMsg)
            {
                MessageBox.Show("application run into an error: " + expMsg.Message);
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }
    }
}