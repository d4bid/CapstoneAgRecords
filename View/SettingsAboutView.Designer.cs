namespace AgRecords.View
{
    partial class SettingsAboutView
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1595, 182);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(1595, 182);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 30);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 93;
            label1.Text = "Barangay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 100);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 94;
            label2.Text = "Barangay";
            // 
            // SettingsAboutView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SettingsAboutView";
            Text = "SettingsAboutView";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
    }
}