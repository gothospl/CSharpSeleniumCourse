using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section7
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void Test_While_Loops()
        {
            int number = 1;
            while(number < 11)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        [TestMethod]
        public void Test_Sentinel_Controlled_Loop()
        {
            string inValue = "";
            while (inValue != "-99")
            {
                Console.Write("\nEnter value (-99 to exit): ");
                inValue = Console.ReadLine();
            }
            Console.ReadKey();
        }

        [TestMethod]
        public void Nested_Loops()
        {
            int number1 = 1;
            int number2 = 1;

            while(number1 <= 5)
            {
                while(number2 <= number1)
                {
                    Console.WriteLine(number2);
                    number2++;
                }
                number1++;
            }
        }
    }
}
;