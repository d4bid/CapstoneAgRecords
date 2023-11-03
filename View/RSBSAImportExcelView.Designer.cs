namespace AgRecords.View
{
    partial class RSBSAImportExcelView
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
            openFileDialog1 = new OpenFileDialog();
            btnSelect = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            txtSheetName = new TextBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            labelProgress = new Label();
            panel1 = new Panel();
            searchBox3 = new SearchBox();
            panel3 = new Panel();
            panel2 = new Panel();
            dgvRSBSAtoImport = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRSBSAtoImport).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(0, 109, 104);
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(325, 41);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(195, 39);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select Excel File";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1285, 41);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 39);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnCancel.Location = new Point(1437, 41);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtSheetName
            // 
            txtSheetName.BorderStyle = BorderStyle.None;
            txtSheetName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSheetName.Location = new Point(48, 48);
            txtSheetName.Name = "txtSheetName";
            txtSheetName.Size = new Size(218, 24);
            txtSheetName.TabIndex = 4;
            txtSheetName.Text = "Sheet1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 5;
            label1.Text = "Sheet Name";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(728, 41);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(355, 40);
            progressBar1.TabIndex = 6;
            // 
            // labelProgress
            // 
            labelProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelProgress.AutoSize = true;
            labelProgress.BackColor = Color.Transparent;
            labelProgress.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelProgress.Location = new Point(725, 84);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(93, 17);
            labelProgress.TabIndex = 7;
            labelProgress.Text = "progress label";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtSheetName);
            panel1.Controls.Add(searchBox3);
            panel1.Controls.Add(labelProgress);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(1595, 115);
            panel1.TabIndex = 21;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(32, 41);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(246, 39);
            searchBox3.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(239, 239, 239);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(1595, 10);
            panel3.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvRSBSAtoImport);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1595, 801);
            panel2.TabIndex = 28;
            // 
            // dgvRSBSAtoImport
            // 
            dgvRSBSAtoImport.AllowUserToAddRows = false;
            dgvRSBSAtoImport.AllowUserToDeleteRows = false;
            dgvRSBSAtoImport.AllowUserToResizeRows = false;
            dgvRSBSAtoImport.BackgroundColor = Color.White;
            dgvRSBSAtoImport.BorderStyle = BorderStyle.None;
            dgvRSBSAtoImport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRSBSAtoImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRSBSAtoImport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRSBSAtoImport.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRSBSAtoImport.Dock = DockStyle.Fill;
            dgvRSBSAtoImport.GridColor = Color.FromArgb(239, 239, 239);
            dgvRSBSAtoImport.Location = new Point(10, 10);
            dgvRSBSAtoImport.Name = "dgvRSBSAtoImport";
            dgvRSBSAtoImport.ReadOnly = true;
            dgvRSBSAtoImport.RowHeadersVisible = false;
            dgvRSBSAtoImport.RowHeadersWidth = 51;
            dgvRSBSAtoImport.RowTemplate.Height = 40;
            dgvRSBSAtoImport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRSBSAtoImport.Size = new Size(1575, 781);
            dgvRSBSAtoImport.TabIndex = 23;
            // 
            // RSBSAImportExcelView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "RSBSAImportExcelView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RSBSAImportExcelView";
            Load += RSBSAImportExcelView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRSBSAtoImport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnSelect;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtSheetName;
        private Label label1;
        private ProgressBar progressBar1;
        private Label labelProgress;
        private Panel panel1;
        private SearchBox searchBox3;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvRSBSAtoImport;
    }
}