using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section11
{
    [TestClass]
    public class SectionExam
    {
        [TestMethod]
        public void Test_Page1()
        {
            IPageObject pageObject1 = new PageObjectOne();
            Assert.AreEqual("Page Name 1", pageObject1.PageName);
        }

        [TestMethod]
        public void Test_Page2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual("Page Name 2", pageObject2.PageName);
        }
    }
}
