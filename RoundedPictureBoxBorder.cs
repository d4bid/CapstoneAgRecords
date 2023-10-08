using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords
{
    public class RoundedPictureBoxBorder : PictureBox
    {
        private Color customBorderColor = Color.Red; // Set your custom border color here
        private float borderWidth = 2.0f; // Set the border width as needed

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Create an off-screen bitmap for rendering
            Bitmap buffer = new Bitmap(ClientSize.Width, ClientSize.Height);

            using (Graphics g = Graphics.FromImage(buffer))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Create a path for the circular border
                GraphicsPath borderPath = new GraphicsPath();
                borderPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

                // Draw the custom border
                using (Pen borderPen = new Pen(customBorderColor, borderWidth))
                {
                    g.DrawPath(borderPen, borderPath);
                }

                // Set the circular region for the control to clip the image
                this.Region = new Region(borderPath);

                // Calculate the rectangle for the image (inside the border)
                Rectangle imageRect = new Rectangle((int)borderWidth, (int)borderWidth, ClientSize.Width - (int)(2 * borderWidth), ClientSize.Height - (int)(2 * borderWidth));

                // Draw the image inside the circular region
                if (Image != null)
                {
                    g.DrawImage(Image, imageRect);
                }
            }

            // Display the off-screen buffer with anti-aliased graphics
            pe.Graphics.DrawImage(buffer, Point.Empty);
        }
    }
}
