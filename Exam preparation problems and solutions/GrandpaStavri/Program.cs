using System;

namespace GrandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double litresSum = 0;
            double degreesSum = 0;

            for (int i = 1; i <= days; i++)
            {
                double litres = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());

                litresSum += litres;
                degreesSum += degrees * litres;
            }

            double degreesAverage = degreesSum / litresSum;

            Console.WriteLine($"Liter: {litresSum:f2}");
            Console.WriteLine($"Degrees: {degreesAverage:f2}");

            if (degreesAverage < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (degreesAverage < 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
