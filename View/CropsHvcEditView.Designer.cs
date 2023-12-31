﻿namespace AgRecords.View
{
    partial class CropsHvcEditView
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
            btnBack = new FontAwesome.Sharp.IconButton();
            btnPrint = new FontAwesome.Sharp.IconButton();
            labelYear = new Label();
            label12 = new Label();
            searchBox7 = new SearchBox();
            labelWeek = new Label();
            label10 = new Label();
            searchBox6 = new SearchBox();
            labelMonth = new Label();
            label5 = new Label();
            searchBox5 = new SearchBox();
            labelHvcSrId = new Label();
            label2 = new Label();
            searchBox3 = new SearchBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel7 = new Panel();
            dgvHvcStanding = new DataGridView();
            panel5 = new Panel();
            panel6 = new Panel();
            cbTotal = new CheckBox();
            panel4 = new Panel();
            panelStandingAccomplishments = new Panel();
            labelHvcStandingId = new Label();
            searchBox12 = new SearchBox();
            label6 = new Label();
            labelCropStage = new Label();
            txtSize = new TextBox();
            searchBox11 = new SearchBox();
            LabelSize = new Label();
            searchBox9 = new SearchBox();
            label14 = new Label();
            cmbCropType = new ComboBox();
            searchBox8 = new SearchBox();
            label13 = new Label();
            btnUpdate = new Button();
            label9 = new Label();
            dtpLogDate = new DateTimePicker();
            btnClear = new Button();
            btnNew = new Button();
            panelStandingAccomplishmentsHeader = new Panel();
            label46 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHvcStanding).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panelStandingAccomplishments.SuspendLayout();
            panelStandingAccomplishmentsHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(labelYear);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(searchBox7);
            panel1.Controls.Add(labelWeek);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(searchBox6);
            panel1.Controls.Add(labelMonth);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(searchBox5);
            panel1.Controls.Add(labelHvcSrId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(searchBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(1595, 90);
            panel1.TabIndex = 27;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 242, 252);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 242, 252);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(43, 121, 223);
            btnBack.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            btnBack.IconColor = Color.FromArgb(43, 121, 223);
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 30;
            btnBack.Location = new Point(1428, 24);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 40);
            btnBack.TabIndex = 55;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.FlatAppearance.BorderColor = Color.FromArgb(3, 0, 67);
            btnPrint.FlatAppearance.BorderSize = 2;
            btnPrint.FlatAppearance.MouseDownBackColor = Color.White;
            btnPrint.FlatAppearance.MouseOverBackColor = Color.White;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.FromArgb(3, 0, 67);
            btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnPrint.IconColor = Color.FromArgb(3, 0, 67);
            btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrint.IconSize = 30;
            btnPrint.Location = new Point(1292, 24);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(130, 40);
            btnPrint.TabIndex = 54;
            btnPrint.Text = "Print";
            btnPrint.TextAlign = ContentAlignment.MiddleRight;
            btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelYear.Location = new Point(571, 38);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(56, 28);
            labelYear.TabIndex = 36;
            labelYear.Text = "2025";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(559, 11);
            label12.Name = "label12";
            label12.Size = new Size(37, 20);
            label12.TabIndex = 35;
            label12.Text = "Year";
            // 
            // searchBox7
            // 
            searchBox7.Location = new Point(559, 34);
            searchBox7.Name = "searchBox7";
            searchBox7.Size = new Size(100, 39);
            searchBox7.TabIndex = 34;
            // 
            // labelWeek
            // 
            labelWeek.AutoSize = true;
            labelWeek.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelWeek.Location = new Point(456, 38);
            labelWeek.Name = "labelWeek";
            labelWeek.Size = new Size(47, 28);
            labelWeek.TabIndex = 33;
            labelWeek.Text = "1-15";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(444, 11);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 32;
            label10.Text = "Week";
            // 
            // searchBox6
            // 
            searchBox6.Location = new Point(444, 34);
            searchBox6.Name = "searchBox6";
            searchBox6.Size = new Size(100, 39);
            searchBox6.TabIndex = 31;
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonth.Location = new Point(317, 38);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(82, 28);
            labelMonth.TabIndex = 30;
            labelMonth.Text = "January";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 11);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 27;
            label5.Text = "Month";
            // 
            // searchBox5
            // 
            searchBox5.Location = new Point(307, 34);
            searchBox5.Name = "searchBox5";
            searchBox5.Size = new Size(122, 39);
            searchBox5.TabIndex = 26;
            // 
            // labelHvcSrId
            // 
            labelHvcSrId.AutoSize = true;
            labelHvcSrId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHvcSrId.Location = new Point(28, 38);
            labelHvcSrId.Name = "labelHvcSrId";
            labelHvcSrId.Size = new Size(125, 28);
            labelHvcSrId.TabIndex = 21;
            labelHvcSrId.Text = "labelHvcSrId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 11);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 17;
            label2.Text = "ID";
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(17, 34);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(262, 39);
            searchBox3.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(239, 239, 239);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 10);
            panel3.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1595, 826);
            panel2.TabIndex = 29;
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvHvcStanding);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 266);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10);
            panel7.Size = new Size(1595, 560);
            panel7.TabIndex = 84;
            // 
            // dgvHvcStanding
            // 
            dgvHvcStanding.AllowUserToAddRows = false;
            dgvHvcStanding.AllowUserToDeleteRows = false;
            dgvHvcStanding.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHvcStanding.BackgroundColor = Color.White;
            dgvHvcStanding.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHvcStanding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHvcStanding.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHvcStanding.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHvcStanding.Dock = DockStyle.Fill;
            dgvHvcStanding.GridColor = Color.FromArgb(239, 239, 239);
            dgvHvcStanding.Location = new Point(10, 10);
            dgvHvcStanding.Name = "dgvHvcStanding";
            dgvHvcStanding.ReadOnly = true;
            dgvHvcStanding.RowHeadersVisible = false;
            dgvHvcStanding.RowHeadersWidth = 51;
            dgvHvcStanding.RowTemplate.Height = 40;
            dgvHvcStanding.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHvcStanding.Size = new Size(1575, 540);
            dgvHvcStanding.TabIndex = 23;
            dgvHvcStanding.CellDoubleClick += dgvHvcStanding_CellDoubleClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 205);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(1595, 61);
            panel5.TabIndex = 83;
            // 
            // panel6
            // 
            panel6.Controls.Add(cbTotal);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(10, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(1575, 41);
            panel6.TabIndex = 76;
            // 
            // cbTotal
            // 
            cbTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTotal.AutoSize = true;
            cbTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbTotal.Location = new Point(1461, 7);
            cbTotal.Name = "cbTotal";
            cbTotal.Size = new Size(68, 27);
            cbTotal.TabIndex = 3;
            cbTotal.Text = "Total";
            cbTotal.UseVisualStyleBackColor = true;
            cbTotal.CheckedChanged += cbTotal_CheckedChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelStandingAccomplishments);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(1595, 205);
            panel4.TabIndex = 82;
            // 
            // panelStandingAccomplishments
            // 
            panelStandingAccomplishments.BorderStyle = BorderStyle.FixedSingle;
            panelStandingAccomplishments.Controls.Add(labelHvcStandingId);
            panelStandingAccomplishments.Controls.Add(searchBox12);
            panelStandingAccomplishments.Controls.Add(label6);
            panelStandingAccomplishments.Controls.Add(labelCropStage);
            panelStandingAccomplishments.Controls.Add(txtSize);
            panelStandingAccomplishments.Controls.Add(searchBox11);
            panelStandingAccomplishments.Controls.Add(LabelSize);
            panelStandingAccomplishments.Controls.Add(searchBox9);
            panelStandingAccomplishments.Controls.Add(label14);
            panelStandingAccomplishments.Controls.Add(cmbCropType);
            panelStandingAccomplishments.Controls.Add(searchBox8);
            panelStandingAccomplishments.Controls.Add(label13);
            panelStandingAccomplishments.Controls.Add(btnUpdate);
            panelStandingAccomplishments.Controls.Add(label9);
            panelStandingAccomplishments.Controls.Add(dtpLogDate);
            panelStandingAccomplishments.Controls.Add(btnClear);
            panelStandingAccomplishments.Controls.Add(btnNew);
            panelStandingAccomplishments.Controls.Add(panelStandingAccomplishmentsHeader);
            panelStandingAccomplishments.Dock = DockStyle.Fill;
            panelStandingAccomplishments.Location = new Point(10, 10);
            panelStandingAccomplishments.Name = "panelStandingAccomplishments";
            panelStandingAccomplishments.Size = new Size(1575, 185);
            panelStandingAccomplishments.TabIndex = 74;
            // 
            // labelHvcStandingId
            // 
            labelHvcStandingId.AutoSize = true;
            labelHvcStandingId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHvcStandingId.Location = new Point(31, 100);
            labelHvcStandingId.Name = "labelHvcStandingId";
            labelHvcStandingId.Size = new Size(32, 28);
            labelHvcStandingId.TabIndex = 95;
            labelHvcStandingId.Text = "ID";
            // 
            // searchBox12
            // 
            searchBox12.Location = new Point(26, 96);
            searchBox12.Name = "searchBox12";
            searchBox12.Size = new Size(80, 39);
            searchBox12.TabIndex = 98;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 73);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 97;
            label6.Text = "ID";
            // 
            // labelCropStage
            // 
            labelCropStage.AutoSize = true;
            labelCropStage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelCropStage.Location = new Point(357, 101);
            labelCropStage.Name = "labelCropStage";
            labelCropStage.Size = new Size(177, 25);
            labelCropStage.TabIndex = 96;
            labelCropStage.Text = "Newly Transplanted";
            labelCropStage.Enter += SelectedPanel;
            labelCropStage.Leave += UnselectedPanel;
            // 
            // txtSize
            // 
            txtSize.BorderStyle = BorderStyle.None;
            txtSize.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSize.Location = new Point(671, 102);
            txtSize.Name = "txtSize";
            txtSize.PlaceholderText = "0.00";
            txtSize.Size = new Size(148, 24);
            txtSize.TabIndex = 94;
            txtSize.TextAlign = HorizontalAlignment.Right;
            txtSize.Enter += SelectedPanel;
            txtSize.KeyPress += NumOrDecimalsOnly;
            txtSize.Leave += UnselectedPanel;
            // 
            // searchBox11
            // 
            searchBox11.Location = new Point(664, 96);
            searchBox11.Name = "searchBox11";
            searchBox11.Size = new Size(162, 39);
            searchBox11.TabIndex = 93;
            // 
            // LabelSize
            // 
            LabelSize.AutoSize = true;
            LabelSize.Location = new Point(664, 73);
            LabelSize.Name = "LabelSize";
            LabelSize.Size = new Size(66, 20);
            LabelSize.TabIndex = 92;
            LabelSize.Text = "Size (ha)";
            // 
            // searchBox9
            // 
            searchBox9.Location = new Point(352, 96);
            searchBox9.Name = "searchBox9";
            searchBox9.Size = new Size(282, 39);
            searchBox9.TabIndex = 91;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(352, 71);
            label14.Name = "label14";
            label14.Size = new Size(99, 20);
            label14.TabIndex = 90;
            label14.Text = "Growth Stage";
            // 
            // cmbCropType
            // 
            cmbCropType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCropType.FlatStyle = FlatStyle.Flat;
            cmbCropType.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbCropType.FormattingEnabled = true;
            cmbCropType.Items.AddRange(new object[] { "Bittergourd", "Eggplant", "Okra", "Patola (Loofah/Sponge gouard)", "Squash", "Tomato", "Upo (bottled gourd)", "Pole sitao", "Mungbean", "Sweet Potato", "Yam/ube", "Peanut", "Plantation Crops", "Banana" });
            cmbCropType.Location = new Point(129, 98);
            cmbCropType.Name = "cmbCropType";
            cmbCropType.Size = new Size(200, 33);
            cmbCropType.TabIndex = 89;
            cmbCropType.Enter += SelectedPanel;
            cmbCropType.Leave += UnselectedPanel;
            // 
            // searchBox8
            // 
            searchBox8.Location = new Point(124, 96);
            searchBox8.Name = "searchBox8";
            searchBox8.Size = new Size(208, 39);
            searchBox8.TabIndex = 88;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(124, 73);
            label13.Name = "label13";
            label13.Size = new Size(76, 20);
            label13.TabIndex = 87;
            label13.Text = "Crop Type";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 221, 100);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(3, 0, 67);
            btnUpdate.Location = new Point(1281, 39);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 39);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Save";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.Enter += SelectedPanel;
            btnUpdate.Leave += UnselectedPanel;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(875, 71);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 54;
            label9.Text = "Date Transplated";
            // 
            // dtpLogDate
            // 
            dtpLogDate.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLogDate.Format = DateTimePickerFormat.Short;
            dtpLogDate.Location = new Point(875, 94);
            dtpLogDate.Name = "dtpLogDate";
            dtpLogDate.Size = new Size(167, 28);
            dtpLogDate.TabIndex = 53;
            dtpLogDate.Enter += SelectedPanel;
            dtpLogDate.Leave += UnselectedPanel;
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(3, 0, 67);
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatAppearance.MouseDownBackColor = Color.White;
            btnClear.FlatAppearance.MouseOverBackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.FromArgb(3, 0, 67);
            btnClear.Location = new Point(1281, 133);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 39);
            btnClear.TabIndex = 52;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            btnClear.Enter += SelectedPanel;
            btnClear.Leave += UnselectedPanel;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(255, 221, 100);
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.FromArgb(3, 0, 67);
            btnNew.Location = new Point(1281, 86);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(130, 39);
            btnNew.TabIndex = 40;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            btnNew.Enter += SelectedPanel;
            btnNew.Leave += UnselectedPanel;
            // 
            // panelStandingAccomplishmentsHeader
            // 
            panelStandingAccomplishmentsHeader.BackColor = Color.FromArgb(43, 121, 223);
            panelStandingAccomplishmentsHeader.Controls.Add(label46);
            panelStandingAccomplishmentsHeader.Dock = DockStyle.Top;
            panelStandingAccomplishmentsHeader.Location = new Point(0, 0);
            panelStandingAccomplishmentsHeader.Name = "panelStandingAccomplishmentsHeader";
            panelStandingAccomplishmentsHeader.Size = new Size(1573, 29);
            panelStandingAccomplishmentsHeader.TabIndex = 0;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label46.ForeColor = Color.White;
            label46.Location = new Point(6, 1);
            label46.Name = "label46";
            label46.Size = new Size(287, 25);
            label46.TabIndex = 28;
            label46.Text = "STANDING ACCOMPLISHMENTS";
            // 
            // CropsHvcEditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CropsHvcEditView";
            Text = "CropsHvcEditView";
            Load += CropsHvcEditView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHvcStanding).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panelStandingAccomplishments.ResumeLayout(false);
            panelStandingAccomplishments.PerformLayout();
            panelStandingAccomplishmentsHeader.ResumeLayout(false);
            panelStandingAccomplishmentsHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelYear;
        private Label label12;
        private SearchBox searchBox7;
        private Label labelWeek;
        private Label label10;
        private SearchBox searchBox6;
        private Label labelMonth;
        private Label label5;
        private SearchBox searchBox5;
        private Label labelHvcSrId;
        private Label label2;
        private SearchBox searchBox3;
        private Panel panel3;
        private Panel panel2;
        private Panel panelStandingAccomplishments;
        private Label labelHvcStandingId;
        private SearchBox searchBox12;
        private Label label6;
        private Label labelCropStage;
        private TextBox txtSize;
        private SearchBox searchBox11;
        private Label LabelSize;
        private SearchBox searchBox9;
        private Label label14;
        private ComboBox cmbCropType;
        private SearchBox searchBox8;
        private Label label13;
        private Button btnUpdate;
        private Label label9;
        private DateTimePicker dtpLogDate;
        private Button btnClear;
        private Button btnNew;
        private Panel panelStandingAccomplishmentsHeader;
        private Label label46;
        private DataGridView dgvHvcStanding;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnPrint;
        private Panel panel4;
        private Panel panel7;
        private Panel panel5;
        private Panel panel6;
        private CheckBox cbTotal;
    }
}