using System;

namespace testDecorator.Toppings
{
    public class Pineapple : PizzaTopping
    {
        public Pineapple(Pizza p) : base(p)
        {
        }

        public override double cost()
        {
            return base.cost() + 5;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("A handfull of pineapple, mmmhhh");
        }

        public override double tasteIndex()
        {
            return base.tasteIndex() + 20;
        }
    }
}
