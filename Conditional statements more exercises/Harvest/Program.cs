using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMeters = int.Parse(Console.ReadLine());
            double grapeForOneSquareMeter = double.Parse(Console.ReadLine());
            int litersNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double squareMetersForGrape = 0.4 * squareMeters;
            double sumGrapes = squareMetersForGrape * grapeForOneSquareMeter;
            double litres = sumGrapes / 2.5;

            if (litres < litersNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(litersNeeded - litres)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litres)} liters.");
                Console.WriteLine($"{Math.Ceiling(litres - litersNeeded)} liters left -> {Math.Ceiling((litres - litersNeeded) / workers)} liters per person.");
            }
        }
    }
}
