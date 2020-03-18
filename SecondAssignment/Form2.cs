using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SecondAssignment
{
    /// <summary>
    /// form2 class
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// function to clear the textbox value
        /// </summary>
        private void Clear_Text()
        {
            Name_Text2.Clear();
            Age_Text2.Clear();
            Salary_Text2.Clear();
            Email_Text2.Clear();
        }
        /// <summary>
        /// function to assign value to textbox of form1
        /// </summary>
        private void Fill_Form1()
        {
            Form1.strName = Name_Text2.Text;
            Form1.strAge = Age_Text2.Text;
            Form1.strSalary = Salary_Text2.Text;
            Form1.strEmailID = Email_Text2.Text;
        }
        /// <summary>
        /// event handler of submit button to perform validation operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Validation(object sender, EventArgs e)
        {
            ///
            //Name Validation
            ///
            if (Name_Text2.Text == "" || Name_Text2.Text == null)
            {
                MessageBox.Show("Enter Name");
                Name_Text2.Focus();
                return;
            }
            else if (!(new Regex(@"^([A-Za-z]+)(\s[A-Za-z]+)*$").Match(Name_Text2.Text).Success))
            {
                MessageBox.Show("Enter Name");
                Name_Text2.Focus();
                return;
            }
            else if (Name_Text2.Text.Length < 7)
            {
                MessageBox.Show("Name Should Contain Min 6 Characters");
                Name_Text2.Focus();
                return;
            }
            else
            {
                Age_Text2.Focus();
            }
            ///
            //Age Validation
            ///
            int ageV;
            if (!(int.TryParse(Age_Text2.Text, out ageV)))
            {
                MessageBox.Show("Enter Valid Age");
                Age_Text2.Focus();
                return;
            }
            else if (ageV < 0 || ageV > 150)
            {
                MessageBox.Show("Age Limit from 1 to 150");
                Age_Text2.Focus();
                return;
            }
            else
            {
                Salary_Text2.Focus();
            }
            ///
            //Salary Validation
            ///
            int salaryV;
            if (!(int.TryParse(Salary_Text2.Text, out salaryV)))
            {
                MessageBox.Show("Enter Valid Salary");
                Salary_Text2.Focus();
                return;
            }
            else if (salaryV < 0)
            {
                MessageBox.Show("Salary can't be Negative");
                Salary_Text2.Focus();
                return;
            }
            else if (salaryV >= 0 && salaryV < 500)
            {
                MessageBox.Show("Salary can't be less then 500");
                Salary_Text2.Focus();
                return;
            }
            else
            {
                Email_Text2.Focus();
            }
            ///
            //EmailID Validation
            ///
            if (!(new Regex(@"^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$").Match(Email_Text2.Text).Success))
            {
                MessageBox.Show("Enter valid EmailID");
                Email_Text2.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Thank You");
                Fill_Form1();
                Clear_Text();
                this.Hide();
            }
        }
    }
}
