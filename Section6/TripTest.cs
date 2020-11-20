using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void Trip_Test_1()
        {
            Trip vancouverTrip = new Trip("Vancouver", 2345, 200, 95);

            Console.WriteLine(vancouverTrip);
            Console.WriteLine($"Miles Per Gallon: {vancouverTrip.MilesPerGallon()}");
            Assert.AreEqual(24.68, vancouverTrip.MilesPerGallon(), 0.01);
        }

        [TestMethod]
        public void Trip_Test_2()
        {
            Trip vancouverTrip = new Trip("Vancouver", 2345, 200, 95);

            Console.WriteLine(vancouverTrip);
            Console.WriteLine($"Cost Per Mile: {vancouverTrip.CostPerMile()}");
            Assert.AreEqual(0.085, vancouverTrip.CostPerMile(), 0.001);
        }
    }
}
