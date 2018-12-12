using System;

namespace B3_P2_9.CheckResultAddition
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
            Console.Write("Enter the sum of numbers: ");
            var result = Convert.ToInt32(Console.ReadLine());
            if (result == sum)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
