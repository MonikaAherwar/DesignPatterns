using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers;
        private static object syncLock = new object();

        private LoadBalancer() 
        {
            Console.WriteLine("LoadBalancer Class: Private constructor");
            _servers = new List<string>();
            _servers.Add("SRMS Server 1");
            _servers.Add("SRMS Server 2");
            _servers.Add("SRMS Server 3");
            _servers.Add("SRMS Server 4");
        }

        public static LoadBalancer GetInstance()
        {
            if(_instance == null)
            {
                lock (syncLock)
                {
                    if(_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        public string GetServer()
        {
            Random rnd = new Random();
            var index = rnd.Next(_servers.Count);
            return _servers[index].ToString();
        }

    }
}
