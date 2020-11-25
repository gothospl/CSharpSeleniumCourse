using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12
{
    static class ExceptionHelper
    {
        public static void DivisionTest(int aValue, int bValue)
        {
            try
            {
                int totalScores = 10;
                int countOfScores = 0;
                double average = totalScores / countOfScores;
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Division operation");
            }
        }
        public static string state;

        public static void CheckStateOK(string st)
        {
            switch(st.ToUpper())
            {
                case "FL":
                case "GA":
                case "NC":
                case "SC":
                case "VA":
                   state = st.ToUpper();
                   break;
                default:
                    CustomException exception = new CustomException("State not Part" + " of Atlantic ICW");
                    throw exception;
            }
        }
    }
}
