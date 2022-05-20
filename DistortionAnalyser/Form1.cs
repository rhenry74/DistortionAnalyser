using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistortionAnalyser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var display = scope1;

            var scope = new Scope();
            scope.Signal = new Signal();
            scope.Signal.YPoints = new float[96];
            scope.Signal.NumberOfPoints = 96;
            for (int a = 0; a < 45; a++)
            {
                scope.Signal.YPoints[a] = a;
            }
            IModelDrawer drawer = scope;
            
            display.ModelDrawer = drawer;
            drawer.Setup(scope1.Width, scope1.Height, 0, display.Host);
            
        }

       
    }
}
