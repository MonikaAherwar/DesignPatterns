using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CoffeeShop
{
    internal abstract class Beverage
    {
        internal string description;
        internal int cost;

        internal Beverage()
        {
            // Nothing to do for now
        }

        internal abstract int GetCost();

    }
}
