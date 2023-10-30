namespace AgRecords.View
{
    partial class LettersView
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            btnAdd = new Button();
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
            dgvLetters = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLetters).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(43, 121, 223);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1444, 33);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 39);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(1595, 91);
            panel1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 13);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 8;
            label2.Text = "Type";
            // 
            // comboBoxFilterType
            // 
            comboBoxFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterType.FlatStyle = FlatStyle.Flat;
            comboBoxFilterType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilterType.FormattingEnabled = true;
            comboBoxFilterType.Items.AddRange(new object[] { "All", "Incoming", "Outgoing", "Internal" });
            comboBoxFilterType.Location = new Point(387, 41);
            comboBoxFilterType.Name = "comboBoxFilterType";
            comboBoxFilterType.Size = new Size(237, 28);
            comboBoxFilterType.TabIndex = 3;
            comboBoxFilterType.SelectedIndexChanged += comboBoxFilterType_SelectedIndexChanged;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(382, 36);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(246, 39);
            searchBox3.TabIndex = 7;
            // 
            // comboBoxSearchCategory
            // 
            comboBoxSearchCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCategory.FlatStyle = FlatStyle.Flat;
            comboBoxSearchCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSearchCategory.FormattingEnabled = true;
            comboBoxSearchCategory.Items.AddRange(new object[] { "All", "ID", "Title", "Receiver", "Sender", "Tag", "Date Received" });
            comboBoxSearchCategory.Location = new Point(652, 40);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(237, 28);
            comboBoxSearchCategory.TabIndex = 0;
            comboBoxSearchCategory.SelectedValueChanged += comboBoxSearchFilter_SelectedValueChanged;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(647, 35);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(246, 39);
            searchBox2.TabIndex = 6;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.GrayText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = SystemColors.GrayText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(24, 43);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.BorderStyle = BorderStyle.None;
            txtBoxSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxSearch.Location = new Point(51, 40);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.PlaceholderText = "Search";
            txtBoxSearch.Size = new Size(297, 24);
            txtBoxSearch.TabIndex = 0;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(16, 36);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(343, 39);
            searchBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(647, 12);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 4;
            label1.Text = "Filter";
            // 
            // dgvLetters
            // 
            dgvLetters.AllowUserToAddRows = false;
            dgvLetters.AllowUserToDeleteRows = false;
            dgvLetters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLetters.BackgroundColor = Color.White;
            dgvLetters.BorderStyle = BorderStyle.None;
            dgvLetters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvLetters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvLetters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvLetters.DefaultCellStyle = dataGridViewCellStyle12;
            dgvLetters.Dock = DockStyle.Fill;
            dgvLetters.GridColor = Color.FromArgb(239, 239, 239);
            dgvLetters.Location = new Point(10, 10);
            dgvLetters.Name = "dgvLetters";
            dgvLetters.ReadOnly = true;
            dgvLetters.RowHeadersVisible = false;
            dgvLetters.RowHeadersWidth = 51;
            dgvLetters.RowTemplate.Height = 40;
            dgvLetters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLetters.Size = new Size(1575, 805);
            dgvLetters.TabIndex = 22;
            dgvLetters.CellDoubleClick += dgvLetters_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1595, 10);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvLetters);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 101);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(1595, 825);
            panel3.TabIndex = 24;
            // 
            // LettersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1595, 926);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LettersView";
            Text = "LettersView";
            Load += LettersView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLetters).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Panel panel1;
        private DataGridView dgvLetters;
        private TextBox txtBoxSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ComboBox comboBoxSearchCategory;
        private ComboBox comboBoxFilterType;
        private Label label1;
        private SearchBox searchBox1;
        private Panel panel2;
        private SearchBox searchBox2;
        private SearchBox searchBox3;
        private Label label2;
        private Panel panel3;
    }
}