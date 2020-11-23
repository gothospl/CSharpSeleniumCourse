using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section7
{
    [TestClass]
    public class NestedLoopsQuiz
    {
        [TestMethod]
        public void Nested_Loops_Quiz()
        {
            int i = 0;
            int j = 10;
            while (i <= 2)
            {
                while (j >= 6)
                {
                    Console.WriteLine($"Outer: {i}\tInner: {j}");
                    j--;
                }
                i++;
                j = 10;
            }
        }
    }
}
