namespace AgRecords.View
{
    partial class CropsCornView
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
            panel1 = new Panel();
            dgvCropsCorn = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCropsCorn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(1139, 90);
            panel1.TabIndex = 23;
            // 
            // dgvCropsCorn
            // 
            dgvCropsCorn.AllowUserToAddRows = false;
            dgvCropsCorn.AllowUserToDeleteRows = false;
            dgvCropsCorn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCropsCorn.BackgroundColor = Color.White;
            dgvCropsCorn.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 148, 214);
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 74, 95);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCropsCorn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCropsCorn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 241, 242);
            dataGridViewCellStyle2.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(52, 74, 95);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(78, 177, 203);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(52, 74, 95);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCropsCorn.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCropsCorn.Location = new Point(0, 96);
            dgvCropsCorn.Name = "dgvCropsCorn";
            dgvCropsCorn.ReadOnly = true;
            dgvCropsCorn.RowHeadersVisible = false;
            dgvCropsCorn.RowHeadersWidth = 51;
            dgvCropsCorn.RowTemplate.Height = 25;
            dgvCropsCorn.Size = new Size(1139, 520);
            dgvCropsCorn.TabIndex = 24;
            // 
            // CropsCornView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1139, 619);
            Controls.Add(dgvCropsCorn);
            Controls.Add(panel1);
            Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CropsCornView";
            Text = "CropsCornView";
            Load += CropsCornView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCropsCorn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvCropsCorn;
    }
}