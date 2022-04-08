using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int num = startNum; num <= endNum; num++)
            {
                int currentNum = num;
                int evenSum = 0;
                int oddSum = 0;
                int count = 0;

                while (currentNum != 0)
                {
                    int digit = currentNum % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    currentNum /= 10;
                    count++;
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
