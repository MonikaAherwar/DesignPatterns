using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Subject_Observer
{
    internal interface ISubject
    {
        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void Notify();
    }
}
