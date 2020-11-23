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

        [TestMethod]
        public void Pass_Array_Method()
        {
            int[] scores = { 2, 4, 6, 8, 10 };
            int sum = TotalScores(scores);
        }

        public int TotalScores(int[] scores)
        {
            int sum = 0;
            foreach(int score in scores)
            {
                sum += score;
            }
            return sum;
        }

        [TestMethod]
        public void Pass_Array_Element()
        {
            int[] scores = { 2, 4, 6, 8, 10 };

            foreach (int score in scores)
            {
                Console.WriteLine(CheckScore(score));
            }
        }

        public string CheckScore(int score)
        {
            if (score >= 6)
                return "Pass";
            else
                return "Fail";
        }

        [TestMethod]
        public void Array_Class_Methods()
        {
            double[] waterDepth = { 12.4, 3.5, 6.8 };
            Array.Sort(waterDepth);
            foreach (double wVal in waterDepth)
            {
                Console.Write($"{wVal}\t");
            }

            Array.Reverse(waterDepth);
            foreach (double wVal in waterDepth)
            {
                Console.Write($"{wVal}\t");
            }

        }
    }
}
