using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace SixthClient
{ 
    public partial class ControllerWindowForm : Form
    {
        private bool[] ErrorForTextbox = new bool[] {false, false, false, false,false};
        private string[] emailid, password;

        public ControllerWindowForm()
        {
            InitializeComponent();
            backgroundWorker.RunWorkerAsync();
        }

        private void ClearTextboxFunction()
        {
            textBox_emaliid.Clear();
            textBox_password.Clear();
            ErrorForTextbox[0] = false;
            ErrorForTextbox[1] = false;
        }

        private void ClearTextboxFunctionS()
        {
            textBox_emailidS.Clear();
            textBox_passwordS.Clear();
            textBox_ConfirmPassS.Clear();
            ErrorForTextbox[2] = false;
            ErrorForTextbox[3] = false;
            ErrorForTextbox[4] = false;
        }

        private void ClearErrorProviderFunction()
        {
            errorProvider_emailid.Clear();
            errorProvider_password.Clear();
        }

        private void ClearErrorProviderFunctionS()
        {
            errorProvider_emailidS.Clear();
            errorProvider_passwordS.Clear();
            errorProvider_confirmPassS.Clear();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            bool error = true;
            try
            {
                label_dateTimePicker.Text = dateTimePicker.Value.ToLongDateString();
                error = false;
            }
            catch(Exception)
            {
                MessageBox.Show("application ran into an error");
            }
            finally
            {
                if(error)
                    this.Close();
            }
        }

        private void button_imageBrowser_Click(object sender, EventArgs e)
        {
            bool error = true ;
            try
            {
                if (openFileDialog_image.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_image.Image = Image.FromFile(openFileDialog_image.FileName);
                    error = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("application ran into an error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void ControllerWindowForm_Load(object sender, EventArgs e)
        {
            bool error = true;
            try
            {
                this.signUPTABELTableAdapter.Fill(this.acerNitroDBDataSet.SignUPTABEL);
                pictureBox_image.Image = pictureBox_image.InitialImage;
                error = false;
            }
            catch (Exception)
            {
                MessageBox.Show("application ran into an error");
            }
            finally
            {
                if (error)
                    this.Close();
            }

        }

        private void RuntimePasswordValidation(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!(Regex.IsMatch(textBox_password.Text, @"^([@$#^&\*\-\]\.,\)\( }[|\\{])?\w+(([@$# ^&*_\-\]\.,\)\(}[|\\{])*)([a-zA-Z]+)$") && textBox_password.TextLength > 7))
                {
                    errorProvider_password.SetError(textBox_password, "Format: min: 8 max:30 characters\n1. optional: special character - only 1\n2. a-z A-Z _\n3. special characters\n4. alphabet character");
                    return;
                }
                ErrorForTextbox[1] = true;
                errorProvider_password.Clear();
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

        private void RuntimeEmailIDValidation(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!(Regex.IsMatch(textBox_emaliid.Text, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$")))
                {
                    errorProvider_emailid.SetError(textBox_emaliid, "Enter a valid EmailID");
                    return;
                }
                errorProvider_emailid.Clear();
                ErrorForTextbox[0] = true;
            }
            catch (Exception)
            {
                error = false;
                MessageBox.Show("application ran into an error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!ErrorForTextbox[0])
                {
                    textBox_emaliid.Focus();
                }
                else if (!ErrorForTextbox[1])
                {
                    textBox_password.Focus();
                }
                else
                {
                    int resultFromDB = new ClassInteractingWithDB().retrievingDataFormDB(textBox_emaliid.Text, textBox_password.Text);
                    // sucessful login
                    if (2 == resultFromDB)
                    {
                        label_invalidUserDisplay.Visible = false;
                        groupBox_gridForm.Visible = true;
                        groupBox_DB.Visible = true;
                        //ClearTextboxFunction();
                        textBox_emaliid.Focus();
                        //ClearErrorProviderFunction();
                    }
                    else if (1 == resultFromDB)
                    {
                        groupBox_gridForm.Visible = false;
                        groupBox_DB.Visible = false;
                        label_invalidUserDisplay.Visible = true;
                        //ClearTextboxFunction();
                        textBox_emaliid.Focus();
                        //ClearErrorProviderFunction();
                    }
                    else if (0 == resultFromDB)
                    {
                        label_invalidUserDisplay.Visible = false;
                        groupBox_gridForm.Visible = false;
                        groupBox_DB.Visible = false;
                        //ClearErrorProviderFunction();
                        if (DialogResult.Yes == MessageBox.Show("Press Yes, to join with us.", "SignUp Confirmation Window", MessageBoxButtons.YesNo))
                        {
                            textBox_emailidS.Text = textBox_emaliid.Text;
                            textBox_passwordS.Text = textBox_password.Text;
                            ClearTextboxFunction();
                            textBox_ConfirmPassS.Focus();
                            ClearErrorProviderFunctionS();
                        }
                        else
                        {
                            //ClearTextboxFunction();
                            textBox_emaliid.Focus();
                            //ClearErrorProviderFunction();
                        }
                    }
                    ClearTextboxFunction();
                    ClearErrorProviderFunction();
                }
            }
            catch(Exception expMsg)
            {
                error = true;
                MessageBox.Show("Application ran into an error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!ErrorForTextbox[2])
                {
                    textBox_emailidS.Focus();
                }
                else if (!ErrorForTextbox[3])
                {
                    textBox_passwordS.Focus();
                }
                else if (!ErrorForTextbox[4])
                {
                    textBox_ConfirmPassS.Focus();
                }
                else
                {
                    int resultFromDB = new ClassInteractingWithDB().retrievingDataFormDB(textBox_emailidS.Text, textBox_passwordS.Text);
                    //
                    if (2 == resultFromDB || 1 == resultFromDB)
                    {
                        label_newUserJoin.Visible = true;
                        ClearTextboxFunctionS();
                        textBox_emailidS.Focus();
                        ClearErrorProviderFunctionS();
                        label_newUserJoin.Visible = false;
                    }
                    else if (0 == resultFromDB)
                    {
                        label_newUserJoin.Visible = false;
                        new EntryForm(textBox_emailidS.Text, textBox_ConfirmPassS.Text).ShowDialog();
                        ClearTextboxFunctionS();
                        textBox_emailidS.Focus();
                        ClearErrorProviderFunctionS();
                    }
                }
            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show("Application ran into an error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void RuntimePasswordValidationS(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!(Regex.IsMatch(textBox_passwordS.Text, @"^([@$#^&\*\-\]\.,\)\( }[|\\{])?\w+(([@$# ^&*_\-\]\.,\)\(}[|\\{])*)([a-zA-Z]+)$") && textBox_passwordS.TextLength > 7))
                {
                    errorProvider_passwordS.SetError(textBox_passwordS, "Format: min: 8 max:30 characters\n1. optional: special character - only 1\n2. a-z A-Z _\n3. special characters\n4. alphabet character");
                }
                else
                {
                    errorProvider_passwordS.Clear();
                    ErrorForTextbox[3] = true;
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
                {
                    this.Close();
                }
            }
        }

        private void RuntimeEmailIDValidationS(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (!(Regex.IsMatch(textBox_emailidS.Text, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$")))
                {
                    errorProvider_emailidS.SetError(textBox_emailidS, "Enter a valid EmailID");
                }
                else
                {
                    errorProvider_emailidS.Clear();
                    ErrorForTextbox[2] = true;
                }
            }
            catch (Exception)
            {
                error = false;
                MessageBox.Show("application ran into an error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void RuntimeConfirmPassValidation(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                if (textBox_passwordS.Text == textBox_ConfirmPassS.Text)
                {
                    errorProvider_confirmPassS.Clear();
                    ErrorForTextbox[4] = true;
                }
                else
                    errorProvider_confirmPassS.SetError(textBox_ConfirmPassS, "password mismatch");
            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show("Application ran into an error");
            }
            finally
            {
                if (error)
                    this.Close();
            }
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<KeyValuePair<string, string>> keyValuePairs = new ClassInteractingWithDB().ReteriveEmailIDPassword();
            emailid = new string[keyValuePairs.Count];
            password = new string[keyValuePairs.Count];
            int i = 0;
            foreach (var element in keyValuePairs)
            {
                emailid[i] = element.Key;
                password[i] = element.Value;
                i++;
            }
            this.comboBox_SelectedIndexChanged(this, e);
            comboBox.Items.AddRange(emailid);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex >= 0)
                label_DPPassword.Text = "password: " + password[comboBox.SelectedIndex];
        }
    }
}
