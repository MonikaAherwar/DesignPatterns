using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizza.NY
{
    internal class Cheese : Pizza
    {
        internal override void AddToppings()
        {
            Console.WriteLine("Adding Cheese");
        }

        internal override int GetPrice()
        {
            return 20;
        }
    }
}
