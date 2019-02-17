using Exceptions.Entities;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out dates must be after check-in date");
            }
            else
            {
                Reservation r = new Reservation(number, checkIn, checkOut);

                Console.WriteLine(r.ToString());
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = r.UpdateDates(checkIn, checkOut);
                if(error != null)
                {
                    Console.WriteLine(error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + r);
                }
            }
        }
    }
}
