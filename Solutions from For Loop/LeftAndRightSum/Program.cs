using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int counter = 0; counter < quantity; counter++)
            {
                int leftNums = int.Parse(Console.ReadLine());
                leftSum += leftNums;
            }
            for (int counter = 0; counter < quantity; counter++)
            {
                int rightNums = int.Parse(Console.ReadLine());
                rightSum += rightNums;
            }


            if (leftSum == rightSum)
            {
                int sum = leftSum;
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                int sum = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {sum}");
            }
        }
    }
}
