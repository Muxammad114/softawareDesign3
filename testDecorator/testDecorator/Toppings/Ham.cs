using System;

namespace testDecorator.Toppings
{
    public class Ham : PizzaTopping
    {
        public Ham(Pizza p) : base(p)
        {
        }

        public override double cost()
        {
            return base.cost() + 10;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("100g of ham in strips");
        }

        public override double tasteIndex()
        {
            return base.tasteIndex() + 10;
        }
    }
}
