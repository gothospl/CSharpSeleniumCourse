using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Test_Employee_ID_Set()
        {
            Employee employee1 = new Employee(666);

            string jobLocation = employee1.JobLocation();
            StringAssert.Equals("New York", jobLocation);

            employee1.JobTitle = "Manager";
            Assert.AreEqual("Boston", jobLocation);
        }

        [TestMethod]
        public void Test_To_String()
        {
            Employee employee1 = new Employee("John Wood", 96669, "Manager");
            Console.WriteLine(employee1);
        }
    }
}
