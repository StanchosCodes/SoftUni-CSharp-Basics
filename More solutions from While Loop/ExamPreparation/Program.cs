using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            int countBadGrades = 0;
            int countAllGrades = 0;
            double sumGrades = 0;

            string taskName = Console.ReadLine();
            int currentGrade = int.Parse(Console.ReadLine());
            string currentTaskName = taskName;

            while (taskName != "Enough")
            {
                countAllGrades++;
                sumGrades += currentGrade;
                currentTaskName = taskName;
                if (currentGrade <= 4)
                {
                    countBadGrades++;
                    if (countBadGrades == badGrades)
                    {
                        Console.WriteLine($"You need a break, {countBadGrades} poor grades.");
                        break;
                    }
                }
                taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    double averageGrade = sumGrades / countAllGrades;
                    Console.WriteLine($"Average score: {averageGrade:f2}");
                    Console.WriteLine($"Number of problems: {countAllGrades}");
                    Console.WriteLine($"Last problem: {currentTaskName}");
                    break;
                }
                currentGrade = int.Parse(Console.ReadLine());
            }
        }
    }
}
