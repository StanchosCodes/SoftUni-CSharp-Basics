﻿using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("User please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("User please enter your city of birth: ");
            string city = Console.ReadLine();

            Console.Write("Your name is ");
            Console.Write(name);
            Console.Write(" and your age is ");
            Console.Write(age);
            Console.Write(" and you are from city of ");
            Console.WriteLine(city);
            Console.WriteLine("Your name is " + name + " and your age is " + age + " and you are from " + city);
            Console.Write($"Your name is {name} and your age is {age} and you are from {city}");
        }
    }
}
