using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizza.India
{
    internal class PaneerOnion : Pizza
    {
        internal override void AddToppings()
        {
            Console.WriteLine("Adding Panner and Onion");
        }

        internal override int GetPrice()
        {
            return 200;
        }
    }
}
