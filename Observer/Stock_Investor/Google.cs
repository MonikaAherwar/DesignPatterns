using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Stock_Investor
{
    internal class Google : Stock
    {
        internal Google(string symbol, double price) : base(symbol, price) 
        {
        }
    }
}
