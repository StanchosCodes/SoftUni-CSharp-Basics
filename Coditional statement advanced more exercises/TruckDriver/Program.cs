using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());

            double pricePerKm = 0;

            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kilometers <= 5000)
                    {
                        pricePerKm = 0.75;
                    }
                    else if (kilometers <= 10000)
                    {
                        pricePerKm = 0.95;
                    }
                    else
                    {
                        pricePerKm = 1.45;
                    }
                    break;
                case "Summer":
                    if (kilometers <= 5000)
                    {
                        pricePerKm = 0.90;
                    }
                    else if (kilometers <= 10000)
                    {
                        pricePerKm = 1.10;
                    }
                    else
                    {
                        pricePerKm = 1.45;
                    }
                    break;
                case "Winter":
                    if (kilometers <= 5000)
                    {
                        pricePerKm = 1.05;
                    }
                    else if (kilometers <= 10000)
                    {
                        pricePerKm = 1.25;
                    }
                    else
                    {
                        pricePerKm = 1.45;
                    }
                    break;
            }

            double salaryPerMonth = pricePerKm * kilometers;
            double salaryForTheSeason = salaryPerMonth * 4;
            double netSalary = salaryForTheSeason * 0.90;

            Console.WriteLine($"{netSalary:f2}");
        }
    }
}
