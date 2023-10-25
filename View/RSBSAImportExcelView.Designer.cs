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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            openFileDialog1 = new OpenFileDialog();
            btnSelect = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            txtSheetName = new TextBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            labelProgress = new Label();
            panel1 = new Panel();
            btnImport = new Button();
            btnAdd = new Button();
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
            btnSelect.Location = new Point(312, 41);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(195, 39);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select Excel File";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1261, 39);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 42);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.White;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(43, 121, 223);
            btnCancel.Location = new Point(1413, 39);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 42);
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
            progressBar1.Location = new Point(742, 42);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(294, 36);
            progressBar1.TabIndex = 6;
            // 
            // labelProgress
            // 
            labelProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(834, 52);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(103, 20);
            labelProgress.TabIndex = 7;
            labelProgress.Text = "progress label";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtSheetName);
            panel1.Controls.Add(searchBox3);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(labelProgress);
            panel1.Controls.Add(btnAdd);
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
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.BackColor = Color.FromArgb(43, 121, 223);
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnImport.ForeColor = Color.White;
            btnImport.Location = new Point(2639, 27);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(177, 39);
            btnImport.TabIndex = 4;
            btnImport.Text = "Import Excel File";
            btnImport.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(43, 121, 223);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(2838, 27);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 39);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
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
            dgvRSBSAtoImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRSBSAtoImport.BackgroundColor = Color.White;
            dgvRSBSAtoImport.BorderStyle = BorderStyle.None;
            dgvRSBSAtoImport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvRSBSAtoImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvRSBSAtoImport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvRSBSAtoImport.DefaultCellStyle = dataGridViewCellStyle12;
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
            Text = "RSBSAImportExcelView";
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
        private Button btnImport;
        private Button btnAdd;
        private SearchBox searchBox3;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvRSBSAtoImport;
    }
}