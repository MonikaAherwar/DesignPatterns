using Decorator.CoffeeShop;
using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! We are running design pattern - Decorator Pattern");

            InitializeAndTestCoffeeShop();
        }

        private static void InitializeAndTestCoffeeShop()
        {
            // Lets create Hot Beverage with Caramel and Soy
            Beverage hotBeverage = new HotBeverage();
            hotBeverage = new Caramel(hotBeverage);
            hotBeverage = new Soy(hotBeverage);
            int hotBeverageCost = hotBeverage.GetCost();

            Console.WriteLine("Hot Beverage Cost: {0}", hotBeverageCost);

            // Lets create Cold Beverage with Caramel, Soy qand Chocolate
            Beverage coldBeverage = new HotBeverage();
            coldBeverage = new Caramel(coldBeverage);
            coldBeverage = new Soy(coldBeverage);
            coldBeverage = new Chocolate(coldBeverage);
            int coldBeverageCost = coldBeverage.GetCost();

            Console.WriteLine("Cold Beverage Cost: {0}", coldBeverageCost);
        }
    }
}
