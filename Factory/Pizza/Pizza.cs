using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizza
{
    internal abstract class Pizza
    {
        internal void CreateDough()
        {
            Console.WriteLine("Creating Dough");
        }

        internal abstract void AddToppings();

        internal void Bake()
        {
            Console.WriteLine("Baking Pizza");
        }

        internal void Pack()
        {
            Console.WriteLine("Packing Pizza");
        }

        internal abstract int GetPrice();
    }
}
