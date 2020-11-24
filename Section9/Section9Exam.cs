using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class Section9Exam
    {
        [TestMethod]
        public void Exam_Test()
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add(13.5);
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");

            double total = SumArrayList(PruneArrayList(dataList));

            Console.WriteLine(total);
            Assert.AreEqual(160.5, total);
        }

        public ArrayList PruneArrayList(ArrayList dataList)
        {
            double inValue;
            ArrayList cleanList = new ArrayList();

            for (int i=0; i<dataList.Count; i++)
            {
                if (double.TryParse(Convert.ToString(dataList[i]), out inValue) == true)
                {
                    cleanList.Add(inValue);
                }
            }
            return cleanList;
        }

        public double SumArrayList(ArrayList dataList)
        {
            double sum = 0.0;
            foreach (double item in dataList)
            {
                sum += item;
            }
            return sum;
        }
    }
}
