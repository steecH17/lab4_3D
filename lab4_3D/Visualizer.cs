using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace lab4_3D
{
    public class Visualizer
    {
        private Viewport3D viewportMain;
        private PerspectiveCamera camera;
        private CameraPositions cameraPosition;

        private CameraPositions cameraStartMovingPosition;
        private CameraPositions cameraEndMovingPosition;
        readonly double cameraRotatingSpeed = 0.4;
        readonly double cameraDistanceSpeed = 1.2;
        Function function;
        LinearGradientBrush brush;

        Viewport3D viewportCube;
        private PerspectiveCamera viewCubeCamera;
        private CameraPositions cameraCubePosition;

        public Visualizer(Viewport3D viewportMain, Function function, Viewport3D viewportCube) 
        {
            this.viewportMain = viewportMain;
            this.viewportCube = viewportCube;

            CameraInit();
            LightsInit();
            this.function = function;
        }

        private void CameraInit()
        {
            camera = new PerspectiveCamera();

            camera.FieldOfView = 45;
            viewportMain.Camera = camera;

            viewCubeCamera = new PerspectiveCamera();
            viewCubeCamera.FieldOfView = 45;
            viewportCube.Camera = viewCubeCamera;


            cameraPosition = new CameraPositions(-45, -45, 10);
            cameraCubePosition = new CameraPositions(-45, -45, 5);
            UpdateCameraPosition(-45, -45, 10, camera);
            UpdateCameraPosition(-45, -45, 5, viewCubeCamera);
        }

        private void LightsInit()
        {
            Model3DGroup lights = new Model3DGroup();
            AmbientLight ambientLight = new AmbientLight(Colors.White);

            lights.Children.Add(ambientLight);
            ModelVisual3D modelVisualLight = new ModelVisual3D();
            modelVisualLight.Content = lights;

            viewportMain.Children.Add(modelVisualLight);

            ModelVisual3D viewCubeLightsVisual = new ModelVisual3D();
            viewCubeLightsVisual.Content = lights;
            viewportCube.Children.Add(viewCubeLightsVisual);
        }

        public void CreateAxes()
        {
            Axes axes = new Axes(100, 0.01);

            viewportMain.Children.Add(axes.GetVisual());
            viewportMain.InvalidateVisual();
        }

        public void CreateFunction(Function function, int gradientType)
        {
            viewportMain.Children.Add(function.GetVisual(gradientType));
            viewportMain.InvalidateVisual();
            brush = function.brush;
        }
        public void SetCameraDistance(double distance)
        {
            cameraPosition.Distance = distance;
        }

        public void InitCameraMoving()
        {
            double alpha = cameraPosition.Alpha;
            double beta = cameraPosition.Beta;
            double distance = cameraPosition.Distance;
            cameraStartMovingPosition = new CameraPositions(alpha, beta, distance);
        }

        public void EndCameraMovingPosition()
        {
            double alpha = cameraPosition.Alpha;
            double beta = cameraPosition.Beta;
            double distance = cameraPosition.Distance;
            cameraEndMovingPosition = new CameraPositions(alpha, beta, distance);
        }
        private void ChangeCamera()
        {
            camera = new PerspectiveCamera();

            viewportMain.Camera = camera;


            cameraPosition = new CameraPositions(cameraEndMovingPosition.Alpha, cameraEndMovingPosition.Beta, cameraEndMovingPosition.Distance);
            UpdateCameraPosition(cameraEndMovingPosition.Alpha, cameraEndMovingPosition.Beta, cameraEndMovingPosition.Distance, camera);
        }
        public void RotateCameras(Vector delta)
        {
            double newAlpha = cameraStartMovingPosition.Alpha + delta.Y * cameraRotatingSpeed;
            double newBeta = cameraStartMovingPosition.Beta + delta.X * cameraRotatingSpeed;

            cameraPosition.Alpha = newAlpha;
            UpdateCameraPosition(cameraPosition.Alpha, cameraPosition.Beta, cameraPosition.Distance, camera);
            cameraPosition.Beta = newBeta;
            UpdateCameraPosition(cameraPosition.Alpha, cameraPosition.Beta, cameraPosition.Distance, camera);

            cameraCubePosition.Alpha = newAlpha;
            UpdateCameraPosition(cameraPosition.Alpha, cameraPosition.Beta, 5, viewCubeCamera);
            cameraCubePosition.Beta = newBeta;
            UpdateCameraPosition(cameraPosition.Alpha, cameraPosition.Beta, 5, viewCubeCamera);



        }
        public void ChangeCameraDistance(int delta)
        {
            cameraPosition.Distance -= delta * cameraDistanceSpeed;
            UpdateCameraPosition(cameraPosition.Alpha, cameraPosition.Beta, cameraPosition.Distance, camera);
        }
        
        public void UpdateCameraPosition(double alpha, double beta, double distance, PerspectiveCamera camera)
        {
            alpha *= -Math.PI / 180;
            beta *= -Math.PI / 180;

            Point3D start = new Point3D(distance, 0, 0);
            Point3D position = new Point3D();

            // XOY
            position.X = start.X * Math.Cos(alpha) - start.Y * Math.Sin(alpha);
            position.Y = start.X * Math.Sin(alpha) + start.Y * Math.Cos(alpha);

            start = position;

            // XOZ
            position.X = start.X * Math.Cos(beta) - start.Z * Math.Sin(beta);
            position.Z = start.X * Math.Sin(beta) + start.Z * Math.Cos(beta);

            camera.Position = position;
            CalculateLookDirection(camera);
            //CalculateUpDirection(camera);
        }
        private void CalculateLookDirection(PerspectiveCamera camera)
        {
            Vector3D direction = new Point3D(0, 0, 0) - camera.Position;
            direction.Normalize();
            camera.LookDirection = direction;
        }
        public void ChangeColorFunction(int gradientType)
        {
            
            brush.GradientStops.Clear();
            //foreach(GradientStop gradient in brush.GradientStops)
            //{
            //    gradient.Offset += 0.1;
            //}

            switch (gradientType)
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
        }
        private void CalculateUpDirection(PerspectiveCamera camera)
        {
            Vector3D upDirection = new Vector3D(0, 1, 0);
            Vector3D right = Vector3D.CrossProduct(camera.LookDirection, upDirection);
            upDirection = Vector3D.CrossProduct(right, camera.LookDirection);
            upDirection.Normalize();
        }
    }
}
