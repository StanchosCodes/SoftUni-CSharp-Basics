using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judgesCount = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double allPresentationsGradeSum = 0;
            int gradesCounter = 0;
            while (presentationName != "Finish")
            {
                double currentPresentationGradeSum = 0;

                for (int i = 1; i <= judgesCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradesCounter++;
                    currentPresentationGradeSum += grade;
                }
                allPresentationsGradeSum += currentPresentationGradeSum;
                double currentAverageGrade = currentPresentationGradeSum / judgesCount;
                Console.WriteLine($"{presentationName} - {currentAverageGrade:f2}.");
                presentationName = Console.ReadLine();
            }
            if (presentationName == "Finish")
            {
                double allGradesAverage = allPresentationsGradeSum / gradesCounter;
                Console.WriteLine($"Student's final assessment is {allGradesAverage:f2}.");
            }
        }
    }
}
