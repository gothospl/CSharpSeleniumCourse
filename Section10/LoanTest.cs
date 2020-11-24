using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section10
{
    [TestClass]
    public class LoanTest
    {
        [TestMethod]
        public void Car_Loan_Test()
        {
            CarLoan testLoan = new CarLoan(1, "Wilhelm", "Hohenzollern", 0.075M, 12000M, 4, "2011", "Corolla", "Toyota", "Red");
            Assert.AreEqual(20.3125M, testLoan.CalculateInterest());
            Console.WriteLine(testLoan);
        }

        [TestMethod]
        public void Home_Loan_Test()
        {
            HomeLoan testLoan = new HomeLoan(2, "George", "Harrison", 0.035M, 210000M, 30, "13 Paper Street, 18921 Wilmington, DE", "1947", "2500");
            Assert.AreEqual(20.902777777777777777777773000M, testLoan.CalculateInterest());
            Console.WriteLine(testLoan);
        }
    }
}
