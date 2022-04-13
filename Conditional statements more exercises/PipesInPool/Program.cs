using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hoursLeft = double.Parse(Console.ReadLine());

            double sumPipe1 = pipe1 * hoursLeft;
            double sumPipe2 = pipe2 * hoursLeft;
            double sumPipes = sumPipe1 + sumPipe2;

            if (volume >= sumPipes)
            {
                double pipe1Percentage = sumPipe1 / sumPipes * 100;
                double pipe2Percentage = sumPipe2 / sumPipes * 100;
                double poolFullnesPercentage = sumPipes / volume * 100;

                Console.WriteLine($"The pool is {poolFullnesPercentage:f2}% full. Pipe 1: {pipe1Percentage:f2}%. Pipe 2: {pipe2Percentage:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursLeft:f2} hours the pool overflows with {sumPipes - volume:f2} liters.");
            }
        }
    }
}
