﻿using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            const double INCH = 2.54;
            double num = double.Parse(Console.ReadLine());
            double centimeters = num * INCH;
            Console.WriteLine(centimeters);
        }
    }
}
