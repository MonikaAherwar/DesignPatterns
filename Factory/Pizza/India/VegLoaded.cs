using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizza.India
{
    internal class VegLoaded : Pizza
    {
        internal override void AddToppings()
        {
            Console.WriteLine("Adding Mixed Vegies");
        }

        internal override int GetPrice()
        {
            return 300;
        }
    }
}
