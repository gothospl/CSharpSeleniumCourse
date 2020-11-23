using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class PropertyTaxTest
    {
        [TestMethod]
        public void Test_Taxable_Value()
        {
            PropertyTaxCalculator myProperty = new PropertyTaxCalculator("18 Paper Street, 18829 Wilmington, DE", 300000M);
            Assert.AreEqual(283100M, myProperty.TaxableValue());
        }

        [TestMethod]
        public void Test_Taxes_Due()
        {
            PropertyTaxCalculator myProperty = new PropertyTaxCalculator("18 Paper Street, 18829 Wilmington, DE", 300000M);
            Assert.AreEqual(2839.493M, myProperty.TaxesDue());
        }

        [TestMethod]
        public void Test_Three_Homes_And_Print()
        {
            PropertyTaxCalculator propertyOne = new PropertyTaxCalculator("18 Paper Street, 18829 Wilmington, DE", 300000M);
            PropertyTaxCalculator propertyTwo = new PropertyTaxCalculator("12 Columbia Avenue, 90210 Beverly Hills, CA", 1700000M);
            PropertyTaxCalculator propertyThree = new PropertyTaxCalculator("227 Browning Street, 12345 Denver, CO", 150000M);

            Console.WriteLine(propertyOne);
            Console.WriteLine(propertyTwo);
            Console.WriteLine(propertyThree);
        }
    }
}
