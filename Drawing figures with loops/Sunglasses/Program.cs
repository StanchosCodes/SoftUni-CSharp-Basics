using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * n; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
           
                Console.Write("*");

                for (int j = 0; j < 2 * n - 2; j++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                for (int k = 0; k < n; k++)
                {
                    if ((n - 1) / 2 - 1 == i)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int l = 0; l < 2 * n - 2; l++)
                {
                    Console.Write("/");
                }

                Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * n; k++)
            {
                Console.Write("*");
            }


        }
    }
}
