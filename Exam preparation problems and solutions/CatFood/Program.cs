using System;

namespace CatFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int catsQuantity = int.Parse(Console.ReadLine());

            double foodInGrams = 0;
            int firstGroupCounter = 0;
            int secondGroupCounter = 0;
            int thirdGroupCounter = 0;

            const double foodPricePerKilogram = 12.45;

            for (int i = 0; i < catsQuantity; i++)
            {
                double eatenFoodInGrams = double.Parse(Console.ReadLine());

                foodInGrams += eatenFoodInGrams;

                if (eatenFoodInGrams >= 100 && eatenFoodInGrams < 200)
                {
                    firstGroupCounter++;
                }
                else if (eatenFoodInGrams >= 200 && eatenFoodInGrams < 300 )
                {
                    secondGroupCounter++;
                }
                else if (eatenFoodInGrams >= 300 && eatenFoodInGrams < 400)
                {
                    thirdGroupCounter++;
                }
            }

            double foodInKilograms = foodInGrams / 1000;
            double priceForFoodPerDay = foodInKilograms * foodPricePerKilogram;

            Console.WriteLine($"Group 1: {firstGroupCounter} cats.");
            Console.WriteLine($"Group 2: {secondGroupCounter} cats.");
            Console.WriteLine($"Group 3: {thirdGroupCounter} cats.");
            Console.WriteLine($"Price for food per day: {priceForFoodPerDay:f2} lv.");
        }
    }
}
