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
            SuspendLayout();
            // 
            // rectangleFullBlue1
            // 
            rectangleFullBlue1.Location = new Point(28, 25);
            rectangleFullBlue1.Name = "rectangleFullBlue1";
            rectangleFullBlue1.Size = new Size(352, 149);
            rectangleFullBlue1.TabIndex = 0;
            // 
            // rectangleFullGreen1
            // 
            rectangleFullGreen1.Location = new Point(410, 25);
            rectangleFullGreen1.Name = "rectangleFullGreen1";
            rectangleFullGreen1.Size = new Size(381, 149);
            rectangleFullGreen1.TabIndex = 1;
            // 
            // rectangleFullYellow1
            // 
            rectangleFullYellow1.Location = new Point(814, 25);
            rectangleFullYellow1.Name = "rectangleFullYellow1";
            rectangleFullYellow1.Size = new Size(369, 149);
            rectangleFullYellow1.TabIndex = 2;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(rectangleFullYellow1);
            Controls.Add(rectangleFullGreen1);
            Controls.Add(rectangleFullBlue1);
            Name = "DashboardView";
            Text = "DashboardView";
            Load += DashboardView_Load;
            ResumeLayout(false);
        }

        #endregion

        private RectangleFullBlue rectangleFullBlue1;
        private RectangleFullGreen rectangleFullGreen1;
        private RectangleFullYellow rectangleFullYellow1;
    }
}