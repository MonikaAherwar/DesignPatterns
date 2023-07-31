using Adapter.DataAnalyticsTool;
using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! We are running design pattern - Decorator Pattern");

            InitializeAndTestDataAnalyticsTool();
        }


        private static void InitializeAndTestDataAnalyticsTool()
        {
            XMLData xmlData = new XMLData("My XML Data");
            DataAnalyticsTool.DataAnalyticsTool tool = new DataAnalyticsTool.Adapter(xmlData);
            Client client = new Client(tool);
            tool.ProcessData();
        }
    }
}
