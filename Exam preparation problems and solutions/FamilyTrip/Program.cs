using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            const int percentDiscount = 5;

            if (nights > 7)
            {
                pricePerNight -= pricePerNight * percentDiscount / 100;
            }

            double priceForAllNights = pricePerNight * nights;
            double priceForTheSideSpendings = budget * percent / 100;
            double TotalMoneyNeeded = priceForAllNights + priceForTheSideSpendings;

            if (TotalMoneyNeeded <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - TotalMoneyNeeded:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{TotalMoneyNeeded - budget:f2} leva needed.");
            }
        }
    }
}
