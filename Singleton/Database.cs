using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal class Database
    {
        private static Database _instance;
        private List<string> _dbServers;
        private static Object synclock = new Object();

        private Database()
        {
            _dbServers = new List<string>();
            _dbServers.Add("DB 1");
            _dbServers.Add("DB 2");
            _dbServers.Add("DB 3");
        }

        public static Database GetInstance()
        {
            if(_instance == null)
            {
                lock (synclock)
                {
                    if(_instance == null)
                    {
                        _instance = new Database();
                    }
                }
            }

            return _instance;
        }

        public string GetDBServer()
        {
            Random rnd = new Random();
            var index = rnd.Next(_dbServers.Count);
            return _dbServers[index].ToString();
        }

    }
}
