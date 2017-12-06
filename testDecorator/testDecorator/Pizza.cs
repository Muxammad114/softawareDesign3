using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDecorator
{
    //An abstract class that everything, that PizzaTopping and BasePizza implement.
    public abstract class Pizza
    {
        public abstract void Display();
        public abstract double Cost();
        public abstract double TasteIndex();
    }
}
