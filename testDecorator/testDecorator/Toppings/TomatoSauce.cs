using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDecorator
{
    public class TomatoSauce : PizzaTopping
    {
        public TomatoSauce(Pizza p) : base(p)
        {
        }

        public override double cost()
        {
            return base.cost() + 2;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("With Tomato sauce");
        }

        public override double tasteIndex()
        {
            return base.tasteIndex() + 5;
        }
    }
}
