﻿using System.Drawing;
using System.Windows.Forms;

namespace DistortionAnalyser
{
    public interface IModelDrawer
    {
        bool DrawOn(Graphics g, IHost host, int elapsed);
        void Setup(int w, int h, int count, IHost host = null);
    }
}