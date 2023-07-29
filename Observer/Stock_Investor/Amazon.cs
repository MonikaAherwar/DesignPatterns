using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Stock_Investor
{
    internal class Amazon : Stock
    {
        internal Amazon(string symbol, double price) : base(symbol, price) 
        {
        }
    }
}
