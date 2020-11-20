using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class IfAndElse
    {
        static int number1, number2;

        [ClassInitialize]
        public static void IfAndElseInitialize(TestContext testContext)
        {
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Number1_Is_Equal_Number2()
        {
            if (number1 == number2)
                Assert.IsTrue(number1 == number2);
            else
                Assert.Fail();
        }

        [TestMethod]
        public void Number1_Is_Not_Equal_Number2()
        {
            if (number1 != number2)
                Assert.IsTrue(number1 != number2);
            else
                Assert.Fail();
        }

        [TestMethod]
        public void Number1_Is_Greater_Than_Number2()
        {
            if (number1 > number2)
                Assert.IsTrue(number1 > number2);
            else
                Assert.Fail();
        }

        [TestMethod]
        public void Number1_Is_Greater_Than_Or_Equal_Number2()
        {
            if (number1 >= number2)
                Assert.IsTrue(number1 >= number2);
            else
                Assert.Fail();
        }

        [TestMethod]
        public void Number1_Is_Less_Than_Number2()
        {
            if (number1 < number2)
                Assert.IsTrue(number1 < number2);
            else
                Assert.Fail();
        }

        [TestMethod]
        public void Number1_Is_Less_Than_Or_Equal_Number2()
        {
            if (number1 <= number2)
                Assert.IsTrue(number1 <= number2);
            else
                Assert.Fail();
        }
    }
}
