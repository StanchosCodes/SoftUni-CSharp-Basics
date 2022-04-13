using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int top = n - 2;

            Console.Write("+ ");

            for (int i = 0; i < top; i++)
            {
                Console.Write("- ");
            }

            Console.WriteLine("+");

            for (int j = 0; j < top; j++)
            {
                Console.Write("| ");
                for (int k = 0; k < top; k++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }

            Console.Write("+ ");

            for (int i = 0; i < top; i++)
            {
                Console.Write("- ");
            }

            Console.WriteLine("+");
        }
    }
}
