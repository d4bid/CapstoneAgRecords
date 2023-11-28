namespace AgRecords.View
{
    partial class SettingsManageDataView
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
            panel5 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            label6 = new Label();
            label4 = new Label();
            searchBox3 = new SearchBox();
            txtBarangay = new TextBox();
            btnAdd = new Button();
            dgvBarangay = new DataGridView();
            label5 = new Label();
            searchBox4 = new SearchBox();
            comboBoxStatus = new ComboBox();
            label1 = new Label();
            searchBox1 = new SearchBox();
            comboBoxFilter = new ComboBox();
            panel3 = new Panel();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarangay).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1595, 926);
            panel5.TabIndex = 77;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(10);
            panel9.Size = new Size(1595, 926);
            panel9.TabIndex = 77;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(comboBoxFilter);
            panel10.Controls.Add(searchBox1);
            panel10.Controls.Add(label1);
            panel10.Controls.Add(comboBoxStatus);
            panel10.Controls.Add(searchBox4);
            panel10.Controls.Add(label5);
            panel10.Controls.Add(dgvBarangay);
            panel10.Controls.Add(btnAdd);
            panel10.Controls.Add(txtBarangay);
            panel10.Controls.Add(searchBox3);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(panel11);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(10, 10);
            panel10.Name = "panel10";
            panel10.Size = new Size(1575, 906);
            panel10.TabIndex = 75;
            panel10.Paint += panel10_Paint;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(43, 121, 223);
            panel11.Controls.Add(label6);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1573, 29);
            panel11.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 1);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 28;
            label6.Text = "BARANGAY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 58);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 92;
            label4.Text = "Barangay";
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(90, 81);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(393, 39);
            searchBox3.TabIndex = 93;
            // 
            // txtBarangay
            // 
            txtBarangay.BorderStyle = BorderStyle.None;
            txtBarangay.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtBarangay.Location = new Point(103, 87);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.PlaceholderText = "Enter new barangay";
            txtBarangay.Size = new Size(368, 25);
            txtBarangay.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(43, 121, 223);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1313, 81);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 39);
            btnAdd.TabIndex = 94;
            btnAdd.Text = "Add Barangay";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvBarangay
            // 
            dgvBarangay.AllowUserToAddRows = false;
            dgvBarangay.AllowUserToDeleteRows = false;
            dgvBarangay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBarangay.BackgroundColor = Color.White;
            dgvBarangay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBarangay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBarangay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvBarangay.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBarangay.GridColor = Color.FromArgb(239, 239, 239);
            dgvBarangay.Location = new Point(90, 145);
            dgvBarangay.Name = "dgvBarangay";
            dgvBarangay.ReadOnly = true;
            dgvBarangay.RowHeadersVisible = false;
            dgvBarangay.RowHeadersWidth = 51;
            dgvBarangay.RowTemplate.Height = 40;
            dgvBarangay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBarangay.Size = new Size(1384, 642);
            dgvBarangay.TabIndex = 95;
            dgvBarangay.CellDoubleClick += dgvBarangay_CellDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 59);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 97;
            label5.Text = "Status";
            // 
            // searchBox4
            // 
            searchBox4.Location = new Point(497, 81);
            searchBox4.Name = "searchBox4";
            searchBox4.Size = new Size(215, 39);
            searchBox4.TabIndex = 98;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FlatStyle = FlatStyle.Flat;
            comboBoxStatus.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Enabled", "Disabled" });
            comboBoxStatus.Location = new Point(503, 84);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(205, 33);
            comboBoxStatus.TabIndex = 96;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(927, 59);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 100;
            label1.Text = "Filter";
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(927, 81);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(377, 39);
            searchBox1.TabIndex = 101;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FlatStyle = FlatStyle.Flat;
            comboBoxFilter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Barangay", "Rice Farm Barangay", "Corn Farm Barangay" });
            comboBoxFilter.Location = new Point(933, 84);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(367, 33);
            comboBoxFilter.TabIndex = 99;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 926);
            panel3.TabIndex = 2;
            // 
            // SettingsManageDataView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel3);
            Name = "SettingsManageDataView";
            Text = "SettingsManageDataView";
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarangay).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label labelHvcStandingId;
        private SearchBox searchBox12;
        private DateTimePicker dtpLogDate;
        private Panel panel5;
        private Panel panel9;
        private Panel panel10;
        private ComboBox comboBoxFilter;
        private SearchBox searchBox1;
        private Label label1;
        private ComboBox comboBoxStatus;
        private SearchBox searchBox4;
        private Label label5;
        private DataGridView dgvBarangay;
        private Button btnAdd;
        private TextBox txtBarangay;
        private SearchBox searchBox3;
        private Label label4;
        private Panel panel11;
        private Label label6;
        private Panel panel3;
    }
}