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
using System.Text;

namespace FunPlot.Charting
{
    public abstract class Layer
    {
        protected readonly Scales.Scale _xScale;
        protected readonly Scales.Scale _yScale;

        protected Layer() { }

        protected Layer(Scales.Scale xScale, Scales.Scale yScale) { _xScale = xScale; _yScale = yScale; }

        public virtual System.Drawing.Rectangle Measure(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle) { throw new System.Exception(); }

        public abstract System.Drawing.Rectangle Render(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle);

        protected static System.Drawing.PointF[] Adjust(System.Drawing.PointF[] points, System.Drawing.Rectangle rectangle, Scales.Scale xScale, Scales.Scale yScale)
        {
            System.Drawing.PointF[] points2 = new System.Drawing.PointF[points.Length];
            for (int i = 0; i < points.Length; i++)
                points2[i] = new System.Drawing.PointF(xScale.AdjustX(rectangle.X, rectangle.Width, points[i].X), yScale.AdjustY(rectangle.Y, rectangle.Height, points[i].Y));
            return points2;
        }

        protected static System.Drawing.PointF Adjust(System.Drawing.PointF point, System.Drawing.Rectangle rectangle, Scales.Scale xScale, Scales.Scale yScale)
        {
            return new System.Drawing.PointF(xScale.AdjustX(rectangle.X, rectangle.Width, point.X), yScale.AdjustY(rectangle.Y, rectangle.Height, point.Y));
        }

        public static System.Drawing.Font CreateFont(string s)
        {
            string[] asz = s.Split(',');
            switch (asz.Length)
            {
                case 2: return new System.Drawing.Font(asz[0], float.Parse(asz[1]));
                case 3: return new System.Drawing.Font(asz[0], float.Parse(asz[1]), (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), asz[2]));
                default: throw new System.Exception();
            }
        }

        public static System.Drawing.Brush CreateBrush(string color)
        {
            return new System.Drawing.SolidBrush(CreateColor(color));
        }

        public static System.Drawing.Pen CreatePen(string color, float penWidth)
        {
            return new System.Drawing.Pen(CreateColor(color), penWidth);
        }

        public static System.Drawing.Pen CreatePen(string color, float penWidth, System.Drawing.Drawing2D.DashStyle dashStyle)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(CreateColor(color), penWidth);
            pen.DashStyle = dashStyle;
            return pen;
        }

        private static System.Drawing.Color CreateColor(string s)
        {
            System.Drawing.Color color = System.Drawing.Color.FromName(s);
            if (color.A == 0 && color.R == 0 && color.G == 0 && color.B == 0)
                return System.Drawing.ColorTranslator.FromHtml("#" + s);
            return color;
        }

    }
}
