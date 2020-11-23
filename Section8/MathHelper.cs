using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
    class MathHelper
    {
        public static int Square(int aValue)
        {
            return aValue * aValue;
        }

        public static int AddNumber(int aValue = 22, int bValue = 10)
        {
            return aValue + bValue;
        }

        public static void NumbersOut(out int value)
        {
            value = 6;
        }

        public static void NumbersRef(ref int value)
        {
            value = 7;
        }
    }
}
