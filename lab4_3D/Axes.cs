using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Media3D;


namespace lab4_3D
{
    public class Axes
    {
        private double length;
        private double width;
        public Axes(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        private MeshGeometry3D GetX(int sign)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(0, width / 2, width / 2));
            mesh.Positions.Add(new Point3D(sign*length, width / 2, width / 2));
            mesh.Positions.Add(new Point3D(sign*length, -width / 2, width / 2));
            mesh.Positions.Add(new Point3D(0, -width / 2, width / 2));
            mesh.Positions.Add(new Point3D(0, width / 2, -width / 2));
            mesh.Positions.Add(new Point3D(sign * length, width / 2, -width / 2));
            mesh.Positions.Add(new Point3D(sign * length, -width / 2, -width / 2));
            mesh.Positions.Add(new Point3D(0, -width / 2, -width / 2));

            if(sign == 1) return AddTriangleIndices(mesh);
            else return AddTriangleIndicesMinus(mesh);


        }
        private MeshGeometry3D GetY(int sign)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(width / 2, 0, width / 2));
            mesh.Positions.Add(new Point3D(width / 2, sign*length, width / 2));
            mesh.Positions.Add(new Point3D(width / 2, sign * length, -width / 2));
            mesh.Positions.Add(new Point3D(width / 2, 0, -width / 2));
            mesh.Positions.Add(new Point3D(-width / 2, 0, width / 2));
            mesh.Positions.Add(new Point3D(-width / 2, sign * length, width / 2));
            mesh.Positions.Add(new Point3D(-width / 2, sign * length, -width / 2));
            mesh.Positions.Add(new Point3D(-width / 2, 0, -width / 2));

            if (sign == 1) return AddTriangleIndices(mesh);
            else return AddTriangleIndicesMinus(mesh);
        }
        private MeshGeometry3D GetZ(int sign)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(width / 2, width / 2, 0));
            mesh.Positions.Add(new Point3D(width / 2, width / 2, sign * length));
            mesh.Positions.Add(new Point3D(-width / 2, width / 2, sign * length));
            mesh.Positions.Add(new Point3D(-width / 2, width / 2, 0));
            mesh.Positions.Add(new Point3D(width / 2, -width / 2, 0));
            mesh.Positions.Add(new Point3D(width / 2, -width / 2, sign * length));
            mesh.Positions.Add(new Point3D(-width / 2, -width / 2, sign * length));
            mesh.Positions.Add(new Point3D(-width / 2, -width / 2, 0));

            if (sign == 1) return AddTriangleIndices(mesh);
            else return AddTriangleIndicesMinus(mesh);
        }
        private MeshGeometry3D AddTriangleIndices(MeshGeometry3D mesh)
        {
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(3);

            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(7);

            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(6);

            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(2);

            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(1);

            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(7);

            return mesh;
        }

        private MeshGeometry3D AddTriangleIndicesMinus(MeshGeometry3D mesh)
        {
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);

            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(3);

            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(7);

            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6);

            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);

            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(6);

            return mesh;
        }
        public ModelVisual3D GetVisual()
        {
            MeshGeometry3D meshX = GetX(1);
            MeshGeometry3D meshY = GetY(1);
            MeshGeometry3D meshZ = GetZ(1);

            MeshGeometry3D meshXMinus = GetX(-1);
            MeshGeometry3D meshYMinus = GetY(-1);
            MeshGeometry3D meshZMinus = GetZ(-1);

            DiffuseMaterial materialX = new DiffuseMaterial(Brushes.Red);
            DiffuseMaterial materialY = new DiffuseMaterial(Brushes.Green);
            DiffuseMaterial materialZ = new DiffuseMaterial(Brushes.Blue);

            GeometryModel3D geometryX = new GeometryModel3D(meshX, materialX);
            GeometryModel3D geometryY = new GeometryModel3D(meshY, materialY);
            GeometryModel3D geometryZ = new GeometryModel3D(meshZ, materialZ);

            GeometryModel3D geometryXMinus = new GeometryModel3D(meshXMinus, materialX);
            GeometryModel3D geometryYMinus = new GeometryModel3D(meshYMinus, materialY);
            GeometryModel3D geometryZMinus = new GeometryModel3D(meshZMinus, materialZ);

            Model3DGroup group = new Model3DGroup();
            group.Children.Add(geometryX);
            group.Children.Add(geometryY);
            group.Children.Add(geometryZ);
            group.Children.Add(geometryXMinus);
            group.Children.Add(geometryYMinus);
            group.Children.Add(geometryZMinus);

            ModelVisual3D visual = new ModelVisual3D();
            visual.Content = group;

            return visual;
        }
    }
}
