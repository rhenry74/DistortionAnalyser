using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistortionAnalyser
{
    internal class Scope : IModelDrawer
    {
        public Signal Signal { get; set; }

        private Color Color;
        private Pen Pen;

        public bool DrawOn(Graphics g, IHost host, int elapsed)
        {
            float yOffset = host.Height / 2;
            float x = 0;
            
            while(x < host.Width && x < Signal.NumberOfPoints-1)
            {
                float nextX = x + 1;
                float y = yOffset - Signal.YPoints[(int)x];
                float nextY = yOffset - Signal.YPoints[(int)nextX];
                g.DrawLine(Pen, new PointF(x, y), new PointF(nextX, nextY));
                x = x + 1;
            }
            return true;
        }

        public void Setup(int w, int h, int count, IHost host = null)
        {
            Color = Color.FromArgb(180, 240, 230, 255);
            Pen = new Pen(Color, 1);
        }
    }
}
