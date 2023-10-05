using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgRecords
{
    public partial class RectangleNavy : UserControl
    {
        public RectangleNavy()
        {
            InitializeComponent();
        }

        private int borderRadius = 5; // Adjust this value to control the roundness of corners.

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Set SmoothingMode to AntiAlias

            RectangleF rect = new RectangleF(0, 0, this.Width - 1, this.Height - 1);
            float borderWidth = 3; // Adjust the border width as needed

            using (GraphicsPath path = new GraphicsPath())
            {
                float halfBorderWidth = borderWidth / 2;

                float arcSize = borderRadius * 2;

                // Add arcs for the rounded corners with proper starting points
                path.AddArc(rect.Left + halfBorderWidth, rect.Top + halfBorderWidth, arcSize, arcSize, 180, 90);
                path.AddArc(rect.Right - arcSize - halfBorderWidth, rect.Top + halfBorderWidth, arcSize, arcSize, 270, 90);
                path.AddArc(rect.Right - arcSize - halfBorderWidth, rect.Bottom - arcSize - halfBorderWidth, arcSize, arcSize, 0, 90);
                path.AddArc(rect.Left + halfBorderWidth, rect.Bottom - arcSize - halfBorderWidth, arcSize, arcSize, 90, 90);

                // Close the path
                path.CloseAllFigures();

                // Calculate the inner rectangle to ensure even border width
                RectangleF innerRect = new RectangleF(rect.Left + halfBorderWidth, rect.Top + halfBorderWidth, rect.Width - borderWidth, rect.Height - borderWidth);

                // Fill the inner region with the control's background color
                using (SolidBrush backgroundBrush = new SolidBrush(this.BackColor))
                {
                    g.FillRectangle(backgroundBrush, innerRect);
                }

                // Draw a custom border with a consistent width around the inner rectangle
                using (Pen borderPen = new Pen(Color.Red, borderWidth)) // Set your custom border color and thickness here
                {
                    g.DrawPath(borderPen, path);
                }
            }
        }
    }
}
