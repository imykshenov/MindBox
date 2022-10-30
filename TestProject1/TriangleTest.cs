using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareMath.Figures;

namespace Tests
{
    public class TriangleTest
    {
        [TestCase(3, 4, 3)]
        public void Init(double a, double b, double c)
        {
            var t = new Triangle(a, b, c);
        }

        [TestCase(3, 4, 55)]
        public void InitThrow(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestCase(3, 4, 3)]
        public void GetSquare(double a, double b, double c)
        {
            var t = new Triangle(a, b, c);
            var square = t.Square;
        }

        [TestCase(3, 4, 3, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(3, 4, 5.000000001, ExpectedResult = true)]
        public bool IsRightTriangle(double a, double b, double c)
        {
            // Data.
            var triangle = new Triangle(a, b, c);

            // Act.
            var isRight = triangle.IsTriangleRight();

            // Assert. 
            return isRight;
        }
    }
}
