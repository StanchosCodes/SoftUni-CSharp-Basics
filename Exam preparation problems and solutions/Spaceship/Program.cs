using System;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeightOfTheAstronauts = double.Parse(Console.ReadLine());

            double volumeOfTheSpaceship = width * length * height;
            double volumeOfOneRoom = (averageHeightOfTheAstronauts + 0.40) * 2 * 2;

            double spaceForAstronauts = Math.Floor(volumeOfTheSpaceship / volumeOfOneRoom);

            if (spaceForAstronauts >= 3 && spaceForAstronauts <= 10)
            {
                Console.WriteLine($"The spacecraft holds {spaceForAstronauts} astronauts.");
            }
            else if (spaceForAstronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
