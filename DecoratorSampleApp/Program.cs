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
            S�tDecorator s�tl�Kahve = new S�tDecorator(kahve);
            PrintProductDetails(s�tl�Kahve);

            // Finally add a Name card on the cake
            KremaDecorator kremal�Kahve = new KremaDecorator(s�tl�Kahve);
            PrintProductDetails(kremal�Kahve);
            
            // Lets now create a simple Pastry
            Pasta pasta = new Pasta();
            PrintProductDetails(pasta);
            
            �ilekDecorator �lekliPAsta = new �ilekDecorator(pasta);
            PrintProductDetails(�lekliPAsta);


            Console.Read();
        }

        private static void PrintProductDetails(StarbucksUrun product)
        {
            Console.WriteLine(); // some whitespace for readability
            Console.WriteLine("Item: {0}, Price: {1}", product.Name, product.Price);
        }
    }
}
