using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();

            const double maxGrade = 20;
            double hardnesGrade = 0;
            double doingGrade = 0;

            if (country == "Russia")
            {
                switch (instrument)
                {
                    case "ribbon":
                        hardnesGrade = 9.100;
                        doingGrade = 9.400;
                        break;
                    case "hoop":
                        hardnesGrade = 9.300;
                        doingGrade = 9.800;
                        break;
                    case "rope":
                        hardnesGrade = 9.600;
                        doingGrade = 9.000;
                        break;
                }
            }
            else if (country == "Bulgaria")
            {
                switch (instrument)
                {
                    case "ribbon":
                        hardnesGrade = 9.600;
                        doingGrade = 9.400;
                        break;
                    case "hoop":
                        hardnesGrade = 9.550;
                        doingGrade = 9.750;
                        break;
                    case "rope":
                        hardnesGrade = 9.500;
                        doingGrade = 9.400;
                        break;
                }
            }
            else if (country == "Italy")
            {
                switch (instrument)
                {
                    case "ribbon":
                        hardnesGrade = 9.200;
                        doingGrade = 9.500;
                        break;
                    case "hoop":
                        hardnesGrade = 9.450;
                        doingGrade = 9.350;
                        break;
                    case "rope":
                        hardnesGrade = 9.700;
                        doingGrade = 9.150;
                        break;
                }
            }

            double sumGrade = hardnesGrade + doingGrade;
            double pointNeeded = maxGrade - sumGrade;
            double percentage = pointNeeded / maxGrade * 100;

            Console.WriteLine($"The team of {country} get {sumGrade:f3} on {instrument}.");
            Console.WriteLine($"{percentage:f2}%");
        }
    }
}
