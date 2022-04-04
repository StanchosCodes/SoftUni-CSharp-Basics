using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            const int springPrice = 3000;
            const int summerAndAutumnPrice = 4200;
            const int winterPrice = 2600;

            double price = 0;

            switch (season)
            {
                case "Spring":
                    if (fishermans <= 6)
                    {
                        price = springPrice * 0.90;
                    }
                    else if (fishermans >= 7 && fishermans <= 11)
                    {
                        price = springPrice * 0.85;
                    }
                    else
                    {
                        price = springPrice * 0.75;
                    }
                    if (fishermans % 2 == 0)
                    {
                        price *= 0.95;
                    }
                    break;
                case "Summer":
                    if (fishermans <= 6)
                    {
                        price = summerAndAutumnPrice * 0.90;
                    }
                    else if (fishermans >= 7 && fishermans <= 11)
                    {
                        price = summerAndAutumnPrice * 0.85;
                    }
                    else
                    {
                        price = summerAndAutumnPrice * 0.75;
                    }
                    if (fishermans % 2 == 0)
                    {
                        price *= 0.95;
                    }
                    break;
                case "Autumn":
                    if (fishermans <= 6)
                    {
                        price = summerAndAutumnPrice * 0.90;
                    }
                    else if (fishermans >= 7 && fishermans <= 11)
                    {
                        price = summerAndAutumnPrice * 0.85;
                    }
                    else
                    {
                        price = summerAndAutumnPrice * 0.75;
                    }
                    break;
                case "Winter":
                    if (fishermans <= 6)
                    {
                        price = winterPrice * 0.90;
                    }
                    else if (fishermans >= 7 && fishermans <= 11)
                    {
                        price = winterPrice * 0.85;
                    }
                    else
                    {
                        price = winterPrice * 0.75;
                    }
                    if (fishermans % 2 == 0)
                    {
                        price *= 0.95;
                    }
                    break;
            }
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
