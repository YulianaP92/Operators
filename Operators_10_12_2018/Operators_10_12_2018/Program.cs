﻿using System;

namespace Operators_10_12_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition();
            Console.ReadKey();
        }
        static void Addition()
        {
            Console.Write("Enter the first number: ");
            var number_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            var number_2 = Convert.ToInt32(Console.ReadLine());
            var sum = number_1 + number_2;
            Console.WriteLine("The sum of the numbers {0} and {1} = {2}", number_1, number_2, sum);
        }
    }
}
