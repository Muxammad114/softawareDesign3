using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDecorator
{
    //Different pizza sizes, the higher the number the higher the price
   public enum Sizes
    {
        small,
        medium,
        large,
        huge
    }
    //Different avaliable Doughs, influence tasteIndex
    public enum Doughs
    {
        plainWheat,
        wholeWheat,
        plainRye,
        cabbage,
    }

    public class BasePizza : Pizza
    {
        // A BasePizza is a Size and Dough
        public Sizes Size { get; }
        public Doughs Dough { get; }


        public BasePizza(Sizes size, Doughs dough)
        {
            Size = size;
            Dough = dough;
        }

        //This describes what a BasePizza writes when called
        public override void Display()
        {
            Console.WriteLine($"Pizza size: {Size.ToString()} \nPizza dough: {Dough.ToString()}");
        }

        //Calculating th cost of the coosen base pizza
        public override double Cost()
        {
            return ((int) Size + 1)*20; //Converting the enum to an int and saying that sizes increase in cost in 20 DKK increments
        }

        public override double TasteIndex()
        {
            //Different abritrary tast indexes for different doughs
            switch (Dough)
            {
                case Doughs.cabbage:
                    return -100;

                case Doughs.plainRye:
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