using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AgRecords
{
    public partial class RectangleRound : UserControl
    {
        public RectangleRound()
        {
            InitializeComponent();
        }

        private int borderRadius = 5; // Adjust this value to control the roundness of corners.
        private float borderWidth = 1; // Adjust the border width as needed
        private Color customColor = Color.FromArgb(0, 35, 76); // Custom color with ARGB values

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Set SmoothingMode to AntiAlias

            RectangleF rect = new RectangleF(0, 0, this.Width - 1, this.Height - 1);

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
