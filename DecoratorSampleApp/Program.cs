using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let us create a Simple Cake Base first
            Kahve kahve = new Kahve();
            PrintProductDetails(kahve);

            // Lets add cream to the cake
            SütDecorator sütlüKahve = new SütDecorator(kahve);
            PrintProductDetails(sütlüKahve);

            // Finally add a Name card on the cake
            KremaDecorator kremalýKahve = new KremaDecorator(sütlüKahve);
            PrintProductDetails(kremalýKahve);
            
            // Lets now create a simple Pastry
            Pasta pasta = new Pasta();
            PrintProductDetails(pasta);
            
            ÇilekDecorator çlekliPAsta = new ÇilekDecorator(pasta);
            PrintProductDetails(çlekliPAsta);


            Console.Read();
        }

        private static void PrintProductDetails(StarbucksUrun product)
        {
            Console.WriteLine(); // some whitespace for readability
            Console.WriteLine("Item: {0}, Price: {1}", product.Name, product.Price);
        }
    }
}
