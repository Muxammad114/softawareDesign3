using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDecorator
{
    //An implementation of Pizza Topping and there for an implementation of pizza
    public class TomatoSauce : PizzaTopping
    {
        //Call the base constructor, and pass on the pizza object
        public TomatoSauce(Pizza p) : base(p)
        {
        }

        //Call the base cost function and add its own price, returning that
        public override double cost()
        {
            return base.cost() + 2;
        }

        //Calling the base display function, and displaying its own text
        public override void display()
        {
            base.display();
            Console.WriteLine("With Tomato sauce");
        }

        //Calling the base tasteIndex function and adding its own value, returning this after.
        public override double tasteIndex()
        {
            return base.tasteIndex() + 5;
        }
    }
}
