using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords
{
    public class CustomButton : Button
    {
        private int borderRadius = 10; // Adjust this value to control the roundness of corners.
        private Color customColor = Color.FromArgb(0, 35, 76); // Custom color with ARGB values

        public CustomButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.FromArgb(0, 122, 204); // Set your button's background color
            ForeColor = Color.White; // Set your button's text color
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Size = new Size(150, 40); // Set the size of your button
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            int borderWidth = 1; // Adjust the border width as needed

            using (GraphicsPath path = CreateRoundedPath(rect, borderRadius))
            {
                // Fill the inner region with the control's background color
                using (SolidBrush backgroundBrush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(backgroundBrush, path);
                }

                // Draw a custom border with rounded corners
                using (Pen borderPen = new Pen(customColor, borderWidth)) // Set your custom border thickness (borderWidth) and color here
                {
                    g.DrawPath(borderPen, path);
                }

                // Draw the button's text with smoothing mode
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(Text, Font, new SolidBrush(ForeColor), rect, stringFormat);
            }
        }

        private GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left corner
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right corner
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left corner
            path.CloseFigure();

            return path;
        }
    }
}
