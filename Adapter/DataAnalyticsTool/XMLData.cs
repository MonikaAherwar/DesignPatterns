using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.DataAnalyticsTool
{
    internal class XMLData
    {
        internal string xmlData;

        internal XMLData(string xmlData)
        {
            this.xmlData = xmlData;
        }

        internal string GetXMLData()
        {
            return xmlData;
        }
    }
}
