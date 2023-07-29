using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Stock_Investor
{
    internal interface IInvestors
    {
        public void Update(Stock stock);
    }
}
