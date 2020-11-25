using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinalProjectCSharpPart
{
    [TestClass]
    public class HousingTests
    {
        [TestMethod]
        public void Single_Family_Test()
        {
            List<SingleFamily> singleFamilyList = new List<SingleFamily>();

            SingleFamily house1 = new SingleFamily("11 Paper St, 19823 Wilmington, DE", "Wooden House", "1961", 2100M, "1113", 5, "No", "No");
            singleFamilyList.Add(house1);

            SingleFamily house2 = new SingleFamily("13 Paper St, 19823 Wilmington, DE", "Wooden House", "1965", 2500M, "1513", 9, "Yes", "No");
            singleFamilyList.Add(house2);

            SingleFamily house3 = new SingleFamily("15 Paper St, 19823 Wilmington, DE", "Wooden House", "1963", 2300M, "1313", 7, "Yes", "Yes");
            singleFamilyList.Add(house3);

            SingleFamily house4 = new SingleFamily("17 Paper St, 19823 Wilmington, DE", "Wooden House", "1962", 2200M, "1213", 6, "No", "Yes");
            singleFamilyList.Add(house4);

            SingleFamily house5 = new SingleFamily("19 Paper St, 19823 Wilmington, DE", "Wooden House", "1964", 2400M, "1413", 8, "Yes", "No");
            singleFamilyList.Add(house5);

            foreach (var house in singleFamilyList)
            {
                Console.WriteLine(house.ToString());
            }
        }

        [TestMethod]
        public void Multi_Unit_Test()
        {
            List<MultiUnit> multiUnitList = new List<MultiUnit>();

            MultiUnit complex1 = new MultiUnit("12 Paper St, 19823 Wilmington, DE", "Brick House", "1984", "Soap", 12, 700M);
            multiUnitList.Add(complex1);

            MultiUnit complex2 = new MultiUnit("14 Paper St, 19823 Wilmington, DE", "Brick House", "1984", "Club", 7, 900M);
            multiUnitList.Add(complex2);

            MultiUnit complex3 = new MultiUnit("16 Paper St, 19823 Wilmington, DE", "Brick House", "1984", "Khakis", 15, 550M);
            multiUnitList.Add(complex3);

            MultiUnit complex4 = new MultiUnit("18 Paper St, 19823 Wilmington, DE", "Brick House", "1984", "Project", 10, 650M);
            multiUnitList.Add(complex4);

            MultiUnit complex5 = new MultiUnit("20 Paper St, 19823 Wilmington, DE", "Brick House", "1984", "Marla", 18, 450M);
            multiUnitList.Add(complex5);

            foreach (var complex in multiUnitList)
            {
                Console.WriteLine(complex.ToString());
            }
        }

        [TestMethod]
        public void Combined_Test()
        {
            List<Housing> allHousings = new List<Housing>();
            allHousings.Add(new SingleFamily("11 Paper St, 19823 Wilmington, DE", "Wooden House", "1961", 2100M, "1113", 5, "No", "No"));
            allHousings.Add(new SingleFamily("13 Paper St, 19823 Wilmington, DE", "Wooden House", "1965", 2500M, "1513", 9, "Yes", "No"));
            allHousings.Add(new SingleFamily("15 Paper St, 19823 Wilmington, DE", "Wooden House", "1963", 2300M, "1313", 7, "Yes", "Yes"));
            allHousings.Add(new SingleFamily("17 Paper St, 19823 Wilmington, DE", "Wooden House", "1962", 2200M, "1213", 6, "No", "Yes"));
            allHousings.Add(new SingleFamily("19 Paper St, 19823 Wilmington, DE", "Wooden House", "1964", 2400M, "1413", 8, "Yes", "No"));
            allHousings.Add(new MultiUnit("12 Paper St, 19823 Wilmington, DE", "Brick House", "1984", "Soap", 12, 700M));
            allHousings.Add(new MultiUnit("14 Paper St, 19823 Wilmington, DE", "Brick House", "1984", "Club", 7, 900M));
            allHousings.Add(new MultiUnit("16 Paper St, 19823 Wilmington, DE", "Brick House", "1984", "Khakis", 15, 550M));
            allHousings.Add(new MultiUnit("18 Paper St, 19823 Wilmington, DE", "Brick House", "1984", "Project", 10, 650M));
            allHousings.Add(new MultiUnit("20 Paper St, 19823 Wilmington, DE", "Brick House", "1984", "Marla", 18, 450M));


            foreach (var house in allHousings)
                Console.WriteLine(house);
        }
    }
}
