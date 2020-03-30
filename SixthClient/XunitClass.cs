using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Xunit;
namespace SixthClient
{
    public class XunitClass
    {
        [Theory]
        [InlineData("siddu.chalwa@dn.com")]
        [InlineData("abc.@dn.com")]
        public void SignupEmailIDValidation_Case(string emailid)
        {
            //Expected: 0: means the user is new, else other value mean that account exist
            Assert.Equal(0, new ClassInteractingWithDB().SignupEmailIDValidation(emailid));
        }
        [Theory]
        [InlineData("siddu.chalwa@dn.com", "@DN0.sid", null)]
        [InlineData("abc.xyz@dn.com", "@DN9.xyz", null)]
        public void LoginEmailidPasswordValidation_Case(string emailid, string password, out byte[] vs)
        {
            //Expected: true: means imgage uploaded by the user, else image has not been uploaded
            new ClassInteractingWithDB().LoginEmailidPasswordValidation(emailid, password, out vs);
            Assert.NotNull(vs);
        }
        [Fact]
        public void ReteriveEmailIDPassword_Case()
        {
            //Expected: true: means DB has somoe entries
            Assert.NotEmpty(new ClassInteractingWithDB().ReteriveEmailIDPassword());
        }
        [Theory]
        [InlineData("emailId@gmail.com", "@password123", "Gmail_Email", 100, 100000, "1234567890", null)]
        public void WrittingDataToDB_Case(string emailID, string password, string name, int age, int salary, string contactNo, string imageFile)
        {
            //Expected: true: means data stored to db
            Assert.True(new ClassInteractingWithDB().WrittingDataToDB(emailID, password, name, age, salary, contactNo, imageFile));
        }
        [Theory]
        [InlineData("Siddu.Chalwa")]
        [InlineData("Siddu80Chalwa")]
        [InlineData("Siddu_Chalwa")]
        [InlineData("siddu")]
        [InlineData("Siddu@Chalwa")]
        public void RuntimeNameValidation_Case(string name)
        {
            //Expected: True: means the name foramt is correct
            Assert.True(RuntimeNameValidation(name));
        }
        private bool RuntimeNameValidation(string name)
        {
            if (name.Length <= 6 || !(Regex.IsMatch(name, @"^(_?)([a-zA-Z]+)([ _.-]?)(([a-zA-Z]+)?)$")))
                return false;
            return true;
        }
        [Theory]
        [InlineData("10")]
        [InlineData("0")]
        [InlineData("200")]
        [InlineData("age")]
        public void textBox_age_TextChanged_Case(string age)
        {
            Assert.True(textBox_age_TextChanged(age));
        }
        private bool textBox_age_TextChanged(string age)
        {
            int _age;
            if (int.TryParse(age, out _age) && _age > 0 && _age <= 150)
                return true;
            return false;

        }
        [Theory]
        [InlineData("100")]
        [InlineData("450000")]
        [InlineData("Rupee")]
        public void textBox_salary_TextChanged_Case(string salary)
        {
            Assert.True(textBox_salary_TextChanged(salary));
        }
        private bool textBox_salary_TextChanged(string salary)
        {
            int _salary;
            if (int.TryParse(salary, out _salary) && _salary >= 500 && _salary <= 1000000000)
                return true;
            return false;
        }
        [Theory]
        [InlineData("9513087238")]
        [InlineData("01234567891")]
        public void textBox_ContactNo_TextChanged_Case(string mobileNo)
        {
            Assert.Equal(10, mobileNo.Length);
        }
    }
}
