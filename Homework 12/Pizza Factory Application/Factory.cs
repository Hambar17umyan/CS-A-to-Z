using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application
{
    internal abstract partial class Factory
    {
        protected Factory() 
        { 
            
        }

        public readonly List<PizzaType> Menue; 
    }
}
