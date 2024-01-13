using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace lab4_3D
{
    public abstract class Function
    {
        private double xMin;
        private double xMax;

        private double zMin;
        private double zMax;

        private double step;

        private int countX;
        private int countZ;
        public LinearGradientBrush brush;
        public Function(double xMin, double xMax, double zMin, double zMax, double step) 
        {
            this.xMin = xMin;
            this.xMax = xMax;
            this.zMin = zMin;
            this.zMax = zMax;
            this.step = step;
            countX = (int)Math.Ceiling((xMax - xMin) / step);
            countZ = (int)Math.Ceiling((zMax - zMin) / step);
        }

        public abstract double GetValueY(double x, double z);

        public List<List<Point3D>> GetPoints() 
        {
            List<List<Point3D>> points = new List<List<Point3D>>();
            int pointer = 0;
            for(double x = xMin; x <= countX; x+=step, pointer++) 
            {
                points.Add(new List<Point3D>());
                for(double z = zMin; z <= countZ; z+=step)
                {
                    points[pointer].Add(new Point3D(x, GetValueY(x, z), z));
                }
            }
            return points;
        }

        public MeshGeometry3D GetMesh()
        {
            MeshGeometry3D mesh = new MeshGeometry3D();
            List<List<Point3D>> points = GetPoints();
            

            for (int i = 0; i < countX; i++)
            {
                for (int j = 0; j < countZ; j++)
                {
                    mesh.TextureCoordinates.Add(new Point(0, points[i][j].Y));
                    mesh.Positions.Add(points[i][j]);

                    if (i > 0 && j > 0)
                    {
                        int p1 = (countX * j) + i;
                        int p2 = (countX * j) + i - 1;
                        int p3 = (countX * (j - 1)) + i - 1;
                        int p4 = (countX * (j - 1)) + i;

                        mesh.TriangleIndices.Add(p1);
                        mesh.TriangleIndices.Add(p2);
                        mesh.TriangleIndices.Add(p3);

                        mesh.TriangleIndices.Add(p1);
                        mesh.TriangleIndices.Add(p3);
                        mesh.TriangleIndices.Add(p4);

                        mesh.TriangleIndices.Add(p3);
                        mesh.TriangleIndices.Add(p2);
                        mesh.TriangleIndices.Add(p1);

                        mesh.TriangleIndices.Add(p4);
                        mesh.TriangleIndices.Add(p3);
                        mesh.TriangleIndices.Add(p1);
                    }
                }
            }

            return mesh;
        }

        public Visual3D GetVisual(int gradientType)
        {
            MeshGeometry3D mesh = GetMesh();

            brush = new LinearGradientBrush();
            brush.StartPoint = new Point(0.5, 0);
            brush.EndPoint = new Point(0.5, 1);
            switch(gradientType)
            {
                case 0:
                    {
                        brush.GradientStops.Add(new GradientStop(Colors.Blue, 0));
                        brush.GradientStops.Add(new GradientStop(Colors.Green, 0.25));
                        brush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.5));
                        brush.GradientStops.Add(new GradientStop(Colors.Orange, 0.75));
                        brush.GradientStops.Add(new GradientStop(Colors.Red, 1));
                        break;
                    }
                case 1:
                    {
                        brush.GradientStops.Add(new GradientStop(Colors.Blue, 0.25));
                        brush.GradientStops.Add(new GradientStop(Colors.Green, 0.5));
                        brush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.75));
                        brush.GradientStops.Add(new GradientStop(Colors.Orange, 1));
                        brush.GradientStops.Add(new GradientStop(Colors.Red, 0));
                        break;
                    }
                case 2:
                    {
                        brush.GradientStops.Add(new GradientStop(Colors.Blue, 0.5));
                        brush.GradientStops.Add(new GradientStop(Colors.Green, 0.75));
                        brush.GradientStops.Add(new GradientStop(Colors.Yellow, 1));
                        brush.GradientStops.Add(new GradientStop(Colors.Orange, 0));
                        brush.GradientStops.Add(new GradientStop(Colors.Red, 0.25));
                        break;
                    }
                case 3:
                    {
                        brush.GradientStops.Add(new GradientStop(Colors.Blue, 0.75));
                        brush.GradientStops.Add(new GradientStop(Colors.Green, 1));
                        brush.GradientStops.Add(new GradientStop(Colors.Yellow, 0));
                        brush.GradientStops.Add(new GradientStop(Colors.Orange, 0.25));
                        brush.GradientStops.Add(new GradientStop(Colors.Red, 0.5));
                        break;
                    }
                case 4:
                    {
                        brush.GradientStops.Add(new GradientStop(Colors.Blue, 1));
                        brush.GradientStops.Add(new GradientStop(Colors.Green, 0));
                        brush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.25));
                        brush.GradientStops.Add(new GradientStop(Colors.Orange, 0.5));
                        brush.GradientStops.Add(new GradientStop(Colors.Red, 0.75));
                        break;
                    }
            }
            
            brush.Opacity = 0.8;


            DiffuseMaterial material = new DiffuseMaterial(brush);

            GeometryModel3D model3D = new GeometryModel3D(mesh, material);

            Model3DGroup group = new Model3DGroup();
            group.Children.Add(model3D);

            ModelVisual3D visual = new ModelVisual3D();
            visual.Content = group;
            

            return visual;
        }
    }
}
