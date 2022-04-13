using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            int overTimeWorkers = int.Parse(Console.ReadLine());

            double workingDaysWithoutEducation = workingDays * 0.90;
            double workingHours = workingDaysWithoutEducation * 8;
            int overTimeHours = overTimeWorkers * (workingDays * 2);

            double sumHours = overTimeHours + workingHours;
            double finalHours = Math.Floor(sumHours);

            if (finalHours >= neededHours)
            {
                Console.WriteLine($"Yes!{finalHours - neededHours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{neededHours - finalHours} hours needed.");
            }
        }
    }
}
