using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Part3")]
    public class Test3
    {
        private int a, b;
        public TestContext Test3Context { get; set; }
        private static TestContext _testContext;

        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            a = 1;
        }

        [TestCleanup]
        public void RunAfterEveryTest()
        {
            Trace.Write("This method runs after every test method in a class");
        }

        [ClassInitialize]
        public static void RunBeforeSuite(TestContext testContext)
        {
            _testContext = testContext;
            Trace.Write("This method runs once before all tests in a suite");
        }

        [ClassCleanup]
        public static void RunAfterSuite()
        {
            Trace.Write("This method runs once after all tests in class are done");
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
