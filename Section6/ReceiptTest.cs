using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class ReceiptTest
    {
        [TestMethod]
        [TestCategory("Positive")]
        public void Receipt_Number_Valid_Test()
        {
            Receipt TestReceipt = new Receipt(17, "2020-04-30", 24, "Tyler Durden", "Paper Street 1, 19810 Wilmington, DE", "555-678", 231, "Sack of Fat", 12.34, 100);
            Assert.AreEqual(17, TestReceipt.ReceiptNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        [TestCategory("Negative")]
        public void Receipt_Number_Invalid_Test()
        {
            Receipt TestReceipt = new Receipt(-2, "2020-04-30", 24, "Tyler Durden", "Paper Street 1, 19810 Wilmington, DE", "555-678", 231, "Sack of Fat", 12.34M, 100);
            Assert.AreEqual(-2, TestReceipt.ReceiptNumber);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void Customer_Number_Valid_Test()
        {
            Receipt TestReceipt = new Receipt(17, "2020-04-30", 24, "Tyler Durden", "Paper Street 1, 19810 Wilmington, DE", "555-678", 231, "Sack of Fat", 12.34M, 100);
            Assert.AreEqual(24, TestReceipt.CustomerNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        [TestCategory("Negative")]
        public void Customer_Number_Invalid_Test()
        {
            Receipt TestReceipt = new Receipt(17, "2020-04-30", -6, "Tyler Durden", "Paper Street 1, 19810 Wilmington, DE", "555-678", 231, "Sack of Fat", 12.34M, 100);
            Assert.AreEqual(24, TestReceipt.CustomerNumber);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void Item_Number_Valid_Test()
        {
            Receipt TestReceipt = new Receipt(17, "2020-04-30", 24, "Tyler Durden", "Paper Street 1, 19810 Wilmington, DE", "555-678", 231, "Sack of Fat", 12.34M, 100);
            Assert.AreEqual(231, TestReceipt.ItemNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        [TestCategory("Negative")]
        public void Item_Number_Invalid_Test()
        {
            Receipt TestReceipt = new Receipt(17, "2020-04-30", 24, "Tyler Durden", "Paper Street 1, 19810 Wilmington, DE", "555-678", -9, "Sack of Fat", 12.34M, 100);
            Assert.AreEqual(231, TestReceipt.ItemNumber);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void Unit_Price_Valid_Test()
        {
            Receipt TestReceipt = new Receipt(17, "2020-04-30", 24, "Tyler Durden", "Paper Street 1, 19810 Wilmington, DE", "555-678", 231, "Sack of Fat", 12.34M, 100);
            Assert.AreEqual(12.34, TestReceipt.UnitPrice);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        [TestCategory("Negative")]
        public void Unit_Price_Invalid_Test()
        {
            Receipt TestReceipt = new Receipt(17, "2020-04-30", 24, "Tyler Durden", "Paper Street 1, 19810 Wilmington, DE", "555-678", 231, "Sack of Fat", -3.12M, 100);
            Assert.AreEqual(12.34, TestReceipt.UnitPrice);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void Quantity_Purchased_Valid_Test()
        {
            Receipt TestReceipt = new Receipt(17, "2020-04-30", 24, "Tyler Durden", "Paper Street 1, 19810 Wilmington, DE", "555-678", 231, "Sack of Fat", 12.34M, 100);
            Assert.AreEqual(100, TestReceipt.QuantityPurchased);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        [TestCategory("Negative")]
        public void Quantity_Purchased_Invalid_Test()
        {
            Receipt TestReceipt = new Receipt(17, "2020-04-30", 24, "Tyler Durden", "Paper Street 1, 19810 Wilmington, DE", "555-678", 231, "Sack of Fat", 12.34M, -5);
            Assert.AreEqual(100, TestReceipt.QuantityPurchased);
        }
    }
}
