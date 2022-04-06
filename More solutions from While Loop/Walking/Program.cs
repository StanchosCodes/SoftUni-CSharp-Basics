using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int currentSteps = 0;

            while (currentSteps <= 10000)
            {
                if (input != "Going home")
                {
                    int newSteps = int.Parse(input);
                    currentSteps += newSteps;
                    if (currentSteps >= 10000)
                    {
                        break;
                    }
                }
                else
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    currentSteps += stepsToHome;
                    break;
                }
                input = Console.ReadLine();
            }
            int diff = 0;
            if (currentSteps >= 10000)
            {
                diff = currentSteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{diff} steps over the goal!");
            }
            else
            {
                diff = 10000 - currentSteps;
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
        }
    }
}
