namespace AgRecords.View
{
    partial class WeeklyActivitiesView
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
            btnPrint = new FontAwesome.Sharp.IconButton();
            cmbColumn = new ComboBox();
            searchBox2 = new SearchBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtBoxSearch = new TextBox();
            searchBox1 = new SearchBox();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            dgvActivities = new DataGridView();
            panel4 = new Panel();
            panel5 = new Panel();
            label9 = new Label();
            weekGraph2 = new OxyPlot.WindowsForms.PlotView();
            panel6 = new Panel();
            panel7 = new Panel();
            label2 = new Label();
            weekGraph1 = new OxyPlot.WindowsForms.PlotView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivities).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(cmbColumn);
            panel1.Controls.Add(searchBox2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(txtBoxSearch);
            panel1.Controls.Add(searchBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(1595, 90);
            panel1.TabIndex = 25;
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
            btnPrint.Location = new Point(1424, 32);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(148, 40);
            btnPrint.TabIndex = 53;
            btnPrint.Text = "Print";
            btnPrint.TextAlign = ContentAlignment.MiddleRight;
            btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // cmbColumn
            // 
            cmbColumn.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColumn.FlatStyle = FlatStyle.Flat;
            cmbColumn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbColumn.FormattingEnabled = true;
            cmbColumn.Items.AddRange(new object[] { "All", "ID", "Month", "Week", "Year", "Created By", "Date" });
            cmbColumn.Location = new Point(391, 38);
            cmbColumn.Name = "cmbColumn";
            cmbColumn.Size = new Size(237, 28);
            cmbColumn.TabIndex = 9;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(386, 33);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(246, 39);
            searchBox2.TabIndex = 15;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.GrayText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = SystemColors.GrayText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(21, 41);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 12;
            iconPictureBox1.TabStop = false;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.BorderStyle = BorderStyle.None;
            txtBoxSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxSearch.Location = new Point(48, 38);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.PlaceholderText = "Search";
            txtBoxSearch.Size = new Size(297, 24);
            txtBoxSearch.TabIndex = 10;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(13, 34);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(343, 39);
            searchBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 10);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 13;
            label1.Text = "Filter";
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
            panel2.Controls.Add(dgvActivities);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(886, 826);
            panel2.TabIndex = 28;
            // 
            // dgvActivities
            // 
            dgvActivities.AllowUserToAddRows = false;
            dgvActivities.AllowUserToDeleteRows = false;
            dgvActivities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivities.BackgroundColor = Color.White;
            dgvActivities.BorderStyle = BorderStyle.None;
            dgvActivities.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvActivities.DefaultCellStyle = dataGridViewCellStyle4;
            dgvActivities.Dock = DockStyle.Fill;
            dgvActivities.GridColor = Color.FromArgb(239, 239, 239);
            dgvActivities.Location = new Point(10, 10);
            dgvActivities.Name = "dgvActivities";
            dgvActivities.ReadOnly = true;
            dgvActivities.RowHeadersVisible = false;
            dgvActivities.RowHeadersWidth = 51;
            dgvActivities.RowTemplate.Height = 40;
            dgvActivities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivities.Size = new Size(866, 806);
            dgvActivities.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(239, 239, 239);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(886, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 826);
            panel4.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(weekGraph2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(896, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(699, 380);
            panel5.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 35, 76);
            label9.Location = new Point(20, 14);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 47;
            label9.Text = "Daily Progress";
            // 
            // weekGraph2
            // 
            weekGraph2.BackColor = Color.White;
            weekGraph2.Location = new Point(29, 50);
            weekGraph2.Name = "weekGraph2";
            weekGraph2.PanCursor = Cursors.Hand;
            weekGraph2.Size = new Size(640, 313);
            weekGraph2.TabIndex = 46;
            weekGraph2.ZoomHorizontalCursor = Cursors.SizeWE;
            weekGraph2.ZoomRectangleCursor = Cursors.SizeNWSE;
            weekGraph2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(239, 239, 239);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(896, 480);
            panel6.Name = "panel6";
            panel6.Size = new Size(699, 10);
            panel6.TabIndex = 31;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label2);
            panel7.Controls.Add(weekGraph1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(896, 490);
            panel7.Name = "panel7";
            panel7.Size = new Size(699, 436);
            panel7.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 35, 76);
            label2.Location = new Point(20, 16);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 48;
            label2.Text = "Activities";
            // 
            // weekGraph1
            // 
            weekGraph1.BackColor = Color.White;
            weekGraph1.Location = new Point(29, 48);
            weekGraph1.Name = "weekGraph1";
            weekGraph1.PanCursor = Cursors.Hand;
            weekGraph1.Size = new Size(647, 363);
            weekGraph1.TabIndex = 45;
            weekGraph1.ZoomHorizontalCursor = Cursors.SizeWE;
            weekGraph1.ZoomRectangleCursor = Cursors.SizeNWSE;
            weekGraph1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // WeeklyActivitiesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "WeeklyActivitiesView";
            Text = "WeeklyActivitiesView";
            Load += WeeklyActivitiesView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActivities).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbColumn;
        private SearchBox searchBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtBoxSearch;
        private SearchBox searchBox1;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvActivities;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private OxyPlot.WindowsForms.PlotView weekGraph2;
        private OxyPlot.WindowsForms.PlotView weekGraph1;
        private Label label9;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnPrint;
    }
}