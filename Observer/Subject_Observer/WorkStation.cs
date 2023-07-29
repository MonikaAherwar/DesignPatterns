using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Subject_Observer
{
    internal class WorkStation : ISubject
    {
        internal int temperature;
        private List<IObserver> _observers;

        internal WorkStation() 
        { 
            _observers = new List<IObserver>();
            temperature = 0;
        }

        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers?.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        internal int GetTemperature()
        {
            return temperature;
        }

        internal void SetTemperature(int temp)
        {
            temperature = temp;
        }
    }
}
