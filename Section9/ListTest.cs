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

        [TestMethod]
        public void ArrayList_Practice()
        {
            ArrayList list = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            list.Add(45);
            list.Add(78);
            list.Add(33);
            list.Add(56);
            list.Add(12);
            list.Add(23);
            list.Add(9);

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count: {0}", list.Count);

            Console.Write("Content: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.Write("Sorted Content: ");
            list.Sort();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
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
