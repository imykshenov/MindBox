using System;

namespace SquareMath.Figures
{
    public class Circle
    {
        public const double Accuracy = 1e6;
        public double Radius { get; }

        public Circle(double radius)
        {
            if(radius > Accuracy)
                Radius = radius;
            else
            {
                throw new ArgumentException("Неверно указан раудиус окружности");
            }
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }

    }
}
