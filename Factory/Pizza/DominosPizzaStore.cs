using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Factory.Pizza
{
    internal abstract class DominosPizzaStore
    {
        internal abstract Pizza CreatePizza(string type);

        internal Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            int price = pizza.GetPrice();
            Console.WriteLine("Pizza Price: {0}", price);
            
            Thread.Sleep(3000);
            Console.WriteLine("Create pizza of type: {0}", type);

            pizza.CreateDough();
            pizza.AddToppings();
            pizza.Bake();
            pizza.Pack();

            Console.WriteLine("Pizza is ready");

            return pizza;
        }
    }
}
