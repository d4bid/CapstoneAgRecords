namespace AgRecords.View
{
    partial class RsbsaView
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
            btnExport = new FontAwesome.Sharp.IconButton();
            btnImport = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            comboBoxFilterCommodity = new ComboBox();
            searchBox4 = new SearchBox();
            label2 = new Label();
            comboBoxFilterBrgy = new ComboBox();
            searchBox3 = new SearchBox();
            comboBoxSearchCategory = new ComboBox();
            searchBox2 = new SearchBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtBoxSearch = new TextBox();
            searchBox1 = new SearchBox();
            label1 = new Label();
            btnAdd = new Button();
            dgvRsbsa = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRsbsa).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxFilterCommodity);
            panel1.Controls.Add(searchBox4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxFilterBrgy);
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
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(1595, 91);
            panel1.TabIndex = 20;
            // 
            // btnExport
            // 
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(3, 0, 67);
            btnExport.FlatAppearance.BorderSize = 2;
            btnExport.FlatAppearance.MouseDownBackColor = Color.White;
            btnExport.FlatAppearance.MouseOverBackColor = Color.White;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.FromArgb(3, 0, 67);
            btnExport.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            btnExport.IconColor = Color.FromArgb(3, 0, 67);
            btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExport.IconSize = 30;
            btnExport.Location = new Point(1250, 33);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(148, 40);
            btnExport.TabIndex = 56;
            btnExport.Text = "Export";
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.FlatAppearance.BorderColor = Color.FromArgb(3, 0, 67);
            btnImport.FlatAppearance.BorderSize = 2;
            btnImport.FlatAppearance.MouseDownBackColor = Color.White;
            btnImport.FlatAppearance.MouseOverBackColor = Color.White;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnImport.ForeColor = Color.FromArgb(3, 0, 67);
            btnImport.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            btnImport.IconColor = Color.FromArgb(3, 0, 67);
            btnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImport.IconSize = 30;
            btnImport.Location = new Point(1096, 33);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(148, 40);
            btnImport.TabIndex = 55;
            btnImport.Text = "Import";
            btnImport.TextAlign = ContentAlignment.MiddleRight;
            btnImport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(774, 14);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 20;
            label3.Text = "Commodity";
            // 
            // comboBoxFilterCommodity
            // 
            comboBoxFilterCommodity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterCommodity.FlatStyle = FlatStyle.Flat;
            comboBoxFilterCommodity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilterCommodity.FormattingEnabled = true;
            comboBoxFilterCommodity.Items.AddRange(new object[] { "ALL", "Rice", "Corn", "HVC" });
            comboBoxFilterCommodity.Location = new Point(781, 42);
            comboBoxFilterCommodity.Name = "comboBoxFilterCommodity";
            comboBoxFilterCommodity.Size = new Size(174, 28);
            comboBoxFilterCommodity.TabIndex = 18;
            comboBoxFilterCommodity.SelectedIndexChanged += comboBoxFilterCommodity_SelectedIndexChanged;
            // 
            // searchBox4
            // 
            searchBox4.Location = new Point(774, 37);
            searchBox4.Name = "searchBox4";
            searchBox4.Size = new Size(184, 39);
            searchBox4.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 14);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 17;
            label2.Text = "Barangay";
            // 
            // comboBoxFilterBrgy
            // 
            comboBoxFilterBrgy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterBrgy.FlatStyle = FlatStyle.Flat;
            comboBoxFilterBrgy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilterBrgy.FormattingEnabled = true;
            comboBoxFilterBrgy.Items.AddRange(new object[] { "ALL", "AGGUB", "BAGAHABAG", "BANGAAN", "BANGAR", "BASCARAN", "COMMUNAL", "CONCEPCION CALALABANGAN", "CURIFANG", "DADAP", "LACTAWAN", "OSMENA", "PILAR D. GALIMA", "POBLACION NORTH", "QUEZON", "QUIRINO", "ROXAS", "SAN JUAN", "SAN LUIS", "TUCAL", "UDDIAWAN", "WACAL" });
            comboBoxFilterBrgy.Location = new Point(374, 42);
            comboBoxFilterBrgy.Name = "comboBoxFilterBrgy";
            comboBoxFilterBrgy.Size = new Size(174, 28);
            comboBoxFilterBrgy.TabIndex = 11;
            comboBoxFilterBrgy.SelectedIndexChanged += comboBoxFilterBrgy_SelectedIndexChanged;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(368, 37);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(184, 39);
            searchBox3.TabIndex = 16;
            // 
            // comboBoxSearchCategory
            // 
            comboBoxSearchCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCategory.FlatStyle = FlatStyle.Flat;
            comboBoxSearchCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSearchCategory.FormattingEnabled = true;
            comboBoxSearchCategory.Items.AddRange(new object[] { "ALL", "ID", "FIRST NAME", "MIDDLE NAME", "SURNAME" });
            comboBoxSearchCategory.Location = new Point(573, 42);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(183, 28);
            comboBoxSearchCategory.TabIndex = 9;
            comboBoxSearchCategory.SelectedIndexChanged += comboBoxSearchCategory_SelectedIndexChanged;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(568, 37);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(191, 39);
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
            iconPictureBox1.Location = new Point(19, 44);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 12;
            iconPictureBox1.TabStop = false;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.BorderStyle = BorderStyle.None;
            txtBoxSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxSearch.Location = new Point(46, 41);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.PlaceholderText = "Search";
            txtBoxSearch.Size = new Size(291, 24);
            txtBoxSearch.TabIndex = 10;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(11, 37);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(341, 39);
            searchBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(568, 14);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 13;
            label1.Text = "Category";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(43, 121, 223);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1433, 33);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvRsbsa
            // 
            dgvRsbsa.AllowUserToAddRows = false;
            dgvRsbsa.AllowUserToDeleteRows = false;
            dgvRsbsa.BackgroundColor = Color.White;
            dgvRsbsa.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRsbsa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRsbsa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRsbsa.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRsbsa.Dock = DockStyle.Fill;
            dgvRsbsa.GridColor = Color.FromArgb(239, 239, 239);
            dgvRsbsa.Location = new Point(10, 10);
            dgvRsbsa.Name = "dgvRsbsa";
            dgvRsbsa.ReadOnly = true;
            dgvRsbsa.RowHeadersVisible = false;
            dgvRsbsa.RowHeadersWidth = 51;
            dgvRsbsa.RowTemplate.Height = 25;
            dgvRsbsa.ScrollBars = ScrollBars.None;
            dgvRsbsa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRsbsa.Size = new Size(1575, 805);
            dgvRsbsa.TabIndex = 19;
            dgvRsbsa.CellDoubleClick += dgvRsbsa_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(239, 239, 239);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 10);
            panel3.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvRsbsa);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 101);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1595, 825);
            panel2.TabIndex = 29;
            // 
            // RsbsaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "RsbsaView";
            Text = "RsbsaView";
            Load += RsbsaView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRsbsa).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvRsbsa;
        private Button btnAdd;
        private Label label2;
        private ComboBox comboBoxFilterBrgy;
        private SearchBox searchBox3;
        private ComboBox comboBoxSearchCategory;
        private SearchBox searchBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtBoxSearch;
        private SearchBox searchBox1;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxFilterCommodity;
        private SearchBox searchBox4;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconButton btnImport;
        private Panel panel3;
        private Panel panel2;
    }
}