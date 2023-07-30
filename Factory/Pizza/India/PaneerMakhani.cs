using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizza.India
{
    internal class PaneerMakhani : Pizza
    {
        internal override void AddToppings()
        {
            Console.WriteLine("Adding Panner and Makhani");
        }

        internal override int GetPrice()
        {
            return 100;
        }
    }
}
