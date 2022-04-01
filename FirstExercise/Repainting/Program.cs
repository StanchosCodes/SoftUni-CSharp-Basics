using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int plastic = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double plasticPrice = (plastic + 2) * 1.50;
            double paintPrice = (paint + 0.1 * paint) * 14.50;
            double thinnerPrice = thinner * 5.00;
            double sum = plasticPrice + paintPrice + thinnerPrice + 0.40;
            double workersPrice = (0.3 * sum) * hours;
            Console.WriteLine(sum + workersPrice);
        }
    }
}
