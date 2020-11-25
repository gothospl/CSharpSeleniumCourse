using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section12
{
    [TestClass]
    public class QuizTester
    {
        //modify test to catch three different exceptions:
        //ArithmeticException
        //FormatException
        //Exception
        //Use on try block to accomplish this task

        [TestMethod]
        public void Calculate_BMI()
        {
            string weight = "150";
            string heightInFeet = "6";
            string heightInInches = "72";
            BodyMassIndexCalculator bmi = null;

            try
            {
                bmi = new BodyMassIndexCalculator(int.Parse(weight), int.Parse(heightInFeet), int.Parse(heightInInches));
            }
            catch (ArithmeticException arithmeticException)
            {
                Console.WriteLine(arithmeticException.Message);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine(formatException.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            string result = bmi.ToString();
            Assert.AreEqual("BMI: 5.09", result);
        }
    }
}
