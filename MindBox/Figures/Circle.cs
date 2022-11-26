using System;

namespace SquareMath.Figures
{
    public class Circle : Figure , IFigure
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius > Accuracy)
            {
                Radius = radius;
            }
            else
            {
                throw new ArgumentException("Неверно указан раудиус окружности", nameof(Circle));
            }
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
