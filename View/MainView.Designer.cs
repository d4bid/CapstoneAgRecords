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
            pbMap = new PictureBox();
            panelNotif = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbLogoDa = new PictureBox();
            pbLogoSolano = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbMap).BeginInit();
            panelNotif.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoDa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoSolano).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbMap
            // 
            pbMap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbMap.BackgroundImage = Properties.Resources.map1;
            pbMap.BackgroundImageLayout = ImageLayout.Stretch;
            pbMap.Location = new Point(12, 12);
            pbMap.Name = "pbMap";
            pbMap.Size = new Size(736, 499);
            pbMap.TabIndex = 13;
            pbMap.TabStop = false;
            // 
            // panelNotif
            // 
            panelNotif.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNotif.BorderStyle = BorderStyle.FixedSingle;
            panelNotif.Controls.Add(label5);
            panelNotif.Location = new Point(12, 532);
            panelNotif.Name = "panelNotif";
            panelNotif.Size = new Size(736, 330);
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(775, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 595);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 368);
            label4.Name = "label4";
            label4.Size = new Size(565, 120);
            label4.TabIndex = 18;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(86, 116);
            label3.Name = "label3";
            label3.Size = new Size(523, 96);
            label3.TabIndex = 17;
            label3.Text = "To improve the quality of life of our presemt and future \ngeneration of farmers,fisherfolks and consumers through \neffective and efficient delivery of agriculturual\nextension services.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(302, 324);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 16;
            label2.Text = "Vision";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(297, 78);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 15;
            label1.Text = "Mission";
            // 
            // pbLogoDa
            // 
            pbLogoDa.BackgroundImage = Properties.Resources.logoDoA;
            pbLogoDa.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogoDa.Location = new Point(232, 22);
            pbLogoDa.Name = "pbLogoDa";
            pbLogoDa.Size = new Size(200, 200);
            pbLogoDa.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoDa.TabIndex = 14;
            pbLogoDa.TabStop = false;
            // 
            // pbLogoSolano
            // 
            pbLogoSolano.BackgroundImage = Properties.Resources.logoSolano;
            pbLogoSolano.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogoSolano.Location = new Point(438, 22);
            pbLogoSolano.Name = "pbLogoSolano";
            pbLogoSolano.Size = new Size(200, 200);
            pbLogoSolano.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoSolano.TabIndex = 13;
            pbLogoSolano.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pbLogoSolano);
            panel2.Controls.Add(pbLogoDa);
            panel2.Location = new Point(775, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 236);
            panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(26, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1455, 874);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelNotif);
            Controls.Add(pbMap);
            Name = "MainView";
            Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)pbMap).EndInit();
            panelNotif.ResumeLayout(false);
            panelNotif.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoDa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoSolano).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbMap;
        private Panel panelNotif;
        private Label label5;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pbLogoDa;
        private PictureBox pbLogoSolano;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}