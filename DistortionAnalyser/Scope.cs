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
        public Signal Reference { get; set; }

        public float VerticalMultiplier { get; set; } = 1;
        public int HorizontalOffset { get; internal set; }
        public int HorizontalCompression { get; internal set; } = 1;

        private Color SignalColor;
        private Pen SignalPen;
        private Color ReferenceColor;
        private Pen ReferencePen;

        public bool DrawOn(Graphics g, IHost host, int elapsed)
        {
            RenderSignal(Signal, g, host, SignalPen, true);
            RenderSignal(Reference, g, host, ReferencePen);
            return true;
        }

        private void RenderSignal(Signal signal, Graphics g, IHost host, Pen pen, bool statPeaks = false)
        {
            float yOffset = host.Height / 2;
            int index = HorizontalOffset;
            int x = 0;

            float posPeak = 0;
            float negPeak = 0;

            while (x < (host.Width + HorizontalOffset) && index < signal.NumberOfPoints - 1)
            {
                int nextX = x + 1;
                for (var compression = 0; compression < HorizontalCompression; compression++)
                {                    
                    int nextIndex = index + 1;
                    float y = yOffset - (signal.YPoints[index] * VerticalMultiplier);
                    float nextY = yOffset - (signal.YPoints[nextIndex] * VerticalMultiplier);
                    g.DrawLine(pen, new PointF(x, y), new PointF(nextX, nextY));
                    index++;                    
                }
                x++;

                if (posPeak < signal.YPoints[index])
                    posPeak = signal.YPoints[index];
                if (negPeak > signal.YPoints[index])
                    negPeak = signal.YPoints[index];
            }

            if (statPeaks)
            {
                host.SetStatictic("Positive Peak", posPeak);
                host.SetStatictic("Negative Peak", negPeak);
                host.SetStatictic("Peak to Peak", Math.Abs(negPeak) + posPeak);
                Signal.PeakToPeakCalc = Math.Abs(negPeak) + posPeak;
            }
        }

        public void Setup(int w, int h, int count, IHost host = null)
        {
            SignalColor = Color.FromArgb(180, 30, 230, 255);
            SignalPen = new Pen(SignalColor, 1);
            ReferenceColor = Color.FromArgb(180, 240, 230, 30);
            ReferencePen = new Pen(ReferenceColor, 1);
        }
    }
}
