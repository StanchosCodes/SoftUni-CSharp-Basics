using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int nums = 0;
            int sum = 0;

            while (sum < num)
            {
                nums = int.Parse(Console.ReadLine());
                sum += nums;
            }
            Console.WriteLine(sum);
        }
    }
}
