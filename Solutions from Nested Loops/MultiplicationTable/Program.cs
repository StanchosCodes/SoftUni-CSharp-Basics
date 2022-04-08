using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int multiplier = 1; multiplier <= 10; multiplier++)
            {
                for (int multiply = 1; multiply <= 10; multiply++)
                {
                    int sum = multiplier * multiply;
                    Console.WriteLine($"{multiplier} * {multiply} = {sum}");
                }
            }
        }
    }
}
