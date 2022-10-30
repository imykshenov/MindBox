using System;

namespace SquareMath.Figures
{
    public class Triangle : Figure
    {
        private double SideA { get; }
        private double SideB { get; }
        private double SideC { get; }


        public Triangle(double a, double b, double c)
        {
            if (TriangleCheck(a, b, c))
            {
                SideA = a;
                SideB = b;
                SideC = c;
                Square = GetSquare();
            }
            else
            {
                throw new ArgumentException("Наибольшая сторона должна быть меньше суммы двух других сторон", nameof(Triangle));
            }
        }

        private bool TriangleCheck(double a, double b, double c)
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
