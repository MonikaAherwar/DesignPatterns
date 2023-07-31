using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.DataAnalyticsTool
{
    internal abstract class DataAnalyticsTool
    {
        internal string jsonData;
        public DataAnalyticsTool(string jsonData)
        {
            this.jsonData = jsonData;
        }

        internal abstract void ProcessData();
    }
}
