using System;

namespace SquareMath.Figures
{
    public class Triangle
    {
        public const double Accuracy = 1e6;
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private bool _isTriangleRight { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (TriangleCheck(a, b, c))
            {
                SideA = a;
                SideB = b;
                SideC = c;
                _isTriangleRight = IsTriangleRight();
            }
            else
            {
                throw new ArgumentException("Наибольшая сторона должна быть меньше суммы двух других сторон");
            }
        }

        public bool TriangleCheck(double a, double b, double c)
        {
            return (a < b + c) && (b < a + c) &&(c < b + a);
        }

        public bool IsTriangleRight()
        {
            var aa = Math.Sqrt(SideB * SideB + SideC * SideC);
            var bb = Math.Sqrt(SideA * SideA + SideC * SideC);
            var cc = Math.Sqrt(SideA * SideA + SideB * SideB);
            return (Math.Abs(SideA - aa) < Accuracy) || Math.Abs(SideB - bb) < Accuracy || Math.Abs(SideC - cc) < Accuracy;
        }

        public double GetSquare()
        {
            var halfPerimeter = (SideA + SideB + SideC)/2d;
            var square = Math.Sqrt((halfPerimeter * (halfPerimeter - SideA)*(halfPerimeter - SideB)*(halfPerimeter - SideC)));
            return square;
        }

    }
}
