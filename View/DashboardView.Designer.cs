namespace AgRecords.View
{
    partial class DashboardView
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
            rectangleFullBlue1 = new RectangleFullBlue();
            rectangleFullGreen1 = new RectangleFullGreen();
            rectangleFullYellow1 = new RectangleFullYellow();
            pieChart1 = new OxyPlot.WindowsForms.PlotView();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // rectangleFullBlue1
            // 
            rectangleFullBlue1.Location = new Point(28, 25);
            rectangleFullBlue1.Name = "rectangleFullBlue1";
            rectangleFullBlue1.Size = new Size(299, 149);
            rectangleFullBlue1.TabIndex = 0;
            // 
            // rectangleFullGreen1
            // 
            rectangleFullGreen1.Location = new Point(352, 25);
            rectangleFullGreen1.Name = "rectangleFullGreen1";
            rectangleFullGreen1.Size = new Size(299, 149);
            rectangleFullGreen1.TabIndex = 1;
            // 
            // rectangleFullYellow1
            // 
            rectangleFullYellow1.Location = new Point(28, 195);
            rectangleFullYellow1.Name = "rectangleFullYellow1";
            rectangleFullYellow1.Size = new Size(299, 149);
            rectangleFullYellow1.TabIndex = 2;
            // 
            // pieChart1
            // 
            pieChart1.Location = new Point(107, 455);
            pieChart1.Name = "pieChart1";
            pieChart1.PanCursor = Cursors.Hand;
            pieChart1.Size = new Size(418, 358);
            pieChart1.TabIndex = 3;
            pieChart1.ZoomHorizontalCursor = Cursors.SizeWE;
            pieChart1.ZoomRectangleCursor = Cursors.SizeNWSE;
            pieChart1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panel1
            // 
            panel1.Location = new Point(824, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 4;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(pieChart1);
            Controls.Add(rectangleFullYellow1);
            Controls.Add(rectangleFullGreen1);
            Controls.Add(rectangleFullBlue1);
            Controls.Add(panel1);
            Name = "DashboardView";
            Padding = new Padding(10);
            Text = "DashboardView";
            Load += DashboardView_Load;
            ResumeLayout(false);
        }

        #endregion

        private RectangleFullBlue rectangleFullBlue1;
        private RectangleFullGreen rectangleFullGreen1;
        private RectangleFullYellow rectangleFullYellow1;
        private OxyPlot.WindowsForms.PlotView pieChart1;
        private Panel panel1;
    }
}