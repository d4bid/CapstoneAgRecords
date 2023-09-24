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
            pbMap = new PictureBox();
            panelNotif = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogoDa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoSolano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMap).BeginInit();
            panelNotif.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(465, 38);
            label1.Name = "label1";
            label1.Size = new Size(74, 26);
            label1.TabIndex = 9;
            label1.Text = "Mission";
            // 
            // pbLogoDa
            // 
            pbLogoDa.BackgroundImage = Properties.Resources.logoDoA;
            pbLogoDa.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogoDa.Location = new Point(12, 218);
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
            pbLogoSolano.Location = new Point(12, 12);
            pbLogoSolano.Name = "pbLogoSolano";
            pbLogoSolano.Size = new Size(200, 200);
            pbLogoSolano.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoSolano.TabIndex = 7;
            pbLogoSolano.TabStop = false;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbLogo.BackColor = Color.FromArgb(43, 121, 223);
            pbLogo.BackgroundImage = Properties.Resources.logo2;
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.Location = new Point(12, 437);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(765, 396);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(472, 222);
            label2.Name = "label2";
            label2.Size = new Size(62, 26);
            label2.TabIndex = 10;
            label2.Text = "Vision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(254, 76);
            label3.Name = "label3";
            label3.Size = new Size(467, 88);
            label3.TabIndex = 11;
            label3.Text = "To improve the quality of life of our presemt and future \ngeneration of farmers,fisherfolks and consumers through \neffective and efficient delivery of agriculturual\nextension services.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(243, 266);
            label4.Name = "label4";
            label4.Size = new Size(505, 110);
            label4.TabIndex = 12;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbMap
            // 
            pbMap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbMap.BackgroundImage = Properties.Resources.map1;
            pbMap.BackgroundImageLayout = ImageLayout.Stretch;
            pbMap.Location = new Point(808, 12);
            pbMap.Name = "pbMap";
            pbMap.Size = new Size(720, 406);
            pbMap.TabIndex = 13;
            pbMap.TabStop = false;
            // 
            // panelNotif
            // 
            panelNotif.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelNotif.Controls.Add(label5);
            panelNotif.Location = new Point(808, 437);
            panelNotif.Name = "panelNotif";
            panelNotif.Size = new Size(720, 396);
            panelNotif.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 14);
            label5.Name = "label5";
            label5.Size = new Size(101, 24);
            label5.TabIndex = 0;
            label5.Text = "Notifications";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1540, 845);
            Controls.Add(panelNotif);
            Controls.Add(pbMap);
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
            ((System.ComponentModel.ISupportInitialize)pbMap).EndInit();
            panelNotif.ResumeLayout(false);
            panelNotif.PerformLayout();
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
        private PictureBox pbMap;
        private Panel panelNotif;
        private Label label5;
    }
}