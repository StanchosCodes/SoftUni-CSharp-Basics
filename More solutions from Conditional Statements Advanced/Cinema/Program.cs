using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double sum = 0;
            switch (type)
            {
                case "Premiere":
                    sum = rows * colums * 12.00;
                    break;
                case "Normal":
                    sum = rows * colums * 7.50;
                    break;
                case "Discount":
                    sum = rows * colums * 5.00;
                    break;
            }
            Console.WriteLine($"{sum:f2} leva");
        }
    }
}
