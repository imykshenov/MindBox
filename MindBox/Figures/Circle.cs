using System;

namespace SquareMath.Figures
{
    public class Circle : Figure
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            if (radius > Accuracy)
            {
                Radius = radius;
                Square = GetSquare();
            }
            else
            {
                throw new ArgumentException("Неверно указан раудиус окружности", nameof(Circle));
            }
        }

        private double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }

    }
}
