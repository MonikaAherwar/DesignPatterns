using System;
using System.Collections.Generic;
using System.Text;
using Factory.Pizza.India;

namespace Factory.Pizza
{
    internal class IndiaDominosFactory : DominosPizzaStore
    {
        internal override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            
            if (type == "PaneerMakhani")
                pizza = new PaneerMakhani();
            else if (type == "PaneerOnion")
                pizza = new PaneerOnion();
            else if(type == "VegLoaded")
                pizza = new VegLoaded();

            return pizza;
        }
    }
}
