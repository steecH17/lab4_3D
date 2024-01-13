using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_3D
{
    public class Sphere:Function
    {
        public Sphere(double xMin, double xMax, double zMin, double zMax, double step)
            : base(xMin, xMax, zMin, zMax, step) { }
        public override double GetValueY(double x, double z)
        {
            return Math.Cos(x*x + z*z)/(1 + x*x + z*z);
            //return Math.Cos(x * x + z * z);
            //return Math.Sin(x * z);
        }
    }
}
