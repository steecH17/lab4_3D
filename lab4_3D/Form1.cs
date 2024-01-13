using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Media3D;


namespace lab4_3D
{
    public partial class Form1 : Form
    {
        _3DGraph sin;
        _3DGraph eggBox;
        _3DGraph volcano;
        _3DGraph orchid;
        _3DGraph currentGraph;
        int gradientType = 0;
        public Form1()
        {
            InitializeComponent();

            sin = new _3DGraph(new Sinus(-10, 10, -10, 10, 0.1));
            eggBox = new _3DGraph(new EggBox(-10, 10, -10, 10, 0.1));
            volcano = new _3DGraph(new Volcano(-3, 3, -3, 3, 0.1));
            orchid = new _3DGraph(new Orchid(-2, 2, -2, 2, 0.1));

            elementHostEggBox.Child = eggBox;
            elementHostVolcano.Child = volcano;
            elementHostSin.Child = sin;
            elementHostOrchid.Child = orchid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //new comment
        }

        private void elementHostEggBox_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void elementHostOrchid_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void buttonOrchid_Click(object sender, EventArgs e)
        {
            currentGraph = orchid;
            timerColor.Interval=200;
            timerColor.Start();

        }

        private void timerColor_Tick(object sender, EventArgs e)
        {
            currentGraph.ChangeMaterial(gradientType);
            if(gradientType<=3)gradientType++;
            else gradientType=0;
        }

        private void buttonEgg_Click(object sender, EventArgs e)
        {
            currentGraph = eggBox;
            timerColor.Interval = 200;
            timerColor.Start();
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            currentGraph = sin;
            timerColor.Interval = 200;
            timerColor.Start();
        }

        private void buttonVolcano_Click(object sender, EventArgs e)
        {
            currentGraph = volcano;
            timerColor.Interval = 200;
            timerColor.Start();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("gdfg");
            //timerColor.Stop();
            //gradientType = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerColor.Stop();
            gradientType = 0;
        }
    }
}
