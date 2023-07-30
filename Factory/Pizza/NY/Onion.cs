using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizza.NY
{
    internal class Onion : Pizza
    {
        internal override void AddToppings()
        {
            Console.WriteLine("Adding Onion");
        }

        internal override int GetPrice()
        {
            return 30;
        }
    }
}
