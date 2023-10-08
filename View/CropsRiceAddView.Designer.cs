namespace AgRecords.View
{
    partial class CropsRiceAddView
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
            label2 = new Label();
            searchBox3 = new SearchBox();
            comboBoxSearchCategory = new ComboBox();
            searchBox2 = new SearchBox();
            label1 = new Label();
            btnAdd = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            dgvRicePlanting = new DataGridView();
            label3 = new Label();
            cmbSeason = new ComboBox();
            searchBox1 = new SearchBox();
            labelReport = new Label();
            label4 = new Label();
            cmbMonth = new ComboBox();
            searchBox4 = new SearchBox();
            label5 = new Label();
            cmbWeek = new ComboBox();
            searchBox5 = new SearchBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRicePlanting).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbWeek);
            panel1.Controls.Add(searchBox5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbMonth);
            panel1.Controls.Add(searchBox4);
            panel1.Controls.Add(labelReport);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbSeason);
            panel1.Controls.Add(searchBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(searchBox3);
            panel1.Controls.Add(comboBoxSearchCategory);
            panel1.Controls.Add(searchBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(1595, 90);
            panel1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 11);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 17;
            label2.Text = "Report";
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(17, 34);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(192, 39);
            searchBox3.TabIndex = 16;
            // 
            // comboBoxSearchCategory
            // 
            comboBoxSearchCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCategory.FlatStyle = FlatStyle.Flat;
            comboBoxSearchCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSearchCategory.FormattingEnabled = true;
            comboBoxSearchCategory.Items.AddRange(new object[] { "All", "Irrigated", "Rainfed Lowland", "Raindfed Upland" });
            comboBoxSearchCategory.Location = new Point(1173, 39);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(237, 28);
            comboBoxSearchCategory.TabIndex = 9;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(1168, 34);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(246, 39);
            searchBox2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1168, 11);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 13;
            label1.Text = "Farm Type";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(43, 121, 223);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1444, 34);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 39);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 5);
            panel3.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvRicePlanting);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(1595, 831);
            panel2.TabIndex = 26;
            // 
            // dgvRicePlanting
            // 
            dgvRicePlanting.AllowUserToAddRows = false;
            dgvRicePlanting.AllowUserToDeleteRows = false;
            dgvRicePlanting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRicePlanting.BackgroundColor = Color.White;
            dgvRicePlanting.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRicePlanting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvRicePlanting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRicePlanting.DefaultCellStyle = dataGridViewCellStyle6;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 11);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 20;
            label3.Text = "Season";
            // 
            // cmbSeason
            // 
            cmbSeason.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeason.FlatStyle = FlatStyle.Flat;
            cmbSeason.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSeason.FormattingEnabled = true;
            cmbSeason.Items.AddRange(new object[] { "Dry", "Wet" });
            cmbSeason.Location = new Point(233, 39);
            cmbSeason.Name = "cmbSeason";
            cmbSeason.Size = new Size(184, 28);
            cmbSeason.TabIndex = 18;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(228, 34);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(193, 39);
            searchBox1.TabIndex = 19;
            // 
            // labelReport
            // 
            labelReport.AutoSize = true;
            labelReport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelReport.Location = new Point(28, 38);
            labelReport.Name = "labelReport";
            labelReport.Size = new Size(87, 28);
            labelReport.TabIndex = 21;
            labelReport.Text = "Planting";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 11);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 24;
            label4.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FlatStyle = FlatStyle.Flat;
            cmbMonth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cmbMonth.Location = new Point(444, 39);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(184, 28);
            cmbMonth.TabIndex = 22;
            // 
            // searchBox4
            // 
            searchBox4.Location = new Point(439, 34);
            searchBox4.Name = "searchBox4";
            searchBox4.Size = new Size(193, 39);
            searchBox4.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 11);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 27;
            label5.Text = "Week";
            // 
            // cmbWeek
            // 
            cmbWeek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeek.FlatStyle = FlatStyle.Flat;
            cmbWeek.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbWeek.FormattingEnabled = true;
            cmbWeek.Items.AddRange(new object[] { "1-15", "16-30", "16-31" });
            cmbWeek.Location = new Point(658, 39);
            cmbWeek.Name = "cmbWeek";
            cmbWeek.Size = new Size(184, 28);
            cmbWeek.TabIndex = 25;
            // 
            // searchBox5
            // 
            searchBox5.Location = new Point(653, 34);
            searchBox5.Name = "searchBox5";
            searchBox5.Size = new Size(193, 39);
            searchBox5.TabIndex = 26;
            // 
            // CropsRiceAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CropsRiceAddView";
            Text = "CropsRiceAddView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRicePlanting).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private SearchBox searchBox3;
        private ComboBox comboBoxSearchCategory;
        private SearchBox searchBox2;
        private Label label1;
        private Button btnAdd;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvRicePlanting;
        private Label label3;
        private ComboBox cmbSeason;
        private SearchBox searchBox1;
        private Label labelReport;
        private Label label5;
        private ComboBox cmbWeek;
        private SearchBox searchBox5;
        private Label label4;
        private ComboBox cmbMonth;
        private SearchBox searchBox4;
    }
}