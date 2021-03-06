﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section7
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void Test_Switch_Statements()
        {
            int weekDay = 4;
            string testDay = "";

            switch (weekDay)
            {
                case 1:
                    testDay = "Monday";
                    break;
                case 2:
                    testDay = "Tuesday";
                    break;
                case 3:
                    testDay = "Wednesday";
                    break;
                case 4:
                    testDay = "Thursday";
                    break;
                case 5:
                    testDay = "Friday";
                    break;
                default:
                    testDay = "Weekend";
                    break;
            }
            Assert.AreEqual("Thursday", testDay);
        }

        [TestMethod]
        public void Switch_State_Names()
        {
            string stateAbbreviation = "GA";
            string stateName = "";

            switch (stateAbbreviation)
            {
                case "GA":
                    stateName = "Georgia";
                    break;
                case "AL":
                    stateName = "Alabama";
                    break;
                case "FL":
                    stateName = "Florida";
                    break;
                case "IL":
                    stateName = "Illinois";
                    break;
                case "KY":
                    stateName = "Kentucky";
                    break;
                case "MI":
                    stateName = "Michigan";
                    break;
                default:
                    stateName = "No Match";
                    break;
            }
            Assert.AreEqual("Georgia", stateName);
        }
    }
}
