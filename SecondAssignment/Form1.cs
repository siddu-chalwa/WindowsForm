using System;
using System.Windows.Forms;

namespace SecondAssignment
{
    /// <summary>
    /// Form1 Class
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// static variables for trasnfering data between 2 forms
        /// </summary>
        public static string strName;
        public static string strAge;
        public static string strSalary;
        public static string strEmailID;
        /// <summary>
        /// constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// function to clear the text in form1
        /// </summary>
        private void Clear_Text()
        {
            Name_Text1.Clear();
            Age_Text1.Clear();
            Salary_Text1.Clear();
            Email_Text1.Clear();
        }
        /// <summary>
        /// function to assign values to textbox
        /// </summary>
        private void AssignValueToLabel()
        {
            Name_Text1.Text = strName;
            Age_Text1.Text = strAge;
            Salary_Text1.Text = strSalary;
            Email_Text1.Text = strEmailID;
        }
        /// <summary>
        /// event handler of submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Goto_ChildForm(object sender, EventArgs e)
        {
            Clear_Text();
            new Form2().ShowDialog();
            AssignValueToLabel();
        }
    }
}
