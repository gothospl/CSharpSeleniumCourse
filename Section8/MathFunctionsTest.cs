using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class MathFunctionsTest
    {
        [TestMethod]
        public void Test_Square_Root()
        {
            double expectedResult = 4.0;
            double input = 16.0;
            double actualResult = MathFunctions.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_Sum_Int()
        {
            int expectedResult = 35;
            int input1 = 12;
            int input2 = 23;
            int actualResult = MathFunctions.Sum(input1, input2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_Sum_Double()
        {
            double expectedResult = 66.0;
            double input1 = 20.13;
            double input2 = 45.87;
            double actualResult = MathFunctions.Sum(input1, input2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_Sum_Decimal()
        {
            decimal expectedResult = 13.45M;
            decimal input1 = 6.213M;
            decimal input2 = 7.237M;
            decimal actualResult = MathFunctions.Sum(input1, input2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
