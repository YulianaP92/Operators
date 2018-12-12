using System;


namespace B3_P5_9.CheckResultWithAttemps
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
            else if (@operator == '-')
                Subtraction(number_1, number_2);
            else
                Console.WriteLine("Enter the correct statement");
            Console.ReadKey();
        }
        static void Addition(int number_1, int number_2)
        {
            int count = 0;
            while (count < 3)
            {
                var sum = number_1 + number_2;
                Console.Write("Enter the sum of numbers: ");
                var result = Convert.ToInt32(Console.ReadLine());
                if (result == sum)
                {
                    Console.WriteLine("True");
                    return;
                }
                else
                {
                    Console.WriteLine("False");
                    if (result < sum)
                        Console.WriteLine("The sum must be greater");
                    else
                        Console.WriteLine("The sum must be less");
                    count++;
                }
            }
        }
        static void Subtraction(int number_1, int number_2)
        {
            int count = 0;
            while (count < 3)
            {
                var substract = number_1 + number_2;
                Console.Write("Enter the difference of numbers: ");
                var result = Convert.ToInt32(Console.ReadLine());
                if (result == substract)
                {
                    Console.WriteLine("True");
                    return;
                }
                else
                {
                    Console.WriteLine("False");
                    if (result < substract)
                        Console.WriteLine("The difference must be greater");
                    else
                        Console.WriteLine("The difference must be less");
                    count++;
                }
            }
        }
    }
}
