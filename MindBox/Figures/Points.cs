using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareMath.Figures
{
    public struct Vector
    {
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; } 
        public double Y { get; set; } 
    }
}
