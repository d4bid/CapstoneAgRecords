namespace AgRecords.View
{
    partial class RSBSAExportView
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
            btnColumn = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            comboBoxFilterCommodity = new ComboBox();
            searchBox4 = new SearchBox();
            label2 = new Label();
            comboBoxFilterBrgy = new ComboBox();
            searchBox3 = new SearchBox();
            btnExport = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            dgvRsbsa = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRsbsa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnColumn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxFilterCommodity);
            panel1.Controls.Add(searchBox4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxFilterBrgy);
            panel1.Controls.Add(searchBox3);
            panel1.Controls.Add(btnExport);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(1595, 91);
            panel1.TabIndex = 21;
            // 
            // btnColumn
            // 
            btnColumn.FlatAppearance.BorderColor = Color.FromArgb(3, 0, 67);
            btnColumn.FlatAppearance.BorderSize = 2;
            btnColumn.FlatAppearance.MouseDownBackColor = Color.White;
            btnColumn.FlatAppearance.MouseOverBackColor = Color.White;
            btnColumn.FlatStyle = FlatStyle.Flat;
            btnColumn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnColumn.ForeColor = Color.FromArgb(3, 0, 67);
            btnColumn.IconChar = FontAwesome.Sharp.IconChar.None;
            btnColumn.IconColor = Color.FromArgb(3, 0, 67);
            btnColumn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnColumn.IconSize = 30;
            btnColumn.Location = new Point(646, 35);
            btnColumn.Name = "btnColumn";
            btnColumn.Size = new Size(188, 40);
            btnColumn.TabIndex = 57;
            btnColumn.Text = "Select Columns";
            btnColumn.TextAlign = ContentAlignment.MiddleRight;
            btnColumn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnColumn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 13);
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
            comboBoxFilterCommodity.Location = new Point(221, 41);
            comboBoxFilterCommodity.Name = "comboBoxFilterCommodity";
            comboBoxFilterCommodity.Size = new Size(174, 28);
            comboBoxFilterCommodity.TabIndex = 18;
            // 
            // searchBox4
            // 
            searchBox4.Location = new Point(214, 36);
            searchBox4.Name = "searchBox4";
            searchBox4.Size = new Size(184, 39);
            searchBox4.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 13);
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
            comboBoxFilterBrgy.Location = new Point(21, 41);
            comboBoxFilterBrgy.Name = "comboBoxFilterBrgy";
            comboBoxFilterBrgy.Size = new Size(174, 28);
            comboBoxFilterBrgy.TabIndex = 11;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(15, 36);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(184, 39);
            searchBox3.TabIndex = 16;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(43, 121, 223);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(1433, 33);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(139, 40);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(239, 239, 239);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 10);
            panel3.TabIndex = 29;
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
            panel2.TabIndex = 30;
            // 
            // dgvRsbsa
            // 
            dgvRsbsa.AllowUserToAddRows = false;
            dgvRsbsa.AllowUserToDeleteRows = false;
            dgvRsbsa.BackgroundColor = Color.White;
            dgvRsbsa.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRsbsa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRsbsa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRsbsa.DefaultCellStyle = dataGridViewCellStyle4;
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
            // 
            // RSBSAExportView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "RSBSAExportView";
            Text = "RSBSAExportView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRsbsa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ComboBox comboBoxFilterCommodity;
        private SearchBox searchBox4;
        private Label label2;
        private ComboBox comboBoxFilterBrgy;
        private SearchBox searchBox3;
        private Button btnExport;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvRsbsa;
        private FontAwesome.Sharp.IconButton btnColumn;
    }
}