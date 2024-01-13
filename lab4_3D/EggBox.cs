using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_3D
{
    public class EggBox: Function
    {
        public EggBox(double xMin, double xMax, double zMin, double zMax, double step)
            : base(xMin, xMax, zMin, zMax, step) { }
        public override double GetValueY(double x, double z)
        {
            return Math.Cos(x) * Math.Sin(z);

        }
    }
}
