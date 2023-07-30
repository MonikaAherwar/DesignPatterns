using Factory.Pizza;
using Factory.SRMS;
using System;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! We are running design pattern - Factory Pattern");

            InitializeAndTestPizzaStore();
            InitializeAndTestSRMS();
        }

        private static void InitializeAndTestSRMS()
        {
            bool isProduction = false;

            Runbook runbook = new Runbook(isProduction);

            foreach(var command in runbook.commands)
            {
                if (isProduction)
                {
                    CommandFactoryProduction commandFactoryProduction = new CommandFactoryProduction();
                    Command commandObject = commandFactoryProduction.CreateCommand(command);
                    commandObject.Run();

                }
                else
                {
                    CommandFactoryLocal commandFactoryLocal = new CommandFactoryLocal();
                    Command commandObject = commandFactoryLocal.CreateCommand(command);
                    commandObject.Run();
                }
            }
        }

        private static void InitializeAndTestPizzaStore()
        {
            bool IsIndiaStore = false;

            if (IsIndiaStore)
            {
                Console.WriteLine("Enter Pizza Type");
                Console.WriteLine("PaneerMakhani");
                Console.WriteLine("PaneerOnion");
                Console.WriteLine("VegLoaded");
                var type = Console.ReadLine();

                IndiaDominosFactory indiaDominosFactory = new IndiaDominosFactory();
                indiaDominosFactory.OrderPizza(type);
            }
            else
            {
                Console.WriteLine("Enter Pizza Type");
                Console.WriteLine("Capsicum");
                Console.WriteLine("Cheese");
                Console.WriteLine("Onion");
                var type = Console.ReadLine();

                NYDominosFactory nyDominosFactory = new NYDominosFactory();
                nyDominosFactory.OrderPizza(type);
            }
        }
    }
}
