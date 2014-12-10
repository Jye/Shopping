using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ShoppingTest
{
    [TestClass]
    public class CheckoutTest
    {
        [TestMethod]
        public void TotalShouldBeSumOfScannedItemPrices()
        {
            var prices = new Dictionary<char, int>();
            prices.Add('A', 50);
            prices.Add('B', 45);

            //var specials = new List<Tuple<char,int, int>>();
            //specials.Add(new Tuple<char, int, int>('A', 3, 130));
            //specials.Add(new Tuple<char, int, int>('A', 4, 160));
            //specials.Add(new Tuple<char, int, int>('B', 2, 80));

            Checkout checkout = new Checkout(prices);//, specials);
            checkout.Scan('A');
            checkout.Scan('B');
            Assert.AreEqual(95, checkout.Total);
        }
    }
}
