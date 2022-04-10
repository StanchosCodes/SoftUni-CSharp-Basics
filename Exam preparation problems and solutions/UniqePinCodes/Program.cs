using System;

namespace UniqePinCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumMax = int.Parse(Console.ReadLine());
            int secondNumMax = int.Parse(Console.ReadLine());
            int thirdNumMax = int.Parse(Console.ReadLine());


            for (int num1 = 1; num1 <= firstNumMax; num1++)
            {
                for (int num2 = 1; num2 <= secondNumMax; num2++)
                {
                    int num2DevidersCounter = 0;
                    for (int i = 1; i <= secondNumMax; i++)
                    {
                        int currentNum2 = num2;
                        if (currentNum2 >= 2 && currentNum2 <= 7)
                        {
                            if (currentNum2 % i == 0)
                            {
                                num2DevidersCounter++;
                            }
                        }
                    }
                    for (int num3 = 1; num3 <= thirdNumMax; num3++)
                    {
                        if (num1 % 2 == 0 && num2DevidersCounter == 2 && num3 % 2 == 0)
                        {
                            Console.WriteLine($"{num1} {num2} {num3}");
                        }
                    }
                }
            }
        }
    }
}
