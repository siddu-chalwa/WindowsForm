using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsLoginForm
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constrctor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// function to clear the fields of windows form
        /// </summary>
        private void TextClear()
        {
            Name_T.Clear();
            Age_T.Clear();
            Salary_T.Clear();
            EmailID_T.Clear();
        }
        /// <summary>
        /// event handler of submit button which perform validation opertation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Validation(object sender, EventArgs e)
        {
            ///
            //Name Validation
            ///
            if (Name_T.Text == "" || Name_T.Text == null)
            {
                MessageBox.Show("Enter Name");
                Name_T.Focus(); 
                return;
            }
            else if (!(new Regex(@"^([A-Za-z]+)(\s[A-Za-z]+)*$").Match(Name_T.Text).Success))
            {
                MessageBox.Show("Enter Name");
                Name_T.Focus();
                return;
            }
            else if (Name_T.Text.Length < 7)
            {
                MessageBox.Show("Name Should Contain Min 6 Characters");
                Name_T.Focus();
                return;
            }
            else
            {
                Age_T.Focus();
            }
            ///
            //Age Validation
            ///
            int ageV;
            if (!(int.TryParse(Age_T.Text, out ageV)))
            {
                MessageBox.Show("Enter Valid Age");
                Age_T.Focus();
                return;
            }
            else if (ageV < 0 || ageV > 150)
            {
                MessageBox.Show("Age Limit from 1 to 150");
                Age_T.Focus();
                return;
            }
            else
            {
                Salary_T.Focus();
            }
            ///
            //Salary Validation
            ///
            int salaryV;
            if (!(int.TryParse(Salary_T.Text, out salaryV)))
            {
                MessageBox.Show("Enter Valid Salary");
                Salary_T.Focus();
                return;
            }
            else if (salaryV < 0)
            {
                MessageBox.Show("Salary can't be Negative");
                Salary_T.Focus();
                return;
            }
            else if (salaryV >= 0 && salaryV < 500)
            {
                MessageBox.Show("Salary can't be less then 500");
                Salary_T.Focus();
                return;
            }
            else
            {
                EmailID_T.Focus();
            }
            ///
            //EmailID Validation
            ///
            if (!(new Regex(@"^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$").Match(EmailID_T.Text).Success))
            {
                MessageBox.Show("Enter valid EmailID");
                EmailID_T.Focus();
                return;
            }
            else
            {
                ///
                // File Operation
                ///
                string fileName = "dataFile.txt";
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(fileName, true);
                streamWriter.WriteLine("Name: " + Name_T.Text);
                streamWriter.WriteLine("Age: " + Age_T.Text);
                streamWriter.WriteLine("Salary: " + Salary_T.Text);
                streamWriter.WriteLine("Email ID: " + EmailID_T.Text);
                streamWriter.WriteLine();
                streamWriter.Close();
                TextClear();
                Name_T.Focus();
            }
        }
        /// <summary>
        /// event handler of reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Validation(object sender, EventArgs e)
        {
            TextClear();
            Name_T.Focus();
        }
    }
}
