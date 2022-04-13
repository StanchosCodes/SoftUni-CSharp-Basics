using System;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int space = n - i;

                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                int stars = i - 1;

                for (int k = 1; k <= stars; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            int secPart = n - 1;

            for (int i = 1; i <= secPart; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                int starsForSecPart = secPart - i;

                for (int k = 1; k <= starsForSecPart; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
