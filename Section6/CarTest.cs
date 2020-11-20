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

            //assert
            Assert.AreEqual("black", thisCar.Color);

        }
        [TestMethod]
        public void Call_Acceleration_Method()
        {
            Car thisCar = new Car("black", 4, false);

            thisCar.Accelerate();
        }

        [TestMethod]
        public void Call_FamilyCar_Method()
        {
            Car thisCar = new Car("black", 4, false);

            bool carType = thisCar.FamilyCar();
            if (carType == true)
            {
                Assert.IsTrue(carType == true);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
