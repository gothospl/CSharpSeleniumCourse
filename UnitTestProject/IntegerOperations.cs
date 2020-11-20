using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class IntegerOperations
    {
        static int number1, number2;
        [ClassInitialize]
        public static void IntegerInitialize(TestContext testContext)
        {
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Test_Addition()
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(15, sum);
        }

        [TestMethod]
        public void Test_Substraction()
        {
            int difference = number1 - number2;
            Console.WriteLine(difference);
            Assert.AreEqual(5, difference);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            int product = number1 * number2;
            Console.WriteLine(product);
            Assert.AreEqual(50, product);
        }

        [TestMethod]
        public void Test_Division()
        {
            int quotient = number1 / number2;
            Console.WriteLine(quotient);
            Assert.AreEqual(2, quotient);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            int modulus = number1 % number2;
            Console.WriteLine(modulus);
            Assert.AreEqual(0, modulus);
        }
    }
}
