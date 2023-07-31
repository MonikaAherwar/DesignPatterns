using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CoffeeShop
{
    internal class Caramel : AddOnDecorator
    {
        internal Caramel(Beverage beverage) 
        { 
            this.beverage = beverage;
            cost = 50;
        }  

        internal override int GetCost()
        {
            return cost + this.beverage.GetCost();
        }
    }
}
