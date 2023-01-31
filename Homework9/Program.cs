using System;
using Classes;

namespace Homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product= new Product();

            product.Name = "something";
            Console.WriteLine(product.Name);
            product.Name = "t";
            Console.WriteLine(product.Name);

            product.Price = 100;
            Console.WriteLine(product.Price);
            product.Price = -1;
            Console.WriteLine(product.Price);

            Drink drink = new Drink();

            drink.Name = "Cosmopolitan";
            Console.WriteLine($"Name: {drink.Name}");

            drink.Price = 14;
            Console.WriteLine($"Price: {drink.Price} AZN");

            drink.AlcoholPercent = 20;
            Console.WriteLine($"Alchohol Percentage: {drink.AlcoholPercent}%");
            
        }
    }
}
