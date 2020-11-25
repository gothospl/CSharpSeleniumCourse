using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EndOfCourseExam
{
    [TestClass]
    public class PageMockTest
    {
        [TestMethod]
        public void Test_Complicated_Page()
        {
            SectionOfButtons buttonSection = new SectionOfButtons();
            SectionOfSocialMedia socialMediaSection = new SectionOfSocialMedia();
            SectionOfRandomStuff randomStuffSection = new SectionOfRandomStuff();
            ComplicatedPage testPage = new ComplicatedPage(buttonSection, socialMediaSection, randomStuffSection);

            Assert.AreEqual("Complicated Page", testPage.PageName);
        }

        [TestMethod]
        public void Test_Section_Of_Random_Stuff()
        {
            SectionOfRandomStuff testRandomStuffSection = new SectionOfRandomStuff();

            testRandomStuffSection.FillForm();
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void Test_Section_Of_Buttons()
        {
            try
            {
                SectionOfButtons testSectionOfButtons = new SectionOfButtons();
                testSectionOfButtons.Button.Click();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
