using System;

namespace testDecorator.Toppings
{
    public class Cheese : PizzaTopping
    {
        public Cheese(Pizza p) : base(p)
        {
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Cheese on top");
        }

        public override double cost()
        {
            return base.cost() + 2;
        }

        public override double tasteIndex()
        {
            return base.tasteIndex() + 10;
        }
    }
}
