using System;
using Polymorphism2.Entities;
using System.Collections.Generic;

namespace Polymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for(int i=0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i+1} data:");

                Console.Write("Commom, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case 'c':
                        list.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        list.Add(new ImportedProduct(name, price, customsFee));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
