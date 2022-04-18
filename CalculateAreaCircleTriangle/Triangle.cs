using System;

namespace CalculateAreaCircleTriangle
{
    public class Triangle: InformationDisplay
    {
        // Стороны треугольника
        // Sides of a triangle
        public double A
        {
            get;
            set;
        }
        public double B
        {
            get;
            set;
        }
        public double C
        {
            get;
            set;
        }
        /// <summary>
        /// Узнаём, является ли треугольник прямоугольным.
        /// Find out if a triangle is a right triangle
        /// </summary>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            if (C == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(A, 2))
                || A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2)))
            {
                Console.WriteLine("Triangle is right!");
            }
        }

        /// <summary>
        /// Находим периметр треугольника.
        /// Calculate the perimeter of a triangle
        /// </summary>
        public override double GetPerimeter()
        {
            Perimeter = A + B + C;
            return Perimeter;
        }
        /// <summary>
        /// Вычисление площади треугольника по трём сторонам.
        /// Calculating the area of a triangle with 3 sides given
        /// </summary>
        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return Area;
        }
    }
}
