using Strategy.Duck;
using Strategy.Sort;
using Strategy.Travel;
using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! We are running design pattern - Strategy Pattern");

            InitialiseAndTestDuck();
            InitialiseAndTestSort();
            InitialiseAndTestTravel();

        }

        private static void InitialiseAndTestTravel()
        {
            Console.WriteLine("Pick the travel Mode");
            Console.WriteLine("1. Auto");
            Console.WriteLine("2. Bus");
            Console.WriteLine("3. Cab");
            Console.WriteLine("Enter the number to select the travel mode");
            var mode = Console.ReadLine();
            
            Travel.Travel travel = null;
            switch (mode)
            {
                case "1": 
                    travel = new Travel.Travel(new Auto());
                    break;
                case "2":
                    travel = new Travel.Travel(new Bus());
                    break;
                case "3":
                    travel = new Travel.Travel(new Cab());
                    break;
                default:
                    travel = null;
                    break;
            }

            if(travel != null)
            {
                travel.TravelVehicle();
                
                int fare = travel.TravelFare();
                Console.WriteLine("Travel Fare: {0}", fare);
            }
            else
            {
                Console.WriteLine("Pick up the write travel mode");
            }
        }

        private static void InitialiseAndTestSort()
        {
            // Merge Sort
            Sort.SortingAlgorithm mergeSort = new Sort.SortingAlgorithm(new MergeSort());
            mergeSort.Sort();

            // Quick Sort
            Sort.SortingAlgorithm quickSort = new Sort.SortingAlgorithm(new QuickSort());
            quickSort.Sort();

            // Count Sort
            Sort.SortingAlgorithm countSort = new Sort.SortingAlgorithm(new CountSort());
            countSort.Sort();
        }

        private static void InitialiseAndTestDuck()
        {
            // Wild Duck
            Duck.Duck wildDuck = new Duck.Duck(new SimpleQuack(), new SimpleFly());
            wildDuck.Quack();
            wildDuck.Fly();
            wildDuck.Display();

            // Rubber Duck
            Duck.Duck rubberDuck = new Duck.Duck(new NoQuack(), new NoFly());
            rubberDuck.Quack();
            rubberDuck.Fly();
            rubberDuck.Display();
        }
    }
}
