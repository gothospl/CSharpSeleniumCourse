using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Tests2
    {
        [TestMethod]
        [TestCategory("Quiz")]
        public void TestMethod1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(2, a + b);
        }

        [TestMethod]
        [TestCategory("Quiz")]
        public void TestMethod2()
        {
            Assert.Fail("AlwaysFail");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        [TestCategory("Quiz")]
        public void TestMethod3()
        {
            var a = 10;
            var b = 10;
            Assert.AreEqual(21, a + b);
        }
    }
}
