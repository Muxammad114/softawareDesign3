using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDecorator.Toppings
{
    public class Anchovies : PizzaTopping
    {
        public Anchovies(Pizza p) : base(p)
        {
        }

        public override double cost()
        {
            return base.cost() + 20;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Anchovies my favorite!");
        }

        public override double tasteIndex()
        {
            return base.tasteIndex() + 100;
        }
    }
}
