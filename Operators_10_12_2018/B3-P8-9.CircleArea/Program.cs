using System;


namespace B3_P8_9.CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Area();
            Console.ReadKey();
        }
        static void Area()
        {
            Console.Write("Enter the radius of the circle: ");
            var radius = Double.Parse(Console.ReadLine());
            var areaCircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of a circle = {0:#.##}",areaCircle);
        }
    }
}
