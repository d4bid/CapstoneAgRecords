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
            openFileDialog1 = new OpenFileDialog();
            btnSelect = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            dgvRSBSAtoImport = new DataGridView();
            txtSheetName = new TextBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            labelProgress = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRSBSAtoImport).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(421, 12);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(195, 29);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select Excel File";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(940, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(195, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1141, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(195, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvRSBSAtoImport
            // 
            dgvRSBSAtoImport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRSBSAtoImport.Location = new Point(12, 47);
            dgvRSBSAtoImport.Name = "dgvRSBSAtoImport";
            dgvRSBSAtoImport.RowHeadersWidth = 51;
            dgvRSBSAtoImport.RowTemplate.Height = 29;
            dgvRSBSAtoImport.Size = new Size(1324, 541);
            dgvRSBSAtoImport.TabIndex = 3;
            // 
            // txtSheetName
            // 
            txtSheetName.Location = new Point(290, 12);
            txtSheetName.Name = "txtSheetName";
            txtSheetName.Size = new Size(125, 27);
            txtSheetName.TabIndex = 4;
            txtSheetName.Text = "Sheet1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 5;
            label1.Text = "Sheet Name";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(640, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(294, 36);
            progressBar1.TabIndex = 6;
            // 
            // labelProgress
            // 
            labelProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(732, 15);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(103, 20);
            labelProgress.TabIndex = 7;
            labelProgress.Text = "progress label";
            // 
            // RSBSAImportExcelView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 600);
            Controls.Add(labelProgress);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(txtSheetName);
            Controls.Add(dgvRSBSAtoImport);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnSelect);
            Name = "RSBSAImportExcelView";
            Text = "RSBSAImportExcelView";
            ((System.ComponentModel.ISupportInitialize)dgvRSBSAtoImport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnSelect;
        private Button btnSave;
        private Button btnCancel;
        private DataGridView dgvRSBSAtoImport;
        private TextBox txtSheetName;
        private Label label1;
        private ProgressBar progressBar1;
        private Label labelProgress;
    }
}