using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CoffeeShop
{
    internal class Chocolate : AddOnDecorator
    {
        internal Chocolate(Beverage beverage)
        {
            this.beverage = beverage;
            cost = 100;
        }

        internal override int GetCost()
        {
            return cost + this.beverage.GetCost();
        }
    }
}
