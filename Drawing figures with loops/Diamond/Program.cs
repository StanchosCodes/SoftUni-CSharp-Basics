using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rowsCounter = 1;
            int lines = (n - 1) / 2;
            int midLines = (n - 2) - (lines * 2);

            for (int i = 0; i < lines; i++)
            {
                Console.Write("-");
            }
            Console.Write("*");
            if (midLines >= 0)
            {
                Console.Write("*");
            }
            for (int i = 0; i < lines; i++)
            {
                Console.Write("-");
            }

            lines--;
            rowsCounter++;
            Console.WriteLine();

            for (int i = 0; i < n / 2; i++)
            {
                if (lines < 0)
                {
                    continue;
                }
                midLines = (n - 2) - (lines * 2);
                for (int j = 0; j < lines; j++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int k = 0; k < midLines; k++)
                {
                    Console.Write("-");
                }
                if (midLines >= 0)
                {
                    Console.Write("*");
                }
                for (int l = 0; l < lines; l++)
                {
                    Console.Write("-");
                }
                lines--;
                if (n % 2 == 0)
                {
                    rowsCounter++;
                }
                Console.WriteLine();
            }

            lines += 2;

            for (int i = 0; i < n / 2; i++)
            {
                if (rowsCounter == n)
                {
                    continue;
                }
                midLines = (n - 2) - (lines * 2);
                for (int j = 0; j < lines; j++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int k = 0; k < midLines; k++)
                {
                    Console.Write("-");
                }
                if (midLines >= 0)
                {
                Console.Write("*");
                }

                for (int l = 0; l < lines; l++)
                {
                    Console.Write("-");
                }
                lines++;
                rowsCounter++;
                Console.WriteLine();
            }
        }
    }
}
