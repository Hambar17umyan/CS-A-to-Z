using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application
{
    public partial class Factory
    {
        private class Menue
        {
            public Dictionary<PizzaType, decimal> PriceList {  get; private set; }
            public Menue(params (PizzaType pizza, decimal price)[] pizza)
            {
                PriceList = new Dictionary<PizzaType, decimal>();
                foreach(var p in pizza)
                {
                    PriceList[p.pizza] = p.price;
                }


            }
        }
    }
}
