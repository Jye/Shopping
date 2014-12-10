using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingTest
{
    class Checkout
    {
        private Dictionary<char, int> prices;

        public Checkout(Dictionary<char, int> prices)
        {
            this.prices = prices;
        }
        internal void Scan(char itemCode)
        {
            throw new NotImplementedException();
        }

        public int Total { get; set; }
    }
}
