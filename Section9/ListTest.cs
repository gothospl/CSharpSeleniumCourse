using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Section9
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Test_Crreating_Lists()
        {
            ArrayList scores = new ArrayList();
            FillList(scores);
            int sum = TotalScores(scores);
            Console.WriteLine(sum);
        }

        public void FillList(ArrayList scores)
        {
            for(int i = 1; i<=20; i++)
            {
                scores.Add(i);
            }
        }

        public int TotalScores(ArrayList scores)
        {
            int sum = 0;
            foreach(int score in scores)
            {
                sum += score;
            }
            return sum;
        }
    }
}
