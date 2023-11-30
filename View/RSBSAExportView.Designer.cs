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
            cbIsMultipleSheet = new CheckBox();
            btnCancel = new Button();
            label2 = new Label();
            comboBoxFilterBrgy = new ComboBox();
            searchBox3 = new SearchBox();
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxFilterBrgy);
            panel1.Controls.Add(searchBox3);
            panel1.Controls.Add(btnExport);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(1595, 105);
            panel1.TabIndex = 21;
            // 
            // cbIsMultipleSheet
            // 
            cbIsMultipleSheet.AutoSize = true;
            cbIsMultipleSheet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbIsMultipleSheet.Location = new Point(244, 49);
            cbIsMultipleSheet.Name = "cbIsMultipleSheet";
            cbIsMultipleSheet.Size = new Size(242, 24);
            cbIsMultipleSheet.TabIndex = 39;
            cbIsMultipleSheet.Text = "Multiple Sheets (per Barangay)";
            cbIsMultipleSheet.UseVisualStyleBackColor = true;
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
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 19);
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
            comboBoxFilterBrgy.Location = new Point(18, 47);
            comboBoxFilterBrgy.Name = "comboBoxFilterBrgy";
            comboBoxFilterBrgy.Size = new Size(174, 28);
            comboBoxFilterBrgy.TabIndex = 23;
            comboBoxFilterBrgy.SelectedIndexChanged += comboBoxFilterBrgy_SelectedIndexChanged;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(12, 42);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(184, 39);
            searchBox3.TabIndex = 28;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.FromArgb(43, 121, 223);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
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
            panel2.Location = new Point(0, 387);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1595, 539);
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
            dgvRSBSAExport.Size = new Size(1575, 519);
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
            panel4.Size = new Size(1595, 262);
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
            groupBox1.Location = new Point(1018, 6);
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
            groupBox2.Controls.Add(checkBox10);
            groupBox2.Controls.Add(checkBox9);
            groupBox2.Controls.Add(checkBox8);
            groupBox2.Controls.Add(checkBox7);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(cbMobileNo);
            groupBox2.Controls.Add(cbBirthDate);
            groupBox2.Controls.Add(cbPlaceOfBirth);
            groupBox2.Controls.Add(cbProvince);
            groupBox2.Controls.Add(cbIdNumber);
            groupBox2.Controls.Add(cbMunicipality);
            groupBox2.Controls.Add(cbStreet);
            groupBox2.Location = new Point(10, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1002, 228);
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
            panel5.Location = new Point(0, 377);
            panel5.Name = "panel5";
            panel5.Size = new Size(1595, 10);
            panel5.TabIndex = 32;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(25, 121);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Street";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(161, 121);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(70, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Street";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(312, 121);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(70, 24);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Street";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.Location = new Point(608, 76);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(70, 24);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "Street";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.Location = new Point(25, 160);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(70, 24);
            checkBox5.TabIndex = 13;
            checkBox5.Text = "Street";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Checked = true;
            checkBox6.CheckState = CheckState.Checked;
            checkBox6.Location = new Point(161, 160);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(70, 24);
            checkBox6.TabIndex = 14;
            checkBox6.Text = "Street";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Checked = true;
            checkBox7.CheckState = CheckState.Checked;
            checkBox7.Location = new Point(312, 160);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(70, 24);
            checkBox7.TabIndex = 15;
            checkBox7.Text = "Street";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Checked = true;
            checkBox8.CheckState = CheckState.Checked;
            checkBox8.Location = new Point(483, 121);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(70, 24);
            checkBox8.TabIndex = 16;
            checkBox8.Text = "Street";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Checked = true;
            checkBox9.CheckState = CheckState.Checked;
            checkBox9.Location = new Point(608, 38);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(70, 24);
            checkBox9.TabIndex = 17;
            checkBox9.Text = "Street";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Checked = true;
            checkBox10.CheckState = CheckState.Checked;
            checkBox10.Location = new Point(483, 76);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(70, 24);
            checkBox10.TabIndex = 18;
            checkBox10.Text = "Street";
            checkBox10.UseVisualStyleBackColor = true;
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
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}