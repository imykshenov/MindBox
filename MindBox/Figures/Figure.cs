using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareMath.Figures
{
    public abstract class Figure
    {
        public const double Accuracy = 1e-6;
        public  double Square { get; set; }
    }
}
