using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int currentNumber = i;
                int digit = i % 10;
                if (digit == 0)
                {
                    continue;
                }
                if (n % digit == 0)
                {
                    digit = i / 10 % 10;
                    if (digit == 0)
                    {
                        continue;
                    }
                    if (n % digit == 0)
                    {
                        digit = i / 100 % 10;
                        if (digit == 0)
                        {
                            continue;
                        }
                        if (n % digit == 0)
                        {
                            digit = i / 1000 % 10;
                            if (digit == 0)
                            {
                                continue;
                            }
                            if (n % digit == 0)
                            {
                                Console.Write($"{currentNumber} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
