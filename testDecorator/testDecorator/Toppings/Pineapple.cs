using System;

namespace testDecorator.Toppings
{
    //An implementation of Pizza Topping and there for an implementation of pizza
    public class Pineapple : PizzaTopping
    {
        //Call the base constructor, and pass on the pizza object
        public Pineapple(Pizza p) : base(p)
        {
        }
        
        //Call the base cost function and add its own price, returning that
        public override double cost()
        {
            return base.cost() + 5;
        }
        
        //Calling the base display function, and displaying its own text
        public override void display()
        {
            base.display();
            Console.WriteLine("A handfull of pineapple, mmmhhh");
        }

        //Calling the base tasteIndex function and adding its own value, returning this after.
        public override double tasteIndex()
        {
            return base.tasteIndex() + 20;
        }
    }
}
