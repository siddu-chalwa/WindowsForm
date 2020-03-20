using System;
using System.Windows.Forms;

namespace ThirdClient
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }
        public void AssignValuesToTextbox(string textbox_name, string textbox_age, string textbox_salary, string textbox_emailid)
        {
            name_textbox.Text = textbox_name;
            age_textbox.Text = textbox_age;
            salary_textbox.Text = textbox_salary;
            emailid_textbox.Text = textbox_emailid;
        }
    }
}
