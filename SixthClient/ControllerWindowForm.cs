using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace SixthClient
{ 
    public partial class ControllerWindowForm : Form
    {
        /// <summary>
        /// class variables
        /// </summary>
        private bool[] ErrorForTextbox = new bool[] {false, false, false, false,false};
        private string[] emailid, password;
        private bool LoginVal = false;  
        /// <summary>
        /// Constructor
        /// </summary>
        public ControllerWindowForm()
        {
            InitializeComponent();
            backgroundWorker.RunWorkerAsync();
        }
        /// <summary>
        /// thread event handler: background worker: for presenting the data stored in the array to combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Function: clear the textbox in login group
        /// </summary>
        private void ClearTextboxFunction()
        {
            textBox_emaliid.Clear();
            textBox_password.Clear();
            ErrorForTextbox[0] = false;
            ErrorForTextbox[1] = false;
        }
        /// <summary>
        /// Function: clear the textbox in signup group
        /// </summary>
        private void ClearTextboxFunctionS()
        {
            textBox_emailidS.Clear();
            textBox_passwordS.Clear();
            textBox_ConfirmPassS.Clear();
            ErrorForTextbox[2] = false;
            ErrorForTextbox[3] = false;
            ErrorForTextbox[4] = false;
        }
        /// <summary>
        /// function: clear the errorProvider in login group
        /// </summary>
        private void ClearErrorProviderFunction()
        {
            errorProvider_emailid.Clear();
            errorProvider_password.Clear();
        }
        /// <summary>
        /// function: clear the errorProvider in signup group
        /// </summary>
        private void ClearErrorProviderFunctionS()
        {
            errorProvider_emailidS.Clear();
            errorProvider_passwordS.Clear();
            errorProvider_confirmPassS.Clear();
        }
        /// <summary>
        /// function: for notificatio icon control
        /// </summary>
        private void NotificationIconControl()
        {
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = "DN_WindowsForm";
            notifyIcon.BalloonTipTitle = "Welcome";
            notifyIcon.ShowBalloonTip(10000);
        }
        /// <summary>
        /// Function: to occur after user sucessful login
        /// </summary>
        private void OnSucessFullLogin()
        {
            label_invalidUserDisplay.Visible = false;
            groupBox_gridForm.Visible = true;
            groupBox_DB.Visible = true;
            groupBox_loginIn.Visible = false;
            groupBox_signup.Visible = false;
            button_imageBrowser.Visible = false;
            lOGINToolStripMenuItem1.Visible = false;
            lOGUTToolStripMenuItem.Visible = true;
            sIGNUPToolStripMenuItem1.Visible = false;
            pRINTToolStripMenuItem1.Visible = true;
            refreshToolStripMenuItem1.Visible = false;
        }
        /// <summary>
        /// event handler: display the date slected by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
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
        /// <summary>
        /// event handler: for browse button: open the folder and select the file and display in the picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_imageBrowser_Click(object sender, EventArgs e)
        {
            bool error = false ;
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
        ///  event handler: when page gets loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControllerWindowForm_Load(object sender, EventArgs e)
        {
            bool error = true;
            try
            {
                this.signUPTABELTableAdapter.Fill(this.acerNitroDBDataSet.SignUPTABEL);
                pictureBox_image.Image = pictureBox_image.InitialImage;
                NotificationIconControl();
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
        /// <summary>
        /// event handler: text change: for password validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// event handler: text change: for emailid validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// evenet handler: login button: for verifying the user entery with the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    byte[] vs = null;
                    int id = new ClassInteractingWithDB().LoginEmailidPasswordValidation(textBox_emaliid.Text, textBox_password.Text, out vs);
                    // sucessful login
                    if (0 != id)
                    {
                        if (vs != null)
                            pictureBox_image.Image = Image.FromStream(new MemoryStream(vs));
                        else
                            pictureBox_image.Image = pictureBox_image.InitialImage;
                        OnSucessFullLogin();
                        LoginVal = true;
                    }
                    else
                    {
                        groupBox_gridForm.Visible = false;
                        groupBox_DB.Visible = false;
                        label_invalidUserDisplay.Visible = true;
                        textBox_emaliid.Focus();
                        pictureBox_image.Image = pictureBox_image.InitialImage;
                    }
                    ClearTextboxFunction();
                    ClearErrorProviderFunction();
                }
            }
            catch(Exception)
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
        /// <summary>
        /// Event handller: for submit button: validate user entry and pass to ClassInteractingWithDB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    int id = new ClassInteractingWithDB().SignupEmailIDValidation(textBox_emailidS.Text);
                    // New User
                    if (0 == id)
                    {
                        label_newUserJoin.Visible = false;
                        new EntryForm(textBox_emailidS.Text, textBox_ConfirmPassS.Text).ShowDialog();
                        ClearTextboxFunctionS();
                        textBox_emaliid.Focus();
                        ClearErrorProviderFunctionS();
                    }
                    //Account Exist
                    else
                    {
                        label_newUserJoin.Visible = true;
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
        /// <summary>
        /// event handler: text change: for password validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// event handler: text change: for new user emailid validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// event handler: text change: for confirm password validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// event handler: toolstripmenuitem: for login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_emaliid.Focus();
        }
        /// <summary>
        /// event handler: toolstripmenuitem: for signup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_emailidS.Focus();
        }
        /// <summary>
        /// event handler: toolstripmenuitema: logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LoginVal)
            {
                groupBox_loginIn.Visible = true;
                groupBox_signup.Visible = true;
                groupBox_gridForm.Visible = false;
                button_imageBrowser.Visible = true;
                pictureBox_image.Image = pictureBox_image.InitialImage;
                lOGINToolStripMenuItem1.Visible = true;
                sIGNUPToolStripMenuItem1.Visible = true;
                lOGUTToolStripMenuItem.Visible = false;
                groupBox_DB.Visible = false;
                pRINTToolStripMenuItem1.Visible = false;
                refreshToolStripMenuItem1.Visible = true;
                LoginVal = false;
            }
        }
        /// <summary>
        /// event handler: toolstripmenuitem: for about
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dieboldnixdorf.com/");
        }
        /// <summary>
        /// event handler: toolstripmenuitem: eixt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// event handler: toolstripmenuitem: print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pRINTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(dataGridView.Rows.Count != 0)
            {
                int row = dataGridView.Rows.Count;
                int column = dataGridView.Columns.Count;
                string filePath = "dataFile.txt";
                string[] contentFromGrid = new string[row];
                for (int i = 0; i < row; i++)
                {
                    string[] content = new string[column];
                    for (int j = 0; j < column; j++)
                    {
                        content[j] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    contentFromGrid[i] = string.Join("..........", content);
                }
                string bla = string.Join("\n", contentFromGrid);

                File.WriteAllText(filePath, "Name...........Age.........Salary...........Mobile No..........EmailID\n\n" + bla);
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("DataBase in Empty");
            }
        }
        /// <summary>
        /// event handler: toolstripmenuitem: refresh on mouse right click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!LoginVal)
            {
                label_invalidUserDisplay.Visible = false;
                label_newUserJoin.Visible = false;
                ClearTextboxFunction();
                ClearTextboxFunctionS();
                ClearErrorProviderFunction();
                ClearErrorProviderFunctionS();
                dateTimePicker.Value = DateTime.Now;
                pictureBox_image.Image = pictureBox_image.InitialImage;
            }
        }
        /// <summary>
        /// event handler: combobox: from the list collection the data are listed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex >= 0)
                label_DPPassword.Text = "password: " + password[comboBox.SelectedIndex];
        }
    }
}
