using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            const double vipPrice = 499.99;
            const double normalPrice = 249.99;

            if (quantity >= 1 && quantity <= 4)
            {
                budget *= 0.25;
            }
            else if (quantity > 4 && quantity <= 9)
            {
                budget *= 0.40;
            }
            else if (quantity > 9 && quantity <= 24)
            {
                budget *= 0.50;
            }
            else if (quantity > 24 && quantity <= 49)
            {
                budget *= 0.60;
            }
            else if (quantity >= 50)
            {
                budget *= 0.75;
            }

            switch (type)
            {
                case "VIP":
                    budget -= quantity * vipPrice;
                    break;
                case "Normal":
                    budget -= quantity * normalPrice;
                    break;
            }

            if (budget >= 0)
            {
                Console.WriteLine($"Yes! You have {budget:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget):f2} leva.");
            }
        }
    }
}
