using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            if (statists > 150)
            {
                clothesPrice *= 0.90;
            }

            double totalClothesPrice = statists * clothesPrice;
            double sum = totalClothesPrice + decor;
            double leftover = Math.Abs(budget - sum);

            if (sum <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftover:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {leftover:f2} leva more.");
            }
        }
    }
}
