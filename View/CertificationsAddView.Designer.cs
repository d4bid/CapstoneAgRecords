namespace AgRecords.View
{
    partial class CertificationsAddView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificationsAddView));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtReferenceNumber = new TextBox();
            label4 = new Label();
            rectangleRound4 = new RectangleRound();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label6 = new Label();
            rectangleRound7 = new RectangleRound();
            labelRsbsaId = new Label();
            panel1 = new Panel();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnPrint = new FontAwesome.Sharp.IconButton();
            txtOrNo = new TextBox();
            label2 = new Label();
            rectangleRound1 = new RectangleRound();
            panel3 = new Panel();
            panel2 = new Panel();
            panel9 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel8 = new Panel();
            panel7 = new Panel();
            groupBox1 = new GroupBox();
            lblTempParcelCount = new Label();
            txtBarangay = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            rectangleRound2 = new RectangleRound();
            label3 = new Label();
            rectangleRound3 = new RectangleRound();
            panel4 = new Panel();
            panel5 = new Panel();
            label10 = new Label();
            panel6 = new Panel();
            dgvCert = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCert).BeginInit();
            SuspendLayout();
            // 
            // txtReferenceNumber
            // 
            txtReferenceNumber.BorderStyle = BorderStyle.None;
            txtReferenceNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtReferenceNumber.Location = new Point(406, 42);
            txtReferenceNumber.Margin = new Padding(3, 4, 3, 4);
            txtReferenceNumber.Name = "txtReferenceNumber";
            txtReferenceNumber.Size = new Size(316, 27);
            txtReferenceNumber.TabIndex = 30;
            txtReferenceNumber.Text = "Ref Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 16);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 22;
            label4.Text = "Reference Number";
            // 
            // rectangleRound4
            // 
            rectangleRound4.BackColor = Color.White;
            rectangleRound4.Location = new Point(391, 39);
            rectangleRound4.Name = "rectangleRound4";
            rectangleRound4.Size = new Size(346, 38);
            rectangleRound4.TabIndex = 23;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 16);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 31;
            label6.Text = "RSBSA ID";
            // 
            // rectangleRound7
            // 
            rectangleRound7.BackColor = Color.White;
            rectangleRound7.Location = new Point(13, 39);
            rectangleRound7.Name = "rectangleRound7";
            rectangleRound7.Size = new Size(346, 38);
            rectangleRound7.TabIndex = 32;
            // 
            // labelRsbsaId
            // 
            labelRsbsaId.AutoSize = true;
            labelRsbsaId.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelRsbsaId.Location = new Point(22, 45);
            labelRsbsaId.Name = "labelRsbsaId";
            labelRsbsaId.Size = new Size(30, 25);
            labelRsbsaId.TabIndex = 33;
            labelRsbsaId.Text = "ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(txtOrNo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtReferenceNumber);
            panel1.Controls.Add(rectangleRound1);
            panel1.Controls.Add(labelRsbsaId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(rectangleRound4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(rectangleRound7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(1595, 90);
            panel1.TabIndex = 36;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.White;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(43, 121, 223);
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.FromArgb(43, 121, 223);
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 30;
            btnCancel.Location = new Point(1435, 36);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(148, 40);
            btnCancel.TabIndex = 59;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
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
            btnPrint.Location = new Point(1281, 36);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(148, 40);
            btnPrint.TabIndex = 58;
            btnPrint.Text = "Print";
            btnPrint.TextAlign = ContentAlignment.MiddleRight;
            btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // txtOrNo
            // 
            txtOrNo.BorderStyle = BorderStyle.None;
            txtOrNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtOrNo.Location = new Point(784, 42);
            txtOrNo.Margin = new Padding(3, 4, 3, 4);
            txtOrNo.Name = "txtOrNo";
            txtOrNo.Size = new Size(195, 27);
            txtOrNo.TabIndex = 31;
            txtOrNo.Text = "O.R. No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(769, 16);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 22;
            label2.Text = "O.R. No.";
            // 
            // rectangleRound1
            // 
            rectangleRound1.BackColor = Color.White;
            rectangleRound1.Location = new Point(769, 39);
            rectangleRound1.Name = "rectangleRound1";
            rectangleRound1.Size = new Size(225, 38);
            rectangleRound1.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(239, 239, 239);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 10);
            panel3.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 826);
            panel2.TabIndex = 38;
            // 
            // panel9
            // 
            panel9.Controls.Add(flowLayoutPanel1);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 127);
            panel9.Name = "panel9";
            panel9.Size = new Size(831, 699);
            panel9.TabIndex = 38;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(799, 683);
            flowLayoutPanel1.TabIndex = 39;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 117);
            panel8.Name = "panel8";
            panel8.Size = new Size(831, 10);
            panel8.TabIndex = 37;
            // 
            // panel7
            // 
            panel7.Controls.Add(groupBox1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(831, 117);
            panel7.TabIndex = 36;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTempParcelCount);
            groupBox1.Controls.Add(txtBarangay);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rectangleRound2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rectangleRound3);
            groupBox1.Location = new Point(13, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 106);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // lblTempParcelCount
            // 
            lblTempParcelCount.AutoSize = true;
            lblTempParcelCount.Location = new Point(620, 11);
            lblTempParcelCount.Name = "lblTempParcelCount";
            lblTempParcelCount.Size = new Size(122, 20);
            lblTempParcelCount.TabIndex = 29;
            lblTempParcelCount.Text = "tempParcelCount";
            lblTempParcelCount.Visible = false;
            // 
            // txtBarangay
            // 
            txtBarangay.BorderStyle = BorderStyle.None;
            txtBarangay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBarangay.Location = new Point(469, 50);
            txtBarangay.Margin = new Padding(3, 4, 3, 4);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.Size = new Size(271, 27);
            txtBarangay.TabIndex = 28;
            txtBarangay.Text = "Barangay";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(34, 50);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 27);
            txtName.TabIndex = 27;
            txtName.Text = "NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 22;
            label1.Text = "Name";
            // 
            // rectangleRound2
            // 
            rectangleRound2.BackColor = Color.White;
            rectangleRound2.Location = new Point(19, 46);
            rectangleRound2.Name = "rectangleRound2";
            rectangleRound2.Size = new Size(408, 38);
            rectangleRound2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 21);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 24;
            label3.Text = "Address (Barangay)";
            // 
            // rectangleRound3
            // 
            rectangleRound3.BackColor = Color.White;
            rectangleRound3.Location = new Point(454, 47);
            rectangleRound3.Name = "rectangleRound3";
            rectangleRound3.Size = new Size(301, 38);
            rectangleRound3.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(239, 239, 239);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(831, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 826);
            panel4.TabIndex = 39;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label10);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(841, 100);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(754, 54);
            panel5.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(13, 24);
            label10.Name = "label10";
            label10.Size = new Size(159, 20);
            label10.TabIndex = 32;
            label10.Text = "Requested Certificates";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgvCert);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(841, 154);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10);
            panel6.Size = new Size(754, 772);
            panel6.TabIndex = 41;
            // 
            // dgvCert
            // 
            dgvCert.AllowUserToAddRows = false;
            dgvCert.AllowUserToDeleteRows = false;
            dgvCert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCert.BackgroundColor = Color.White;
            dgvCert.BorderStyle = BorderStyle.None;
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
            dgvCert.Dock = DockStyle.Fill;
            dgvCert.GridColor = Color.FromArgb(239, 239, 239);
            dgvCert.Location = new Point(10, 10);
            dgvCert.Name = "dgvCert";
            dgvCert.ReadOnly = true;
            dgvCert.RowHeadersVisible = false;
            dgvCert.RowHeadersWidth = 51;
            dgvCert.RowTemplate.Height = 40;
            dgvCert.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCert.Size = new Size(734, 752);
            dgvCert.TabIndex = 24;
            // 
            // CertificationsAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CertificationsAddView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Issue Certificate";
            Load += CertificationsAddView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCert).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private RectangleRound rectangleRound4;
        private TextBox txtReferenceNumber;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label6;
        private RectangleRound rectangleRound7;
        private Label labelRsbsaId;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtOrNo;
        private Label label2;
        private RectangleRound rectangleRound1;
        private GroupBox groupBox1;
        private TextBox txtBarangay;
        private TextBox txtName;
        private Label label1;
        private RectangleRound rectangleRound2;
        private Label label3;
        private RectangleRound rectangleRound3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private DataGridView dgvCert;
        private Panel panel9;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel8;
        private Panel panel7;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnPrint;
        private FontAwesome.Sharp.IconButton btnCancel;
        private Label lblTempParcelCount;
    }
}