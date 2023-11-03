﻿namespace AgRecords.View
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            rectangleFullGreen1 = new RectangleFullGreen();
            rectangleFullYellow1 = new RectangleFullYellow();
            barChart1 = new OxyPlot.WindowsForms.PlotView();
            rectangleFullWhite1 = new RectangleFullWhite();
            label1 = new Label();
            labelTotalFarmers = new Label();
            label2 = new Label();
            labelGaiFarming = new Label();
            label4 = new Label();
            labelGaiNonFarming = new Label();
            label6 = new Label();
            rectangleFullYellow2 = new RectangleFullYellow();
            rectangleFullWhite2 = new RectangleFullWhite();
            rectangleFullWhite3 = new RectangleFullWhite();
            rectangleFullWhite4 = new RectangleFullWhite();
            rectangleFullWhite5 = new RectangleFullWhite();
            pieChart1 = new OxyPlot.WindowsForms.PlotView();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            dgvAss = new DataGridView();
            dgvLetters = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAss).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLetters).BeginInit();
            SuspendLayout();
            // 
            // rectangleFullGreen1
            // 
            rectangleFullGreen1.Location = new Point(899, 12);
            rectangleFullGreen1.Name = "rectangleFullGreen1";
            rectangleFullGreen1.Size = new Size(334, 144);
            rectangleFullGreen1.TabIndex = 1;
            // 
            // rectangleFullYellow1
            // 
            rectangleFullYellow1.Location = new Point(547, 12);
            rectangleFullYellow1.Name = "rectangleFullYellow1";
            rectangleFullYellow1.Size = new Size(334, 144);
            rectangleFullYellow1.TabIndex = 2;
            // 
            // barChart1
            // 
            barChart1.BackColor = Color.White;
            barChart1.Location = new Point(30, 69);
            barChart1.Name = "barChart1";
            barChart1.PanCursor = Cursors.Hand;
            barChart1.Size = new Size(484, 474);
            barChart1.TabIndex = 3;
            barChart1.ZoomHorizontalCursor = Cursors.SizeWE;
            barChart1.ZoomRectangleCursor = Cursors.SizeNWSE;
            barChart1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // rectangleFullWhite1
            // 
            rectangleFullWhite1.Location = new Point(12, 12);
            rectangleFullWhite1.Name = "rectangleFullWhite1";
            rectangleFullWhite1.Size = new Size(518, 552);
            rectangleFullWhite1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 221, 100);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 35, 76);
            label1.Location = new Point(564, 30);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 5;
            label1.Text = "No. Registered Farmers";
            // 
            // labelTotalFarmers
            // 
            labelTotalFarmers.AutoSize = true;
            labelTotalFarmers.BackColor = Color.FromArgb(255, 221, 100);
            labelTotalFarmers.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalFarmers.ForeColor = Color.FromArgb(0, 35, 76);
            labelTotalFarmers.Location = new Point(564, 69);
            labelTotalFarmers.Name = "labelTotalFarmers";
            labelTotalFarmers.Size = new Size(55, 62);
            labelTotalFarmers.TabIndex = 6;
            labelTotalFarmers.Text = "#";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 109, 104);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(916, 30);
            label2.Name = "label2";
            label2.Size = new Size(262, 20);
            label2.TabIndex = 7;
            label2.Text = "Avg. Gross Annual Income Last Year";
            // 
            // labelGaiFarming
            // 
            labelGaiFarming.AutoSize = true;
            labelGaiFarming.BackColor = Color.FromArgb(0, 109, 104);
            labelGaiFarming.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelGaiFarming.ForeColor = Color.White;
            labelGaiFarming.Location = new Point(916, 69);
            labelGaiFarming.Name = "labelGaiFarming";
            labelGaiFarming.Size = new Size(55, 62);
            labelGaiFarming.TabIndex = 8;
            labelGaiFarming.Text = "#";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 35, 76);
            label4.Location = new Point(30, 34);
            label4.Name = "label4";
            label4.Size = new Size(244, 20);
            label4.TabIndex = 9;
            label4.Text = "Number of Farmers Per Barangay";
            // 
            // labelGaiNonFarming
            // 
            labelGaiNonFarming.AutoSize = true;
            labelGaiNonFarming.BackColor = Color.FromArgb(255, 221, 100);
            labelGaiNonFarming.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelGaiNonFarming.ForeColor = Color.FromArgb(0, 35, 76);
            labelGaiNonFarming.Location = new Point(1266, 69);
            labelGaiNonFarming.Name = "labelGaiNonFarming";
            labelGaiNonFarming.Size = new Size(55, 62);
            labelGaiNonFarming.TabIndex = 12;
            labelGaiNonFarming.Text = "#";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 221, 100);
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 35, 76);
            label6.Location = new Point(1266, 30);
            label6.Name = "label6";
            label6.Size = new Size(262, 20);
            label6.TabIndex = 11;
            label6.Text = "Avg. Gross Annual Income Last Year";
            // 
            // rectangleFullYellow2
            // 
            rectangleFullYellow2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleFullYellow2.Location = new Point(1249, 12);
            rectangleFullYellow2.Name = "rectangleFullYellow2";
            rectangleFullYellow2.Size = new Size(334, 144);
            rectangleFullYellow2.TabIndex = 10;
            // 
            // rectangleFullWhite2
            // 
            rectangleFullWhite2.Location = new Point(547, 172);
            rectangleFullWhite2.Name = "rectangleFullWhite2";
            rectangleFullWhite2.Size = new Size(686, 392);
            rectangleFullWhite2.TabIndex = 13;
            // 
            // rectangleFullWhite3
            // 
            rectangleFullWhite3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleFullWhite3.Location = new Point(1249, 172);
            rectangleFullWhite3.Name = "rectangleFullWhite3";
            rectangleFullWhite3.Size = new Size(334, 392);
            rectangleFullWhite3.TabIndex = 14;
            // 
            // rectangleFullWhite4
            // 
            rectangleFullWhite4.Location = new Point(12, 580);
            rectangleFullWhite4.Name = "rectangleFullWhite4";
            rectangleFullWhite4.Size = new Size(1221, 334);
            rectangleFullWhite4.TabIndex = 15;
            // 
            // rectangleFullWhite5
            // 
            rectangleFullWhite5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleFullWhite5.Location = new Point(1249, 580);
            rectangleFullWhite5.Name = "rectangleFullWhite5";
            rectangleFullWhite5.Size = new Size(334, 334);
            rectangleFullWhite5.TabIndex = 16;
            // 
            // pieChart1
            // 
            pieChart1.BackColor = Color.White;
            pieChart1.Location = new Point(568, 228);
            pieChart1.Name = "pieChart1";
            pieChart1.PanCursor = Cursors.Hand;
            pieChart1.Size = new Size(650, 321);
            pieChart1.TabIndex = 17;
            pieChart1.ZoomHorizontalCursor = Cursors.SizeWE;
            pieChart1.ZoomRectangleCursor = Cursors.SizeNWSE;
            pieChart1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 35, 76);
            label7.Location = new Point(568, 193);
            label7.Name = "label7";
            label7.Size = new Size(260, 20);
            label7.TabIndex = 18;
            label7.Text = "Number of Farmers Per Commodity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 221, 100);
            label9.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 35, 76);
            label9.Location = new Point(1481, 130);
            label9.Name = "label9";
            label9.Size = new Size(89, 17);
            label9.TabIndex = 20;
            label9.Text = "Non-Farming";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 109, 104);
            label8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1160, 130);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 22;
            label8.Text = "Farming";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 35, 76);
            label3.Location = new Point(1266, 193);
            label3.Name = "label3";
            label3.Size = new Size(172, 20);
            label3.TabIndex = 23;
            label3.Text = "Recently Added Letters";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 35, 76);
            label5.Location = new Point(30, 601);
            label5.Name = "label5";
            label5.Size = new Size(248, 20);
            label5.TabIndex = 25;
            label5.Text = "Farmers Association Per Barangay";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 35, 76);
            label10.Location = new Point(1266, 601);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 27;
            label10.Text = "No. of Barangays";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 35, 76);
            label11.Location = new Point(1355, 699);
            label11.Name = "label11";
            label11.Size = new Size(137, 106);
            label11.TabIndex = 28;
            label11.Text = "22";
            // 
            // dgvAss
            // 
            dgvAss.AllowUserToAddRows = false;
            dgvAss.AllowUserToDeleteRows = false;
            dgvAss.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAss.BackgroundColor = Color.White;
            dgvAss.BorderStyle = BorderStyle.None;
            dgvAss.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAss.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvAss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvAss.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvAss.DefaultCellStyle = dataGridViewCellStyle14;
            dgvAss.GridColor = Color.FromArgb(239, 239, 239);
            dgvAss.Location = new Point(30, 636);
            dgvAss.Name = "dgvAss";
            dgvAss.ReadOnly = true;
            dgvAss.RowHeadersVisible = false;
            dgvAss.RowHeadersWidth = 51;
            dgvAss.RowTemplate.Height = 40;
            dgvAss.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAss.Size = new Size(1188, 258);
            dgvAss.TabIndex = 29;
            // 
            // dgvLetters
            // 
            dgvLetters.AllowUserToAddRows = false;
            dgvLetters.AllowUserToDeleteRows = false;
            dgvLetters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvLetters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLetters.BackgroundColor = Color.White;
            dgvLetters.BorderStyle = BorderStyle.None;
            dgvLetters.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLetters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvLetters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvLetters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dgvLetters.DefaultCellStyle = dataGridViewCellStyle16;
            dgvLetters.GridColor = Color.FromArgb(239, 239, 239);
            dgvLetters.Location = new Point(1266, 228);
            dgvLetters.Name = "dgvLetters";
            dgvLetters.ReadOnly = true;
            dgvLetters.RowHeadersVisible = false;
            dgvLetters.RowHeadersWidth = 51;
            dgvLetters.RowTemplate.Height = 40;
            dgvLetters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLetters.Size = new Size(304, 321);
            dgvLetters.TabIndex = 30;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1595, 926);
            Controls.Add(dgvLetters);
            Controls.Add(dgvAss);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(pieChart1);
            Controls.Add(rectangleFullWhite5);
            Controls.Add(rectangleFullWhite4);
            Controls.Add(rectangleFullWhite3);
            Controls.Add(rectangleFullWhite2);
            Controls.Add(labelGaiNonFarming);
            Controls.Add(label6);
            Controls.Add(rectangleFullYellow2);
            Controls.Add(label4);
            Controls.Add(labelGaiFarming);
            Controls.Add(label2);
            Controls.Add(labelTotalFarmers);
            Controls.Add(label1);
            Controls.Add(barChart1);
            Controls.Add(rectangleFullYellow1);
            Controls.Add(rectangleFullGreen1);
            Controls.Add(rectangleFullWhite1);
            Name = "DashboardView";
            Text = "DashboardView";
            Load += DashboardView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAss).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLetters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RectangleFullGreen rectangleFullGreen1;
        private RectangleFullYellow rectangleFullYellow1;
        private OxyPlot.WindowsForms.PlotView barChart1;
        private RectangleFullWhite rectangleFullWhite1;
        private Label label1;
        private Label labelTotalFarmers;
        private Label label2;
        private Label labelGaiFarming;
        private Label label4;
        private Label labelGaiNonFarming;
        private Label label6;
        private RectangleFullYellow rectangleFullYellow2;
        private RectangleFullWhite rectangleFullWhite2;
        private RectangleFullWhite rectangleFullWhite3;
        private RectangleFullWhite rectangleFullWhite4;
        private RectangleFullWhite rectangleFullWhite5;
        private OxyPlot.WindowsForms.PlotView pieChart1;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label3;
        private Label label5;
        private Label label10;
        private Label label11;
        private DataGridView dgvAss;
        private DataGridView dgvLetters;
    }
}