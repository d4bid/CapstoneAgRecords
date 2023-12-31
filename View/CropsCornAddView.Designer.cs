﻿namespace AgRecords.View
{
    partial class CropsCornAddView
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
            cmbLandType = new ComboBox();
            label3 = new Label();
            searchBox2 = new SearchBox();
            cmbCornType = new ComboBox();
            searchBox1 = new SearchBox();
            cmbGrowthStageFilter = new ComboBox();
            label1 = new Label();
            boxGrowthFilter = new SearchBox();
            labelGrowthFilter = new Label();
            cbTotal = new CheckBox();
            cmbSeedType = new ComboBox();
            label8 = new Label();
            searchBox10 = new SearchBox();
            panel4 = new Panel();
            panelPlantingByEcoZone = new Panel();
            labelCornPlantingId = new Label();
            searchBox12 = new SearchBox();
            label6 = new Label();
            labelGrowthStage = new Label();
            txtSize = new TextBox();
            searchBox11 = new SearchBox();
            LabelSize = new Label();
            searchBox9 = new SearchBox();
            label14 = new Label();
            cmbBrgy = new ComboBox();
            searchBox8 = new SearchBox();
            label13 = new Label();
            btnUpdate = new Button();
            label9 = new Label();
            dtpLogDate = new DateTimePicker();
            btnClear = new Button();
            btnNew = new Button();
            panelPlantingByEcoZoneHeader = new Panel();
            label46 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCornPlanting).BeginInit();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panelPlantingByEcoZone.SuspendLayout();
            panelPlantingByEcoZoneHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnBack);
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
            panel1.TabIndex = 25;
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
            btnBack.Location = new Point(1428, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 54;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelYear.Location = new Point(571, 38);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(50, 28);
            labelYear.TabIndex = 36;
            labelYear.Text = "Year";
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
            labelWeek.Size = new Size(63, 28);
            labelWeek.TabIndex = 33;
            labelWeek.Text = "Week";
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
            labelMonth.Size = new Size(73, 28);
            labelMonth.TabIndex = 30;
            labelMonth.Text = "Month";
            // 
            // labelSeasonYear
            // 
            labelSeasonYear.AutoSize = true;
            labelSeasonYear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeasonYear.Location = new Point(825, 38);
            labelSeasonYear.Name = "labelSeasonYear";
            labelSeasonYear.Size = new Size(121, 28);
            labelSeasonYear.TabIndex = 29;
            labelSeasonYear.Text = "Season Year";
            // 
            // labelSeason
            // 
            labelSeason.AutoSize = true;
            labelSeason.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeason.Location = new Point(698, 38);
            labelSeason.Name = "labelSeason";
            labelSeason.Size = new Size(77, 28);
            labelSeason.TabIndex = 28;
            labelSeason.Text = "Season";
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
            panel3.TabIndex = 26;
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
            panel2.TabIndex = 27;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvCornPlanting);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 283);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(10);
            panel8.Size = new Size(1595, 543);
            panel8.TabIndex = 80;
            // 
            // dgvCornPlanting
            // 
            dgvCornPlanting.AllowUserToAddRows = false;
            dgvCornPlanting.AllowUserToDeleteRows = false;
            dgvCornPlanting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCornPlanting.BackgroundColor = Color.White;
            dgvCornPlanting.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
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
            panel7.TabIndex = 79;
            // 
            // panel5
            // 
            panel5.Controls.Add(cmbLandType);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(searchBox2);
            panel5.Controls.Add(cmbCornType);
            panel5.Controls.Add(searchBox1);
            panel5.Controls.Add(cmbGrowthStageFilter);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(boxGrowthFilter);
            panel5.Controls.Add(labelGrowthFilter);
            panel5.Controls.Add(cbTotal);
            panel5.Controls.Add(cmbSeedType);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(searchBox10);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(1575, 87);
            panel5.TabIndex = 76;
            panel5.Paint += panel5_Paint;
            // 
            // cmbLandType
            // 
            cmbLandType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLandType.FlatStyle = FlatStyle.Flat;
            cmbLandType.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbLandType.FormattingEnabled = true;
            cmbLandType.Items.AddRange(new object[] { "L.Vega", "U.Vega", "Broad Plains", "Hilly" });
            cmbLandType.Location = new Point(873, 37);
            cmbLandType.Name = "cmbLandType";
            cmbLandType.Size = new Size(207, 33);
            cmbLandType.TabIndex = 102;
            cmbLandType.SelectedIndexChanged += cmbLandType_SelectedIndexChanged;
            cmbLandType.Enter += SelectedPanel;
            cmbLandType.Leave += UnselectedPanel;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(868, 12);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 103;
            label3.Text = "Land Type";
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(868, 34);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(216, 40);
            searchBox2.TabIndex = 104;
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
            cmbCornType.TabIndex = 99;
            cmbCornType.SelectedIndexChanged += cmbCornType_SelectedIndexChanged;
            cmbCornType.Enter += SelectedPanel;
            cmbCornType.Leave += UnselectedPanel;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(26, 35);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(229, 39);
            searchBox1.TabIndex = 101;
            // 
            // cmbGrowthStageFilter
            // 
            cmbGrowthStageFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrowthStageFilter.FlatStyle = FlatStyle.Flat;
            cmbGrowthStageFilter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbGrowthStageFilter.FormattingEnabled = true;
            cmbGrowthStageFilter.Items.AddRange(new object[] { "Newly Planted/Seedling Stage", "Vegetative Stage", "Reproductive Stage", "Maturing Stage", "Harvested" });
            cmbGrowthStageFilter.Location = new Point(281, 38);
            cmbGrowthStageFilter.Name = "cmbGrowthStageFilter";
            cmbGrowthStageFilter.Size = new Size(305, 33);
            cmbGrowthStageFilter.TabIndex = 88;
            cmbGrowthStageFilter.SelectedIndexChanged += cmbGrowthStageFilter_SelectedIndexChanged_1;
            cmbGrowthStageFilter.Enter += SelectedPanel;
            cmbGrowthStageFilter.Leave += UnselectedPanel;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 100;
            label1.Text = "Corn Type";
            // 
            // boxGrowthFilter
            // 
            boxGrowthFilter.Location = new Point(279, 35);
            boxGrowthFilter.Name = "boxGrowthFilter";
            boxGrowthFilter.Size = new Size(309, 39);
            boxGrowthFilter.TabIndex = 90;
            // 
            // labelGrowthFilter
            // 
            labelGrowthFilter.AutoSize = true;
            labelGrowthFilter.Location = new Point(279, 12);
            labelGrowthFilter.Name = "labelGrowthFilter";
            labelGrowthFilter.Size = new Size(99, 20);
            labelGrowthFilter.TabIndex = 89;
            labelGrowthFilter.Text = "Growth Stage";
            // 
            // cbTotal
            // 
            cbTotal.AutoSize = true;
            cbTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbTotal.Location = new Point(1480, 41);
            cbTotal.Name = "cbTotal";
            cbTotal.Size = new Size(68, 27);
            cbTotal.TabIndex = 3;
            cbTotal.Text = "Total";
            cbTotal.UseVisualStyleBackColor = true;
            cbTotal.CheckedChanged += cbTotal_CheckedChanged;
            cbTotal.Enter += SelectedPanel;
            cbTotal.Leave += UnselectedPanel;
            // 
            // cmbSeedType
            // 
            cmbSeedType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeedType.FlatStyle = FlatStyle.Flat;
            cmbSeedType.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSeedType.FormattingEnabled = true;
            cmbSeedType.Items.AddRange(new object[] { "GMO", "HYBRID", "OPV", "GREEN CORN/SWEET CORN", "TRADITIONAL" });
            cmbSeedType.Location = new Point(620, 37);
            cmbSeedType.Name = "cmbSeedType";
            cmbSeedType.Size = new Size(220, 33);
            cmbSeedType.TabIndex = 76;
            cmbSeedType.SelectedIndexChanged += cmbSeedType_SelectedIndexChanged;
            cmbSeedType.Enter += SelectedPanel;
            cmbSeedType.Leave += UnselectedPanel;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(614, 12);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 77;
            label8.Text = "Seed Type";
            // 
            // searchBox10
            // 
            searchBox10.Location = new Point(614, 34);
            searchBox10.Name = "searchBox10";
            searchBox10.Size = new Size(229, 39);
            searchBox10.TabIndex = 78;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelPlantingByEcoZone);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(1595, 176);
            panel4.TabIndex = 76;
            // 
            // panelPlantingByEcoZone
            // 
            panelPlantingByEcoZone.BorderStyle = BorderStyle.FixedSingle;
            panelPlantingByEcoZone.Controls.Add(labelCornPlantingId);
            panelPlantingByEcoZone.Controls.Add(searchBox12);
            panelPlantingByEcoZone.Controls.Add(label6);
            panelPlantingByEcoZone.Controls.Add(labelGrowthStage);
            panelPlantingByEcoZone.Controls.Add(txtSize);
            panelPlantingByEcoZone.Controls.Add(searchBox11);
            panelPlantingByEcoZone.Controls.Add(LabelSize);
            panelPlantingByEcoZone.Controls.Add(searchBox9);
            panelPlantingByEcoZone.Controls.Add(label14);
            panelPlantingByEcoZone.Controls.Add(cmbBrgy);
            panelPlantingByEcoZone.Controls.Add(searchBox8);
            panelPlantingByEcoZone.Controls.Add(label13);
            panelPlantingByEcoZone.Controls.Add(btnUpdate);
            panelPlantingByEcoZone.Controls.Add(label9);
            panelPlantingByEcoZone.Controls.Add(dtpLogDate);
            panelPlantingByEcoZone.Controls.Add(btnClear);
            panelPlantingByEcoZone.Controls.Add(btnNew);
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
            // searchBox12
            // 
            searchBox12.Location = new Point(26, 80);
            searchBox12.Name = "searchBox12";
            searchBox12.Size = new Size(80, 39);
            searchBox12.TabIndex = 98;
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
            txtSize.Location = new Point(694, 87);
            txtSize.Name = "txtSize";
            txtSize.PlaceholderText = "0.00";
            txtSize.Size = new Size(202, 24);
            txtSize.TabIndex = 94;
            txtSize.TextAlign = HorizontalAlignment.Right;
            txtSize.Enter += SelectedPanel;
            txtSize.KeyPress += NumOrDecimalsOnly;
            txtSize.Leave += UnselectedPanel;
            // 
            // searchBox11
            // 
            searchBox11.Location = new Point(688, 80);
            searchBox11.Name = "searchBox11";
            searchBox11.Size = new Size(216, 39);
            searchBox11.TabIndex = 93;
            // 
            // LabelSize
            // 
            LabelSize.AutoSize = true;
            LabelSize.Location = new Point(688, 58);
            LabelSize.Name = "LabelSize";
            LabelSize.Size = new Size(66, 20);
            LabelSize.TabIndex = 92;
            LabelSize.Text = "Size (ha)";
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
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(255, 221, 100);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(3, 0, 67);
            btnUpdate.Location = new Point(1281, 50);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(934, 57);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 54;
            label9.Text = "Date Planted";
            // 
            // dtpLogDate
            // 
            dtpLogDate.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLogDate.Format = DateTimePickerFormat.Short;
            dtpLogDate.Location = new Point(934, 87);
            dtpLogDate.Name = "dtpLogDate";
            dtpLogDate.Size = new Size(135, 28);
            dtpLogDate.TabIndex = 53;
            dtpLogDate.Enter += SelectedPanel;
            dtpLogDate.Leave += UnselectedPanel;
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
            btnClear.Location = new Point(1417, 95);
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
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.BackColor = Color.FromArgb(255, 221, 100);
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.FromArgb(3, 0, 67);
            btnNew.Location = new Point(1281, 95);
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
            // panelPlantingByEcoZoneHeader
            // 
            panelPlantingByEcoZoneHeader.BackColor = Color.FromArgb(43, 121, 223);
            panelPlantingByEcoZoneHeader.Controls.Add(label46);
            panelPlantingByEcoZoneHeader.Dock = DockStyle.Top;
            panelPlantingByEcoZoneHeader.Location = new Point(0, 0);
            panelPlantingByEcoZoneHeader.Name = "panelPlantingByEcoZoneHeader";
            panelPlantingByEcoZoneHeader.Size = new Size(1573, 29);
            panelPlantingByEcoZoneHeader.TabIndex = 0;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label46.ForeColor = Color.White;
            label46.Location = new Point(6, 1);
            label46.Name = "label46";
            label46.Size = new Size(300, 25);
            label46.TabIndex = 28;
            label46.Text = "PLANTING BY ECOLOGICAL ZONE";
            // 
            // CropsCornAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CropsCornAddView";
            Text = "CropsCornAddView";
            Load += CropsCornAddView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCornPlanting).EndInit();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panelPlantingByEcoZone;
        private Label labelCornPlantingId;
        private SearchBox searchBox12;
        private Label label6;
        private Label labelGrowthStage;
        private TextBox txtSize;
        private SearchBox searchBox11;
        private Label LabelSize;
        private SearchBox searchBox9;
        private Label label14;
        private ComboBox cmbBrgy;
        private SearchBox searchBox8;
        private Label label13;
        private Button btnUpdate;
        private ComboBox cmbSeedType;
        private SearchBox searchBox10;
        private Label label9;
        private Label label8;
        private DateTimePicker dtpLogDate;
        private Button btnClear;
        private Button btnNew;
        private Panel panelPlantingByEcoZoneHeader;
        private Label label46;
        private DataGridView dgvCornPlanting;
        private ComboBox cmbCornType;
        private SearchBox searchBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBack;
        private Panel panel4;
        private Panel panel7;
        private Panel panel5;
        private CheckBox cbTotal;
        private ComboBox cmbGrowthStageFilter;
        private SearchBox boxGrowthFilter;
        private Label labelGrowthFilter;
        private Panel panel8;
        private ComboBox cmbLandType;
        private Label label3;
        private SearchBox searchBox2;
    }
}