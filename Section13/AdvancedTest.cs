using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section13
{
    [TestClass]
    public class AdvancedTest
    {
        [TestMethod]
        public void Implicit_Casting()
        {
            Mammal mammal = new Cat();
            Animal animal = new Cat();
        }

        [TestMethod]
        public void Explicit_Casting()
        {
            double dPi = 3.1415926535;

            int iValue = (int)dPi;
            Console.WriteLine(iValue);
        }

        [TestMethod]
        public void Boxing_Casting()
        {
            double dPi = 3.1415926535;

            object oPi = (object)dPi;
        }

        [TestMethod]
        public void Unboxing_Casting()
        {
            double dPi = 3.1415926535;
            object oPi = (object)dPi;

            dPi = (double)oPi;
            Console.WriteLine(dPi);
        }

        [TestMethod]
        public void Delegate_Test()
        {
            DelegateDemo.Main();
        }

        delegate int del(int i);
        [TestMethod]
        public void Test_Lambda()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5);
            Assert.AreEqual(25, j);
        }

        [TestMethod]
        public void Test_List_Lambda()
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            int oddIndex = elements.FindIndex(x => x % 2 != 0);
            Console.WriteLine(oddIndex);
        }

        delegate void TestDelegate(string s);
        [TestMethod]
        public void Test_Statement_Lambda()
        {
            TestDelegate del = n =>
            {
                string s = n + " World";
                Console.WriteLine(s);
            };
            del("Hello");
        }
    }
}
