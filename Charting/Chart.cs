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
    public class Chart
    {
        private readonly bool _debug;
        private readonly System.Drawing.Brush _backBrush;
        private readonly float _leftMargin;
        private readonly float _rightMargin;
        private readonly float _topMargin;
        private readonly float _bottomMargin;
        private readonly Title _title;
        private readonly Layer[] _layers;

        public Chart(Collections.Map<string, string> configuration, string title, params Layer[] layers)
        {
            _debug = configuration.ContainsKey("Debug") ? bool.Parse(configuration["Debug"]) : false;
            _backBrush = Layer.CreateBrush(configuration.ContainsKey("BackColor") ? configuration["BackColor"] : "Black");
            _leftMargin = configuration.ContainsKey("LeftMargin") ? float.Parse(configuration["LeftMargin"]) : 35;
            _rightMargin = configuration.ContainsKey("RightMargin") ? float.Parse(configuration["RightMargin"]) : 35;
            _topMargin = configuration.ContainsKey("TopMargin") ? float.Parse(configuration["TopMargin"]) : 15;
            _bottomMargin = configuration.ContainsKey("BottomMargin") ? float.Parse(configuration["BottomMargin"]) : 35;
            _title = new Title(configuration, title);
            _layers = layers;
        }

        public void Render(System.Drawing.Graphics graphics, float x, float y, float width, float height)
        {
            graphics.FillRectangle(_backBrush, x, y, width, height);

            x += _leftMargin;
            y += _topMargin;
            width -= (_leftMargin + _rightMargin);
            height -= (_topMargin + _bottomMargin);

            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle((int)x, (int)y, (int)width, (int)height);

            rectangle = _title.Render(graphics, rectangle);
            
            if (_debug)
            {
                for (int i = 0; i < _layers.Length; i++)
                {
                    rectangle = _layers[i].Render(graphics, rectangle);
                    graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);
                }
            }
            else
            {
                for (int i = 0; i < _layers.Length; i++)
                    rectangle = _layers[i].Render(graphics, rectangle);
            }
        }

        public static void Render(Collections.Map<string, string> configuration, Chart chart, string path)
        {
            string directory = System.IO.Path.GetDirectoryName(path);
            if (!System.IO.Directory.Exists(directory))
                System.IO.Directory.CreateDirectory(directory);
            int chartWidth = configuration.ContainsKey("Width") ? int.Parse(configuration["Width"]) : 1366;
            int chartHeight = configuration.ContainsKey("Height") ? int.Parse(configuration["Height"]) : 768;
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(chartWidth, chartHeight);
            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (chart != null)
            {
                try
                {
                    chart.Render(graphics, 0, 0, chartWidth, chartHeight);
                }
                catch (System.Exception)
                {
                }
            }
            bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Png);
            bitmap.Dispose();
        }

    }
}
