namespace AgRecords.View
{
    partial class CropsCornView
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
            btnAdd = new Button();
            label2 = new Label();
            cmbReportType = new ComboBox();
            searchBox3 = new SearchBox();
            cmbColumn = new ComboBox();
            searchBox2 = new SearchBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtBoxSearch = new TextBox();
            searchBox1 = new SearchBox();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            dgvCorn = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCorn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbReportType);
            panel1.Controls.Add(searchBox3);
            panel1.Controls.Add(cmbColumn);
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
            panel1.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(43, 121, 223);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1438, 27);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 39);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 11);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 17;
            label2.Text = "Report Type";
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FlatStyle = FlatStyle.Flat;
            cmbReportType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Planting", "Planting By Ecological Zone", "Harvesting" });
            cmbReportType.Location = new Point(385, 39);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(305, 28);
            cmbReportType.TabIndex = 11;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(380, 34);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(314, 39);
            searchBox3.TabIndex = 16;
            // 
            // cmbColumn
            // 
            cmbColumn.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColumn.FlatStyle = FlatStyle.Flat;
            cmbColumn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbColumn.FormattingEnabled = true;
            cmbColumn.Items.AddRange(new object[] { "All", "ID", "Season", "Season Year", "Month", "Week", "Year", "Created By", "Date" });
            cmbColumn.Location = new Point(719, 39);
            cmbColumn.Name = "cmbColumn";
            cmbColumn.Size = new Size(237, 28);
            cmbColumn.TabIndex = 9;
            cmbColumn.SelectedIndexChanged += cmbColumn_SelectedIndexChanged;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(714, 34);
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
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
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
            label1.Location = new Point(714, 11);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 13;
            label1.Text = "Column";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 10);
            panel3.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvCorn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1595, 826);
            panel2.TabIndex = 26;
            // 
            // dgvCorn
            // 
            dgvCorn.AllowUserToAddRows = false;
            dgvCorn.AllowUserToDeleteRows = false;
            dgvCorn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCorn.BackgroundColor = Color.White;
            dgvCorn.BorderStyle = BorderStyle.None;
            dgvCorn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCorn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCorn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCorn.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCorn.Dock = DockStyle.Fill;
            dgvCorn.GridColor = Color.FromArgb(239, 239, 239);
            dgvCorn.Location = new Point(10, 10);
            dgvCorn.Name = "dgvCorn";
            dgvCorn.ReadOnly = true;
            dgvCorn.RowHeadersVisible = false;
            dgvCorn.RowHeadersWidth = 51;
            dgvCorn.RowTemplate.Height = 40;
            dgvCorn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCorn.Size = new Size(1575, 806);
            dgvCorn.TabIndex = 23;
            dgvCorn.CellDoubleClick += dgvCorn_CellDoubleClick;
            // 
            // CropsCornView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CropsCornView";
            Text = "CropsCornView";
            Load += CropsCornView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCorn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private ComboBox cmbReportType;
        private SearchBox searchBox3;
        private ComboBox cmbColumn;
        private SearchBox searchBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtBoxSearch;
        private SearchBox searchBox1;
        private Label label1;
        private Button btnAdd;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvCorn;
    }
}