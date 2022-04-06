using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string income = Console.ReadLine();

            double sum = 0;

            while (income != "NoMoreMoney")
            {
                double increase = double.Parse(income);
                if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {increase:f2}") ;
                sum += increase;
                income = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
