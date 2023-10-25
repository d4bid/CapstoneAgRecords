namespace AgRecords.View
{
    partial class RsbsaView
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
            btnImport = new Button();
            btnAdd = new Button();
            dgvRsbsa = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRsbsa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(1595, 91);
            panel1.TabIndex = 20;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.BackColor = Color.FromArgb(43, 121, 223);
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnImport.ForeColor = Color.White;
            btnImport.Location = new Point(1244, 27);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(177, 39);
            btnImport.TabIndex = 4;
            btnImport.Text = "Import Excel File";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(43, 121, 223);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1443, 27);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 39);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvRsbsa
            // 
            dgvRsbsa.AllowUserToAddRows = false;
            dgvRsbsa.AllowUserToDeleteRows = false;
            dgvRsbsa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRsbsa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRsbsa.BackgroundColor = Color.White;
            dgvRsbsa.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(42, 148, 214);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(52, 74, 95);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRsbsa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvRsbsa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(240, 241, 242);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(52, 74, 95);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(78, 177, 203);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(52, 74, 95);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRsbsa.DefaultCellStyle = dataGridViewCellStyle6;
            dgvRsbsa.Location = new Point(0, 99);
            dgvRsbsa.Name = "dgvRsbsa";
            dgvRsbsa.ReadOnly = true;
            dgvRsbsa.RowHeadersVisible = false;
            dgvRsbsa.RowHeadersWidth = 51;
            dgvRsbsa.RowTemplate.Height = 25;
            dgvRsbsa.Size = new Size(1595, 827);
            dgvRsbsa.TabIndex = 19;
            dgvRsbsa.CellDoubleClick += dgvRsbsa_CellDoubleClick;
            // 
            // RsbsaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1595, 926);
            Controls.Add(dgvRsbsa);
            Controls.Add(panel1);
            Name = "RsbsaView";
            Text = "RsbsaView";
            Load += RsbsaView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRsbsa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvRsbsa;
        private Button btnAdd;
        private Button btnImport;
    }
}