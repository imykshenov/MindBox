using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareMath.Figures;

namespace Tests
{
    public class PolygonsTest
    {

        [Test]
        public void Triangle()
        {
            var polygon = new Polygon(
                new Vector(0, 0),
                new Vector(4, 0),
                new Vector(0, 5));

            Assert.AreEqual(10, polygon.Square);
        }


        [Test]
        public void Rectangle()
        {
            var polygon = new Polygon(
                new Vector(0, 0),
                new Vector(4, 0),
                new Vector(4, 4),
                new Vector(0, 4));

            Assert.AreEqual(16, polygon.Square);
        }


        [Test]
        public void Point5()
        {
            var polygon = new Polygon(
                new Vector(0, 0),
                new Vector(4, 0),
                new Vector(4, 4),
                new Vector(2, 3),
                new Vector(0, 4));

            Assert.AreEqual(14, polygon.Square);
        }

        [Test]
        public void Point6()
        {
            var polygon = new Polygon(
                new Vector(0, 0),
                new Vector(2, 2),
                new Vector(4, 0),
                new Vector(4, 4),
                new Vector(2, 3),
                new Vector(0, 4));

            Assert.AreEqual(10, polygon.Square);
        }

    }
}
