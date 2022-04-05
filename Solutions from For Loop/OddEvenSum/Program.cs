using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int counter = 0; counter < numbers; counter++)
            {
                int num = int.Parse(Console.ReadLine());

                if (counter % 2 == 1)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}
