using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistortionAnalyser
{
    internal class Differientiator : IModelDrawer
    {
        public Signal Signal { get; set; }
        public Signal Reference { get; set; }

        public float VerticalMultiplier { get; set; } = 1;
        public int HorizontalOffset { get; internal set; }
        public int HorizontalCompression { get; internal set; } = 1;

        private Color SignalColor;
        private Pen SignalPen;

        public bool DrawOn(Graphics g, IHost host, int elapsed)
        {
            var signal = SubtractSignals();

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
                    g.DrawLine(SignalPen, new PointF(x, y), new PointF(nextX, nextY));
                    index++;
                }
                x++;

                if (posPeak < signal.YPoints[index])
                    posPeak = signal.YPoints[index];
                if (negPeak > signal.YPoints[index])
                    negPeak = signal.YPoints[index];
            }
            
            host.SetStatictic("Positive Peak", posPeak);
            host.SetStatictic("Negative Peak", negPeak);
            host.SetStatictic("Peak to Peak", Math.Abs(negPeak) + posPeak);
            if (Signal.PeakToPeakCalc != 0)
            {
                host.SetStatictic("Distortion%", ((Math.Abs(negPeak) + posPeak) / Signal.PeakToPeakCalc) * 100);
            }

            return true;
        }

        private Signal SubtractSignals()
        {
            var dif = new List<float>();
            for(var x = 0; x < Signal.NumberOfPoints; x++)
            {
                dif.Add(Signal.YPoints[x] - Reference.YPoints[x]);
            }
            var signal = new Signal();
            signal.YPoints = dif.ToArray();
            signal.NumberOfPoints = dif.Count;
            return signal;
        }

        public void Setup(int w, int h, int count, IHost host = null)
        {
            SignalColor = Color.FromArgb(255, 230, 56, 255);
            SignalPen = new Pen(SignalColor, 1);
            
        }
    }
}
