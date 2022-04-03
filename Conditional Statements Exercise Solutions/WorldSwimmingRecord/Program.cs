using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double lenghtInMeters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double swimmingTimeForTheMeters = lenghtInMeters * timeForOneMeter;
            double slowingTime = Math.Floor(lenghtInMeters / 15) * 12.5;
            double totalTimeSwimming = swimmingTimeForTheMeters + slowingTime;

            double difference = totalTimeSwimming - recordInSec;

            Console.WriteLine(totalTimeSwimming < recordInSec ? $"Yes, he succeeded! The new world record is {totalTimeSwimming:f2} seconds." : $"No, he failed! He was {difference:f2} seconds slower.");
        }
    }
}
