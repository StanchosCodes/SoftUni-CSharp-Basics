using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double volumeInCubics = volume * 0.001;
            double percentage = percent / 100;
            double litresNeeded = volumeInCubics * (1 - percentage);

            Console.WriteLine(litresNeeded);
        }
    }
}
