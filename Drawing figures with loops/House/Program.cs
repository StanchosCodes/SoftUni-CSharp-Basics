using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int lines = 0;
            int stars = 0;

            if (n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }

            lines = (n - stars) / 2;

            for (int i = 0; i < (n + 1) / 2; i++)
            {


                for (int j = 0; j < lines; j++)
                {
                    Console.Write("-");
                }
                for (int k = 0; k < stars; k++)
                {
                    Console.Write("*");
                }
                for (int l = 0; l < lines; l++)
                {
                    Console.Write("-");
                }
                stars += 2;
                lines -= 1;
                Console.WriteLine();
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
