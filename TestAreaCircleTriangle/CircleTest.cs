using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateAreaCircleTriangle;
using System;

namespace TestAreaCircleTriangle
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleTestArea()
        {
            Circle circle = new Circle(8);
            double expected = Math.PI * Math.Pow(8, 2);
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual, "Incorrect");
        }
        [TestMethod]
        public void CircleTestPerimeter()
        {
            double radius = 3;
            double expected = 2 * Math.PI * radius;
            Circle circle = new Circle(radius);
            double actual = circle.GetPerimeter();

            Assert.AreEqual(expected, actual, "Incorrect");
        }
    }
}
