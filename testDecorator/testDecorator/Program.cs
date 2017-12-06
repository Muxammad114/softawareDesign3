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
           
            //A pizza consisting of TomatoSauce, anchovies and a BasePizza
            // Pizza pizza = new TomatoSauce(new Anchovies(new BasePizza(Sizes.huge,Doughs.plainRey)));
            Pizza pizza = new TomatoSauce(new Anchovies( new BasePizza(Sizes.huge, Doughs.wholeWheat)));
            //Calls all display functions in; Anchovies, TomatoSauce and BasePizza
            pizza.Display();
            //Here 2 other fuctions are called cost and tasteIndex, which call in the same way as display
            Console.WriteLine("Price of pizza: " + pizza.Cost() + " DKK \nTaste index: " + pizza.TasteIndex());
        }
    };
}
