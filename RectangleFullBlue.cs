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
    public partial class RectangleFullBlue : UserControl
    {
        public RectangleFullBlue()
        {
            InitializeComponent();
        }

        private int borderRadius = 5; // Adjust this value to control the roundness of corners.
        private float borderWidth = 1; // Adjust the border width as needed
        private Color customColor = Color.FromArgb(43, 121, 223); // Custom color with ARGB values

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Set SmoothingMode to AntiAlias

            RectangleF rect = new RectangleF(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = new GraphicsPath())
            {
                float halfBorderWidth = 0; // Set the border width to 0 to remove the border
                float arcSize = borderRadius * 2;

                // Add arcs for the rounded corners with proper starting points
                path.AddArc(rect.Left + halfBorderWidth, rect.Top + halfBorderWidth, arcSize, arcSize, 180, 90);
                path.AddArc(rect.Right - arcSize - halfBorderWidth, rect.Top + halfBorderWidth, arcSize, arcSize, 270, 90);
                path.AddArc(rect.Right - arcSize - halfBorderWidth, rect.Bottom - arcSize - halfBorderWidth, arcSize, arcSize, 0, 90);
                path.AddArc(rect.Left + halfBorderWidth, rect.Bottom - arcSize - halfBorderWidth, arcSize, arcSize, 90, 90);

                // Close the path
                path.CloseAllFigures();

                // Fill the inner region with the custom background color
                using (SolidBrush backgroundBrush = new SolidBrush(Color.FromArgb(43, 121, 223)))
                {
                    g.FillPath(backgroundBrush, path);
                }
            }
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Invalidate the control to trigger a repaint
            this.Invalidate();
        }
    }
}
