using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            double totalPoints = academyPoints;

            for (int counter = 1; counter <= judges; counter++)
            {
                string judgeName = Console.ReadLine();
                double pointsFromJudge = double.Parse(Console.ReadLine());

                int nameLenght = judgeName.Length;
                totalPoints += nameLenght * pointsFromJudge / 2;

                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }
                if (counter == judges && totalPoints <= 1250.5)
                {
                    Console.WriteLine($"Sorry, {name} you need {1250.5 - totalPoints:f1} more!");
                }
            }
        }
    }
}
