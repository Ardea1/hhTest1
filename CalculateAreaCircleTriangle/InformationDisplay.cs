using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaCircleTriangle
{
    /// <summary>
    /// Класс для объявления свойств и отображения в консоли площади и периметра.
    /// Class for declaring properties and displaying area and perimeter in the console
    /// </summary>
    public class InformationDisplay
    {
        public double Area
        {   
            get;
            set;
        }

        public double Perimeter
        {
            get;
            set;
        }
        public virtual double GetArea()
        {
            return Area;
        }

        public virtual double GetPerimeter()
        {
            return Perimeter;
        }

        /// <summary>
        /// Метод для отображения в консоли площади и периметра.
        /// Method for displaying the area and perimeter in the console
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Area: {Math.Round(GetArea(), 6)}");
            Console.WriteLine($"Perimeter: {Math.Round(GetPerimeter(), 6)}");
        }
    }
}
