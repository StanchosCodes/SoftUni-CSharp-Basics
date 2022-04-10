using System;

namespace Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double littersPer100Km = double.Parse(Console.ReadLine());

            double totalDistance = 384400 * 2;
            double timeToTheMoonAndBack = totalDistance / averageSpeed;
            double totalTimeNeeded = timeToTheMoonAndBack + 3;

            double fuelNeeded = (littersPer100Km * totalDistance) / 100;

            Console.WriteLine($"{Math.Ceiling(totalTimeNeeded)}");
            Console.WriteLine(fuelNeeded);
        }
    }
}
