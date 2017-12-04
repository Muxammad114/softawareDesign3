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
        public abstract void display();
        public abstract double cost();
        public abstract double tasteIndex();
    }
}
