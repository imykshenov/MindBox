using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace SquareMath.Figures
{
    public class Polygon : Figure
    {
        public List<Vector> Points { get; set; }
        public Polygon(params Vector[] points)
        {
            Points = points.ToList();
            Square = GetSquare();

            var a = "";
        }

        /// <summary>
        /// Формула площади Гаусса для n-угольных фигур(даже треугольник)
        /// </summary>
        private double GetSquare()
        {
            double area = 0;
            for (int i = 0; i < Points.Count; i++)
            {
                int j = (i + 1) % Points.Count;
                var a = Points[i];
                var b = Points[j];

                area += a.X * b.Y - a.Y * b.X;
            }
            return Math.Abs(area) / 2;
        }

    }

}
