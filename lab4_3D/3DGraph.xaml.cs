using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab4_3D
{
    /// <summary>
    /// Логика взаимодействия для _3DGraph.xaml
    /// </summary>
    public partial class _3DGraph : System.Windows.Controls.UserControl
    {
        private Visualizer visualizer;
        private bool isCameraMoving = false;
        Point prevPosition;

        public _3DGraph(Function function)
        {
            InitializeComponent();

            visualizer = new Visualizer(viewportMain, function, viewCube);

            //visualizer.SetCameraDistance(10);

            visualizer.CreateAxes();
            visualizer.CreateFunction(function, 0);
        }

        public void ChangeMaterial(int gradientType)
        {
            visualizer.ChangeColorFunction(gradientType);
        }

        private void Graph_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Right)
            {
                visualizer.InitCameraMoving();
                isCameraMoving = true;
                prevPosition = e.GetPosition(this);
            }
        }

        private void Graph_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            isCameraMoving = false;
            if (e.ChangedButton == MouseButton.Right)
            {
                visualizer.EndCameraMovingPosition();
            }
        }

        private void Graph_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (isCameraMoving && e.RightButton == MouseButtonState.Pressed)
            {
                Point currentPosition = e.GetPosition(this);
                Vector delta = prevPosition - currentPosition;
                visualizer.RotateCameras(delta);
            }
        }

        private void Graph_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            visualizer.ChangeCameraDistance(e.Delta / SystemInformation.MouseWheelScrollDelta);
        }


    }
}
