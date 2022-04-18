using System;
using CalculateAreaCircleTriangle;

namespace LibraryCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a, side b and side c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            InformationDisplay triangle = new Triangle(a, b, c);
            Console.WriteLine($"Perimeter:{triangle.GetPerimeter()}");
            triangle.DisplayInfo();//both work
            Console.WriteLine();

            Console.WriteLine("Enter radius:");
            double r = Convert.ToDouble(Console.ReadLine());
            InformationDisplay circle = new Circle(r);
            circle.DisplayInfo();

            Console.ReadKey(true);

        }
    }
}