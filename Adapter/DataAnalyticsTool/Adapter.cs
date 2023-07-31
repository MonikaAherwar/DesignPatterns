using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.DataAnalyticsTool
{
    internal class Adapter : DataAnalyticsTool
    {
        private XMLData xmlData;
        internal Adapter(XMLData xmlData) : base ("")
        {
            this.xmlData = xmlData;
        }

        internal override void ProcessData()
        {
            Console.WriteLine("Converting XML data `{0}` to JSON data", this.xmlData.GetXMLData());
            Console.WriteLine("This is processing Json Data for Analytics");
        }
    }
}
