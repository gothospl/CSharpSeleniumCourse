using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class StringClassTest
    {
        [TestMethod]
        public void Using_String_Class()
        {
            string str = "Moja poezja to jest... wielkie uspokojenie";
            Console.WriteLine(str);
            string substr = str.Substring(12);
            Console.WriteLine(substr);
        }

        [TestMethod]
        public void Joining_Strings_Together()
        {
            char[] chars = { 'K', 'o', 'l', 'o', 'n', 'i', 'i' };
            string name = new string(chars);
            Console.WriteLine($"Witamy w {name}");
        }
    }
}
