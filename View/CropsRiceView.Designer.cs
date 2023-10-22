﻿namespace AgRecords.View
{
    partial class CropsRiceView
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            comboBoxFilterType = new ComboBox();
            searchBox3 = new SearchBox();
            comboBoxSearchCategory = new ComboBox();
            searchBox2 = new SearchBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtBoxSearch = new TextBox();
            searchBox1 = new SearchBox();
            label1 = new Label();
            btnAdd = new Button();
            panel2 = new Panel();
            dgvRice = new DataGridView();
            panel4 = new Panel();
            panel5 = new Panel();
            btnPrint = new Button();
            panel3 = new Panel();
            cbHarvesting = new CheckBox();
            cbStanding = new CheckBox();
            cbPlanting = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRice).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxFilterType);
            panel1.Controls.Add(searchBox3);
            panel1.Controls.Add(comboBoxSearchCategory);
            panel1.Controls.Add(searchBox2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(txtBoxSearch);
            panel1.Controls.Add(searchBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(1595, 90);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 11);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 17;
            label2.Text = "Type";
            // 
            // comboBoxFilterType
            // 
            comboBoxFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterType.FlatStyle = FlatStyle.Flat;
            comboBoxFilterType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilterType.FormattingEnabled = true;
            comboBoxFilterType.Items.AddRange(new object[] { "All", "Planting", "Standing", "Harvesting" });
            comboBoxFilterType.Location = new Point(379, 39);
            comboBoxFilterType.Name = "comboBoxFilterType";
            comboBoxFilterType.Size = new Size(237, 28);
            comboBoxFilterType.TabIndex = 11;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(374, 34);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(246, 39);
            searchBox3.TabIndex = 16;
            // 
            // comboBoxSearchCategory
            // 
            comboBoxSearchCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCategory.FlatStyle = FlatStyle.Flat;
            comboBoxSearchCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSearchCategory.FormattingEnabled = true;
            comboBoxSearchCategory.Items.AddRange(new object[] { "All", "ID", "Season", "Week", "Year" });
            comboBoxSearchCategory.Location = new Point(644, 39);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(237, 28);
            comboBoxSearchCategory.TabIndex = 9;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(639, 34);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(246, 39);
            searchBox2.TabIndex = 15;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.GrayText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = SystemColors.GrayText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(21, 41);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 12;
            iconPictureBox1.TabStop = false;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.BorderStyle = BorderStyle.None;
            txtBoxSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxSearch.Location = new Point(48, 38);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.PlaceholderText = "Search";
            txtBoxSearch.Size = new Size(297, 24);
            txtBoxSearch.TabIndex = 10;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(13, 34);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(343, 39);
            searchBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(639, 11);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 13;
            label1.Text = "Category";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(43, 121, 223);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1438, 27);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 39);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvRice);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1595, 836);
            panel2.TabIndex = 23;
            // 
            // dgvRice
            // 
            dgvRice.AllowUserToAddRows = false;
            dgvRice.AllowUserToDeleteRows = false;
            dgvRice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRice.BackgroundColor = Color.White;
            dgvRice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvRice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvRice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvRice.DefaultCellStyle = dataGridViewCellStyle10;
            dgvRice.Dock = DockStyle.Fill;
            dgvRice.GridColor = Color.FromArgb(239, 239, 239);
            dgvRice.Location = new Point(10, 85);
            dgvRice.Name = "dgvRice";
            dgvRice.ReadOnly = true;
            dgvRice.RowHeadersVisible = false;
            dgvRice.RowHeadersWidth = 51;
            dgvRice.RowTemplate.Height = 40;
            dgvRice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRice.Size = new Size(1575, 741);
            dgvRice.TabIndex = 23;
            dgvRice.CellDoubleClick += dgvRice_CellDoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(btnPrint);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(1575, 75);
            panel4.TabIndex = 24;
            // 
            // panel5
            // 
            panel5.Controls.Add(cbHarvesting);
            panel5.Controls.Add(cbStanding);
            panel5.Controls.Add(cbPlanting);
            panel5.Location = new Point(15, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(472, 46);
            panel5.TabIndex = 76;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.White;
            btnPrint.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnPrint.FlatAppearance.BorderSize = 2;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.FromArgb(43, 121, 223);
            btnPrint.Location = new Point(1428, 19);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(139, 36);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 5);
            panel3.TabIndex = 24;
            // 
            // cbHarvesting
            // 
            cbHarvesting.AutoSize = true;
            cbHarvesting.Location = new Point(328, 13);
            cbHarvesting.Name = "cbHarvesting";
            cbHarvesting.Size = new Size(102, 24);
            cbHarvesting.TabIndex = 6;
            cbHarvesting.Text = "Harvesting";
            cbHarvesting.UseVisualStyleBackColor = true;
            cbHarvesting.CheckedChanged += cbHarvesting_CheckedChanged;
            // 
            // cbStanding
            // 
            cbStanding.AutoSize = true;
            cbStanding.Location = new Point(170, 13);
            cbStanding.Name = "cbStanding";
            cbStanding.Size = new Size(90, 24);
            cbStanding.TabIndex = 5;
            cbStanding.Text = "Standing";
            cbStanding.UseVisualStyleBackColor = true;
            cbStanding.CheckedChanged += cbStanding_CheckedChanged;
            // 
            // cbPlanting
            // 
            cbPlanting.AutoSize = true;
            cbPlanting.Location = new Point(24, 13);
            cbPlanting.Name = "cbPlanting";
            cbPlanting.Size = new Size(85, 24);
            cbPlanting.TabIndex = 4;
            cbPlanting.Text = "Planting";
            cbPlanting.UseVisualStyleBackColor = true;
            cbPlanting.CheckedChanged += cbPlanting_CheckedChanged;
            // 
            // CropsRiceView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1595, 926);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CropsRiceView";
            Text = "CropsRiceView";
            Load += CropsRiceView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRice).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvRice;
        private Button btnAdd;
        private Label label2;
        private ComboBox comboBoxFilterType;
        private SearchBox searchBox3;
        private ComboBox comboBoxSearchCategory;
        private SearchBox searchBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtBoxSearch;
        private SearchBox searchBox1;
        private Label label1;
        private Panel panel4;
        private Button btnPrint;
        private Panel panel5;
        private CheckBox cbHarvesting;
        private CheckBox cbStanding;
        private CheckBox cbPlanting;
    }
}