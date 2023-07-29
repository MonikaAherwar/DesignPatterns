using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Observer.Stock_Investor
{
    internal interface IStock
    {
        public void Add(IInvestors investor);
        public void Remove(IInvestors investors);
        public void Notify();
    }
}
