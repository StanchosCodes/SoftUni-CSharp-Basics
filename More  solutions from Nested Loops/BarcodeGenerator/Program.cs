using System;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int fourthDigitOfNum1 = num1 % 10;
            int fourthDigitOfNum2 = num2 % 10;
            num1 /= 10;
            num2 /= 10;
            int thirdDigitOfNum1 = num1 % 10;
            int thirdDigitOfNum2 = num2 % 10;
            num1 /= 10;
            num2 /= 10;
            int secondDigitOfNum1 = num1 % 10;
            int secondDigitOfNum2 = num2 % 10;
            num1 /= 10;
            num2 /= 10;

            for (int i = num1; i <= num2; i++)
            {
                for (int j = secondDigitOfNum1; j <= secondDigitOfNum2; j++)
                {
                    for (int k = thirdDigitOfNum1; k <= thirdDigitOfNum2; k++)
                    {
                        for (int l = fourthDigitOfNum1; l <= fourthDigitOfNum2; l++)
                        {
                            if (l % 2 != 0 && k % 2 != 0 && j % 2 != 0 && i % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
