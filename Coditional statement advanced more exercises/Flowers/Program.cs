using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char hollyday = char.Parse(Console.ReadLine());

            int sumFlowers = hrizantemi + roses + tulips;
            double price = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    double hrizantemiPrice = 2.00;
                    double rosesPrice = 4.10;
                    double tulipsPrice = 2.50;
                    price = hrizantemiPrice * hrizantemi + rosesPrice * roses + tulipsPrice * tulips;
                    break;
                case "Autumn":
                case "Winter":
                    hrizantemiPrice = 3.75;
                    rosesPrice = 4.50;
                    tulipsPrice = 4.15;
                    price = hrizantemiPrice * hrizantemi + rosesPrice * roses + tulipsPrice * tulips;
                    break;
            }

            if (hollyday == 'Y')
            {
                price *= 1.15;
            }

            if (season == "Spring" && tulips > 7)
            {
                price *= 0.95;
            }
            if (season == "Winter" && roses >= 10)
            {
                price *= 0.90;
            }
            if (sumFlowers > 20)
            {
                price *= 0.80;
            }
            price += 2;

            Console.WriteLine($"{price:f2}");
        }
    }
}
