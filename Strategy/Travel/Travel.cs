using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Travel
{
    internal class Travel
    {
        ITravelMode _travelMode;

        internal Travel(ITravelMode travelMode)
        {
            _travelMode = travelMode;
        }   

        internal void TravelVehicle()
        {
            _travelMode.TravelVehicle();
        }

        internal int TravelFare()
        {
            int fare = _travelMode.TravelFare();
            return fare;
        }
    }
}
