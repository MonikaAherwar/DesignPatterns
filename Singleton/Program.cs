using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! We are running design pattern - Singleton Pattern");

            // Initialise class And Test Code
            InitialiseAndTestSingletonClass();
            InitialiseAndTestLoadBalancerClass();
            InitialiseAndTestDatabaseClass();   
        }

        //******************************
        // Code Test for Singleton Class
        //******************************
        private static void InitialiseAndTestSingletonClass()
        { 
            Singleton singletonInstance1 = Singleton.GetInstance();
            Singleton singletonInstance2 = Singleton.GetInstance();

            if (singletonInstance1 == singletonInstance2)
            {
                Console.WriteLine("Singleton Class: Both instances are Same");
            }
        }

        //**********************************
        // Code Test for Load Balancer Class
        //**********************************
        private static void InitialiseAndTestLoadBalancerClass()
        {
            LoadBalancer loadBalancerInstance1 = LoadBalancer.GetInstance();
            LoadBalancer loadBalancerInstance2 = LoadBalancer.GetInstance();
            LoadBalancer loadBalancerInstance3 = LoadBalancer.GetInstance();

            if (loadBalancerInstance1 == loadBalancerInstance2 && loadBalancerInstance2 == loadBalancerInstance3)
            {
                Console.WriteLine("LoadBalancer Class: All three instances are Same");
            }

            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Load Balancer Server : {0}", loadBalancerInstance1.GetServer());
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Load Balancer Server : {0}", loadBalancerInstance2.GetServer());
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine("Load Balancer Server : {0}", loadBalancerInstance3.GetServer());
                }
            }
        }


        //*****************************
        // Code Test for Database Class
        //*****************************
        private static void InitialiseAndTestDatabaseClass()
        {           
            Database databae1 = Database.GetInstance();
            Database databae2 = Database.GetInstance();

            if (databae1 == databae2)
            {
                Console.WriteLine("Database Class: Both instances are Same");
            }

            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Database Server : {0}", databae1.GetDBServer());
                }
                else
                {
                    Console.WriteLine("Database Server : {0}", databae2.GetDBServer());
                }
            }
        }
    }
}
