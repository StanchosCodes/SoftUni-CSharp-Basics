using System;

namespace NumbersFrom1ToNStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= n; counter += 3)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
