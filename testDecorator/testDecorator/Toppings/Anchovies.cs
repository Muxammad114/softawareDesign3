﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDecorator.Toppings
{
    //An implementation of Pizza Topping and there for an implementation of pizza
    public class Anchovies : PizzaTopping
    {
        //Call the base constructor, and pass on the pizza object
        public Anchovies(Pizza p) : base(p)
        {
        }

        //Call the base cost function and add its own price, returning that
        public override double Cost()
        {
            return base.Cost() + 20;
        }

        //Calling the base display function, and displaying its own text
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Anchovies my favorite!");
        }

        //Calling the base tasteIndex function and adding its own value, returning this after.
        public override double TasteIndex()
        {
            return base.TasteIndex() + 100;
        }
    }
}
