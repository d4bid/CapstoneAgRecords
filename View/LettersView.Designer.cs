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
            btnAdd = new Button();
            panel1 = new Panel();
            dgvLetters = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLetters).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(43, 121, 223);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(988, 27);
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
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(1139, 90);
            panel1.TabIndex = 21;
            // 
            // dgvLetters
            // 
            dgvLetters.AllowUserToAddRows = false;
            dgvLetters.AllowUserToDeleteRows = false;
            dgvLetters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLetters.Dock = DockStyle.Bottom;
            dgvLetters.Location = new Point(0, 96);
            dgvLetters.Name = "dgvLetters";
            dgvLetters.ReadOnly = true;
            dgvLetters.RowHeadersWidth = 51;
            dgvLetters.RowTemplate.Height = 29;
            dgvLetters.Size = new Size(1139, 523);
            dgvLetters.TabIndex = 22;
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
            ((System.ComponentModel.ISupportInitialize)dgvLetters).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Panel panel1;
        private DataGridView dgvLetters;
    }
}