using System;

namespace CalculateAreaCircleTriangle
{
    public class Circle: InformationDisplay
    {
        public double radius
        {
            get;
            set;
        }

        public Circle(double r)
        {
            radius = r;
        }
        /// <summary>
        /// Вычисление площади круга по радиусу.
        /// Calculating the area of a circle from a radius
        /// </summary>
        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(radius, 2);
            return Area;
        }

        public override double GetPerimeter()
        {
            Perimeter = 2 * Math.PI * radius;
            return Perimeter;
        }
    }
}
