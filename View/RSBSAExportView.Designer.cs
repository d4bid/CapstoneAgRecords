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
            btnCancel = new Button();
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
            btnExport = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            dgvRSBSAExport = new DataGridView();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            cbAgriFishery = new CheckBox();
            cbHVC = new CheckBox();
            cbCorn = new CheckBox();
            cbRice = new CheckBox();
            cbFarmParcelNo = new CheckBox();
            cbTotalFarmArea = new CheckBox();
            groupBox2 = new GroupBox();
            cbMobileNo = new CheckBox();
            cbBirthDate = new CheckBox();
            cbPlaceOfBirth = new CheckBox();
            cbProvince = new CheckBox();
            cbIdNumber = new CheckBox();
            cbMunicipality = new CheckBox();
            cbStreet = new CheckBox();
            panel5 = new Panel();
            cbIsMultipleSheet = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRSBSAExport).BeginInit();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cbIsMultipleSheet);
            panel1.Controls.Add(btnCancel);
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
            panel1.Controls.Add(btnExport);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(1595, 105);
            panel1.TabIndex = 21;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.White;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(43, 121, 223);
            btnCancel.Location = new Point(1437, 42);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 40);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(771, 20);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 32;
            label3.Text = "Commodity";
            // 
            // comboBoxFilterCommodity
            // 
            comboBoxFilterCommodity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterCommodity.FlatStyle = FlatStyle.Flat;
            comboBoxFilterCommodity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilterCommodity.FormattingEnabled = true;
            comboBoxFilterCommodity.Items.AddRange(new object[] { "ALL", "Rice", "Corn", "HVC" });
            comboBoxFilterCommodity.Location = new Point(778, 48);
            comboBoxFilterCommodity.Name = "comboBoxFilterCommodity";
            comboBoxFilterCommodity.Size = new Size(174, 28);
            comboBoxFilterCommodity.TabIndex = 30;
            // 
            // searchBox4
            // 
            searchBox4.Location = new Point(771, 43);
            searchBox4.Name = "searchBox4";
            searchBox4.Size = new Size(184, 39);
            searchBox4.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 20);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 29;
            label2.Text = "Barangay";
            // 
            // comboBoxFilterBrgy
            // 
            comboBoxFilterBrgy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterBrgy.FlatStyle = FlatStyle.Flat;
            comboBoxFilterBrgy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilterBrgy.FormattingEnabled = true;
            comboBoxFilterBrgy.Items.AddRange(new object[] { "ALL", "AGGUB", "BAGAHABAG", "BANGAAN", "BANGAR", "BASCARAN", "COMMUNAL", "CONCEPCION CALALABANGAN", "CURIFANG", "DADAP", "LACTAWAN", "OSMENA", "PILAR D. GALIMA", "POBLACION NORTH", "QUEZON", "QUIRINO", "ROXAS", "SAN JUAN", "SAN LUIS", "TUCAL", "UDDIAWAN", "WACAL" });
            comboBoxFilterBrgy.Location = new Point(371, 48);
            comboBoxFilterBrgy.Name = "comboBoxFilterBrgy";
            comboBoxFilterBrgy.Size = new Size(174, 28);
            comboBoxFilterBrgy.TabIndex = 23;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(365, 43);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(184, 39);
            searchBox3.TabIndex = 28;
            // 
            // comboBoxSearchCategory
            // 
            comboBoxSearchCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCategory.FlatStyle = FlatStyle.Flat;
            comboBoxSearchCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSearchCategory.FormattingEnabled = true;
            comboBoxSearchCategory.Items.AddRange(new object[] { "ALL", "ID", "FIRST NAME", "MIDDLE NAME", "SURNAME" });
            comboBoxSearchCategory.Location = new Point(570, 48);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(183, 28);
            comboBoxSearchCategory.TabIndex = 21;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(565, 43);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(191, 39);
            searchBox2.TabIndex = 27;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.GrayText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = SystemColors.GrayText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(15, 50);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 24;
            iconPictureBox1.TabStop = false;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.BorderStyle = BorderStyle.None;
            txtBoxSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxSearch.Location = new Point(45, 50);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.PlaceholderText = "Search";
            txtBoxSearch.Size = new Size(291, 24);
            txtBoxSearch.TabIndex = 22;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(8, 43);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(341, 39);
            searchBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(565, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 25;
            label1.Text = "Category";
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(43, 121, 223);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(1292, 42);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(139, 40);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(239, 239, 239);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 10);
            panel3.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvRSBSAExport);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 260);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1595, 666);
            panel2.TabIndex = 30;
            // 
            // dgvRSBSAExport
            // 
            dgvRSBSAExport.AllowUserToAddRows = false;
            dgvRSBSAExport.AllowUserToDeleteRows = false;
            dgvRSBSAExport.AllowUserToResizeRows = false;
            dgvRSBSAExport.BackgroundColor = Color.White;
            dgvRSBSAExport.BorderStyle = BorderStyle.None;
            dgvRSBSAExport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRSBSAExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRSBSAExport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRSBSAExport.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRSBSAExport.Dock = DockStyle.Fill;
            dgvRSBSAExport.GridColor = Color.FromArgb(239, 239, 239);
            dgvRSBSAExport.Location = new Point(10, 10);
            dgvRSBSAExport.Name = "dgvRSBSAExport";
            dgvRSBSAExport.ReadOnly = true;
            dgvRSBSAExport.RowHeadersVisible = false;
            dgvRSBSAExport.RowHeadersWidth = 51;
            dgvRSBSAExport.RowTemplate.Height = 40;
            dgvRSBSAExport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRSBSAExport.Size = new Size(1575, 646);
            dgvRSBSAExport.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 115);
            panel4.Name = "panel4";
            panel4.Size = new Size(1595, 135);
            panel4.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbAgriFishery);
            groupBox1.Controls.Add(cbHVC);
            groupBox1.Controls.Add(cbCorn);
            groupBox1.Controls.Add(cbRice);
            groupBox1.Controls.Add(cbFarmParcelNo);
            groupBox1.Controls.Add(cbTotalFarmArea);
            groupBox1.Location = new Point(755, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 116);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Farm Info";
            // 
            // cbAgriFishery
            // 
            cbAgriFishery.AutoSize = true;
            cbAgriFishery.Checked = true;
            cbAgriFishery.CheckState = CheckState.Checked;
            cbAgriFishery.Location = new Point(448, 76);
            cbAgriFishery.Name = "cbAgriFishery";
            cbAgriFishery.Size = new Size(110, 24);
            cbAgriFishery.TabIndex = 6;
            cbAgriFishery.Text = "Agri-Fishery";
            cbAgriFishery.UseVisualStyleBackColor = true;
            cbAgriFishery.CheckedChanged += cbAgriFishery_CheckedChanged;
            // 
            // cbHVC
            // 
            cbHVC.AutoSize = true;
            cbHVC.Checked = true;
            cbHVC.CheckState = CheckState.Checked;
            cbHVC.Location = new Point(340, 76);
            cbHVC.Name = "cbHVC";
            cbHVC.Size = new Size(60, 24);
            cbHVC.TabIndex = 5;
            cbHVC.Text = "HVC";
            cbHVC.UseVisualStyleBackColor = true;
            cbHVC.CheckedChanged += cbHVC_CheckedChanged;
            // 
            // cbCorn
            // 
            cbCorn.AutoSize = true;
            cbCorn.Checked = true;
            cbCorn.CheckState = CheckState.Checked;
            cbCorn.Location = new Point(193, 76);
            cbCorn.Name = "cbCorn";
            cbCorn.Size = new Size(62, 24);
            cbCorn.TabIndex = 4;
            cbCorn.Text = "Corn";
            cbCorn.UseVisualStyleBackColor = true;
            cbCorn.CheckedChanged += cbCorn_CheckedChanged;
            // 
            // cbRice
            // 
            cbRice.AutoSize = true;
            cbRice.Checked = true;
            cbRice.CheckState = CheckState.Checked;
            cbRice.Location = new Point(25, 76);
            cbRice.Name = "cbRice";
            cbRice.Size = new Size(59, 24);
            cbRice.TabIndex = 3;
            cbRice.Text = "Rice";
            cbRice.UseVisualStyleBackColor = true;
            cbRice.CheckedChanged += cbRice_CheckedChanged;
            // 
            // cbFarmParcelNo
            // 
            cbFarmParcelNo.AutoSize = true;
            cbFarmParcelNo.Checked = true;
            cbFarmParcelNo.CheckState = CheckState.Checked;
            cbFarmParcelNo.Location = new Point(25, 38);
            cbFarmParcelNo.Name = "cbFarmParcelNo";
            cbFarmParcelNo.Size = new Size(149, 24);
            cbFarmParcelNo.TabIndex = 1;
            cbFarmParcelNo.Text = "Farm Parcel Count";
            cbFarmParcelNo.UseVisualStyleBackColor = true;
            cbFarmParcelNo.CheckedChanged += cbFarmParcelNo_CheckedChanged;
            // 
            // cbTotalFarmArea
            // 
            cbTotalFarmArea.AutoSize = true;
            cbTotalFarmArea.Checked = true;
            cbTotalFarmArea.CheckState = CheckState.Checked;
            cbTotalFarmArea.Location = new Point(193, 38);
            cbTotalFarmArea.Name = "cbTotalFarmArea";
            cbTotalFarmArea.Size = new Size(135, 24);
            cbTotalFarmArea.TabIndex = 2;
            cbTotalFarmArea.Text = "Total Farm Area";
            cbTotalFarmArea.UseVisualStyleBackColor = true;
            cbTotalFarmArea.CheckedChanged += cbTotalFarmArea_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbMobileNo);
            groupBox2.Controls.Add(cbBirthDate);
            groupBox2.Controls.Add(cbPlaceOfBirth);
            groupBox2.Controls.Add(cbProvince);
            groupBox2.Controls.Add(cbIdNumber);
            groupBox2.Controls.Add(cbMunicipality);
            groupBox2.Controls.Add(cbStreet);
            groupBox2.Location = new Point(10, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(723, 116);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Farmer Info";
            // 
            // cbMobileNo
            // 
            cbMobileNo.AutoSize = true;
            cbMobileNo.Checked = true;
            cbMobileNo.CheckState = CheckState.Checked;
            cbMobileNo.Location = new Point(312, 76);
            cbMobileNo.Name = "cbMobileNo";
            cbMobileNo.Size = new Size(136, 24);
            cbMobileNo.TabIndex = 8;
            cbMobileNo.Text = "Mobile Number";
            cbMobileNo.UseVisualStyleBackColor = true;
            cbMobileNo.CheckedChanged += cbMobileNo_CheckedChanged;
            // 
            // cbBirthDate
            // 
            cbBirthDate.AutoSize = true;
            cbBirthDate.Checked = true;
            cbBirthDate.CheckState = CheckState.Checked;
            cbBirthDate.Location = new Point(25, 76);
            cbBirthDate.Name = "cbBirthDate";
            cbBirthDate.Size = new Size(98, 24);
            cbBirthDate.TabIndex = 7;
            cbBirthDate.Text = "Birth Date";
            cbBirthDate.UseVisualStyleBackColor = true;
            cbBirthDate.CheckedChanged += cbBirthDate_CheckedChanged;
            // 
            // cbPlaceOfBirth
            // 
            cbPlaceOfBirth.AutoSize = true;
            cbPlaceOfBirth.Checked = true;
            cbPlaceOfBirth.CheckState = CheckState.Checked;
            cbPlaceOfBirth.Location = new Point(161, 76);
            cbPlaceOfBirth.Name = "cbPlaceOfBirth";
            cbPlaceOfBirth.Size = new Size(119, 24);
            cbPlaceOfBirth.TabIndex = 6;
            cbPlaceOfBirth.Text = "Place of Birth";
            cbPlaceOfBirth.UseVisualStyleBackColor = true;
            cbPlaceOfBirth.CheckedChanged += cbPlaceOfBirth_CheckedChanged;
            // 
            // cbProvince
            // 
            cbProvince.AutoSize = true;
            cbProvince.Checked = true;
            cbProvince.CheckState = CheckState.Checked;
            cbProvince.Location = new Point(483, 38);
            cbProvince.Name = "cbProvince";
            cbProvince.Size = new Size(87, 24);
            cbProvince.TabIndex = 5;
            cbProvince.Text = "Province";
            cbProvince.UseVisualStyleBackColor = true;
            cbProvince.CheckedChanged += cbProvince_CheckedChanged;
            // 
            // cbIdNumber
            // 
            cbIdNumber.AutoSize = true;
            cbIdNumber.Checked = true;
            cbIdNumber.CheckState = CheckState.Checked;
            cbIdNumber.Location = new Point(25, 38);
            cbIdNumber.Name = "cbIdNumber";
            cbIdNumber.Size = new Size(104, 24);
            cbIdNumber.TabIndex = 1;
            cbIdNumber.Text = "ID Number";
            cbIdNumber.UseVisualStyleBackColor = true;
            cbIdNumber.CheckedChanged += cbIdNumber_CheckedChanged;
            // 
            // cbMunicipality
            // 
            cbMunicipality.AutoSize = true;
            cbMunicipality.Checked = true;
            cbMunicipality.CheckState = CheckState.Checked;
            cbMunicipality.Location = new Point(312, 38);
            cbMunicipality.Name = "cbMunicipality";
            cbMunicipality.Size = new Size(112, 24);
            cbMunicipality.TabIndex = 4;
            cbMunicipality.Text = "Municipality";
            cbMunicipality.UseVisualStyleBackColor = true;
            cbMunicipality.CheckedChanged += cbMunicipality_CheckedChanged;
            // 
            // cbStreet
            // 
            cbStreet.AutoSize = true;
            cbStreet.Checked = true;
            cbStreet.CheckState = CheckState.Checked;
            cbStreet.Location = new Point(161, 38);
            cbStreet.Name = "cbStreet";
            cbStreet.Size = new Size(70, 24);
            cbStreet.TabIndex = 3;
            cbStreet.Text = "Street";
            cbStreet.UseVisualStyleBackColor = true;
            cbStreet.CheckedChanged += cbStreet_CheckedChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(239, 239, 239);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 250);
            panel5.Name = "panel5";
            panel5.Size = new Size(1595, 10);
            panel5.TabIndex = 32;
            // 
            // cbIsMultipleSheet
            // 
            cbIsMultipleSheet.AutoSize = true;
            cbIsMultipleSheet.Checked = true;
            cbIsMultipleSheet.CheckState = CheckState.Checked;
            cbIsMultipleSheet.Location = new Point(1057, 50);
            cbIsMultipleSheet.Name = "cbIsMultipleSheet";
            cbIsMultipleSheet.Size = new Size(229, 24);
            cbIsMultipleSheet.TabIndex = 39;
            cbIsMultipleSheet.Text = "Multiple Sheet (per Barangay)";
            cbIsMultipleSheet.UseVisualStyleBackColor = true;
            // 
            // RSBSAExportView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "RSBSAExportView";
            Text = "RSBSAExportView";
            Load += RSBSAExportView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRSBSAExport).EndInit();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExport;
        private Panel panel3;
        private Panel panel2;
        private Label label3;
        private ComboBox comboBoxFilterCommodity;
        private SearchBox searchBox4;
        private Label label2;
        private ComboBox comboBoxFilterBrgy;
        private SearchBox searchBox3;
        private ComboBox comboBoxSearchCategory;
        private SearchBox searchBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtBoxSearch;
        private SearchBox searchBox1;
        private Label label1;
        private DataGridView dgvRSBSAExport;
        private Panel panel4;
        private Panel panel5;
        private CheckBox cbStreet;
        private CheckBox cbIdNumber;
        private CheckBox cbMunicipality;
        private CheckBox cbProvince;
        private GroupBox groupBox2;
        private CheckBox cbBirthDate;
        private CheckBox cbPlaceOfBirth;
        private GroupBox groupBox1;
        private CheckBox cbFarmParcelNo;
        private CheckBox cbTotalFarmArea;
        private CheckBox cbMobileNo;
        private Button btnCancel;
        private CheckBox cbAgriFishery;
        private CheckBox cbHVC;
        private CheckBox cbCorn;
        private CheckBox cbRice;
        private CheckBox cbIsMultipleSheet;
    }
}