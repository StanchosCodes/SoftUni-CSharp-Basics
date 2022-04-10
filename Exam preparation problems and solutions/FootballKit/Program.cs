using System;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double priceToReach = double.Parse(Console.ReadLine());

            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.20;
            double shoesPrice = (tshirtPrice + shortsPrice) * 2;
            double totalMoney = tshirtPrice + shortsPrice + socksPrice + shoesPrice;
            double finalMoney = totalMoney - (totalMoney * 0.15);

            if (finalMoney > priceToReach)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {finalMoney:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {priceToReach - finalMoney:f2} lv. more.");
            }
        }
    }
}
