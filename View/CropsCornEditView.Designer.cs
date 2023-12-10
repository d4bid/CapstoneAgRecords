namespace AgRecords.View
{
    partial class CropsCornEditView
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
            labelSeasonYear = new Label();
            labelSeason = new Label();
            label5 = new Label();
            searchBox5 = new SearchBox();
            labelSeasonYearl = new Label();
            boxSeasonYear = new SearchBox();
            labelCornPrId = new Label();
            labelSeasonl = new Label();
            boxSeason = new SearchBox();
            label2 = new Label();
            searchBox3 = new SearchBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel8 = new Panel();
            dgvCornPlanting = new DataGridView();
            panel7 = new Panel();
            panel5 = new Panel();
            panelLand = new Panel();
            cmbLandType = new ComboBox();
            label3 = new Label();
            searchBox2 = new SearchBox();
            panelSeed = new Panel();
            cmbSeedType = new ComboBox();
            label8 = new Label();
            searchBox10 = new SearchBox();
            panelGrowth = new Panel();
            cmbGrowthStageFilter = new ComboBox();
            boxGrowthFilter = new SearchBox();
            labelGrowthFilter = new Label();
            panelCorn = new Panel();
            cmbCornType = new ComboBox();
            searchBox1 = new SearchBox();
            label1 = new Label();
            cbTotal = new CheckBox();
            panel4 = new Panel();
            panelPlantingByEcoZone = new Panel();
            labelCornPlantingId = new Label();
            txtAveYield = new TextBox();
            boxAveYield = new SearchBox();
            searchBox12 = new SearchBox();
            labelAveYield = new Label();
            label6 = new Label();
            labelGrowthStage = new Label();
            txtSize = new TextBox();
            btnClear = new Button();
            searchBox11 = new SearchBox();
            btnNew = new Button();
            labelSize = new Label();
            btnUpdate = new Button();
            searchBox9 = new SearchBox();
            label14 = new Label();
            cmbBrgy = new ComboBox();
            searchBox8 = new SearchBox();
            label13 = new Label();
            label9 = new Label();
            dtpLogDate = new DateTimePicker();
            panelPlantingByEcoZoneHeader = new Panel();
            labelArea = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCornPlanting).BeginInit();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panelLand.SuspendLayout();
            panelSeed.SuspendLayout();
            panelGrowth.SuspendLayout();
            panelCorn.SuspendLayout();
            panel4.SuspendLayout();
            panelPlantingByEcoZone.SuspendLayout();
            panelPlantingByEcoZoneHeader.SuspendLayout();
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
            panel1.Controls.Add(labelSeasonYear);
            panel1.Controls.Add(labelSeason);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(searchBox5);
            panel1.Controls.Add(labelSeasonYearl);
            panel1.Controls.Add(boxSeasonYear);
            panel1.Controls.Add(labelCornPrId);
            panel1.Controls.Add(labelSeasonl);
            panel1.Controls.Add(boxSeason);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(searchBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(1595, 90);
            panel1.TabIndex = 26;
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
            btnBack.Location = new Point(1435, 34);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 40);
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
            btnPrint.Location = new Point(1280, 34);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(148, 40);
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
            // labelSeasonYear
            // 
            labelSeasonYear.AutoSize = true;
            labelSeasonYear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeasonYear.Location = new Point(825, 38);
            labelSeasonYear.Name = "labelSeasonYear";
            labelSeasonYear.Size = new Size(108, 28);
            labelSeasonYear.TabIndex = 29;
            labelSeasonYear.Text = "2022-2023";
            // 
            // labelSeason
            // 
            labelSeason.AutoSize = true;
            labelSeason.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeason.Location = new Point(698, 38);
            labelSeason.Name = "labelSeason";
            labelSeason.Size = new Size(48, 28);
            labelSeason.TabIndex = 28;
            labelSeason.Text = "Wet";
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
            // labelSeasonYearl
            // 
            labelSeasonYearl.AutoSize = true;
            labelSeasonYearl.Location = new Point(815, 11);
            labelSeasonYearl.Name = "labelSeasonYearl";
            labelSeasonYearl.Size = new Size(37, 20);
            labelSeasonYearl.TabIndex = 24;
            labelSeasonYearl.Text = "Year";
            // 
            // boxSeasonYear
            // 
            boxSeasonYear.Location = new Point(815, 34);
            boxSeasonYear.Name = "boxSeasonYear";
            boxSeasonYear.Size = new Size(142, 39);
            boxSeasonYear.TabIndex = 23;
            // 
            // labelCornPrId
            // 
            labelCornPrId.AutoSize = true;
            labelCornPrId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCornPrId.Location = new Point(28, 38);
            labelCornPrId.Name = "labelCornPrId";
            labelCornPrId.Size = new Size(135, 28);
            labelCornPrId.TabIndex = 21;
            labelCornPrId.Text = "labelCornPrId";
            // 
            // labelSeasonl
            // 
            labelSeasonl.AutoSize = true;
            labelSeasonl.Location = new Point(689, 11);
            labelSeasonl.Name = "labelSeasonl";
            labelSeasonl.Size = new Size(56, 20);
            labelSeasonl.TabIndex = 20;
            labelSeasonl.Text = "Season";
            // 
            // boxSeason
            // 
            boxSeason.Location = new Point(689, 34);
            boxSeason.Name = "boxSeason";
            boxSeason.Size = new Size(111, 39);
            boxSeason.TabIndex = 19;
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
            panel3.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1595, 826);
            panel2.TabIndex = 28;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvCornPlanting);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 283);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(10);
            panel8.Size = new Size(1595, 543);
            panel8.TabIndex = 107;
            // 
            // dgvCornPlanting
            // 
            dgvCornPlanting.AllowUserToAddRows = false;
            dgvCornPlanting.AllowUserToDeleteRows = false;
            dgvCornPlanting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCornPlanting.BackgroundColor = Color.White;
            dgvCornPlanting.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCornPlanting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCornPlanting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCornPlanting.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCornPlanting.Dock = DockStyle.Fill;
            dgvCornPlanting.GridColor = Color.FromArgb(239, 239, 239);
            dgvCornPlanting.Location = new Point(10, 10);
            dgvCornPlanting.Name = "dgvCornPlanting";
            dgvCornPlanting.ReadOnly = true;
            dgvCornPlanting.RowHeadersVisible = false;
            dgvCornPlanting.RowHeadersWidth = 51;
            dgvCornPlanting.RowTemplate.Height = 40;
            dgvCornPlanting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCornPlanting.Size = new Size(1575, 523);
            dgvCornPlanting.TabIndex = 23;
            dgvCornPlanting.CellDoubleClick += dgvCornPlanting_CellDoubleClick;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 176);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10);
            panel7.Size = new Size(1595, 107);
            panel7.TabIndex = 106;
            // 
            // panel5
            // 
            panel5.Controls.Add(panelLand);
            panel5.Controls.Add(panelSeed);
            panel5.Controls.Add(panelGrowth);
            panel5.Controls.Add(panelCorn);
            panel5.Controls.Add(cbTotal);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(1575, 87);
            panel5.TabIndex = 76;
            // 
            // panelLand
            // 
            panelLand.BackColor = Color.White;
            panelLand.Controls.Add(cmbLandType);
            panelLand.Controls.Add(label3);
            panelLand.Controls.Add(searchBox2);
            panelLand.Dock = DockStyle.Left;
            panelLand.Location = new Point(874, 0);
            panelLand.Name = "panelLand";
            panelLand.Padding = new Padding(10);
            panelLand.Size = new Size(235, 87);
            panelLand.TabIndex = 91;
            // 
            // cmbLandType
            // 
            cmbLandType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLandType.FlatStyle = FlatStyle.Flat;
            cmbLandType.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbLandType.FormattingEnabled = true;
            cmbLandType.Items.AddRange(new object[] { "L.Vega", "U.Vega", "Broad Plains", "Hilly" });
            cmbLandType.Location = new Point(13, 37);
            cmbLandType.Name = "cmbLandType";
            cmbLandType.Size = new Size(207, 33);
            cmbLandType.TabIndex = 105;
            cmbLandType.SelectedIndexChanged += cmbLandType_SelectedIndexChanged;
            cmbLandType.Enter += SelectedPanel;
            cmbLandType.Leave += UnselectedPanel;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 12);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 106;
            label3.Text = "Land Type";
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(8, 34);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(216, 40);
            searchBox2.TabIndex = 107;
            // 
            // panelSeed
            // 
            panelSeed.BackColor = Color.White;
            panelSeed.Controls.Add(cmbSeedType);
            panelSeed.Controls.Add(label8);
            panelSeed.Controls.Add(searchBox10);
            panelSeed.Dock = DockStyle.Left;
            panelSeed.Location = new Point(603, 0);
            panelSeed.Name = "panelSeed";
            panelSeed.Padding = new Padding(10);
            panelSeed.Size = new Size(271, 87);
            panelSeed.TabIndex = 90;
            // 
            // cmbSeedType
            // 
            cmbSeedType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeedType.FlatStyle = FlatStyle.Flat;
            cmbSeedType.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSeedType.FormattingEnabled = true;
            cmbSeedType.Items.AddRange(new object[] { "GMO", "HYBRID", "OPV", "GREEN CORN/SWEET CORN", "TRADITIONAL" });
            cmbSeedType.Location = new Point(13, 38);
            cmbSeedType.Name = "cmbSeedType";
            cmbSeedType.Size = new Size(245, 33);
            cmbSeedType.TabIndex = 79;
            cmbSeedType.SelectedIndexChanged += cmbSeedType_SelectedIndexChanged;
            cmbSeedType.Enter += SelectedPanel;
            cmbSeedType.Leave += UnselectedPanel;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 13);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 80;
            label8.Text = "Seed Type";
            // 
            // searchBox10
            // 
            searchBox10.Location = new Point(7, 35);
            searchBox10.Name = "searchBox10";
            searchBox10.Size = new Size(254, 39);
            searchBox10.TabIndex = 81;
            // 
            // panelGrowth
            // 
            panelGrowth.BackColor = Color.White;
            panelGrowth.Controls.Add(cmbGrowthStageFilter);
            panelGrowth.Controls.Add(boxGrowthFilter);
            panelGrowth.Controls.Add(labelGrowthFilter);
            panelGrowth.Dock = DockStyle.Left;
            panelGrowth.Location = new Point(263, 0);
            panelGrowth.Name = "panelGrowth";
            panelGrowth.Padding = new Padding(10);
            panelGrowth.Size = new Size(340, 87);
            panelGrowth.TabIndex = 89;
            // 
            // cmbGrowthStageFilter
            // 
            cmbGrowthStageFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrowthStageFilter.FlatStyle = FlatStyle.Flat;
            cmbGrowthStageFilter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbGrowthStageFilter.FormattingEnabled = true;
            cmbGrowthStageFilter.Items.AddRange(new object[] { "Newly Planted/Seedling Stage", "Vegetative Stage", "Reproductive Stage", "Maturing Stage", "Harvested" });
            cmbGrowthStageFilter.Location = new Point(13, 38);
            cmbGrowthStageFilter.Name = "cmbGrowthStageFilter";
            cmbGrowthStageFilter.Size = new Size(311, 33);
            cmbGrowthStageFilter.TabIndex = 91;
            cmbGrowthStageFilter.SelectedIndexChanged += cmbGrowthStageFilter_SelectedIndexChanged_1;
            cmbGrowthStageFilter.Enter += SelectedPanel;
            cmbGrowthStageFilter.Leave += UnselectedPanel;
            // 
            // boxGrowthFilter
            // 
            boxGrowthFilter.Location = new Point(11, 35);
            boxGrowthFilter.Name = "boxGrowthFilter";
            boxGrowthFilter.Size = new Size(316, 39);
            boxGrowthFilter.TabIndex = 93;
            // 
            // labelGrowthFilter
            // 
            labelGrowthFilter.AutoSize = true;
            labelGrowthFilter.Location = new Point(11, 12);
            labelGrowthFilter.Name = "labelGrowthFilter";
            labelGrowthFilter.Size = new Size(99, 20);
            labelGrowthFilter.TabIndex = 92;
            labelGrowthFilter.Text = "Growth Stage";
            // 
            // panelCorn
            // 
            panelCorn.BackColor = Color.White;
            panelCorn.Controls.Add(cmbCornType);
            panelCorn.Controls.Add(searchBox1);
            panelCorn.Controls.Add(label1);
            panelCorn.Dock = DockStyle.Left;
            panelCorn.Location = new Point(0, 0);
            panelCorn.Name = "panelCorn";
            panelCorn.Padding = new Padding(10);
            panelCorn.Size = new Size(263, 87);
            panelCorn.TabIndex = 88;
            // 
            // cmbCornType
            // 
            cmbCornType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCornType.FlatStyle = FlatStyle.Flat;
            cmbCornType.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbCornType.FormattingEnabled = true;
            cmbCornType.Items.AddRange(new object[] { "Yellow", "White" });
            cmbCornType.Location = new Point(32, 37);
            cmbCornType.Name = "cmbCornType";
            cmbCornType.Size = new Size(220, 33);
            cmbCornType.TabIndex = 102;
            cmbCornType.SelectedIndexChanged += cmbCornType_SelectedIndexChanged;
            cmbCornType.Enter += SelectedPanel;
            cmbCornType.Leave += UnselectedPanel;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(26, 35);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(229, 39);
            searchBox1.TabIndex = 104;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 103;
            label1.Text = "Corn Type";
            // 
            // cbTotal
            // 
            cbTotal.AutoSize = true;
            cbTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbTotal.Location = new Point(1487, 41);
            cbTotal.Name = "cbTotal";
            cbTotal.Size = new Size(68, 27);
            cbTotal.TabIndex = 3;
            cbTotal.Text = "Total";
            cbTotal.UseVisualStyleBackColor = true;
            cbTotal.CheckedChanged += cbTotal_CheckedChanged;
            cbTotal.Enter += SelectedPanel;
            cbTotal.Leave += UnselectedPanel;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelPlantingByEcoZone);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(1595, 176);
            panel4.TabIndex = 105;
            // 
            // panelPlantingByEcoZone
            // 
            panelPlantingByEcoZone.BorderStyle = BorderStyle.FixedSingle;
            panelPlantingByEcoZone.Controls.Add(labelCornPlantingId);
            panelPlantingByEcoZone.Controls.Add(txtAveYield);
            panelPlantingByEcoZone.Controls.Add(boxAveYield);
            panelPlantingByEcoZone.Controls.Add(searchBox12);
            panelPlantingByEcoZone.Controls.Add(labelAveYield);
            panelPlantingByEcoZone.Controls.Add(label6);
            panelPlantingByEcoZone.Controls.Add(labelGrowthStage);
            panelPlantingByEcoZone.Controls.Add(txtSize);
            panelPlantingByEcoZone.Controls.Add(btnClear);
            panelPlantingByEcoZone.Controls.Add(searchBox11);
            panelPlantingByEcoZone.Controls.Add(btnNew);
            panelPlantingByEcoZone.Controls.Add(labelSize);
            panelPlantingByEcoZone.Controls.Add(btnUpdate);
            panelPlantingByEcoZone.Controls.Add(searchBox9);
            panelPlantingByEcoZone.Controls.Add(label14);
            panelPlantingByEcoZone.Controls.Add(cmbBrgy);
            panelPlantingByEcoZone.Controls.Add(searchBox8);
            panelPlantingByEcoZone.Controls.Add(label13);
            panelPlantingByEcoZone.Controls.Add(label9);
            panelPlantingByEcoZone.Controls.Add(dtpLogDate);
            panelPlantingByEcoZone.Controls.Add(panelPlantingByEcoZoneHeader);
            panelPlantingByEcoZone.Dock = DockStyle.Fill;
            panelPlantingByEcoZone.Location = new Point(10, 10);
            panelPlantingByEcoZone.Name = "panelPlantingByEcoZone";
            panelPlantingByEcoZone.Size = new Size(1575, 156);
            panelPlantingByEcoZone.TabIndex = 74;
            // 
            // labelCornPlantingId
            // 
            labelCornPlantingId.AutoSize = true;
            labelCornPlantingId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCornPlantingId.Location = new Point(31, 84);
            labelCornPlantingId.Name = "labelCornPlantingId";
            labelCornPlantingId.Size = new Size(32, 28);
            labelCornPlantingId.TabIndex = 95;
            labelCornPlantingId.Text = "ID";
            // 
            // txtAveYield
            // 
            txtAveYield.BorderStyle = BorderStyle.None;
            txtAveYield.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtAveYield.Location = new Point(926, 87);
            txtAveYield.Name = "txtAveYield";
            txtAveYield.PlaceholderText = "0.00";
            txtAveYield.Size = new Size(217, 24);
            txtAveYield.TabIndex = 104;
            txtAveYield.TextAlign = HorizontalAlignment.Right;
            txtAveYield.Enter += SelectedPanel;
            txtAveYield.KeyPress += NumOrDecimalsOnly;
            txtAveYield.Leave += UnselectedPanel;
            // 
            // boxAveYield
            // 
            boxAveYield.Location = new Point(921, 80);
            boxAveYield.Name = "boxAveYield";
            boxAveYield.Size = new Size(229, 39);
            boxAveYield.TabIndex = 103;
            // 
            // searchBox12
            // 
            searchBox12.Location = new Point(26, 80);
            searchBox12.Name = "searchBox12";
            searchBox12.Size = new Size(80, 39);
            searchBox12.TabIndex = 98;
            // 
            // labelAveYield
            // 
            labelAveYield.AutoSize = true;
            labelAveYield.Location = new Point(921, 58);
            labelAveYield.Name = "labelAveYield";
            labelAveYield.Size = new Size(104, 20);
            labelAveYield.TabIndex = 102;
            labelAveYield.Text = "Ave. Yield (ha)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 57);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 97;
            label6.Text = "ID";
            // 
            // labelGrowthStage
            // 
            labelGrowthStage.AutoSize = true;
            labelGrowthStage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrowthStage.Location = new Point(363, 87);
            labelGrowthStage.Name = "labelGrowthStage";
            labelGrowthStage.Size = new Size(264, 25);
            labelGrowthStage.TabIndex = 96;
            labelGrowthStage.Text = "Newly Planted/Seedling Stage";
            labelGrowthStage.Enter += SelectedPanel;
            labelGrowthStage.Leave += UnselectedPanel;
            // 
            // txtSize
            // 
            txtSize.BorderStyle = BorderStyle.None;
            txtSize.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSize.Location = new Point(689, 87);
            txtSize.Name = "txtSize";
            txtSize.PlaceholderText = "0.00";
            txtSize.Size = new Size(202, 24);
            txtSize.TabIndex = 94;
            txtSize.TextAlign = HorizontalAlignment.Right;
            txtSize.Enter += SelectedPanel;
            txtSize.KeyPress += NumOrDecimalsOnly;
            txtSize.Leave += UnselectedPanel;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(3, 0, 67);
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatAppearance.MouseDownBackColor = Color.White;
            btnClear.FlatAppearance.MouseOverBackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.FromArgb(3, 0, 67);
            btnClear.Location = new Point(1424, 94);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 37);
            btnClear.TabIndex = 52;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            btnClear.Enter += SelectedPanel;
            btnClear.Leave += UnselectedPanel;
            // 
            // searchBox11
            // 
            searchBox11.Location = new Point(683, 80);
            searchBox11.Name = "searchBox11";
            searchBox11.Size = new Size(216, 39);
            searchBox11.TabIndex = 93;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.BackColor = Color.FromArgb(255, 221, 100);
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.FromArgb(3, 0, 67);
            btnNew.Location = new Point(1287, 94);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(130, 37);
            btnNew.TabIndex = 40;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            btnNew.Enter += SelectedPanel;
            btnNew.Leave += UnselectedPanel;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(683, 58);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(66, 20);
            labelSize.TabIndex = 92;
            labelSize.Text = "Size (ha)";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(255, 221, 100);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(3, 0, 67);
            btnUpdate.Location = new Point(1287, 49);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 37);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Save";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.Enter += SelectedPanel;
            btnUpdate.Leave += UnselectedPanel;
            // 
            // searchBox9
            // 
            searchBox9.Location = new Point(354, 80);
            searchBox9.Name = "searchBox9";
            searchBox9.Size = new Size(309, 39);
            searchBox9.TabIndex = 91;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(354, 58);
            label14.Name = "label14";
            label14.Size = new Size(99, 20);
            label14.TabIndex = 90;
            label14.Text = "Growth Stage";
            // 
            // cmbBrgy
            // 
            cmbBrgy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrgy.FlatStyle = FlatStyle.Flat;
            cmbBrgy.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbBrgy.FormattingEnabled = true;
            cmbBrgy.Items.AddRange(new object[] { "AGGUB", "BAGAHABAG", "BANGAAN", "BANGAR", "BASCARAN", "COMMONAL", "CONCEPCION", "CURIFANG", "DADAP", "SAN JUAN", "UDDIAWAN" });
            cmbBrgy.Location = new Point(130, 82);
            cmbBrgy.Name = "cmbBrgy";
            cmbBrgy.Size = new Size(200, 33);
            cmbBrgy.TabIndex = 89;
            cmbBrgy.Enter += SelectedPanel;
            cmbBrgy.Leave += UnselectedPanel;
            // 
            // searchBox8
            // 
            searchBox8.Location = new Point(125, 80);
            searchBox8.Name = "searchBox8";
            searchBox8.Size = new Size(208, 39);
            searchBox8.TabIndex = 88;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(125, 57);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 87;
            label13.Text = "Barangay";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(926, 57);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 54;
            label9.Text = "Date Planted";
            // 
            // dtpLogDate
            // 
            dtpLogDate.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLogDate.Format = DateTimePickerFormat.Short;
            dtpLogDate.Location = new Point(926, 87);
            dtpLogDate.Name = "dtpLogDate";
            dtpLogDate.Size = new Size(135, 28);
            dtpLogDate.TabIndex = 53;
            // 
            // panelPlantingByEcoZoneHeader
            // 
            panelPlantingByEcoZoneHeader.BackColor = Color.FromArgb(43, 121, 223);
            panelPlantingByEcoZoneHeader.Controls.Add(labelArea);
            panelPlantingByEcoZoneHeader.Dock = DockStyle.Top;
            panelPlantingByEcoZoneHeader.Location = new Point(0, 0);
            panelPlantingByEcoZoneHeader.Name = "panelPlantingByEcoZoneHeader";
            panelPlantingByEcoZoneHeader.Size = new Size(1573, 29);
            panelPlantingByEcoZoneHeader.TabIndex = 0;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelArea.ForeColor = Color.White;
            labelArea.Location = new Point(6, 1);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(300, 25);
            labelArea.TabIndex = 28;
            labelArea.Text = "PLANTING BY ECOLOGICAL ZONE";
            // 
            // CropsCornEditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CropsCornEditView";
            Text = "CropsCornEditView";
            Load += CropsCornEditView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCornPlanting).EndInit();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelLand.ResumeLayout(false);
            panelLand.PerformLayout();
            panelSeed.ResumeLayout(false);
            panelSeed.PerformLayout();
            panelGrowth.ResumeLayout(false);
            panelGrowth.PerformLayout();
            panelCorn.ResumeLayout(false);
            panelCorn.PerformLayout();
            panel4.ResumeLayout(false);
            panelPlantingByEcoZone.ResumeLayout(false);
            panelPlantingByEcoZone.PerformLayout();
            panelPlantingByEcoZoneHeader.ResumeLayout(false);
            panelPlantingByEcoZoneHeader.PerformLayout();
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
        private Label labelSeasonYear;
        private Label labelSeason;
        private Label label5;
        private SearchBox searchBox5;
        private Label labelSeasonYearl;
        private SearchBox boxSeasonYear;
        private Label labelCornPrId;
        private Label labelSeasonl;
        private SearchBox boxSeason;
        private Label label2;
        private SearchBox searchBox3;
        private Panel panel3;
        private Panel panel2;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnNew;
        private DataGridView dgvCornPlanting;
        private TextBox txtAveYield;
        private SearchBox boxAveYield;
        private Label labelAveYield;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnPrint;
        private Panel panel4;
        private Panel panelPlantingByEcoZone;
        private Label labelCornPlantingId;
        private SearchBox searchBox12;
        private Label label6;
        private Label labelGrowthStage;
        private TextBox txtSize;
        private SearchBox searchBox11;
        private Label labelSize;
        private SearchBox searchBox9;
        private Label label14;
        private ComboBox cmbBrgy;
        private SearchBox searchBox8;
        private Label label13;
        private Label label9;
        private DateTimePicker dtpLogDate;
        private Panel panelPlantingByEcoZoneHeader;
        private Label labelArea;
        private Panel panel7;
        private Panel panel5;
        private CheckBox cbTotal;
        private Panel panel8;
        private Panel panelCorn;
        private ComboBox cmbCornType;
        private SearchBox searchBox1;
        private Label label1;
        private Panel panelGrowth;
        private Panel panelLand;
        private Panel panelSeed;
        private ComboBox cmbGrowthStageFilter;
        private SearchBox boxGrowthFilter;
        private Label labelGrowthFilter;
        private ComboBox cmbSeedType;
        private Label label8;
        private SearchBox searchBox10;
        private ComboBox cmbLandType;
        private Label label3;
        private SearchBox searchBox2;
    }
}