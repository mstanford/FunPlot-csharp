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
    public class YAxis : Layer
    {
        private readonly System.Drawing.Font _font;
        private readonly System.Drawing.Brush _fontBrush;
        private readonly float _axisTickSize;
        private readonly float _axisTickPading;
        private readonly System.Drawing.Pen _tickPen;
        private readonly Scales.Scale _scale;
        private readonly bool _primary;

        public YAxis(Collections.Map<string, string> configuration, Scales.Scale scale, bool primary)
        {
            _font = CreateFont(configuration.ContainsKey("Font") ? configuration["Font"] : "Calibri,12,Bold");
            _fontBrush = CreateBrush(configuration.ContainsKey("FontColor") ? configuration["FontColor"] : "White");
            _axisTickSize = configuration.ContainsKey("AxisTickSize") ? float.Parse(configuration["AxisTickSize"]) : 8;
            _axisTickPading = configuration.ContainsKey("AxisTickPadding") ? float.Parse(configuration["AxisTickPadding"]) : 0;
            _tickPen = CreatePen(configuration.ContainsKey("AxisColor") ? configuration["AxisColor"] : "White", configuration.ContainsKey("TickWidth") ? float.Parse(configuration["TickWidth"]) : 1);
            _scale = scale;
            _primary = primary;
        }

        public override System.Drawing.Rectangle Measure(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle)
        {
            float yAxisWidth = 0.0f;
            foreach (Scales.Label label in _scale.Labels)
                yAxisWidth = (float)System.Math.Max(yAxisWidth, graphics.MeasureString(label.Text, _font).Width);
            yAxisWidth += _axisTickSize + _axisTickPading;

            if (_primary)
                return new System.Drawing.Rectangle(rectangle.X + (int)yAxisWidth, rectangle.Y, rectangle.Width - (int)yAxisWidth, rectangle.Height);
            else
                return new System.Drawing.Rectangle(rectangle.X, rectangle.Y, rectangle.Width - (int)yAxisWidth, rectangle.Height);
        }

        public override System.Drawing.Rectangle Render(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle)
        {
            if (_primary)
            {
                float yAxisWidth = 0.0f;
                foreach (Scales.Label label in _scale.Labels)
                    yAxisWidth = (float)System.Math.Max(yAxisWidth, graphics.MeasureString(label.Text, _font).Width);
                yAxisWidth += _axisTickSize + _axisTickPading;

                graphics.DrawLine(_tickPen, rectangle.X, rectangle.Y, rectangle.X, rectangle.Y + rectangle.Height);
                foreach (Scales.Label label in _scale.Labels)
                {
                    float yy = _scale.AdjustY(rectangle.Y, rectangle.Height, label.Value);
                    graphics.DrawLine(_tickPen, rectangle.X - _axisTickSize, yy, rectangle.X, yy);
                    System.Drawing.SizeF size = graphics.MeasureString(label.Text, _font);
                    System.Drawing.StringFormat stringFormat = new System.Drawing.StringFormat();
                    stringFormat.LineAlignment = System.Drawing.StringAlignment.Center;
                    graphics.DrawString(label.Text, _font, _fontBrush, rectangle.X - yAxisWidth + (yAxisWidth - _axisTickSize - size.Width), yy, stringFormat);
                }
            }
            else
            {
                graphics.DrawLine(_tickPen, rectangle.X + rectangle.Width, rectangle.Y, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);
                foreach (Scales.Label label in _scale.Labels)
                {
                    float yy = _scale.AdjustY(rectangle.Y, rectangle.Height, label.Value);
                    graphics.DrawLine(_tickPen, rectangle.X + rectangle.Width, yy, rectangle.X + rectangle.Width + _axisTickSize, yy);
                    System.Drawing.StringFormat stringFormat = new System.Drawing.StringFormat();
                    stringFormat.LineAlignment = System.Drawing.StringAlignment.Center;
                    graphics.DrawString(label.Text, _font, _fontBrush, rectangle.X + rectangle.Width + _axisTickSize + 1, yy, stringFormat);
                }
            }
            return rectangle;
        }

    }
}
