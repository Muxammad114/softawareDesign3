using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDecorator
{
    public class PizzaTopping : Pizza
    {
        private Pizza pizza;

        public PizzaTopping(Pizza p)
        {
            pizza = p;
        }

        public override void display()
        {
            pizza.display();
        }

        public override double cost()
        {
            return pizza.cost();
        }

        public override double tasteIndex()
        {
            return pizza.tasteIndex();
        }
    }
}
