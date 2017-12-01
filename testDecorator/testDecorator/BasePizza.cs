using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDecorator
{
    public enum Sizes
    {
        small,
        medium,
        large,
        huge
    }

    public enum Doughs
    {
        plainWheat,
        wholeWheat,
        plainRey,
        cabbage,
    }

    public class BasePizza : Pizza
    {
        public Sizes Size { get; }
        public Doughs Dough { get; }


        public BasePizza(Sizes size, Doughs dough)
        {
            Size = size;
            Dough = dough;
        }

        public override void display()
        {
            Console.WriteLine($"Pizza size: {Size.ToString()} \nPizza dough: {Dough.ToString()}");
        }

        public override double cost()
        {
            return ((int) Size + 1)*20;
        }

        public override double tasteIndex()
        {
            switch (Dough)
            {
                case Doughs.cabbage:
                    return -100;

                case Doughs.plainRey:
                    return -50;

                case Doughs.plainWheat:
                    return +10;

                case Doughs.wholeWheat:
                    return -10;

                default:
                    return 0;
            }
        }
    }
}