﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDecorator
{
    //An implementation of Pizzaz
    public class PizzaTopping : Pizza
    {
        //This is what enables it to be decorated
        private Pizza pizza;

        //A Pizza topping can take any pizza type class in the constructor, meaning you can cascade constructions
        public PizzaTopping(Pizza p)
        {
            pizza = p;
        }

        //Calling display on its child pizza object
        public override void display()
        {
            pizza.display();
        }

        //Calling cost on its child pizza object and returning the result
        public override double cost()
        {
            return pizza.cost();
        }

        //Calling tasteIndex on its child pizza object and returning the result
        public override double tasteIndex()
        {
            return pizza.tasteIndex();
        }
    }
}
