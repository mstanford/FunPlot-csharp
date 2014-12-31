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
    public class XAxis : Layer
    {
        private readonly System.Drawing.Font _font;
        private readonly System.Drawing.Brush _fontBrush;
        private readonly float _axisTickSize;
        private readonly float _axisTickPading;
        private readonly System.Drawing.Pen _tickPen;
        private readonly float _xAxisAngle;
        private readonly Scales.Scale _scale;
        private readonly bool _primary;

        public XAxis(Collections.Map<string, string> configuration, Scales.Scale scale, bool primary)
        {
            _font = CreateFont(configuration.ContainsKey("Font") ? configuration["Font"] : "Calibri,12,Bold");
            _fontBrush = CreateBrush(configuration.ContainsKey("FontColor") ? configuration["FontColor"] : "White");
            _axisTickSize = configuration.ContainsKey("AxisTickSize") ? float.Parse(configuration["AxisTickSize"]) : 8;
            _axisTickPading = configuration.ContainsKey("AxisTickPadding") ? float.Parse(configuration["AxisTickPadding"]) : 0;
            _tickPen = CreatePen(configuration.ContainsKey("AxisColor") ? configuration["AxisColor"] : "White", configuration.ContainsKey("TickWidth") ? float.Parse(configuration["TickWidth"]) : 1);
            _xAxisAngle = configuration.ContainsKey("XAxisAngle") ? float.Parse(configuration["XAxisAngle"]) : 30;
            _scale = scale;
            _primary = primary;
        }

        public override System.Drawing.Rectangle Measure(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle)
        {
            float xAxisHeight = 0.0f;
            foreach (Scales.Label label in _scale.Labels)
                xAxisHeight = (float)System.Math.Max(xAxisHeight, System.Math.Sin(System.Math.PI * _xAxisAngle / 180.0) * graphics.MeasureString(label.Text, _font).Width);
            xAxisHeight += _axisTickSize + _axisTickPading;

            if (_primary)
                return new System.Drawing.Rectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height - (int)xAxisHeight);
            else
                return new System.Drawing.Rectangle(rectangle.X, rectangle.Y + (int)xAxisHeight, rectangle.Width, rectangle.Height - (int)xAxisHeight);
        }

        public override System.Drawing.Rectangle Render(System.Drawing.Graphics graphics, System.Drawing.Rectangle rectangle)
        {
            if (_primary)
            {
                graphics.DrawLine(_tickPen, rectangle.X, rectangle.Y + rectangle.Height, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);
                foreach (Scales.Label label in _scale.Labels)
                {
                    float xx = _scale.AdjustX(rectangle.X, rectangle.Width, label.Value);
                    graphics.DrawLine(_tickPen, xx, rectangle.Y + rectangle.Height, xx, rectangle.Y + rectangle.Height + _axisTickSize);
                    graphics.TranslateTransform(xx, rectangle.Y + rectangle.Height);
                    graphics.RotateTransform(-_xAxisAngle);
                    System.Drawing.SizeF size = graphics.MeasureString(label.Text, _font);
                    System.Drawing.StringFormat stringFormat = new System.Drawing.StringFormat();
                    stringFormat.LineAlignment = System.Drawing.StringAlignment.Center;
                    graphics.DrawString(label.Text, _font, _fontBrush, -size.Width, (float)(_axisTickSize / System.Math.Sin(System.Math.PI * _xAxisAngle / 180.0)), stringFormat);
                    graphics.ResetTransform();
                }
            }
            else
            {
                graphics.DrawLine(_tickPen, rectangle.X, rectangle.Y, rectangle.X + rectangle.Width, rectangle.Y);
                foreach (Scales.Label label in _scale.Labels)
                {
                    float xx = _scale.AdjustX(rectangle.X, rectangle.Width, label.Value);
                    graphics.DrawLine(_tickPen, xx, rectangle.Y, xx, rectangle.Y - _axisTickSize);
                    graphics.TranslateTransform(xx, rectangle.Y - _axisTickSize);
                    graphics.RotateTransform(_xAxisAngle);
                    System.Drawing.SizeF size = graphics.MeasureString(label.Text, _font);
                    System.Drawing.StringFormat stringFormat = new System.Drawing.StringFormat();
                    stringFormat.LineAlignment = System.Drawing.StringAlignment.Center;
                    graphics.DrawString(label.Text, _font, _fontBrush, -size.Width, -size.Height + (float)(_axisTickSize / System.Math.Sin(System.Math.PI * _xAxisAngle / 180.0)), stringFormat);
                    graphics.ResetTransform();
                }
            }
            return rectangle;
        }

    }
}
