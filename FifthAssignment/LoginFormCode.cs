using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FifthAssignment
{
    /// <summary>
    /// Class: LoginFormCode: In this class controllers & event handler for the controllers are setup for login in window form 
    /// </summary>
    public partial class LoginFormCode : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public LoginFormCode()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function: TextboxClearFunction: This function clears the textbox
        /// </summary>
        private void TextboxClearFunction()
        {
            userid_textbox.Clear();
            password_textbox.Clear();
        }
        /// <summary>
        /// Function: ErrorProviderClearFunction: This function clears all the errorprvider.
        /// </summary>
        private void ErrorProviderClearFunction()
        {
            userid_errorProvider.Clear();
            password_errorProvider.Clear();
        }
        /// <summary>
        /// EventHandler: RuntimeUserValidation: It performs the validation of userid while accepting the data from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RuntimeUserValidation(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!(Regex.IsMatch(userid_textbox.Text, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$")))
                {
                    userid_errorProvider.SetError(userid_textbox, "invalid User ID");
                    return;
                }
                userid_errorProvider.Clear();
            }
            catch(Exception)
            {
                error = false;
                MessageBox.Show("application ran into an error");
            }
            finally
            {
                if(error)
                    this.Close();
            }

        }
        // <summary>
        /// EventHandler: RuntimePasswordValidation: It performs the validation of password while accepting the data from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RuntimePasswordValidation(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!(Regex.IsMatch(password_textbox.Text, @"^([@$#^&\*\-\]\.,\)\( }[|\\{])?\w+(([@$# ^&*_\-\]\.,\)\(}[|\\{])*)([a-zA-Z]+)$")))
                {
                    password_errorProvider.SetError(password_textbox, "Format: min: 8 max:22 characters\n1. optional: special character - only 1\n2. a-z A-Z _\n3. special characters\n4. alphabet character");
                    return;
                }
                password_errorProvider.Clear();
            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show("application ran into an error");
            }
            finally
            {
                if (error)
                {
                    this.Close();
                }
            }
        }
        // <summary>
        /// EventHandler: LoginSubmissionButton: It performs the validation operation with DB & call the other window form, GridViewForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginSubmissionButton(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (string.IsNullOrWhiteSpace(userid_textbox.Text))
                {
                    userid_errorProvider.SetError(userid_textbox, "enter user id");
                    return;
                }
                if (string.IsNullOrWhiteSpace(password_textbox.Text))
                {
                    password_errorProvider.SetError(password_textbox, "enter password");
                    return;
                }
                if (new ClassInteractingToDB().retrievingDataFormDB(userid_textbox.Text, password_textbox.Text))
                {
                    invalid_user_label.Visible = false;
                    new GridViewForm().ShowDialog();
                }
                else
                {
                    invalid_user_label.Visible = true;
                }
                TextboxClearFunction();
                userid_textbox.Focus();
                ErrorProviderClearFunction();
            }
            catch (Exception expMsg)
            {
                string fileName = "Logfile.txt";
                File.AppendAllText(fileName, expMsg.ToString() + "\n");
                error = true;
                MessageBox.Show("application ran into an error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }
    }
}
