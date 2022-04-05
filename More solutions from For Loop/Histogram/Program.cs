using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p1Percentage = 0;
            double p2 = 0;
            double p2Percentage = 0;
            double p3 = 0;
            double p3Percentage = 0;
            double p4 = 0;
            double p4Percentage = 0;
            double p5 = 0;
            double p5Percentage = 0;

            for (int counter = 0; counter < numbers; counter++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num <= 399)
                {
                    p2++;
                }
                else if (num <= 599)
                {
                    p3++;
                }
                else if (num <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            p1Percentage = p1 / numbers * 100;
            p2Percentage = p2 / numbers * 100;
            p3Percentage = p3 / numbers * 100;
            p4Percentage = p4 / numbers * 100;
            p5Percentage = p5 / numbers * 100;

            Console.WriteLine($"{p1Percentage:f2}%");
            Console.WriteLine($"{p2Percentage:f2}%");
            Console.WriteLine($"{p3Percentage:f2}%");
            Console.WriteLine($"{p4Percentage:f2}%");
            Console.WriteLine($"{p5Percentage:f2}%");
        }
    }
}
