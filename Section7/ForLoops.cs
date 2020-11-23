using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section7
{
    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void Test_For_Loops()
        {
            for (int i=0; i<=2; i++)
            {
                for (int j=10; j>=6; j--)
                {
                    Console.WriteLine($"Outer: {i}\tInner: {j}");
                }
            }
        }
        [TestMethod]
        public void Strange_For_Loops()
        {
            for (int counter = 0, val1 = 10; counter < val1; counter++)
            {

            }

            int count2 = 0;
            for (; count2 < 100; count2 += 10)
            {

            }

            for (int j =0; ; j++)
            {

            }

            for (double d = 15.0; d < 20.0; d += 0.5)
            {

            }
        }
    }
}
