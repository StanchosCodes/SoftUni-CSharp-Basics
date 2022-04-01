using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            const double COURSE = 1.79549;
            double bgn = usd * COURSE;
            Console.WriteLine(bgn);
        }
    }
}
