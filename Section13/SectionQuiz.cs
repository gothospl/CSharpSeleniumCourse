using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section13
{
    [TestClass]
    public class SectionQuiz
    {
        [TestMethod]
        public void Test_First_Name()
        {
            string firstName = "Albert";
            string pattern = @"^[A-Za-z]+$";
            bool response = Regex.IsMatch(firstName, pattern);
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void Test_Last_Name()
        {
            string lastName = "Einstein";
            string pattern = @"^[A-Za-z]+$";
            bool response = Regex.IsMatch(lastName, pattern);
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void Test_Age()
        {
            int age = 63;
            string sAge = Convert.ToString(age);
            string pattern = @"^\d+$";
            bool response = Regex.IsMatch(sAge, pattern);
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void Test_Birth_Date()
        {
            int day = 31;
            int month = 11;
            int year = 1910;
            string birthDate = Convert.ToString(year) + "/" + Convert.ToString(month) + "/" + Convert.ToString(day);
            string pattern = @"^(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$";
            bool response = Regex.IsMatch(birthDate, pattern);
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void Test_Phone_Number()
        {
            string phoneNumber = "(555)-555-5555";
            string pattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            bool response = Regex.IsMatch(phoneNumber, pattern);
            Assert.IsTrue(response);
        }
    }
}
