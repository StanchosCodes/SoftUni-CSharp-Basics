using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int year = 1;
            int failsCounter = 0;
            double sumGrades = 0;

            while (year <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    failsCounter++;

                    if (failsCounter > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {year - 1} grade");
                        break;
                    }
                }

                year++;
                sumGrades += grade;
            }
            if (year - 1 == 12)
            {
                double averageGrade = sumGrades / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
