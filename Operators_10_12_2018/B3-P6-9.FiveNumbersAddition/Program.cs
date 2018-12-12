using System;


namespace B3_P6_9.FiveNumbersAddition
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
            Console.Write("Enter the third number: ");
            var number_3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            var number_4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fifth number: ");
            var number_5 = Convert.ToInt32(Console.ReadLine());
            var sum = number_1 += number_2 += number_3 += number_4 += number_5;
            int count = 0;
            while (count < 3)
            {
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
    }
}
