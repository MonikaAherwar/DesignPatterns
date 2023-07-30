using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizza.NY
{
    internal class Capsicum : Pizza
    {
        internal override void AddToppings()
        {
            Console.WriteLine("Adding Capsicum");
        }

        internal override int GetPrice()
        {
            return 10;
        }
    }
}
