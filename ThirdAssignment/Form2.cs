using System;
using System.Windows.Forms;

namespace ThirdAssignment
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
            Name_T.Text = Form1.strName;
            Age_T.Text = Form1.strAge;
            Salary_T.Text = Form1.strSalary;
            Email_T.Text = Form1.strEmail;
        }
        /// <summary>
        /// function to perform clean of text fields
        /// </summary>
        private void clearText()
        {
            Name_T.Clear();
            Age_T.Clear();
            Salary_T.Clear();
            Email_T.Clear();
        }
        /// <summary>
        /// event hadler of submit button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Button(object sender, EventArgs e)
        {
            clearText();
            this.Hide();
        }
    }
}
