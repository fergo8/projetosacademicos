using ElementsComposition2.Entities;
using ElementsComposition2.Entities.Enums;
using System;
using System.Collections.Generic;

namespace ElementsComposition2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client Client = new Client(Name, Email, BirthDate);
            Order Order = new Order(DateTime.Now, Status, Client);
            
            Console.WriteLine();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i=0; i < n; i++)
            {
                Console.WriteLine($"Enter {i+1} item data:");
                Console.Write("Product name: ");
                string ProductName = Console.ReadLine();
                Console.Write("Product price: ");
                double ProductPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());

                Product Product = new Product(ProductName, ProductPrice);
                OrderItem OrderItem = new OrderItem(Quantity, ProductPrice, Product);

                Order.AddItem(OrderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(Order);
        }
    }
}
