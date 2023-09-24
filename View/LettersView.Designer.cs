namespace AgRecords.View
{
    partial class LettersView
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
            btnAdd = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            dgvLetters = new DataGridView();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLetters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(43, 121, 223);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(987, 27);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 39);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(1139, 91);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(22, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 30);
            panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(27, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(314, 22);
            textBox1.TabIndex = 0;
            // 
            // dgvLetters
            // 
            dgvLetters.AllowUserToAddRows = false;
            dgvLetters.AllowUserToDeleteRows = false;
            dgvLetters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLetters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLetters.BackgroundColor = Color.White;
            dgvLetters.BorderStyle = BorderStyle.None;
            dgvLetters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 121, 223);
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLetters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLetters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 221, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 35, 76);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLetters.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLetters.GridColor = Color.FromArgb(239, 239, 239);
            dgvLetters.Location = new Point(0, 97);
            dgvLetters.Name = "dgvLetters";
            dgvLetters.ReadOnly = true;
            dgvLetters.RowHeadersVisible = false;
            dgvLetters.RowHeadersWidth = 51;
            dgvLetters.RowTemplate.Height = 40;
            dgvLetters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLetters.Size = new Size(1139, 520);
            dgvLetters.TabIndex = 22;
            dgvLetters.CellDoubleClick += dgvLetters_CellDoubleClick;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 20;
            iconPictureBox1.Location = new Point(3, 7);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // LettersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1139, 619);
            Controls.Add(dgvLetters);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LettersView";
            Text = "LettersView";
            Load += LettersView_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLetters).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Panel panel1;
        private DataGridView dgvLetters;
        private Panel panel2;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}