using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Stock_Investor
{
    internal class Investor3 : IInvestors
    {
        private string _investorName;

        internal Investor3(string investorName)
        {
            _investorName = investorName;
        }

        public void Update(Stock stock)
        {
            var price = stock.Price;
            var symbol = stock.Symbol;
            Console.WriteLine("{0} is notified for symbol {1}: Current Price - {2}", _investorName, symbol, price);
        }
    }
}
