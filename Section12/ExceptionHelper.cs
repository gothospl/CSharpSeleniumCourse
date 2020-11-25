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
        }
    }
}
