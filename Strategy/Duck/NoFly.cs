using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Duck
{
    internal class NoFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Duck can't fly");
        }
    }
}
