using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Subject_Observer
{
    internal class WindowsDisplay : IObserver, IDisplay
    {
        WorkStation _workStation;

        internal WindowsDisplay(WorkStation workStation)
        { 
            _workStation = workStation;
        }

        public void Display(int temperature)
        {
            Console.WriteLine("Windows Display: Current temperature {0}", temperature);
        }

        public void Update()
        {
            // Get new data
            var temp = _workStation.GetTemperature();
            // Display new data
            Display(temp);
        }
    }
}
