using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CoffeeShop
{
    internal abstract class AddOnDecorator : Beverage
    {
        internal Beverage beverage;
    }
}
