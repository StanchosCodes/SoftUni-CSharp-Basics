using System;

namespace NumTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int counter = n; counter > 0; counter--)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
