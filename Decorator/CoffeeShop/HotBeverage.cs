using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CoffeeShop
{
    internal class HotBeverage : Beverage
    {
        internal HotBeverage()
        {
            cost = 150;
        }

        internal override int GetCost()
        {
            return cost;
        }
    }
}
