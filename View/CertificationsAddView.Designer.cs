namespace AgRecords.View
{
    partial class CertificationsAddView
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
            rectangleRound1 = new RectangleRound();
            label2 = new Label();
            rectangleRound2 = new RectangleRound();
            label1 = new Label();
            rectangleRound3 = new RectangleRound();
            label3 = new Label();
            SuspendLayout();
            // 
            // rectangleRound1
            // 
            rectangleRound1.BackColor = Color.White;
            rectangleRound1.Location = new Point(22, 46);
            rectangleRound1.Name = "rectangleRound1";
            rectangleRound1.Size = new Size(276, 38);
            rectangleRound1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 23);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 0;
            label2.Text = "Reference Number";
            label2.Click += label2_Click;
            // 
            // rectangleRound2
            // 
            rectangleRound2.BackColor = Color.White;
            rectangleRound2.Location = new Point(22, 136);
            rectangleRound2.Name = "rectangleRound2";
            rectangleRound2.Size = new Size(276, 38);
            rectangleRound2.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 113);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 22;
            label1.Text = "Barangay";
            // 
            // rectangleRound3
            // 
            rectangleRound3.BackColor = Color.White;
            rectangleRound3.Location = new Point(312, 214);
            rectangleRound3.Name = "rectangleRound3";
            rectangleRound3.Size = new Size(276, 38);
            rectangleRound3.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 191);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 24;
            label3.Text = "Barangay";
            // 
            // CertificationsAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(685, 483);
            Controls.Add(rectangleRound3);
            Controls.Add(label3);
            Controls.Add(rectangleRound2);
            Controls.Add(label1);
            Controls.Add(rectangleRound1);
            Controls.Add(label2);
            Name = "CertificationsAddView";
            Text = "CertificationsAddView";
            Load += CertificationsAddView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RectangleRound rectangleRound1;
        private Label label2;
        private RectangleRound rectangleRound2;
        private Label label1;
        private RectangleRound rectangleRound3;
        private Label label3;
    }
}