using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void Test_Square()
        {
            int result = MathHelper.Square(6);
            Assert.AreEqual(36, result);
        }
    }
}
