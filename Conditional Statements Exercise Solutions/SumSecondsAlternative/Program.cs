using System;

namespace SumSecondsAlternative
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTime = 0;
            totalTime += int.Parse(Console.ReadLine());
            totalTime += int.Parse(Console.ReadLine());
            totalTime += int.Parse(Console.ReadLine());
            
            
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            // Много по - вярно решение
            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
