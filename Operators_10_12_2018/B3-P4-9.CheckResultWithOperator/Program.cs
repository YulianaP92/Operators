using System;

namespace B3_P4_9.CheckResultWithOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            var number_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            var number_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operotor '+' or '-': ");
            var @operator = Convert.ToChar(Console.ReadLine());
            if (@operator == '+')

                Addition(number_1, number_2);
            if (@operator == '-')
                Subtraction(number_1, number_2);
            else
                Console.WriteLine("Enter the correct statement");
            Console.ReadKey();
        }
        static void Addition(int number_1, int number_2)
        {
            var sum = number_1 + number_2;
            Console.Write("Enter the sum of numbers: ");
            var result = Convert.ToInt32(Console.ReadLine());
            if (result == sum)
                Console.WriteLine("True");
            else
            {
                Console.WriteLine("False");
                if (result < sum)
                    Console.WriteLine("The sum must be greater");
                else
                    Console.WriteLine("The sum must be less");

            }
        }
        static void Subtraction(int number_1, int number_2)
        {
            var subtract = number_1 - number_2;
            Console.Write("Enter the difference of numbers: ");
            var result = Convert.ToInt32(Console.ReadLine());
            if (result == subtract)
                Console.WriteLine("True");
            else
            {
                Console.WriteLine("False");
                if (result < subtract)
                    Console.WriteLine("The difference must be greater");
                else
                    Console.WriteLine("The difference must be less");
            }
        }
    }
}
