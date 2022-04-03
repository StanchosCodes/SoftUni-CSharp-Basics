using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double chickenMenuPrice = chickenMenu * 10.35;
            double fishMenuPrice = fishMenu * 12.40;
            double veganMenuPrice = veganMenu * 8.15;

            double sum = chickenMenuPrice + fishMenuPrice + veganMenuPrice;
            double desertPrice = 0.2 * sum;
            double finalSum = sum + desertPrice + 2.50;
            Console.WriteLine(finalSum);
        }
    }
}
