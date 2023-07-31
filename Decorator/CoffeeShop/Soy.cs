using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CoffeeShop
{
    internal class Soy : AddOnDecorator
    {
        internal Soy(Beverage beverage)
        {
            this.beverage = beverage;
            cost = 70;
        }

        internal override int GetCost()
        {
            return cost + this.beverage.GetCost();
        }
    }
}
