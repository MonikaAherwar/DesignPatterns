using Observer.Stock_Investor;
using Observer.Subject_Observer;
using System;
using System.ComponentModel;
using System.Threading;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! We are running design pattern - Observer Pattern");

            InitialiseAndTestSubject_Observer();
            InitialiseAndTestStock_Investor();

        }

        private static void InitialiseAndTestStock_Investor()
        {
            Google google = new Google("GOOG", 100);
            Investor1 investor1 = new Investor1("Investor 1");
            Investor2 investor2 = new Investor2("Investor 2");

            // Add Investors (Observers)
            google.Add(investor1);
            google.Add(investor2);

            // Notify Investor when Stock price is changed
            Random random = new Random();
            for(int i = 0; i < 5; i++)
            {
                google.Price = random.NextDouble() * 200;
                Thread.Sleep(3000);
            }

            //**********************************************//

            // Adding a new symbol
            Amazon amazon = new Amazon("AMZN", 200);

            // Adding a mew Investor
            Investor3 investor3 = new Investor3("Investor 3");

            // Investor 1 and Investor 3 are interested in Amazon
            // Add both investers
            amazon.Add(investor1);
            amazon.Add(investor3);

            // Notify all investers of Amazon when price is changed
            for (int i = 0; i < 5; i++)
            {
                amazon.Price = random.NextDouble() * 400;
                Thread.Sleep(3000);
            }
        }


        private static void InitialiseAndTestSubject_Observer()
        {
            WorkStation workStation = new WorkStation();
            PhoneDisplay phoneDisplay = new PhoneDisplay(workStation);
            WatchDisplay watchDisplay = new WatchDisplay(workStation);
            WindowsDisplay windowsDisplay = new WindowsDisplay(workStation);

            // Add Observers
            workStation.Add(phoneDisplay);
            workStation.Add(watchDisplay);
            workStation.Add(windowsDisplay);

            Random random = new Random();
            
            // Notify Observers when temperature changes
            for(int i = 0; i < 5; i++)
            {
                int temp = random.Next(200);
                workStation.SetTemperature(temp);
                workStation.Notify();
                Thread.Sleep(3000);
            }

            // Remove all the obserers
            workStation.Remove(phoneDisplay);
            workStation.Remove(watchDisplay);
            workStation.Remove(windowsDisplay);

            // Notify Observers when temperature changes
            // There is no observer to notify
            for (int i = 0; i < 5; i++)
            {
                int temp = random.Next(200);
                workStation.SetTemperature(temp);
                workStation.Notify();
                Thread.Sleep(3000);
            }
        }
    }
}
