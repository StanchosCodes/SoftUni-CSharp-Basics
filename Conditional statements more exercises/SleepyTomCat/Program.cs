using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restingDays = int.Parse(Console.ReadLine());

            int restingDaysMinutesForPlay = restingDays * 127;
            int workingDays = 365 - restingDays;
            int workingDaysMinutesForPlay = workingDays * 63;

            int sumMinutesForPlay = restingDaysMinutesForPlay + workingDaysMinutesForPlay;

            int leftOverMinutesTotal = Math.Abs(30000 - sumMinutesForPlay);

            int leftOverHours = leftOverMinutesTotal / 60;
            int leftOverMinutes = leftOverMinutesTotal - (leftOverHours * 60);

            if (sumMinutesForPlay <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{leftOverHours} hours and {leftOverMinutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{leftOverHours} hours and {leftOverMinutes} minutes more for play");
            }
        }
    }
}
