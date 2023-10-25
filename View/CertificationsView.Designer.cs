namespace AgRecords.View
{
    partial class CertificationsView
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
            dgvCert = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCert).BeginInit();
            SuspendLayout();
            // 
            // dgvCert
            // 
            dgvCert.AllowUserToAddRows = false;
            dgvCert.AllowUserToDeleteRows = false;
            dgvCert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCert.BackgroundColor = Color.White;
            dgvCert.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 148, 214);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 74, 95);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 241, 242);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(52, 74, 95);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(78, 177, 203);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(52, 74, 95);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCert.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCert.Location = new Point(0, 49);
            dgvCert.Name = "dgvCert";
            dgvCert.ReadOnly = true;
            dgvCert.RowHeadersVisible = false;
            dgvCert.RowHeadersWidth = 51;
            dgvCert.RowTemplate.Height = 25;
            dgvCert.Size = new Size(1139, 520);
            dgvCert.TabIndex = 20;
            // 
            // CertificationsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 619);
            Controls.Add(dgvCert);
            Name = "CertificationsView";
            Text = "CertificationsView";
            Load += CertificationsView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCert).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCert;
    }
}