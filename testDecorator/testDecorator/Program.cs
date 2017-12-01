using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    abstract class piza 
{
    abstract public int Cost();
    public string Name = "piza";

    public string getName()
    {
        return Name;
    }
}

class normalPizza: piza
{
    public normalPizza()
    { 
        Name = "normalPiza";
    }
    public override int Cost()
    {
        return 50;
    }

     
}
class FamiliaPiza : piza
{
    public FamiliaPiza()
    {
        Name = "FamiliaPiza";
    }
    public override int Cost()
    {
        return 100;
    }
   
}
class boenePiza : piza
{
    public boenePiza()
    {
        Name = "boenePiza";
    }
    public override int Cost()
    {
        return 40;
    }
    
}


abstract class DecoratorPiza :piza
{
    abstract public string getName();


}

class PizzaMedKebab: DecoratorPiza
{
    public piza piza;

    public PizzaMedKebab(piza piza)
    {
        this.piza = piza;
     
    }
    public override string getName()
    {
        return piza.getName() + " med kebab";
    }

    public override int Cost()
    {
        return piza.Cost() + 16;
    }
}

namespace testDecorator
{
    class Program
    {
        static void Main(string[] args)
        {

            piza piza = new normalPizza();
            Console.WriteLine(piza.getName()+ " koster: " +piza.Cost()+ " kr");
            piza = new PizzaMedKebab(piza);
            Console.WriteLine(piza.getName() + " koster: " + piza.Cost() + " kr");
            piza = new boenePiza();
            piza = new PizzaMedKebab(piza);
            Console.WriteLine(piza.getName() + " koster: " + piza.Cost() + " kr");

            //piza piza2 = new normalPizza();
            //piza2 = new PizzaMedKebab(piza2);

            //Console.WriteLine(piza2.getName() + " kr " + piza2.Cost());
        }
    }
}
