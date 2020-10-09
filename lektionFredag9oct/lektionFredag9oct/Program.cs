using System;
using System.Collections.Generic;
using System.Text;
namespace lektionFredag9oct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<produkt> cart = new List<produkt>();

            Milk milk = new Milk();
            milk.FatContent = 1;
            milk.ProductNumber = 123;
            milk.StockStatus = 10;

            cart.Add(milk);

            Nocco nocco = new Nocco();
            nocco.Flavor = "Limon";
            nocco.ProductNumber = 234;
            nocco.StockStatus = 14;

            cart.Add(nocco);

            Coffee coffee = new Coffee();
            coffee.Roastyness = "Black";
            coffee.ProductNumber = 321;
            coffee.StockStatus = 0;

            cart.Add(coffee);
            
            foreach (var produkt in cart)
            {
                if (produkt.GetType() == typeof(Milk))
                {
                    Console.WriteLine(((Milk)produkt).FatContent);
                }
                else if (produkt.GetType() == typeof(Coffee))
                {
                    Console.WriteLine(((Coffee)produkt).Roastyness);
                }
                else if (produkt.GetType() == typeof(Nocco))
                {
                    Console.WriteLine(((Nocco)produkt).Flavor);
                }

            }
          
        }
    }
}