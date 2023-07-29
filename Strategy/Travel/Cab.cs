using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Travel
{
    internal class Cab : ITravelMode
    {
        readonly int fare = 800;
        public int TravelFare()
        {
            return fare;
        }

        public void TravelVehicle()
        {
            Console.WriteLine("We are travelling via: Cab");
        }
    }
}
