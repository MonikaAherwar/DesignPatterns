using System;
using System.Collections.Generic;
using System.Text;
using Factory.Pizza.NY;

namespace Factory.Pizza
{
    internal class NYDominosFactory : DominosPizzaStore
    {
        internal override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            
            if (type == "Cheese")
                pizza = new Cheese();
            else if (type == "Capsicum")
                pizza = new Capsicum();
            else if(type == "Onion")
                pizza = new Onion();

            return pizza;
        }
    }
}
