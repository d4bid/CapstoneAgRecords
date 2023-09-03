namespace AgRecords.View
{
    partial class MainView
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
            label1 = new Label();
            pbLogoDa = new PictureBox();
            pbLogoSolano = new PictureBox();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogoDa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoSolano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 314);
            label1.Name = "label1";
            label1.Size = new Size(104, 24);
            label1.TabIndex = 9;
            label1.Text = "This is a text.";
            // 
            // pbLogoDa
            // 
            pbLogoDa.BackgroundImage = Properties.Resources.logoDa;
            pbLogoDa.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogoDa.Location = new Point(312, 69);
            pbLogoDa.Name = "pbLogoDa";
            pbLogoDa.Size = new Size(220, 220);
            pbLogoDa.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoDa.TabIndex = 8;
            pbLogoDa.TabStop = false;
            // 
            // pbLogoSolano
            // 
            pbLogoSolano.BackgroundImage = Properties.Resources.logoSolano;
            pbLogoSolano.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogoSolano.Location = new Point(52, 69);
            pbLogoSolano.Name = "pbLogoSolano";
            pbLogoSolano.Size = new Size(220, 220);
            pbLogoSolano.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoSolano.TabIndex = 7;
            pbLogoSolano.TabStop = false;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbLogo.BackColor = Color.FromArgb(43, 121, 223);
            pbLogo.BackgroundImage = Properties.Resources.logo2;
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.Location = new Point(606, 69);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(480, 480);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 619);
            Controls.Add(label1);
            Controls.Add(pbLogoDa);
            Controls.Add(pbLogoSolano);
            Controls.Add(pbLogo);
            Name = "MainView";
            Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)pbLogoDa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoSolano).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbLogoDa;
        private PictureBox pbLogoSolano;
        private PictureBox pbLogo;
    }
}