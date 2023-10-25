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
            pbMap = new PictureBox();
            panelNotif = new Panel();
            panel4 = new Panel();
            dgvNotif = new DataGridView();
            panel3 = new Panel();
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
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotif).BeginInit();
            panel3.SuspendLayout();
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
            pbMap.BackgroundImage = Properties.Resources.map2;
            pbMap.BackgroundImageLayout = ImageLayout.Stretch;
            pbMap.Location = new Point(12, 12);
            pbMap.Name = "pbMap";
            pbMap.Size = new Size(876, 583);
            pbMap.TabIndex = 13;
            pbMap.TabStop = false;
            // 
            // panelNotif
            // 
            panelNotif.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNotif.BorderStyle = BorderStyle.FixedSingle;
            panelNotif.Controls.Add(panel4);
            panelNotif.Controls.Add(panel3);
            panelNotif.Location = new Point(12, 617);
            panelNotif.Name = "panelNotif";
            panelNotif.Size = new Size(876, 296);
            panelNotif.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvNotif);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 40);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(874, 254);
            panel4.TabIndex = 17;
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNotif.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNotif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotif.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNotif.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNotif.Dock = DockStyle.Fill;
            dgvNotif.GridColor = Color.FromArgb(239, 239, 239);
            dgvNotif.Location = new Point(10, 10);
            dgvNotif.Name = "dgvNotif";
            dgvNotif.ReadOnly = true;
            dgvNotif.RowHeadersVisible = false;
            dgvNotif.RowHeadersWidth = 51;
            dgvNotif.RowTemplate.Height = 40;
            dgvNotif.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotif.Size = new Size(854, 234);
            dgvNotif.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(874, 40);
            panel3.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 6);
            label5.Name = "label5";
            label5.Size = new Size(206, 25);
            label5.TabIndex = 1;
            label5.Text = "Recently Added Letters";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(915, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 647);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 368);
            label4.Name = "label4";
            label4.Size = new Size(557, 140);
            label4.TabIndex = 18;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 116);
            label3.Name = "label3";
            label3.Size = new Size(509, 112);
            label3.TabIndex = 17;
            label3.Text = "To improve the quality of life of our presemt and future \ngeneration of farmers,fisherfolks and consumers through \neffective and efficient delivery of agriculturual\nextension services.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(302, 324);
            label2.Name = "label2";
            label2.Size = new Size(78, 31);
            label2.TabIndex = 16;
            label2.Text = "Vision";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(297, 78);
            label1.Name = "label1";
            label1.Size = new Size(94, 31);
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
            panel2.Location = new Point(915, 12);
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
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelNotif);
            Controls.Add(pbMap);
            Name = "MainView";
            Text = "MainView";
            Load += MainView_Load;
            ((System.ComponentModel.ISupportInitialize)pbMap).EndInit();
            panelNotif.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotif).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pbLogoDa;
        private PictureBox pbLogoSolano;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel3;
        private Label label5;
        private DataGridView dgvNotif;
    }
}