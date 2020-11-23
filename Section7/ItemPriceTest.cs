using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section7
{
    [TestClass]
    public class ItemPriceTest
    {
        [TestMethod]
        public void Test_Markup_Table()
        {
            ItemPrice TestPrice = new ItemPrice(34.12M);
            Console.WriteLine($"Markup:\tNewPrice:");

            for (int markupValue = 5; markupValue <= 10; markupValue++)
            {
                decimal newItemPrice = TestPrice.WholesaleItemPrice + (markupValue*TestPrice.WholesaleItemPrice)/100;
                Console.WriteLine($"{markupValue}%\t{newItemPrice.ToString("c")}");
            }
        }
    }
}
