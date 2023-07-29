using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Duck
{
    internal class SimpleFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Duck can fly");
        }
    }
}
