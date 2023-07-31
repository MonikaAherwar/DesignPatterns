using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CoffeeShop
{
    internal class ColdBeverage : Beverage
    {
        internal ColdBeverage()
        {
            cost = 100;
        }
        internal override int GetCost()
        {
            return cost;
        }
    }
}
