using Exceptions.Entities;
using Exceptions.Entities.Exceptions;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation r = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + r);
                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                r.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + r);
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
