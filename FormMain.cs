// ------------------------------------------------------------------------
// 
// This is free and unencumbered software released into the public domain.
// 
// Anyone is free to copy, modify, publish, use, compile, sell, or
// distribute this software, either in source code form or as a compiled
// binary, for any purpose, commercial or non-commercial, and by any
// means.
// 
// In jurisdictions that recognize copyright laws, the author or authors
// of this software dedicate any and all copyright interest in the
// software to the public domain. We make this dedication for the benefit
// of the public at large and to the detriment of our heirs and
// successors. We intend this dedication to be an overt act of
// relinquishment in perpetuity of all present and future rights to this
// software under copyright law.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// 
// For more information, please refer to <http://unlicense.org/>
// 
// ------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FunPlot
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            CreateCharts();
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            CreateCharts();
        }

        private void CreateCharts()
        {
            int xmin1 = trackBarXMin1.Value;
            int xmax1 = trackBarXMax1.Value;
            int ymin1 = trackBarYMin1.Value;
            int ymax1 = trackBarYMax1.Value;

            double pmax2 = (double)trackBarPMax2.Value / (double)(trackBarPMax2.Maximum - trackBarPMax2.Minimum);
            double pmin2 = (double)trackBarPMin2.Value / (double)(trackBarPMin2.Maximum - trackBarPMin2.Minimum);
            double pscale2 = 2.0 * ((double)trackBarPScale2.Value / (double)(trackBarPScale2.Maximum - trackBarPScale2.Minimum));

            if (xmax1 <= xmin1 || ymax1 <= ymin1 || pscale2 == 0.0)
            {
                panel1.Chart = null;
                panel2.Chart = null;
                panel1.Invalidate();
                panel2.Invalidate();
                return;
            }



            double a1 = trackBarA1.Value;
            double b1 = trackBarB1.Value;
            int c1 = trackBarC1.Value;

            if (a1 < 0)
                a1 = 1.0 / System.Math.Pow(2, (-a1 / 2.0));
            else
                a1 = System.Math.Pow(2, (a1 / 2.0));
            double amin = 1;
            double amax = System.Math.Pow(a1, xmax1 - xmin1);

            b1 = System.Math.Tan((System.Math.PI / 2.0) * (double)(b1 - trackBarB1.Minimum) / (double)(trackBarB1.Maximum - trackBarB1.Minimum));

            List<PointF> points1 = new List<PointF>();
            List<PointF> points2 = new List<PointF>();
            for (float i = xmin1; i <= xmax1; i += ((xmax1 - xmin1) / 100.0f))
            {
                points1.Add(new PointF(i, i));

                double y = i;
                if (a1 != 1.0)
                    y = ((((System.Math.Pow(a1, i - xmin1) - amin) / (amax - amin)) * (xmax1 - xmin1)) + xmin1);
                y = (y * b1) + c1;
                y = System.Math.Max(y, ymin1);
                y = System.Math.Min(y, ymax1);
                points2.Add(new PointF(i, (float)y));
            }

            Collections.Map<string, string> configuration = new Collections.Map<string, string>();
            Charting.Scales.LinearScale xScale = Charting.Scales.LinearScale.X(configuration, points1.ToArray(), points2.ToArray());
            Charting.Scales.LinearScale yScale = Charting.Scales.LinearScale.Y(configuration, points1.ToArray(), points2.ToArray());
            List<Charting.Layer> layers = new List<Charting.Layer>();
            layers.Add(new Charting.Frame(new Charting.XAxis(configuration, xScale, true), new Charting.YAxis(configuration, yScale, true)));
            layers.Add(new Charting.LineChart(configuration, "Silver", new PointF[] { new PointF(0, (float)yScale.Min), new PointF(0, (float)yScale.Max) }, xScale, yScale));
            layers.Add(new Charting.LineChart(configuration, "Silver", new PointF[] { new PointF((float)xScale.Min, 0), new PointF((float)xScale.Max, 0) }, xScale, yScale));
            layers.Add(new Charting.LineChart(configuration, "LightSkyBlue", points1.ToArray(), xScale, yScale));
            layers.Add(new Charting.LineChart(configuration, "DodgerBlue", points2.ToArray(), xScale, yScale));
            panel1.Chart = new Charting.Chart(configuration, "Linear", layers.ToArray());



            double mu = 0.0;
            double sigma = 1.0;
            double maxp = (1.0 / System.Math.Sqrt(2.0 * System.Math.PI * sigma * sigma)) * System.Math.Exp(((0 - mu) * (0 - mu)) / (-2.0 * sigma * sigma));

            points1 = new List<PointF>();
            points2 = new List<PointF>();
            for (float i = xmin1; i <= xmax1; i += ((xmax1 - xmin1) / 100.0f))
            {
                double y1 = i;
                if (a1 != 1.0)
                    y1 = ((((System.Math.Pow(a1, i - xmin1) - amin) / (amax - amin)) * (xmax1 - xmin1)) + xmin1);
                y1 = (y1 * b1) + c1;
                y1 = System.Math.Max(y1, ymin1);
                y1 = System.Math.Min(y1, ymax1);

                double p = (1.0 / System.Math.Sqrt(2.0 * System.Math.PI * sigma * sigma)) * System.Math.Exp(((y1 - mu) * (y1 - mu)) / (-2.0 * sigma * sigma));
                p /= maxp;
                p *= pscale2;
                p = System.Math.Max(p, pmin2);
                p = System.Math.Min(p, pmax2);

                points1.Add(new PointF(i, (float)p));

                points2.Add(new PointF(i, (float)p));
            }

            configuration = new Collections.Map<string, string>();
            xScale = Charting.Scales.LinearScale.X(configuration, points1.ToArray(), points2.ToArray());
            yScale = Charting.Scales.LinearScale.Y(configuration, 1.0, 0.0);
            layers = new List<Charting.Layer>();
            layers.Add(new Charting.Frame(new Charting.XAxis(configuration, xScale, true), new Charting.YAxis(configuration, yScale, true)));
            layers.Add(new Charting.LineChart(configuration, "Silver", new PointF[] { new PointF(0, (float)yScale.Min), new PointF(0, (float)yScale.Max) }, xScale, yScale));
            layers.Add(new Charting.LineChart(configuration, "LightSkyBlue", points1.ToArray(), xScale, yScale));
            layers.Add(new Charting.LineChart(configuration, "DodgerBlue", points2.ToArray(), xScale, yScale));
            panel2.Chart = new Charting.Chart(configuration, "Gaussian", layers.ToArray());



            panel1.Invalidate();
            panel2.Invalidate();
        }

        public class DoubleBufferedPanel : Panel
        {
            public Charting.Chart Chart;

            public DoubleBufferedPanel()
            {
                DoubleBuffered = true;
                ResizeRedraw = true;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                if (Chart != null)
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    Chart.Render(e.Graphics, 0, 0, Width, Height);
                }
            }
        }

    }
}