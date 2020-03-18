using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ThirdAssignment
{
    /// <summary>
    /// form1 class
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// static variables to reveive values from form2 class
        /// </summary>
        public static string strName;
        public static string strAge;
        public static string strSalary;
        public static string strEmail;
        /// <summary>
        /// constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// function to clear the text fields
        /// </summary>
        private void TextClear()
        {
            Name_T.Clear();
            Age_T.Clear();
            Salary_T.Clear();
            Email_T.Clear();
        }
        /// <summary>
        /// function to assign values to static variables
        /// </summary>
        private void AssignValue()
        {
            strName = Name_T.Text;
            strAge = Age_T.Text;
            strSalary = Salary_T.Text;
            strEmail = Email_T.Text;
        }
        /// <summary>
        /// event handler of register button for validation operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToDisplayForm(object sender, EventArgs e)
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
                Email_T.Focus();
            }
            ///
            //EmailID Validation
            ///
            if (!(new Regex(@"^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$").Match(Email_T.Text).Success))
            {
                MessageBox.Show("Enter valid EmailID");
                Email_T.Focus();
                return;
            }
            else
            {
                AssignValue();
                new Form2().ShowDialog();
                TextClear();
            }
        }
    }
}
