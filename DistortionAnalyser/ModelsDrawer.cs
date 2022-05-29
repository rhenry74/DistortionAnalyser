using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistortionAnalyser
{
    internal class ModelsDrawer: IModelDrawer
    {
        public IList<IModelDrawer> ModelDrawers { get; set; }

        public bool DrawOn(Graphics g, IHost host, int elapsed)
        {
            foreach(var drawer in ModelDrawers)
            {
                if (!drawer.DrawOn(g,host,elapsed))
                    return false;   
            }
            return true;
        }

        public void Setup(int w, int h, int count, IHost host = null)
        {
            foreach (var drawer in ModelDrawers)
            {
                drawer.Setup(w, h, count, host);   
            }
        }
    }
}
