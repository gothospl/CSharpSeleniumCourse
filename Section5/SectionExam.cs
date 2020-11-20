using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class SectionExam
    {
        static int year;

        [ClassInitialize]
        public static void StarterPack(TestContext testContext)
        {
            year = 1900;
        }

        [TestMethod]
        public void TestMethod1()
        {
            bool divByFour = (year % 4 == 0);
            bool divByHundred = (year % 100 == 0);
            bool divByFourHundred = (year % 400 == 0);
            bool leapYear;

            if ((divByFour && divByHundred && divByFourHundred) || (divByFour && !divByHundred && !divByFourHundred))
                leapYear = true;
            else
                leapYear = false;

            Console.WriteLine($"Year entered: {year}");
            if (divByFour)
                Console.WriteLine($"Divisible by 4: Yes");
            else
                Console.WriteLine($"Divisible by 4: No");
            if (divByHundred)
                Console.WriteLine($"Divisible by 100: Yes");
            else
                Console.WriteLine($"Divisible by 100: No");
            if (divByFourHundred)
                Console.WriteLine($"Divisible by 400: Yes");
            else
                Console.WriteLine($"Divisible by 400: No");
            if (leapYear)
                Console.WriteLine($"Leap year: Yes");
            else
                Console.WriteLine($"Leap year: No");

            Assert.AreEqual(true, leapYear);
        }
    }
}
