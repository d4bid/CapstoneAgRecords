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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnImport = new Button();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRsbsa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(1595, 91);
            panel1.TabIndex = 20;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.BackColor = Color.FromArgb(43, 121, 223);
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnImport.ForeColor = Color.White;
            btnImport.Location = new Point(1244, 27);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(177, 39);
            btnImport.TabIndex = 4;
            btnImport.Text = "Import Excel File";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(766, 14);
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
            comboBoxFilterCommodity.Location = new Point(773, 42);
            comboBoxFilterCommodity.Name = "comboBoxFilterCommodity";
            comboBoxFilterCommodity.Size = new Size(174, 28);
            comboBoxFilterCommodity.TabIndex = 18;
            comboBoxFilterCommodity.SelectedIndexChanged += comboBoxFilterCommodity_SelectedIndexChanged;
            // 
            // searchBox4
            // 
            searchBox4.Location = new Point(766, 37);
            searchBox4.Name = "searchBox4";
            searchBox4.Size = new Size(184, 39);
            searchBox4.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(570, 14);
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
            comboBoxFilterBrgy.Location = new Point(576, 42);
            comboBoxFilterBrgy.Name = "comboBoxFilterBrgy";
            comboBoxFilterBrgy.Size = new Size(174, 28);
            comboBoxFilterBrgy.TabIndex = 11;
            comboBoxFilterBrgy.SelectedIndexChanged += comboBoxFilterBrgy_SelectedIndexChanged;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(570, 37);
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
            comboBoxSearchCategory.Location = new Point(371, 42);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(183, 28);
            comboBoxSearchCategory.TabIndex = 9;
            comboBoxSearchCategory.SelectedIndexChanged += comboBoxSearchCategory_SelectedIndexChanged;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(366, 37);
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
            iconPictureBox1.Location = new Point(14, 44);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 12;
            iconPictureBox1.TabStop = false;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.BorderStyle = BorderStyle.None;
            txtBoxSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxSearch.Location = new Point(41, 41);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.PlaceholderText = "Search";
            txtBoxSearch.Size = new Size(291, 24);
            txtBoxSearch.TabIndex = 10;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(6, 37);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(341, 39);
            searchBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 14);
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
            btnAdd.Location = new Point(1443, 27);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 39);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvRsbsa
            // 
            dgvRsbsa.AllowUserToAddRows = false;
            dgvRsbsa.AllowUserToDeleteRows = false;
            dgvRsbsa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRsbsa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRsbsa.BackgroundColor = Color.White;
            dgvRsbsa.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRsbsa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvRsbsa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRsbsa.DefaultCellStyle = dataGridViewCellStyle6;
            dgvRsbsa.GridColor = Color.FromArgb(239, 239, 239);
            dgvRsbsa.Location = new Point(0, 99);
            dgvRsbsa.Name = "dgvRsbsa";
            dgvRsbsa.ReadOnly = true;
            dgvRsbsa.RowHeadersVisible = false;
            dgvRsbsa.RowHeadersWidth = 51;
            dgvRsbsa.RowTemplate.Height = 25;
            dgvRsbsa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRsbsa.Size = new Size(1595, 827);
            dgvRsbsa.TabIndex = 19;
            dgvRsbsa.CellDoubleClick += dgvRsbsa_CellDoubleClick;
            // 
            // RsbsaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1595, 926);
            Controls.Add(dgvRsbsa);
            Controls.Add(panel1);
            Name = "RsbsaView";
            Text = "RsbsaView";
            Load += RsbsaView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRsbsa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvRsbsa;
        private Button btnAdd;
        private Button btnImport;
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
    }
}