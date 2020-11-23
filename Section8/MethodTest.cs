using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void Test_Square()
        {
            int result = MathHelper.Square(6);
            Assert.AreEqual(36, result);
        }

        [TestMethod]
        public void Test_Employee_Overload_String()
        {
            Employee testEmployee = new Employee("John Curtin", 12345, "Manager");
            string result = testEmployee.PayType(testEmployee.JobTitle);
            Assert.AreEqual("Salary", result);
        }

        [TestMethod]
        public void Test_Employee_Overload_Int()
        {
            Employee testEmployee = new Employee("John Curtin", 12345, "Manager");
            string result = testEmployee.PayType(testEmployee.EmployeeID);
            Assert.AreEqual("Salary", result);
        }
    }
}
