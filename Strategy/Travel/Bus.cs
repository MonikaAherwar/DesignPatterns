using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Travel
{
    internal class Bus : ITravelMode
    {
        readonly int fare = 200;
        public int TravelFare()
        {
            return fare;
        }

        public void TravelVehicle()
        {
            Console.WriteLine("We are travelling via: Bus");
        }
    }
}
