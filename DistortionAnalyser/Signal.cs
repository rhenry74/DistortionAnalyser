using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistortionAnalyser
{
    internal class Signal
    {
        public float[] YPoints { get; set; }
        public int NumberOfPoints { get; set; }
        public double YMultiplier { get; set; }
        public double XInterval { get; set; }
    }
}
