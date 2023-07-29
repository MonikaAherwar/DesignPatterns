using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Duck
{
    internal class Duck 
    {
        IQuackable _qb;
        IFlyable _fb;

        internal Duck(IQuackable qb, IFlyable fb)
        {
            _qb = qb;
            _fb = fb;
        }

        internal void Quack()
        {
            _qb.Quack();
        }

        internal void Fly()
        {
            _fb.Fly();
        }

        internal void Display()
        {
            Console.WriteLine("Duck is displaying");
        }
    }
}
