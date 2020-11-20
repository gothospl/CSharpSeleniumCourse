using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class SectionQuiz
    {
        static double givenF, givenC;

        [ClassInitialize]
        public static void TestSetupClass(TestContext testContext)
        {
            givenF = 23;
            givenC = 10;
        }

        [TestMethod]
        public void Convert_F_To_C()
        {
            double resultC = (givenF - 32.0) / 1.8;
            Console.WriteLine($"The temp in F {givenF} is {resultC} in C.");
            Assert.AreEqual(-5.0, resultC);
        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            double resultF = givenC * 1.8 + 32.0;
            Console.WriteLine($"The temp in C {givenC} is {resultF} in F.");
            Assert.AreEqual(50.0, resultF);
        }
    }
}
