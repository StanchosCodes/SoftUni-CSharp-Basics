using System;

namespace Sequence2K_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int nextNum = 1;

            while (nextNum <= num)
            {
                Console.WriteLine(nextNum);
                nextNum = nextNum * 2 + 1;
            }
        }
    }
}
