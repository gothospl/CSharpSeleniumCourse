using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
    class MathFunctions
    {
        public static double SquareRoot(double aValue)
        {
            return Math.Sqrt(aValue);
        }

        public static int Sum(int aValue, int bValue)
        {
            return aValue + bValue;
        }

        public static double Sum(double aValue, double bValue)
        {
            return aValue + bValue;
        }

        public static decimal Sum(decimal aValue, decimal bValue)
        {
            return aValue + bValue;
        }
    }
}
