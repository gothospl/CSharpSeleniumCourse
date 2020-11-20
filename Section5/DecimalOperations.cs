using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class DecimalOperations
    {
        static decimal number1, number2;

        [ClassInitialize]
        public static void DecimalInitialize(TestContext testContext)
        {
            number1 = 10.5M;
            number2 = 5.0M;
        }

        [TestMethod]
        public void Test_Addition()
        {
            decimal sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(15.5M, sum);
        }

        [TestMethod]
        public void Test_Substraction()
        {
            decimal difference = number1 - number2;
            Console.WriteLine(difference);
            Assert.AreEqual(5.5M, difference);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            decimal product = number1 * number2;
            Console.WriteLine(product);
            Assert.AreEqual(52.5M, product);
        }

        [TestMethod]
        public void Test_Division()
        {
            decimal quotient = number1 / number2;
            Console.WriteLine(quotient);
            Assert.AreEqual(2.1M, quotient);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            decimal modulus = number1 % number2;
            Console.WriteLine(modulus);
            Assert.AreEqual(0.5M, modulus);
        }
    }
}
