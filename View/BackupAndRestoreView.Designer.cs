namespace AgRecords.View
{
    partial class BackupAndRestoreView
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            btnRestore = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            btnBackup = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            dgvLogs = new DataGridView();
            panel7 = new Panel();
            label7 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 239, 239);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1595, 354);
            panel1.TabIndex = 88;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(iconPictureBox2);
            panel4.Controls.Add(btnRestore);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(845, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(750, 354);
            panel4.TabIndex = 91;
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.None;
            btnRestore.FlatAppearance.BorderColor = Color.FromArgb(3, 0, 67);
            btnRestore.FlatAppearance.BorderSize = 2;
            btnRestore.FlatAppearance.MouseDownBackColor = Color.White;
            btnRestore.FlatAppearance.MouseOverBackColor = Color.White;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestore.ForeColor = Color.FromArgb(3, 0, 67);
            btnRestore.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRestore.IconColor = Color.FromArgb(3, 0, 67);
            btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRestore.IconSize = 30;
            btnRestore.Location = new Point(311, 253);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(169, 49);
            btnRestore.TabIndex = 59;
            btnRestore.Text = "Restore";
            btnRestore.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 35, 76);
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 58;
            label2.Text = "Restore";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(239, 239, 239);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(835, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(10, 354);
            panel3.TabIndex = 90;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(btnBackup);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(835, 354);
            panel2.TabIndex = 89;
            // 
            // btnBackup
            // 
            btnBackup.Anchor = AnchorStyles.None;
            btnBackup.FlatAppearance.BorderColor = Color.FromArgb(3, 0, 67);
            btnBackup.FlatAppearance.BorderSize = 2;
            btnBackup.FlatAppearance.MouseDownBackColor = Color.White;
            btnBackup.FlatAppearance.MouseOverBackColor = Color.White;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackup.ForeColor = Color.FromArgb(3, 0, 67);
            btnBackup.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBackup.IconColor = Color.FromArgb(3, 0, 67);
            btnBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBackup.IconSize = 30;
            btnBackup.Location = new Point(320, 253);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(169, 49);
            btnBackup.TabIndex = 58;
            btnBackup.Text = "Backup";
            btnBackup.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 35, 76);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 57;
            label1.Text = "Backup";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(239, 239, 239);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 354);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 10, 0, 0);
            panel5.Size = new Size(1595, 572);
            panel5.TabIndex = 90;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgvLogs);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 10);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10);
            panel6.Size = new Size(1595, 562);
            panel6.TabIndex = 91;
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.AllowUserToResizeColumns = false;
            dgvLogs.AllowUserToResizeRows = false;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = Color.White;
            dgvLogs.BorderStyle = BorderStyle.None;
            dgvLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvLogs.DefaultCellStyle = dataGridViewCellStyle6;
            dgvLogs.Dock = DockStyle.Fill;
            dgvLogs.GridColor = Color.FromArgb(239, 239, 239);
            dgvLogs.Location = new Point(10, 59);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersVisible = false;
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.RowTemplate.Height = 25;
            dgvLogs.ScrollBars = ScrollBars.Vertical;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(1575, 493);
            dgvLogs.TabIndex = 93;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label7);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(10, 10);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10);
            panel7.Size = new Size(1575, 49);
            panel7.TabIndex = 92;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 35, 76);
            label7.Location = new Point(13, 15);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 56;
            label7.Text = "Logs";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            iconPictureBox1.ForeColor = Color.FromArgb(43, 121, 223);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Upload;
            iconPictureBox1.IconColor = Color.FromArgb(43, 121, 223);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 169;
            iconPictureBox1.Location = new Point(320, 64);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(169, 169);
            iconPictureBox1.TabIndex = 59;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            iconPictureBox2.ForeColor = Color.FromArgb(43, 121, 223);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Download;
            iconPictureBox2.IconColor = Color.FromArgb(43, 121, 223);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 169;
            iconPictureBox2.Location = new Point(311, 64);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(169, 169);
            iconPictureBox2.TabIndex = 60;
            iconPictureBox2.TabStop = false;
            // 
            // BackupAndRestoreView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1595, 926);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "BackupAndRestoreView";
            Text = "BackupAndRestoreView";
            Load += BackupAndRestoreView_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private DataGridView dgvLogs;
        private Label label7;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBackup;
        private FontAwesome.Sharp.IconButton btnRestore;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}