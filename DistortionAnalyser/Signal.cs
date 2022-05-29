using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistortionAnalyser
{
    internal class Signal
    {
        public List<string> Attributes { get; internal set; }
        public float[] YPoints { get; set; }
        public int NumberOfPoints { get; set; }
        public double PeakToPeakCalc { get; set; }

        public Signal()
        {
            Attributes = new List<string>();
        }
    }
}
