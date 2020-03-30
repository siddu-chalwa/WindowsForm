using DocumentFormat.OpenXml.Vml;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SixthClient
{
    /// <summary>
    /// class: collecting data from user and passing to ClassInteractingToDB
    /// </summary>
    public partial class EntryForm : Form
    {
        /// <summary>
        /// variables
        /// </summary>
        private bool[] ErrorVerify = new bool[]{false, false, false, false};
        private string emailid, password;
        private string imageFile = null;
        private int ageVar, salaryVar;
        /// <summary>
        /// function: clears the textfield
        /// </summary>
        private void ClearTextFields()
        {
            textBox_age.Clear();
            textBox_ContactNo.Clear();
            textBox_name.Clear();
            textBox_salary.Clear();
        }
        public EntryForm() { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="emailid"></param>
        /// <param name="password"></param>
        /// </summary>
        public EntryForm(string emailid, string password)
        {
            InitializeComponent();
            this.emailid = emailid;
            this.password = password;
        }
        /// <summary>
        /// event handler: for submit button controller to pass the data entered by user to ClasIteractigTODB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button_submit_Click(object sender, EventArgs e)
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
                    if (new ClassInteractingWithDB().WrittingDataToDB(emailid, password, textBox_name.Text, ageVar, salaryVar, textBox_ContactNo.Text, imageFile))
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
            catch(Exception msg)
            {
                error = true;
                MessageBox.Show("application ran into a error" + msg);
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        /// <summary>
        /// event handler: for text change controller: for name validataion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// event handler: for text change controller: age validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// event handler: for upload button controller: pass the image to ClassInteractingToDB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_uploadimg_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (openFileDialog_imageUpload.ShowDialog() == DialogResult.OK)
                {
                    imageFile = openFileDialog_imageUpload.FileName;
                }
            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show("application ran into an error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }
        /// <summary>
        /// event handler: for text change controller: salary validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// event handler: for text change controller: mobile no. validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// event handler: for keypress controller: allows only to enter digits in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyPress_NoCharacterAllowed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
