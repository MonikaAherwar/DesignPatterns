using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Travel
{
    internal interface ITravelMode
    {
        public void TravelVehicle();

        public int TravelFare();
    }
}
