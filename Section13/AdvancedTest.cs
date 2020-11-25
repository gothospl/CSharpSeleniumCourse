using System;
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
    }
}
