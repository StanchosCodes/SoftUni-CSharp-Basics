using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episodeLenght = int.Parse(Console.ReadLine());
            int restLenght = int.Parse(Console.ReadLine()); 

            double lunchTime = restLenght * 0.125;
            double breathTime = restLenght * 0.25;

            double sumTime = lunchTime + breathTime + episodeLenght;
            double differenceTime = Math.Abs(restLenght - sumTime);

            Console.WriteLine(restLenght >= sumTime ? $"You have enough time to watch {name} and left with {Math.Ceiling(differenceTime)} minutes free time." : $"You don't have enough time to watch {name}, you need {Math.Ceiling(differenceTime)} more minutes.");
        }
    }
}
