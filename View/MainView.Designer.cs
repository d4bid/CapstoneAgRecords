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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            label1 = new Label();
            pbLogoDa = new PictureBox();
            pbLogoSolano = new PictureBox();
            pbLogo = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogoDa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoSolano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(263, 242);
            label1.Name = "label1";
            label1.Size = new Size(74, 26);
            label1.TabIndex = 9;
            label1.Text = "Mission";
            // 
            // pbLogoDa
            // 
            pbLogoDa.BackgroundImage = Properties.Resources.logoDa;
            pbLogoDa.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogoDa.Location = new Point(318, 20);
            pbLogoDa.Name = "pbLogoDa";
            pbLogoDa.Size = new Size(200, 200);
            pbLogoDa.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoDa.TabIndex = 8;
            pbLogoDa.TabStop = false;
            // 
            // pbLogoSolano
            // 
            pbLogoSolano.BackgroundImage = Properties.Resources.logoSolano;
            pbLogoSolano.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogoSolano.Location = new Point(94, 20);
            pbLogoSolano.Name = "pbLogoSolano";
            pbLogoSolano.Size = new Size(200, 200);
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
            pbLogo.Location = new Point(661, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(450, 208);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(268, 410);
            label2.Name = "label2";
            label2.Size = new Size(62, 26);
            label2.TabIndex = 10;
            label2.Text = "Vision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 280);
            label3.Name = "label3";
            label3.Size = new Size(496, 92);
            label3.TabIndex = 11;
            label3.Text = "To improve the quality of life of our presemt and future \ngeneration of farmers,fisherfolks and consumers through \neffective and efficient delivery of agriculturual\nextension services.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 453);
            label4.Name = "label4";
            label4.Size = new Size(539, 115);
            label4.TabIndex = 12;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 619);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
    }
}