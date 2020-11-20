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
            StringAssert.Equals("Boston", jobLocation);
        }
    }
}
