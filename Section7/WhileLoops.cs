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
    }
}
