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
namespace FunPlot
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new FunPlot.FormMain.DoubleBufferedPanel();
            this.panel2 = new FunPlot.FormMain.DoubleBufferedPanel();
            this.labelXMin1 = new System.Windows.Forms.Label();
            this.trackBarXMin1 = new System.Windows.Forms.TrackBar();
            this.labelXMax1 = new System.Windows.Forms.Label();
            this.trackBarYMin1 = new System.Windows.Forms.TrackBar();
            this.trackBarYMax1 = new System.Windows.Forms.TrackBar();
            this.labelYMax1 = new System.Windows.Forms.Label();
            this.labelYMin1 = new System.Windows.Forms.Label();
            this.trackBarXMax1 = new System.Windows.Forms.TrackBar();
            this.trackBarA1 = new System.Windows.Forms.TrackBar();
            this.trackBarB1 = new System.Windows.Forms.TrackBar();
            this.trackBarC1 = new System.Windows.Forms.TrackBar();
            this.labelA1 = new System.Windows.Forms.Label();
            this.labelB1 = new System.Windows.Forms.Label();
            this.labelC1 = new System.Windows.Forms.Label();
            this.labelPScale2 = new System.Windows.Forms.Label();
            this.labelPMin2 = new System.Windows.Forms.Label();
            this.labelPMax2 = new System.Windows.Forms.Label();
            this.trackBarPScale2 = new System.Windows.Forms.TrackBar();
            this.trackBarPMin2 = new System.Windows.Forms.TrackBar();
            this.trackBarPMax2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYMax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXMax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPScale2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPMin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPMax2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(120, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(560, 120);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 400);
            this.panel2.TabIndex = 1;
            // 
            // labelXMin1
            // 
            this.labelXMin1.AutoSize = true;
            this.labelXMin1.Location = new System.Drawing.Point(117, 100);
            this.labelXMin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXMin1.Name = "labelXMin1";
            this.labelXMin1.Size = new System.Drawing.Size(48, 16);
            this.labelXMin1.TabIndex = 2;
            this.labelXMin1.Text = "x min";
            // 
            // trackBarXMin1
            // 
            this.trackBarXMin1.LargeChange = 3;
            this.trackBarXMin1.Location = new System.Drawing.Point(120, 71);
            this.trackBarXMin1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarXMin1.Maximum = 6;
            this.trackBarXMin1.Minimum = -6;
            this.trackBarXMin1.Name = "trackBarXMin1";
            this.trackBarXMin1.Size = new System.Drawing.Size(400, 45);
            this.trackBarXMin1.TabIndex = 3;
            this.trackBarXMin1.Value = -3;
            this.trackBarXMin1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labelXMax1
            // 
            this.labelXMax1.AutoSize = true;
            this.labelXMax1.Location = new System.Drawing.Point(117, 55);
            this.labelXMax1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXMax1.Name = "labelXMax1";
            this.labelXMax1.Size = new System.Drawing.Size(48, 16);
            this.labelXMax1.TabIndex = 4;
            this.labelXMax1.Text = "x max";
            // 
            // trackBarYMin1
            // 
            this.trackBarYMin1.LargeChange = 3;
            this.trackBarYMin1.Location = new System.Drawing.Point(71, 120);
            this.trackBarYMin1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarYMin1.Maximum = 6;
            this.trackBarYMin1.Minimum = -6;
            this.trackBarYMin1.Name = "trackBarYMin1";
            this.trackBarYMin1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarYMin1.Size = new System.Drawing.Size(45, 400);
            this.trackBarYMin1.TabIndex = 11;
            this.trackBarYMin1.Value = -3;
            this.trackBarYMin1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarYMax1
            // 
            this.trackBarYMax1.LargeChange = 3;
            this.trackBarYMax1.Location = new System.Drawing.Point(26, 120);
            this.trackBarYMax1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarYMax1.Maximum = 6;
            this.trackBarYMax1.Minimum = -6;
            this.trackBarYMax1.Name = "trackBarYMax1";
            this.trackBarYMax1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarYMax1.Size = new System.Drawing.Size(45, 400);
            this.trackBarYMax1.TabIndex = 12;
            this.trackBarYMax1.Value = 3;
            this.trackBarYMax1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labelYMax1
            // 
            this.labelYMax1.AutoSize = true;
            this.labelYMax1.Location = new System.Drawing.Point(23, 120);
            this.labelYMax1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYMax1.Name = "labelYMax1";
            this.labelYMax1.Size = new System.Drawing.Size(48, 16);
            this.labelYMax1.TabIndex = 15;
            this.labelYMax1.Text = "y max";
            // 
            // labelYMin1
            // 
            this.labelYMin1.AutoSize = true;
            this.labelYMin1.Location = new System.Drawing.Point(68, 120);
            this.labelYMin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYMin1.Name = "labelYMin1";
            this.labelYMin1.Size = new System.Drawing.Size(48, 16);
            this.labelYMin1.TabIndex = 16;
            this.labelYMin1.Text = "y min";
            // 
            // trackBarXMax1
            // 
            this.trackBarXMax1.LargeChange = 3;
            this.trackBarXMax1.Location = new System.Drawing.Point(120, 26);
            this.trackBarXMax1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarXMax1.Maximum = 6;
            this.trackBarXMax1.Minimum = -6;
            this.trackBarXMax1.Name = "trackBarXMax1";
            this.trackBarXMax1.Size = new System.Drawing.Size(400, 45);
            this.trackBarXMax1.TabIndex = 5;
            this.trackBarXMax1.Value = 3;
            this.trackBarXMax1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarA1
            // 
            this.trackBarA1.LargeChange = 3;
            this.trackBarA1.Location = new System.Drawing.Point(120, 524);
            this.trackBarA1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarA1.Maximum = 6;
            this.trackBarA1.Minimum = -6;
            this.trackBarA1.Name = "trackBarA1";
            this.trackBarA1.Size = new System.Drawing.Size(400, 45);
            this.trackBarA1.TabIndex = 21;
            this.trackBarA1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarB1
            // 
            this.trackBarB1.LargeChange = 3;
            this.trackBarB1.Location = new System.Drawing.Point(120, 569);
            this.trackBarB1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarB1.Maximum = 6;
            this.trackBarB1.Minimum = -6;
            this.trackBarB1.Name = "trackBarB1";
            this.trackBarB1.Size = new System.Drawing.Size(400, 45);
            this.trackBarB1.TabIndex = 22;
            this.trackBarB1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarC1
            // 
            this.trackBarC1.LargeChange = 3;
            this.trackBarC1.Location = new System.Drawing.Point(120, 614);
            this.trackBarC1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarC1.Maximum = 6;
            this.trackBarC1.Minimum = -6;
            this.trackBarC1.Name = "trackBarC1";
            this.trackBarC1.Size = new System.Drawing.Size(400, 45);
            this.trackBarC1.TabIndex = 23;
            this.trackBarC1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labelA1
            // 
            this.labelA1.AutoSize = true;
            this.labelA1.Location = new System.Drawing.Point(117, 553);
            this.labelA1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA1.Name = "labelA1";
            this.labelA1.Size = new System.Drawing.Size(112, 16);
            this.labelA1.TabIndex = 24;
            this.labelA1.Text = "a [convexity]";
            // 
            // labelB1
            // 
            this.labelB1.AutoSize = true;
            this.labelB1.Location = new System.Drawing.Point(117, 598);
            this.labelB1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelB1.Name = "labelB1";
            this.labelB1.Size = new System.Drawing.Size(80, 16);
            this.labelB1.TabIndex = 25;
            this.labelB1.Text = "b [slope]";
            // 
            // labelC1
            // 
            this.labelC1.AutoSize = true;
            this.labelC1.Location = new System.Drawing.Point(117, 643);
            this.labelC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(16, 16);
            this.labelC1.TabIndex = 26;
            this.labelC1.Text = "c";
            // 
            // labelPScale2
            // 
            this.labelPScale2.AutoSize = true;
            this.labelPScale2.Location = new System.Drawing.Point(557, 643);
            this.labelPScale2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPScale2.Name = "labelPScale2";
            this.labelPScale2.Size = new System.Drawing.Size(64, 16);
            this.labelPScale2.TabIndex = 32;
            this.labelPScale2.Text = "p scale";
            // 
            // labelPMin2
            // 
            this.labelPMin2.AutoSize = true;
            this.labelPMin2.Location = new System.Drawing.Point(557, 598);
            this.labelPMin2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPMin2.Name = "labelPMin2";
            this.labelPMin2.Size = new System.Drawing.Size(48, 16);
            this.labelPMin2.TabIndex = 31;
            this.labelPMin2.Text = "p min";
            // 
            // labelPMax2
            // 
            this.labelPMax2.AutoSize = true;
            this.labelPMax2.Location = new System.Drawing.Point(557, 553);
            this.labelPMax2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPMax2.Name = "labelPMax2";
            this.labelPMax2.Size = new System.Drawing.Size(48, 16);
            this.labelPMax2.TabIndex = 30;
            this.labelPMax2.Text = "p max";
            // 
            // trackBarPScale2
            // 
            this.trackBarPScale2.LargeChange = 3;
            this.trackBarPScale2.Location = new System.Drawing.Point(560, 614);
            this.trackBarPScale2.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarPScale2.Maximum = 12;
            this.trackBarPScale2.Name = "trackBarPScale2";
            this.trackBarPScale2.Size = new System.Drawing.Size(400, 45);
            this.trackBarPScale2.TabIndex = 29;
            this.trackBarPScale2.Value = 6;
            this.trackBarPScale2.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarPMin2
            // 
            this.trackBarPMin2.LargeChange = 3;
            this.trackBarPMin2.Location = new System.Drawing.Point(560, 569);
            this.trackBarPMin2.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarPMin2.Maximum = 12;
            this.trackBarPMin2.Name = "trackBarPMin2";
            this.trackBarPMin2.Size = new System.Drawing.Size(400, 45);
            this.trackBarPMin2.TabIndex = 28;
            this.trackBarPMin2.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarPMax2
            // 
            this.trackBarPMax2.LargeChange = 3;
            this.trackBarPMax2.Location = new System.Drawing.Point(560, 524);
            this.trackBarPMax2.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarPMax2.Maximum = 12;
            this.trackBarPMax2.Name = "trackBarPMax2";
            this.trackBarPMax2.Size = new System.Drawing.Size(400, 45);
            this.trackBarPMax2.TabIndex = 27;
            this.trackBarPMax2.Value = 12;
            this.trackBarPMax2.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1004, 682);
            this.Controls.Add(this.labelPScale2);
            this.Controls.Add(this.labelPMin2);
            this.Controls.Add(this.labelPMax2);
            this.Controls.Add(this.trackBarPScale2);
            this.Controls.Add(this.trackBarPMin2);
            this.Controls.Add(this.trackBarPMax2);
            this.Controls.Add(this.labelC1);
            this.Controls.Add(this.labelB1);
            this.Controls.Add(this.labelA1);
            this.Controls.Add(this.trackBarC1);
            this.Controls.Add(this.trackBarB1);
            this.Controls.Add(this.trackBarA1);
            this.Controls.Add(this.labelYMin1);
            this.Controls.Add(this.labelYMax1);
            this.Controls.Add(this.trackBarYMax1);
            this.Controls.Add(this.trackBarYMin1);
            this.Controls.Add(this.labelXMax1);
            this.Controls.Add(this.trackBarXMax1);
            this.Controls.Add(this.labelXMin1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBarXMin1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fun Plot";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYMax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXMax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPScale2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPMin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPMax2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferedPanel panel1;
        private DoubleBufferedPanel panel2;
        private System.Windows.Forms.Label labelXMin1;
        private System.Windows.Forms.TrackBar trackBarXMin1;
        private System.Windows.Forms.Label labelXMax1;
        private System.Windows.Forms.TrackBar trackBarYMin1;
        private System.Windows.Forms.TrackBar trackBarYMax1;
        private System.Windows.Forms.Label labelYMax1;
        private System.Windows.Forms.Label labelYMin1;
        private System.Windows.Forms.TrackBar trackBarXMax1;
        private System.Windows.Forms.TrackBar trackBarA1;
        private System.Windows.Forms.TrackBar trackBarB1;
        private System.Windows.Forms.TrackBar trackBarC1;
        private System.Windows.Forms.Label labelA1;
        private System.Windows.Forms.Label labelB1;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.Label labelPScale2;
        private System.Windows.Forms.Label labelPMin2;
        private System.Windows.Forms.Label labelPMax2;
        private System.Windows.Forms.TrackBar trackBarPScale2;
        private System.Windows.Forms.TrackBar trackBarPMin2;
        private System.Windows.Forms.TrackBar trackBarPMax2;
    }
}

