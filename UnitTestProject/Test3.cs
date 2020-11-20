using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Part3")]
    public class Test3
    {
        private int a, b;

        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            a = 1;
        }

        [TestMethod]
        public void TestMethod1()
        {
            b = 2;
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            Assert.AreNotEqual(a, 1);
        }
    }
}
