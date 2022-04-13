using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysGone = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());

            double turtleFoodPerDayInKg = turtleFoodPerDay / 1000;

            double sumFoodNeeded = (dogFoodPerDay * daysGone) + (catFoodPerDay * daysGone) + (turtleFoodPerDayInKg * daysGone);

            if (sumFoodNeeded <= foodLeft)
            {
                Console.WriteLine($"{Math.Floor(foodLeft - sumFoodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(sumFoodNeeded - foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
