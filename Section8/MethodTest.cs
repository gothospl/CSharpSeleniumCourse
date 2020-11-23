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
        public void Test_Static_Square_Named()
        {
            Assert.AreEqual(36, MathHelper.Square(aValue: 6));
        }

        [TestMethod]
        public void Test_Named_Parameters()
        {
            int sum = MathHelper.AddNumber(bValue: 32, aValue: 112);
            Assert.AreEqual(sum, 144);
            int sum10 = MathHelper.AddNumber(0);
            Assert.AreEqual(sum10, 10);
            int sum26 = MathHelper.AddNumber(bValue: 4);
            Assert.AreEqual(sum26, 26);
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

        [TestMethod]
        public void Test_Out_Parameter()
        {
            int number1;
            MathHelper.NumbersOut(out number1);
            Assert.AreEqual(6, number1);
        }

        [TestMethod]
        public void Test_Ref_Parameter()
        {
            int number1 = 0;
            MathHelper.NumbersRef(ref number1);
            Assert.AreEqual(7, number1);
        }
    }
}
