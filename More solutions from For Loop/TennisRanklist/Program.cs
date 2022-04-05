using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int totalPoints = startPoints;
            double wins = 0;

            for (int counter = 0; counter < tournaments; counter++)
            {
                string position = Console.ReadLine();

                switch (position)
                {
                    case "W":
                        wins++;
                        totalPoints += 2000;
                        break;
                    case "F":
                        totalPoints += 1200;
                        break;
                    case "SF":
                        totalPoints += 720;
                        break;
                }
            }
            double average = (totalPoints - startPoints) / tournaments;
            double winningPersentage = wins / tournaments * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{winningPersentage:f2}%");
        }
    }
}
