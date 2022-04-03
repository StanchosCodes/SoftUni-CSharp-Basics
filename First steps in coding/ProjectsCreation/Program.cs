using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TIME = 3;
            string name = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int timeNeeded = num * TIME;
            Console.WriteLine($"The architect {name} will need {timeNeeded} hours to complete {num} project/s.");
        }
    }
}
