﻿using System;

namespace testDecorator.Toppings
{
    //An implementation of Pizza Topping and there for an implementation of pizza
    public class Ham : PizzaTopping
    {
        //Call the base constructor, and pass on the pizza object
        public Ham(Pizza p) : base(p)
        {
        }

        //Call the base cost function and add its own price, returning that
        public override double Cost()
        {
            return base.Cost() + 10;
        }

        //Calling the base display function, and displaying its own text
        public override void Display()
        {
            base.Display();
            Console.WriteLine("100g of ham in strips");
        }

        //Calling the base tasteIndex function and adding its own value, returning this after.
        public override double TasteIndex()
        {
            return base.TasteIndex() + 10;
        }
    }
}
