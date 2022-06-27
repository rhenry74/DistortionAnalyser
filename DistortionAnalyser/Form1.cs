using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        internal Scope Scope { get; private set; }
        internal Differientiator Differientiator { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            var values = new List<float>();
            Scope = new Scope();
            Scope.Signal = new Signal();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Text = Path.GetFileName(openFileDialog1.FileName);
                using (var f = openFileDialog1.OpenFile())
                {
                    var reader = new StreamReader(f);

                    while (!reader.EndOfStream)
                    {
                        var val = reader.ReadLine();
                        if (!string.IsNullOrEmpty(val))
                        {
                            if (val[0] == '#')
                            {
                                Scope.Signal.Attributes.Add(val);
                            }
                            else
                            {
                                values.Add(float.Parse(val));
                            }
                        }
                    }
                }
            }

            Scope.Signal.YPoints = values.ToArray();
            Scope.Signal.NumberOfPoints = values.Count;

            scope1.ModelDrawer = Scope;
            Scope.Setup(scope1.Width, scope1.Height, 0, scope1.Host);

            Differientiator = new Differientiator();
            differientiator.ModelDrawer = Differientiator;
            Differientiator.Setup(differientiator.Width, differientiator.Height, 0, differientiator.Host);

            hScrollBar1.Maximum = (int)(Scope.Signal.NumberOfPoints / nud_HorzComp.Value);

            GenerateReference();
        }

        private void GenerateReference()
        {
            int sin_buf_size = (int)nud_sinBufSize.Value;
            nudSinPhase.Maximum = sin_buf_size - 1;
            var sin_buf = new double[sin_buf_size];

            double ramp = 0;
            double inc = (Math.PI * 2) / sin_buf_size;

            double sin_amplitude = (double)nudSinAmp.Value;
            double sin_vert_offset = (double)nudSinVert.Value;

            for (int x = 0; x < sin_buf_size; x++)
            {
                sin_buf[x] = ((Math.Sin(ramp) / 2 + 0.5) * sin_amplitude) - sin_vert_offset; ;
                ramp = ramp + inc;
            }

            Scope.Reference = new Signal();
            Scope.Reference.YPoints = new float[Scope.Signal.NumberOfPoints];
            Scope.Reference.NumberOfPoints = Scope.Signal.NumberOfPoints;
            int sin_idx = (int)nudSinPhase.Value;
            for (int idx = 0; idx < Scope.Signal.NumberOfPoints; idx++)
            {
                Scope.Reference.YPoints[idx] = (float)sin_buf[sin_idx];
                sin_idx++;
                if (sin_idx == sin_buf_size)
                    sin_idx = 0;
            }

            Differientiator.Signal = Scope.Signal;
            Differientiator.Reference = Scope.Reference;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Scope.VerticalMultiplier = (float)numericUpDown1.Value;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Scope.HorizontalOffset = (int)e.NewValue;
            Differientiator.HorizontalOffset = (int)e.NewValue;
        }

        private void nud_sinBufSize_ValueChanged(object sender, EventArgs e)
        {
            GenerateReference();
        }

        private void nudSinAmp_ValueChanged(object sender, EventArgs e)
        {
            GenerateReference();
        }

        private void nudSinPhase_ValueChanged(object sender, EventArgs e)
        {
            GenerateReference();
        }

        private void nudDiffMult_ValueChanged(object sender, EventArgs e)
        {
            Differientiator.VerticalMultiplier = (float)nudDiffMult.Value;
        }

        private void nudSinVert_ValueChanged(object sender, EventArgs e)
        {
            GenerateReference();
        }

        private void nud_HorzComp_ValueChanged(object sender, EventArgs e)
        {
            Scope.HorizontalCompression = (int)nud_HorzComp.Value;
            Differientiator.HorizontalCompression = (int)nud_HorzComp.Value;
            hScrollBar1.Maximum = (int)(Scope.Signal.NumberOfPoints / nud_HorzComp.Value);
        }
    }
}
