namespace AgRecords.View
{
    partial class FarmLandControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelParcelNo = new Label();
            panel1 = new Panel();
            panel7 = new Panel();
            rtbRemarks = new RichTextBox();
            label18 = new Label();
            cmbOrganicPractitioner = new ComboBox();
            label17 = new Label();
            cmbFarmType = new ComboBox();
            label16 = new Label();
            headNo = new NumericUpDown();
            label15 = new Label();
            nudFarmSize = new NumericUpDown();
            label14 = new Label();
            txtAnimalType = new ComboBox();
            txtCropCommodity = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            panel6 = new Panel();
            txtOwnershipOthers = new TextBox();
            checkBox4 = new CheckBox();
            txtLesseeOwnerName = new TextBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            txtTenantOwnerName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            cmbAgrarianReformBen = new ComboBox();
            label8 = new Label();
            cmbAncestralDomain = new ComboBox();
            label7 = new Label();
            nudFarmArea = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cmbBarangay = new ComboBox();
            cmbMunicipality = new ComboBox();
            label1 = new Label();
            txtOwnershipDcNo = new TextBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel8 = new Panel();
            label11 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)headNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFarmSize).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFarmArea).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelParcelNo
            // 
            labelParcelNo.AutoSize = true;
            labelParcelNo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelParcelNo.Location = new Point(67, 145);
            labelParcelNo.Name = "labelParcelNo";
            labelParcelNo.Size = new Size(16, 18);
            labelParcelNo.TabIndex = 0;
            labelParcelNo.Text = "1";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 523);
            panel1.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(rtbRemarks);
            panel7.Controls.Add(label18);
            panel7.Controls.Add(cmbOrganicPractitioner);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(cmbFarmType);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(headNo);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(nudFarmSize);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(txtAnimalType);
            panel7.Controls.Add(txtCropCommodity);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label12);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(618, 48);
            panel7.Name = "panel7";
            panel7.Size = new Size(494, 473);
            panel7.TabIndex = 25;
            // 
            // rtbRemarks
            // 
            rtbRemarks.Location = new Point(148, 335);
            rtbRemarks.Name = "rtbRemarks";
            rtbRemarks.Size = new Size(324, 123);
            rtbRemarks.TabIndex = 58;
            rtbRemarks.Text = "";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(17, 335);
            label18.Name = "label18";
            label18.Size = new Size(69, 18);
            label18.TabIndex = 57;
            label18.Text = "Remarks";
            // 
            // cmbOrganicPractitioner
            // 
            cmbOrganicPractitioner.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrganicPractitioner.FormattingEnabled = true;
            cmbOrganicPractitioner.Items.AddRange(new object[] { "Yes", "No" });
            cmbOrganicPractitioner.Location = new Point(217, 258);
            cmbOrganicPractitioner.Name = "cmbOrganicPractitioner";
            cmbOrganicPractitioner.Size = new Size(255, 25);
            cmbOrganicPractitioner.TabIndex = 56;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(17, 263);
            label17.Name = "label17";
            label17.Size = new Size(139, 18);
            label17.TabIndex = 55;
            label17.Text = "Organic Practitioner";
            // 
            // cmbFarmType
            // 
            cmbFarmType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFarmType.FormattingEnabled = true;
            cmbFarmType.Items.AddRange(new object[] { "Irrigated", "Rainfed Upland", "Rainfed Lowland" });
            cmbFarmType.Location = new Point(148, 211);
            cmbFarmType.Name = "cmbFarmType";
            cmbFarmType.Size = new Size(324, 25);
            cmbFarmType.TabIndex = 54;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(17, 212);
            label16.Name = "label16";
            label16.Size = new Size(79, 18);
            label16.TabIndex = 53;
            label16.Text = "Farm Type";
            // 
            // headNo
            // 
            headNo.Location = new Point(148, 173);
            headNo.Name = "headNo";
            headNo.Size = new Size(324, 25);
            headNo.TabIndex = 52;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(17, 173);
            label15.Name = "label15";
            label15.Size = new Size(88, 18);
            label15.TabIndex = 51;
            label15.Text = "No. of Head";
            // 
            // nudFarmSize
            // 
            nudFarmSize.Location = new Point(86, 114);
            nudFarmSize.Name = "nudFarmSize";
            nudFarmSize.Size = new Size(386, 25);
            nudFarmSize.TabIndex = 50;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(17, 114);
            label14.Name = "label14";
            label14.Size = new Size(37, 18);
            label14.TabIndex = 49;
            label14.Text = "Size";
            // 
            // txtAnimalType
            // 
            txtAnimalType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtAnimalType.FormattingEnabled = true;
            txtAnimalType.Location = new Point(187, 56);
            txtAnimalType.Name = "txtAnimalType";
            txtAnimalType.Size = new Size(285, 25);
            txtAnimalType.TabIndex = 48;
            // 
            // txtCropCommodity
            // 
            txtCropCommodity.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCropCommodity.FormattingEnabled = true;
            txtCropCommodity.Items.AddRange(new object[] { "Rice", "Corn", "HVC", "Livestock", "Poultry", "Agri-Fishery" });
            txtCropCommodity.Location = new Point(187, 10);
            txtCropCommodity.Name = "txtCropCommodity";
            txtCropCommodity.Size = new Size(285, 25);
            txtCropCommodity.TabIndex = 47;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(17, 57);
            label13.Name = "label13";
            label13.Size = new Size(105, 18);
            label13.TabIndex = 46;
            label13.Text = "Type of Animal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(17, 11);
            label12.Name = "label12";
            label12.Size = new Size(122, 18);
            label12.TabIndex = 45;
            label12.Text = "Crop/Commodity";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txtOwnershipOthers);
            panel6.Controls.Add(checkBox4);
            panel6.Controls.Add(txtLesseeOwnerName);
            panel6.Controls.Add(checkBox3);
            panel6.Controls.Add(checkBox2);
            panel6.Controls.Add(checkBox1);
            panel6.Controls.Add(txtTenantOwnerName);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(cmbAgrarianReformBen);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(cmbAncestralDomain);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(nudFarmArea);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(cmbBarangay);
            panel6.Controls.Add(cmbMunicipality);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(txtOwnershipDcNo);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(140, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(478, 473);
            panel6.TabIndex = 24;
            // 
            // txtOwnershipOthers
            // 
            txtOwnershipOthers.BorderStyle = BorderStyle.FixedSingle;
            txtOwnershipOthers.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtOwnershipOthers.Location = new Point(145, 432);
            txtOwnershipOthers.Name = "txtOwnershipOthers";
            txtOwnershipOthers.Size = new Size(322, 25);
            txtOwnershipOthers.TabIndex = 44;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(27, 432);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(72, 22);
            checkBox4.TabIndex = 43;
            checkBox4.Text = "Others";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // txtLesseeOwnerName
            // 
            txtLesseeOwnerName.BorderStyle = BorderStyle.FixedSingle;
            txtLesseeOwnerName.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLesseeOwnerName.Location = new Point(145, 399);
            txtLesseeOwnerName.Name = "txtLesseeOwnerName";
            txtLesseeOwnerName.Size = new Size(322, 25);
            txtLesseeOwnerName.TabIndex = 42;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(27, 400);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(75, 22);
            checkBox3.TabIndex = 41;
            checkBox3.Text = "Lessee";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(27, 368);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(75, 22);
            checkBox2.TabIndex = 40;
            checkBox2.Text = "Tenant";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 336);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 22);
            checkBox1.TabIndex = 39;
            checkBox1.Text = "Registered Owner";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtTenantOwnerName
            // 
            txtTenantOwnerName.BorderStyle = BorderStyle.FixedSingle;
            txtTenantOwnerName.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenantOwnerName.Location = new Point(145, 365);
            txtTenantOwnerName.Name = "txtTenantOwnerName";
            txtTenantOwnerName.Size = new Size(322, 25);
            txtTenantOwnerName.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 301);
            label10.Name = "label10";
            label10.Size = new Size(115, 18);
            label10.TabIndex = 37;
            label10.Text = "Ownership Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 263);
            label9.Name = "label9";
            label9.Size = new Size(180, 18);
            label9.TabIndex = 36;
            label9.Text = "Ownership Document No.";
            // 
            // cmbAgrarianReformBen
            // 
            cmbAgrarianReformBen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgrarianReformBen.FormattingEnabled = true;
            cmbAgrarianReformBen.Items.AddRange(new object[] { "Yes", "No" });
            cmbAgrarianReformBen.Location = new Point(262, 206);
            cmbAgrarianReformBen.Name = "cmbAgrarianReformBen";
            cmbAgrarianReformBen.Size = new Size(205, 25);
            cmbAgrarianReformBen.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 212);
            label8.Name = "label8";
            label8.Size = new Size(192, 18);
            label8.TabIndex = 34;
            label8.Text = "Agrarian Reform Beneficiary";
            // 
            // cmbAncestralDomain
            // 
            cmbAncestralDomain.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAncestralDomain.FormattingEnabled = true;
            cmbAncestralDomain.Items.AddRange(new object[] { "Yes", "No" });
            cmbAncestralDomain.Location = new Point(262, 167);
            cmbAncestralDomain.Name = "cmbAncestralDomain";
            cmbAncestralDomain.Size = new Size(205, 25);
            cmbAncestralDomain.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 173);
            label7.Name = "label7";
            label7.Size = new Size(159, 18);
            label7.TabIndex = 32;
            label7.Text = "With Ancestral Domain";
            // 
            // nudFarmArea
            // 
            nudFarmArea.Location = new Point(262, 114);
            nudFarmArea.Name = "nudFarmArea";
            nudFarmArea.Size = new Size(205, 25);
            nudFarmArea.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 114);
            label6.Name = "label6";
            label6.Size = new Size(200, 18);
            label6.TabIndex = 30;
            label6.Text = "Total Farm Area (in hectares)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(154, 57);
            label5.Name = "label5";
            label5.Size = new Size(84, 18);
            label5.TabIndex = 29;
            label5.Text = "Municipality";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(154, 12);
            label4.Name = "label4";
            label4.Size = new Size(70, 18);
            label4.TabIndex = 28;
            label4.Text = "Barangay";
            // 
            // cmbBarangay
            // 
            cmbBarangay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarangay.FormattingEnabled = true;
            cmbBarangay.Location = new Point(262, 11);
            cmbBarangay.Name = "cmbBarangay";
            cmbBarangay.Size = new Size(205, 25);
            cmbBarangay.TabIndex = 27;
            // 
            // cmbMunicipality
            // 
            cmbMunicipality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipality.FormattingEnabled = true;
            cmbMunicipality.Location = new Point(262, 56);
            cmbMunicipality.Name = "cmbMunicipality";
            cmbMunicipality.Size = new Size(205, 25);
            cmbMunicipality.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(104, 18);
            label1.TabIndex = 25;
            label1.Text = "Farm Location";
            // 
            // txtOwnershipDcNo
            // 
            txtOwnershipDcNo.BorderStyle = BorderStyle.FixedSingle;
            txtOwnershipDcNo.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtOwnershipDcNo.Location = new Point(262, 258);
            txtOwnershipDcNo.Name = "txtOwnershipDcNo";
            txtOwnershipDcNo.Size = new Size(205, 25);
            txtOwnershipDcNo.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(labelParcelNo);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(140, 473);
            panel4.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 48);
            panel2.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label11);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(617, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(494, 46);
            panel8.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(217, 10);
            label11.Name = "label11";
            label11.Size = new Size(43, 18);
            label11.TabIndex = 5;
            label11.Text = "Farm";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(139, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(478, 46);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(145, 10);
            label3.Name = "label3";
            label3.Size = new Size(158, 18);
            label3.TabIndex = 4;
            label3.Text = "Farm Land Description";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(139, 46);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 10);
            label2.Name = "label2";
            label2.Size = new Size(117, 18);
            label2.TabIndex = 3;
            label2.Text = "Farm Parcel No.";
            // 
            // FarmLandControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FarmLandControl";
            Size = new Size(1121, 532);
            Load += FarmLandControl_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)headNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFarmSize).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFarmArea).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label labelParcelNo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private TextBox txtOwnershipOthers;
        private CheckBox checkBox4;
        private TextBox txtLesseeOwnerName;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox txtTenantOwnerName;
        private Label label10;
        private Label label9;
        private ComboBox cmbAgrarianReformBen;
        private Label label8;
        private ComboBox cmbAncestralDomain;
        private Label label7;
        private NumericUpDown nudFarmArea;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbBarangay;
        private ComboBox cmbMunicipality;
        private Label label1;
        private TextBox txtOwnershipDcNo;
        private Panel panel8;
        private Label label11;
        private Label label13;
        private Label label12;
        private ComboBox txtAnimalType;
        private ComboBox txtCropCommodity;
        private NumericUpDown nudFarmSize;
        private Label label14;
        private NumericUpDown headNo;
        private Label label15;
        private ComboBox cmbFarmType;
        private Label label16;
        private ComboBox cmbOrganicPractitioner;
        private Label label17;
        private Label label18;
        private RichTextBox rtbRemarks;
    }
}
