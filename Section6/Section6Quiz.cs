using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class Section6Quiz
    {
        [ClassInitialize]
        public static void InstantiateEmployee(TestContext testContext)
        {
            }
        [TestMethod]
        public void FirstNameSpaceLastName_Test()
        {
            Employee newGuy = new Employee(112, "Frank", "Underwood", "2011/02/29", "Grade A A**hole", "HR", 8500);
            Console.WriteLine($"\"Frank Underwood\"  ---  \"{newGuy.FirstNameSpaceLastName()}\"");
            Assert.AreEqual("Frank Underwood", newGuy.FirstNameSpaceLastName());
        }

        [TestMethod]
        public void LastNameCommaSpaceFirstName_Test()
        {
            Employee newGuy = new Employee(112, "Frank", "Underwood", "2011//02//29", "Grade A A**hole", "HR", 8500);
            Console.WriteLine($"\"Underwood, Frank\"  ---  \"{newGuy.LastNameCommaSpaceFirstName()}\"");
            Assert.AreEqual("Underwood, Frank", newGuy.LastNameCommaSpaceFirstName());
        }
    }
}
