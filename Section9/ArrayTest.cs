using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void Array_Test()
        {
            int[] scores = new int[14];
            scores[0] = 10;
            int score = scores[0];
            Assert.AreEqual(10, score);

            int numPositions = 10;
            int[] testArray = new int[numPositions];
        }

        [TestMethod]
        public void ForEach_Loop_Test()
        {
            int[] scores = { 2, 4, 6, 8, 10 };

            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
