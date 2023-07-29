using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Duck
{
    internal class SimpleQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Duck can Quack");
        }
    }
}
