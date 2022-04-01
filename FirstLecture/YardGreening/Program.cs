using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE = 7.61;
            const double DISCOUNT = 0.18;

            double area = double.Parse(Console.ReadLine());
            double noDiscountPrice = area * PRICE;
            double discountSum = noDiscountPrice * DISCOUNT;
            double discounted = noDiscountPrice - discountSum;
            Console.WriteLine($"The final price is: {discounted} lv.");
            Console.WriteLine($"The discount is: {discountSum} lv.");
        }
    }
}
