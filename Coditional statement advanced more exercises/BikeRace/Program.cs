using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string typeTrack = Console.ReadLine();

            double sumTaxes = 0;

            switch (typeTrack)
            {
                case "trail":
                    sumTaxes += juniors * 5.50;
                    sumTaxes += seniors * 7;
                    break;
                case "cross-country":
                    sumTaxes += juniors * 8;
                    sumTaxes += seniors * 9.50;
                    break;
                case "downhill":
                    sumTaxes += juniors * 12.25;
                    sumTaxes += seniors * 13.75;
                    break;
                case "road":
                    sumTaxes += juniors * 20;
                    sumTaxes += seniors * 21.50;
                    break;
            }

            if (typeTrack == "cross-country" && juniors + seniors >= 50)
            {
                sumTaxes *= 0.75;
            }

            sumTaxes *= 0.95;

            Console.WriteLine($"{sumTaxes:f2}");
        }
    }
}
