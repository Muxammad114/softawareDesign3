using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testDecorator.Toppings;

namespace testDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new PizzaTopping(new TomatoSauce(new Anchovies(new BasePizza(Sizes.huge,Doughs.plainRey))));

            pizza.display();
            Console.WriteLine(pizza.cost() + " " + pizza.tasteIndex());
        }
    };
}
