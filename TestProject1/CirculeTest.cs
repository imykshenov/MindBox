using SquareMath.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class CirculeTest
    {
        [TestCase(3)]
        public void Init(double a)
        {
            var circle = new Circle(a);
        }

        [TestCase(0)]
        public void InitThrow(double a)
        {
            Assert.Catch<ArgumentException>(() => new Circle(a));
        }

        [TestCase(3)]
        public void GetSquare(double a)
        {
            var c = new Circle(a);
            var square = c.GetSquare();
        }
    }
}
