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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panelNotif = new Panel();
            dgvNotif = new DataGridView();
            pbLogoDa = new PictureBox();
            pbLogoSolano = new PictureBox();
            rectangleFullWhite2 = new RectangleFullWhite();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            rectangleFullWhite1 = new RectangleFullWhite();
            label5 = new Label();
            rectangleFullWhite3 = new RectangleFullWhite();
            rectangleFullWhite4 = new RectangleFullWhite();
            rectangleFullWhite5 = new RectangleFullWhite();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            rectangleFullWhite6 = new RectangleFullWhite();
            rectangleFullWhite7 = new RectangleFullWhite();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panelNotif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoDa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoSolano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelNotif
            // 
            panelNotif.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNotif.BackColor = Color.White;
            panelNotif.Controls.Add(dgvNotif);
            panelNotif.Location = new Point(32, 615);
            panelNotif.Name = "panelNotif";
            panelNotif.Padding = new Padding(10);
            panelNotif.Size = new Size(829, 288);
            panelNotif.TabIndex = 14;
            // 
            // dgvNotif
            // 
            dgvNotif.AllowUserToAddRows = false;
            dgvNotif.AllowUserToDeleteRows = false;
            dgvNotif.AllowUserToResizeColumns = false;
            dgvNotif.AllowUserToResizeRows = false;
            dgvNotif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotif.BackgroundColor = Color.White;
            dgvNotif.BorderStyle = BorderStyle.None;
            dgvNotif.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNotif.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNotif.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNotif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNotif.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNotif.Dock = DockStyle.Fill;
            dgvNotif.EnableHeadersVisualStyles = false;
            dgvNotif.GridColor = Color.FromArgb(239, 239, 239);
            dgvNotif.Location = new Point(10, 10);
            dgvNotif.Name = "dgvNotif";
            dgvNotif.ReadOnly = true;
            dgvNotif.RowHeadersVisible = false;
            dgvNotif.RowHeadersWidth = 51;
            dgvNotif.RowTemplate.Height = 40;
            dgvNotif.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotif.Size = new Size(809, 268);
            dgvNotif.TabIndex = 24;
            // 
            // pbLogoDa
            // 
            pbLogoDa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbLogoDa.BackColor = Color.White;
            pbLogoDa.BackgroundImage = Properties.Resources.logoDoA;
            pbLogoDa.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogoDa.Location = new Point(1156, 38);
            pbLogoDa.Name = "pbLogoDa";
            pbLogoDa.Size = new Size(180, 180);
            pbLogoDa.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoDa.TabIndex = 14;
            pbLogoDa.TabStop = false;
            // 
            // pbLogoSolano
            // 
            pbLogoSolano.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbLogoSolano.BackColor = Color.White;
            pbLogoSolano.BackgroundImage = Properties.Resources.logoSolano;
            pbLogoSolano.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogoSolano.Location = new Point(1386, 38);
            pbLogoSolano.Name = "pbLogoSolano";
            pbLogoSolano.Size = new Size(180, 180);
            pbLogoSolano.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoSolano.TabIndex = 13;
            pbLogoSolano.TabStop = false;
            // 
            // rectangleFullWhite2
            // 
            rectangleFullWhite2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleFullWhite2.Location = new Point(12, 12);
            rectangleFullWhite2.Name = "rectangleFullWhite2";
            rectangleFullWhite2.Size = new Size(876, 541);
            rectangleFullWhite2.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = Properties.Resources.map3;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(32, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(829, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 35, 76);
            label6.Location = new Point(32, 27);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 34;
            label6.Text = "Map of Solano";
            // 
            // rectangleFullWhite1
            // 
            rectangleFullWhite1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleFullWhite1.Location = new Point(12, 571);
            rectangleFullWhite1.Name = "rectangleFullWhite1";
            rectangleFullWhite1.Size = new Size(876, 343);
            rectangleFullWhite1.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 35, 76);
            label5.Location = new Point(32, 588);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 36;
            label5.Text = "Upcoming Events";
            // 
            // rectangleFullWhite3
            // 
            rectangleFullWhite3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rectangleFullWhite3.Location = new Point(908, 12);
            rectangleFullWhite3.Name = "rectangleFullWhite3";
            rectangleFullWhite3.Size = new Size(214, 234);
            rectangleFullWhite3.TabIndex = 37;
            // 
            // rectangleFullWhite4
            // 
            rectangleFullWhite4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rectangleFullWhite4.Location = new Point(1139, 12);
            rectangleFullWhite4.Name = "rectangleFullWhite4";
            rectangleFullWhite4.Size = new Size(214, 234);
            rectangleFullWhite4.TabIndex = 38;
            // 
            // rectangleFullWhite5
            // 
            rectangleFullWhite5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rectangleFullWhite5.Location = new Point(1369, 12);
            rectangleFullWhite5.Name = "rectangleFullWhite5";
            rectangleFullWhite5.Size = new Size(214, 234);
            rectangleFullWhite5.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 31);
            label1.Name = "label1";
            label1.Size = new Size(94, 31);
            label1.TabIndex = 15;
            label1.Text = "Mission";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(276, 39);
            label2.Name = "label2";
            label2.Size = new Size(78, 31);
            label2.TabIndex = 16;
            label2.Text = "Vision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 97);
            label3.Name = "label3";
            label3.Size = new Size(509, 112);
            label3.TabIndex = 17;
            label3.Text = "To improve the quality of life of our presemt and future \ngeneration of farmers,fisherfolks and consumers through \neffective and efficient delivery of agriculturual\nextension services.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 101);
            label4.Name = "label4";
            label4.Size = new Size(557, 140);
            label4.TabIndex = 18;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(932, 588);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 315);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // rectangleFullWhite6
            // 
            rectangleFullWhite6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rectangleFullWhite6.Location = new Point(908, 262);
            rectangleFullWhite6.Name = "rectangleFullWhite6";
            rectangleFullWhite6.Size = new Size(675, 291);
            rectangleFullWhite6.TabIndex = 40;
            // 
            // rectangleFullWhite7
            // 
            rectangleFullWhite7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rectangleFullWhite7.Location = new Point(908, 571);
            rectangleFullWhite7.Name = "rectangleFullWhite7";
            rectangleFullWhite7.Size = new Size(675, 343);
            rectangleFullWhite7.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(932, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 251);
            panel2.TabIndex = 42;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = Properties.Resources.tempLogo3;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(927, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1595, 926);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(rectangleFullWhite7);
            Controls.Add(pbLogoSolano);
            Controls.Add(rectangleFullWhite5);
            Controls.Add(pbLogoDa);
            Controls.Add(rectangleFullWhite4);
            Controls.Add(rectangleFullWhite3);
            Controls.Add(label5);
            Controls.Add(panelNotif);
            Controls.Add(rectangleFullWhite1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(rectangleFullWhite2);
            Controls.Add(rectangleFullWhite6);
            Name = "MainView";
            Text = "MainView";
            Load += MainView_Load;
            panelNotif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotif).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoDa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoSolano).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelNotif;
        private PictureBox pbLogoDa;
        private PictureBox pbLogoSolano;
        private RectangleFullWhite rectangleFullWhite2;
        private PictureBox pictureBox1;
        private Label label6;
        private RectangleFullWhite rectangleFullWhite1;
        private DataGridView dgvNotif;
        private Label label5;
        private RectangleFullWhite rectangleFullWhite3;
        private RectangleFullWhite rectangleFullWhite4;
        private RectangleFullWhite rectangleFullWhite5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private RectangleFullWhite rectangleFullWhite6;
        private RectangleFullWhite rectangleFullWhite7;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}