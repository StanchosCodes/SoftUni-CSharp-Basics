using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double currentPrice = 0;
            int productsQuantity = 0;
            double productsPrice = 0;

            while (command != "Stop")
            {
                productsQuantity++;

                double price = double.Parse(Console.ReadLine());

                if (productsQuantity % 3 == 0)
                {
                    price /= 2;
                }

                currentPrice = price;

                if (price > budget)
                {
                    break;
                }
                productsPrice += price;
                budget -= price;
                command = Console.ReadLine();
            }
            if (command == "Stop")
            {
                Console.WriteLine($"You bought {productsQuantity} products for {productsPrice:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {currentPrice - budget:f2} leva!");
            }
        }
    }
}
