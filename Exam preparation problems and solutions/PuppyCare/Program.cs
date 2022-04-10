using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int boughtFood = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int foodInGrams = boughtFood * 1000;
            int totalEatenFood = 0;

            while (input != "Adopted")
            {
                int currentEatenFood = int.Parse(input);

                totalEatenFood += currentEatenFood;

                input = Console.ReadLine();
            }

            if (foodInGrams >= totalEatenFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGrams - totalEatenFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalEatenFood - foodInGrams} grams more.");
            }
        }
    }
}
