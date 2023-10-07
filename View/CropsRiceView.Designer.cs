namespace AgRecords.View
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnAdd = new Button();
            panel2 = new Panel();
            dgvRicePlanting = new DataGridView();
            panel3 = new Panel();
            label2 = new Label();
            comboBoxFilterType = new ComboBox();
            searchBox3 = new SearchBox();
            comboBoxSearchCategory = new ComboBox();
            searchBox2 = new SearchBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtBoxSearch = new TextBox();
            searchBox1 = new SearchBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRicePlanting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvRicePlanting);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(1595, 836);
            panel2.TabIndex = 23;
            // 
            // dgvRicePlanting
            // 
            dgvRicePlanting.AllowUserToAddRows = false;
            dgvRicePlanting.AllowUserToDeleteRows = false;
            dgvRicePlanting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRicePlanting.BackgroundColor = Color.White;
            dgvRicePlanting.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRicePlanting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRicePlanting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRicePlanting.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRicePlanting.GridColor = Color.FromArgb(239, 239, 239);
            dgvRicePlanting.Location = new Point(12, 15);
            dgvRicePlanting.Name = "dgvRicePlanting";
            dgvRicePlanting.ReadOnly = true;
            dgvRicePlanting.RowHeadersVisible = false;
            dgvRicePlanting.RowHeadersWidth = 51;
            dgvRicePlanting.RowTemplate.Height = 40;
            dgvRicePlanting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRicePlanting.Size = new Size(1571, 809);
            dgvRicePlanting.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 5);
            panel3.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(635, 11);
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
            comboBoxFilterType.Items.AddRange(new object[] { "All", "Incoming", "Outgoing", "Internal" });
            comboBoxFilterType.Location = new Point(640, 39);
            comboBoxFilterType.Name = "comboBoxFilterType";
            comboBoxFilterType.Size = new Size(237, 28);
            comboBoxFilterType.TabIndex = 11;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(635, 34);
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
            comboBoxSearchCategory.Items.AddRange(new object[] { "All", "ID", "Title", "Receiver", "Sender", "Date Received" });
            comboBoxSearchCategory.Location = new Point(377, 39);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(237, 28);
            comboBoxSearchCategory.TabIndex = 9;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(372, 34);
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
            label1.Location = new Point(372, 11);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 13;
            label1.Text = "Category";
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
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRicePlanting).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvRicePlanting;
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
    }
}