using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            //arrange
            Car thisCar = new Car("black", 4, false);

            //act

            //assert
            Assert.AreEqual("black", thisCar.Color);

        }
    }
}
