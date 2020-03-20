using System;
using System.Windows.Forms;

namespace SecondClient
{
    
    public partial class DisplayForm : Form
    {
        private void ClearTextFields()
        {
            name_textbox.Clear();
            age_textbox.Clear();
            salary_textbox.Clear();
            emailid_textbox.Clear();
        }
        public void AssignValuesToTextbox(string textbox_name, string textbox_age, string textbox_salary, string textbox_emailid)
        {
            name_textbox.Text = textbox_name;
            age_textbox.Text = textbox_age;
            salary_textbox.Text = textbox_salary;
            emailid_textbox.Text = textbox_emailid;
        }
        public DisplayForm()
        {
            InitializeComponent();
        }
        private void DisplayButton_OpenRegistrationForm(object sender, MouseEventArgs e)
        {
            bool error = true;
            try
            {
                ClearTextFields();
                DisplayForm displayForRef = this;
                RegistrationForm registrationForm = new RegistrationForm(ref displayForRef);
                registrationForm.ShowDialog();
                error = false;
            }
            catch(Exception expMsg)
            {
                MessageBox.Show("application run into an error" + expMsg.Message);
            }
            finally
            {
                if(error)
                {
                    this.Close();
                }
            }
        }
    }
}
