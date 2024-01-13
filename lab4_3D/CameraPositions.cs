using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace lab4_3D
{
    public class CameraPositions
    {
        private double alpha;
        private double beta;
        private double distance;

        public double Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                if (value < -90) value = -90;
                if (value > 90) value = 90;
                alpha = value;

            }
        }
        public double Beta
        {
            get
            {
                return beta;
            }
            set
            {
                beta = value;
            }
        }
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                if (value < 5) value = 5;
                if (value > 40) value = 40;
                distance = value;
            }
        }

        public CameraPositions(double alpha, double beta, double distance)
        {
            Alpha = alpha;
            Beta = beta;
            Distance = distance;
        }
    }
}
