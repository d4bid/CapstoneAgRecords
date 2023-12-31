﻿namespace AgRecords.View
{
    partial class CertificationsView
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
            panel1 = new Panel();
            label2 = new Label();
            comboBoxFilterBrgy = new ComboBox();
            searchBox3 = new SearchBox();
            comboBoxSearchCategory = new ComboBox();
            searchBox2 = new SearchBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtBoxSearch = new TextBox();
            searchBox1 = new SearchBox();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            dgvCert = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCert).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxFilterBrgy);
            panel1.Controls.Add(searchBox3);
            panel1.Controls.Add(comboBoxSearchCategory);
            panel1.Controls.Add(searchBox2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(txtBoxSearch);
            panel1.Controls.Add(searchBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(1595, 90);
            panel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(566, 15);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 29;
            label2.Text = "Barangay";
            // 
            // comboBoxFilterBrgy
            // 
            comboBoxFilterBrgy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterBrgy.FlatStyle = FlatStyle.Flat;
            comboBoxFilterBrgy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilterBrgy.FormattingEnabled = true;
            comboBoxFilterBrgy.Items.AddRange(new object[] { "ALL", "AGGUB", "BAGAHABAG", "BANGAAN", "BANGAR", "BASCARAN", "COMMUNAL", "CONCEPCION CALALABANGAN", "CURIFANG", "DADAP", "LACTAWAN", "OSMENA", "PILAR D. GALIMA", "POBLACION NORTH", "POBLACION SOUTH", "QUEZON", "QUIRINO", "ROXAS", "SAN JUAN", "SAN LUIS", "TUCAL", "UDDIAWAN", "WACAL" });
            comboBoxFilterBrgy.Location = new Point(572, 43);
            comboBoxFilterBrgy.Name = "comboBoxFilterBrgy";
            comboBoxFilterBrgy.Size = new Size(174, 28);
            comboBoxFilterBrgy.TabIndex = 23;
            comboBoxFilterBrgy.SelectedIndexChanged += comboBoxFilterBrgy_SelectedIndexChanged;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(566, 38);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(184, 39);
            searchBox3.TabIndex = 28;
            // 
            // comboBoxSearchCategory
            // 
            comboBoxSearchCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCategory.FlatStyle = FlatStyle.Flat;
            comboBoxSearchCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSearchCategory.FormattingEnabled = true;
            comboBoxSearchCategory.Items.AddRange(new object[] { "ALL", "RSBSA ID", "FIRST NAME", "LAST NAME", "BIRTHDATE", "NO. OF FARM PARCEL" });
            comboBoxSearchCategory.Location = new Point(368, 43);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(183, 28);
            comboBoxSearchCategory.TabIndex = 21;
            comboBoxSearchCategory.SelectedIndexChanged += comboBoxSearchCategory_SelectedIndexChanged;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(363, 38);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(191, 39);
            searchBox2.TabIndex = 27;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.GrayText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = SystemColors.GrayText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(20, 45);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 24;
            iconPictureBox1.TabStop = false;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.BorderStyle = BorderStyle.None;
            txtBoxSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxSearch.Location = new Point(48, 44);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.PlaceholderText = "Search";
            txtBoxSearch.Size = new Size(291, 24);
            txtBoxSearch.TabIndex = 22;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(12, 38);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(341, 39);
            searchBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 15);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 25;
            label1.Text = "Category";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(239, 239, 239);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 10);
            panel3.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvCert);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1595, 826);
            panel2.TabIndex = 27;
            // 
            // dgvCert
            // 
            dgvCert.AllowUserToAddRows = false;
            dgvCert.AllowUserToDeleteRows = false;
            dgvCert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCert.BackgroundColor = Color.White;
            dgvCert.BorderStyle = BorderStyle.None;
            dgvCert.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCert.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCert.Dock = DockStyle.Fill;
            dgvCert.GridColor = Color.FromArgb(239, 239, 239);
            dgvCert.Location = new Point(10, 10);
            dgvCert.Name = "dgvCert";
            dgvCert.ReadOnly = true;
            dgvCert.RowHeadersVisible = false;
            dgvCert.RowHeadersWidth = 51;
            dgvCert.RowTemplate.Height = 40;
            dgvCert.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCert.Size = new Size(1575, 806);
            dgvCert.TabIndex = 23;
            dgvCert.CellDoubleClick += dgvCert_CellDoubleClick;
            // 
            // CertificationsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CertificationsView";
            Text = "CertificationsView";
            Load += CertificationsView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCert).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvCert;
        private Label label2;
        private ComboBox comboBoxFilterBrgy;
        private SearchBox searchBox3;
        private ComboBox comboBoxSearchCategory;
        private SearchBox searchBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtBoxSearch;
        private SearchBox searchBox1;
        private Label label1;
    }
}