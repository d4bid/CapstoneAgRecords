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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnRiceBrgyDelete = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            comboBox2 = new ComboBox();
            searchBox4 = new SearchBox();
            label5 = new Label();
            dgvCert = new DataGridView();
            button3 = new Button();
            textBox2 = new TextBox();
            searchBox3 = new SearchBox();
            label4 = new Label();
            panel11 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            button1 = new Button();
            btnSave = new Button();
            textBox1 = new TextBox();
            searchBox1 = new SearchBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            searchBox2 = new SearchBox();
            label2 = new Label();
            panel8 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            panelStandingAccomplishments = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnRiceBrgyAdd = new FontAwesome.Sharp.IconButton();
            txtBrgy = new TextBox();
            searchBox11 = new SearchBox();
            LabelSize = new Label();
            cmbBarangay = new ComboBox();
            searchBox8 = new SearchBox();
            label13 = new Label();
            panelStandingAccomplishmentsHeader = new Panel();
            label46 = new Label();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCert).BeginInit();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panelStandingAccomplishments.SuspendLayout();
            panelStandingAccomplishmentsHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1595, 90);
            panel1.TabIndex = 0;
            // 
            // btnRiceBrgyDelete
            // 
            btnRiceBrgyDelete.BackColor = SystemColors.Window;
            btnRiceBrgyDelete.FlatAppearance.BorderSize = 0;
            btnRiceBrgyDelete.FlatStyle = FlatStyle.Flat;
            btnRiceBrgyDelete.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRiceBrgyDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnRiceBrgyDelete.IconColor = Color.FromArgb(207, 92, 96);
            btnRiceBrgyDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRiceBrgyDelete.IconSize = 40;
            btnRiceBrgyDelete.Location = new Point(1152, 68);
            btnRiceBrgyDelete.Name = "btnRiceBrgyDelete";
            btnRiceBrgyDelete.Size = new Size(40, 40);
            btnRiceBrgyDelete.TabIndex = 96;
            btnRiceBrgyDelete.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 239, 239);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(1595, 10);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 826);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 154);
            panel5.Name = "panel5";
            panel5.Size = new Size(1595, 672);
            panel5.TabIndex = 77;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 154);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(5);
            panel9.Size = new Size(1595, 518);
            panel9.TabIndex = 77;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(comboBox2);
            panel10.Controls.Add(searchBox4);
            panel10.Controls.Add(label5);
            panel10.Controls.Add(dgvCert);
            panel10.Controls.Add(button3);
            panel10.Controls.Add(textBox2);
            panel10.Controls.Add(searchBox3);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(panel11);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(5, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(1585, 508);
            panel10.TabIndex = 75;
            panel10.Paint += panel10_Paint;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Barangay", "Rice Farm Barangay", "Corn Farm Barangay", "HVC Type" });
            comboBox2.Location = new Point(487, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(331, 33);
            comboBox2.TabIndex = 96;
            // 
            // searchBox4
            // 
            searchBox4.Location = new Point(481, 72);
            searchBox4.Name = "searchBox4";
            searchBox4.Size = new Size(341, 39);
            searchBox4.TabIndex = 98;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 49);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 97;
            label5.Text = "Filter";
            // 
            // dgvCert
            // 
            dgvCert.AllowUserToAddRows = false;
            dgvCert.AllowUserToDeleteRows = false;
            dgvCert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCert.BackgroundColor = Color.White;
            dgvCert.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCert.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCert.GridColor = Color.FromArgb(239, 239, 239);
            dgvCert.Location = new Point(42, 137);
            dgvCert.Name = "dgvCert";
            dgvCert.ReadOnly = true;
            dgvCert.RowHeadersVisible = false;
            dgvCert.RowHeadersWidth = 51;
            dgvCert.RowTemplate.Height = 40;
            dgvCert.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCert.Size = new Size(1023, 268);
            dgvCert.TabIndex = 95;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(43, 121, 223);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(935, 72);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(130, 39);
            button3.TabIndex = 94;
            button3.Text = "Add Item";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(55, 79);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter new item";
            textBox2.Size = new Size(368, 23);
            textBox2.TabIndex = 2;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(42, 73);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(393, 39);
            searchBox3.TabIndex = 93;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 50);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 92;
            label4.Text = "Barangay";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(43, 121, 223);
            panel11.Controls.Add(label6);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1583, 29);
            panel11.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 1);
            label6.Name = "label6";
            label6.Size = new Size(215, 25);
            label6.TabIndex = 28;
            label6.Text = "BARANGAYS (SOLANO)";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(1595, 154);
            panel6.TabIndex = 76;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(button1);
            panel7.Controls.Add(btnSave);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(searchBox1);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(comboBox1);
            panel7.Controls.Add(searchBox2);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(5, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(1585, 144);
            panel7.TabIndex = 75;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 121, 223);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(987, 73);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(130, 39);
            button1.TabIndex = 95;
            button1.Text = "Delete Item";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(841, 72);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 39);
            btnSave.TabIndex = 94;
            btnSave.Text = "Add Item";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(55, 79);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Barangay";
            textBox1.Size = new Size(368, 23);
            textBox1.TabIndex = 2;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(42, 73);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(393, 39);
            searchBox1.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 50);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 92;
            label1.Text = "Barangay";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(474, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(331, 33);
            comboBox1.TabIndex = 1;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(468, 72);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(341, 39);
            searchBox2.TabIndex = 88;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 49);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 87;
            label2.Text = "Existing Barangays";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(43, 121, 223);
            panel8.Controls.Add(label3);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1583, 29);
            panel8.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 1);
            label3.Name = "label3";
            label3.Size = new Size(215, 25);
            label3.TabIndex = 28;
            label3.Text = "BARANGAYS (SOLANO)";
            // 
            // panel4
            // 
            panel4.Controls.Add(panelStandingAccomplishments);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(1595, 154);
            panel4.TabIndex = 76;
            // 
            // panelStandingAccomplishments
            // 
            panelStandingAccomplishments.BorderStyle = BorderStyle.FixedSingle;
            panelStandingAccomplishments.Controls.Add(btnRiceBrgyDelete);
            panelStandingAccomplishments.Controls.Add(iconButton1);
            panelStandingAccomplishments.Controls.Add(btnRiceBrgyAdd);
            panelStandingAccomplishments.Controls.Add(txtBrgy);
            panelStandingAccomplishments.Controls.Add(searchBox11);
            panelStandingAccomplishments.Controls.Add(LabelSize);
            panelStandingAccomplishments.Controls.Add(cmbBarangay);
            panelStandingAccomplishments.Controls.Add(searchBox8);
            panelStandingAccomplishments.Controls.Add(label13);
            panelStandingAccomplishments.Controls.Add(panelStandingAccomplishmentsHeader);
            panelStandingAccomplishments.Dock = DockStyle.Fill;
            panelStandingAccomplishments.Location = new Point(5, 5);
            panelStandingAccomplishments.Name = "panelStandingAccomplishments";
            panelStandingAccomplishments.Size = new Size(1585, 144);
            panelStandingAccomplishments.TabIndex = 75;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.Window;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton1.IconColor = Color.FromArgb(207, 92, 96);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(992, 73);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 40);
            iconButton1.TabIndex = 97;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnRiceBrgyAdd
            // 
            btnRiceBrgyAdd.BackColor = SystemColors.Window;
            btnRiceBrgyAdd.FlatAppearance.BorderSize = 0;
            btnRiceBrgyAdd.FlatStyle = FlatStyle.Flat;
            btnRiceBrgyAdd.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRiceBrgyAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnRiceBrgyAdd.IconColor = Color.FromArgb(0, 109, 104);
            btnRiceBrgyAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRiceBrgyAdd.IconSize = 40;
            btnRiceBrgyAdd.Location = new Point(441, 72);
            btnRiceBrgyAdd.Name = "btnRiceBrgyAdd";
            btnRiceBrgyAdd.Size = new Size(40, 40);
            btnRiceBrgyAdd.TabIndex = 94;
            btnRiceBrgyAdd.UseVisualStyleBackColor = false;
            // 
            // txtBrgy
            // 
            txtBrgy.BorderStyle = BorderStyle.None;
            txtBrgy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtBrgy.Location = new Point(55, 79);
            txtBrgy.Name = "txtBrgy";
            txtBrgy.PlaceholderText = "Barangay";
            txtBrgy.Size = new Size(368, 23);
            txtBrgy.TabIndex = 2;
            // 
            // searchBox11
            // 
            searchBox11.Location = new Point(42, 73);
            searchBox11.Name = "searchBox11";
            searchBox11.Size = new Size(393, 39);
            searchBox11.TabIndex = 93;
            // 
            // LabelSize
            // 
            LabelSize.AutoSize = true;
            LabelSize.Location = new Point(42, 50);
            LabelSize.Name = "LabelSize";
            LabelSize.Size = new Size(71, 20);
            LabelSize.TabIndex = 92;
            LabelSize.Text = "Barangay";
            // 
            // cmbBarangay
            // 
            cmbBarangay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarangay.FlatStyle = FlatStyle.Flat;
            cmbBarangay.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbBarangay.FormattingEnabled = true;
            cmbBarangay.Location = new Point(651, 75);
            cmbBarangay.Name = "cmbBarangay";
            cmbBarangay.Size = new Size(331, 33);
            cmbBarangay.TabIndex = 1;
            // 
            // searchBox8
            // 
            searchBox8.Location = new Point(645, 73);
            searchBox8.Name = "searchBox8";
            searchBox8.Size = new Size(341, 39);
            searchBox8.TabIndex = 88;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(645, 50);
            label13.Name = "label13";
            label13.Size = new Size(132, 20);
            label13.TabIndex = 87;
            label13.Text = "Existing Barangays";
            // 
            // panelStandingAccomplishmentsHeader
            // 
            panelStandingAccomplishmentsHeader.BackColor = Color.FromArgb(43, 121, 223);
            panelStandingAccomplishmentsHeader.Controls.Add(label46);
            panelStandingAccomplishmentsHeader.Dock = DockStyle.Top;
            panelStandingAccomplishmentsHeader.Location = new Point(0, 0);
            panelStandingAccomplishmentsHeader.Name = "panelStandingAccomplishmentsHeader";
            panelStandingAccomplishmentsHeader.Size = new Size(1583, 29);
            panelStandingAccomplishmentsHeader.TabIndex = 0;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label46.ForeColor = Color.White;
            label46.Location = new Point(6, 1);
            label46.Name = "label46";
            label46.Size = new Size(215, 25);
            label46.TabIndex = 28;
            label46.Text = "BARANGAYS (SOLANO)";
            // 
            // SettingsManageDataView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SettingsManageDataView";
            Text = "SettingsManageDataView";
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCert).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panelStandingAccomplishments.ResumeLayout(false);
            panelStandingAccomplishments.PerformLayout();
            panelStandingAccomplishmentsHeader.ResumeLayout(false);
            panelStandingAccomplishmentsHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panelStandingAccomplishments;
        private Label labelHvcStandingId;
        private SearchBox searchBox12;
        private TextBox txtBrgy;
        private SearchBox searchBox11;
        private Label LabelSize;
        private ComboBox cmbBarangay;
        private SearchBox searchBox8;
        private Label label13;
        private DateTimePicker dtpLogDate;
        private Panel panelStandingAccomplishmentsHeader;
        private Label label46;
        private FontAwesome.Sharp.IconButton btnRiceBrgyAdd;
        private FontAwesome.Sharp.IconButton btnRiceBrgyDelete;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private TextBox textBox1;
        private SearchBox searchBox1;
        private Label label1;
        private ComboBox comboBox1;
        private SearchBox searchBox2;
        private Label label2;
        private Panel panel8;
        private Label label3;
        private Button btnSave;
        private Button button1;
        private Panel panel9;
        private Panel panel10;
        private Button button3;
        private TextBox textBox2;
        private SearchBox searchBox3;
        private Label label4;
        private Panel panel11;
        private Label label6;
        private DataGridView dgvCert;
        private ComboBox comboBox2;
        private SearchBox searchBox4;
        private Label label5;
    }
}