using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Stock_Investor
{
    internal class Stock : IStock
    {
        private string _symbol;
        private double _price;
        private List<IInvestors> _investors;

        internal Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
            _investors = new List<IInvestors>();
        }

        public void Add(IInvestors investor)
        {
            _investors.Add(investor);   
        }

        public void Remove(IInvestors investors)
        {
            _investors?.Remove(investors);
        }

        public void Notify()
        {
            foreach(var investor in _investors)
            {
                investor.Update(this);
            }
        }

        // Property to get/set Stock Price
        public double Price
        {
            get { return _price; }
            set

            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        // Property to get Stock symbol
        public string Symbol
        {
            get { return _symbol; }
        }
    }
}
