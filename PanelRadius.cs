using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords
{
    public class PanelRadius : Panel
    {

        public int BorderRadius { get; set; } = 10; // Adjust the radius as needed

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            int borderRadius = BorderRadius;

            // Draw a rounded rectangle
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90); // Top-left corner
                path.AddArc(rect.X + rect.Width - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90); // Top-right corner
                path.AddArc(rect.X + rect.Width - borderRadius, rect.Y + rect.Height - borderRadius, borderRadius, borderRadius, 0, 90); // Bottom-right corner
                path.AddArc(rect.X, rect.Y + rect.Height - borderRadius, borderRadius, borderRadius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPath(new SolidBrush(this.BackColor), path);
                g.DrawPath(new Pen(this.BackColor, 1), path);
            }
        }
    }
}
