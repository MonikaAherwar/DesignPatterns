using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal class Singleton
    {
        private static Singleton _instance;

        private Singleton() {
            Console.WriteLine("Singleton Class: Private constructor");
        }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
