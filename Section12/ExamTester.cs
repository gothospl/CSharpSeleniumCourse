using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section12
{
    //Create a try/catch block in each test that calls the method and catches the
    //specific exception tat is produced. Each method should be handled so that if an
    //exception occurs, the test will still pass
    //write out the error message taht occurs so you can view it in the output

    [TestClass]
    public class ExamTester
    {
        [TestMethod]
        public void Test_Weekly_Wages()
        {
            try
            {
                ExamHelper.WeeklyWages();
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        [TestMethod]
        public void Test_Calc_Result()
        {
            try
            {
                ExamHelper.CalculateResult();
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception);
            }
        }

        [TestMethod]
        public void Test_Number_Check()
        {
            try
            {
                ExamHelper.NumberCheck();
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
