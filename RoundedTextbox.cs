using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AgRecords
{
    public class RoundedTextbox : TextBox
    {
        private int borderRadius = 10; // Adjust this value to control the roundness of corners.
        private int borderWidth = 2; // Adjust the border width as needed
        private Color borderColor = Color.Red; // Set your custom border color here

        public RoundedTextbox()
        {
            this.BorderStyle = BorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Set SmoothingMode to AntiAlias

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = new GraphicsPath())
            {
                // Add arcs for the rounded corners with proper starting points
                path.AddArc(rect.Left, rect.Top, borderRadius * 2, borderRadius * 2, 180, 90);
                path.AddArc(rect.Right - borderRadius * 2, rect.Top, borderRadius * 2, borderRadius * 2, 270, 90);
                path.AddArc(rect.Right - borderRadius * 2, rect.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);

                // Close the path
                path.CloseAllFigures();

                // Fill the inner region with the control's background color
                using (SolidBrush backgroundBrush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(backgroundBrush, path);
                }

                // Draw a custom border with a consistent width around the path
                using (Pen borderPen = new Pen(borderColor, borderWidth))
                {
                    g.DrawPath(borderPen, path);
                }
            }
        }
    }
}
