using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.DataAnalyticsTool
{
    internal class Client
    {
        DataAnalyticsTool tool;
        internal Client(DataAnalyticsTool tool) 
        {
            this.tool = tool;
        }

        internal void ProcessData()
        {
            tool.ProcessData();
        }
    }
}
