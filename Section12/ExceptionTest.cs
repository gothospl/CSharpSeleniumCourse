using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section12
{
    [TestClass]
    public class ExceptionTest
    {
        [TestMethod]
        public void Test_Exceptions()
        {
            int totalScores = 10;
            int countOfScores = 0;

            double average = totalScores / countOfScores;
        }

        [TestMethod]
        public void Test_Division()
        {
            ExceptionHelper.DivisionTest(10, 0);
        }

        [TestMethod]
        public void Test_StateCheck()
        {
            try
            {
                ExceptionHelper.CheckStateOK("MA");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }

    
}
