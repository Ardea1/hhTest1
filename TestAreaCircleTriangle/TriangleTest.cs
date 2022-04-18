using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateAreaCircleTriangle;

namespace TestAreaCircleTriangle
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleTestArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;
            double actual = triangle.GetArea();
            Assert.AreEqual(expected, actual, "Incorrect");
        }

        [TestMethod]
        public void TriangleTestPerimeter()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 12;
            double actual = triangle.GetPerimeter();
            Assert.AreEqual(expected, actual, "Incorrect");
        }
    }
}
