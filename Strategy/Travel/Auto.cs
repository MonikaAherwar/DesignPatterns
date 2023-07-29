using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Travel
{
    internal class Auto : ITravelMode
    {
        readonly int fare = 400;
        public int TravelFare()
        {
            return fare;
        }

        public void TravelVehicle()
        {
            Console.WriteLine("We are travelling via: Auto");
        }
    }
}
