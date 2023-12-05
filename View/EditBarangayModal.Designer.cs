namespace AgRecords.View
{
    partial class EditBarangayModal
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
            btnSave = new Button();
            btnCancel = new Button();
            panel2 = new Panel();
            comboBoxStatus = new ComboBox();
            label1 = new Label();
            txtBarangay = new TextBox();
            rectangleBlue1 = new RectangleBlue();
            lblBrgyId = new Label();
            lblUsername = new Label();
            lblBrgyType = new Label();
            rectangleBlue2 = new RectangleBlue();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(43, 224);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 34);
            btnSave.TabIndex = 56;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(221, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 34);
            btnCancel.TabIndex = 55;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBoxStatus);
            panel2.Controls.Add(rectangleBlue2);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtBarangay);
            panel2.Controls.Add(rectangleBlue1);
            panel2.Controls.Add(lblBrgyId);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(lblBrgyType);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 318);
            panel2.TabIndex = 104;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FlatStyle = FlatStyle.Flat;
            comboBoxStatus.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Enabled", "Disabled" });
            comboBoxStatus.Location = new Point(53, 168);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(328, 33);
            comboBoxStatus.TabIndex = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 121, 223);
            label1.Location = new Point(43, 142);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 110;
            label1.Text = "Status";
            // 
            // txtBarangay
            // 
            txtBarangay.BackColor = Color.White;
            txtBarangay.BorderStyle = BorderStyle.None;
            txtBarangay.Font = new Font("Segoe UI", 11.7F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarangay.Location = new Point(50, 95);
            txtBarangay.Margin = new Padding(5, 3, 3, 3);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.Size = new Size(333, 26);
            txtBarangay.TabIndex = 104;
            // 
            // rectangleBlue1
            // 
            rectangleBlue1.Location = new Point(43, 90);
            rectangleBlue1.Name = "rectangleBlue1";
            rectangleBlue1.Size = new Size(344, 38);
            rectangleBlue1.TabIndex = 106;
            // 
            // lblBrgyId
            // 
            lblBrgyId.AutoSize = true;
            lblBrgyId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrgyId.ForeColor = Color.FromArgb(43, 121, 223);
            lblBrgyId.Location = new Point(132, 62);
            lblBrgyId.Name = "lblBrgyId";
            lblBrgyId.Size = new Size(19, 23);
            lblBrgyId.TabIndex = 107;
            lblBrgyId.Text = "0";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(43, 121, 223);
            lblUsername.Location = new Point(42, 62);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 23);
            lblUsername.TabIndex = 105;
            lblUsername.Text = "Barangay #";
            // 
            // lblBrgyType
            // 
            lblBrgyType.AutoSize = true;
            lblBrgyType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrgyType.ForeColor = Color.FromArgb(43, 121, 223);
            lblBrgyType.Location = new Point(217, 38);
            lblBrgyType.Name = "lblBrgyType";
            lblBrgyType.Size = new Size(81, 23);
            lblBrgyType.TabIndex = 111;
            lblBrgyType.Text = "brgyType";
            lblBrgyType.Visible = false;
            // 
            // rectangleBlue2
            // 
            rectangleBlue2.Location = new Point(43, 165);
            rectangleBlue2.Name = "rectangleBlue2";
            rectangleBlue2.Size = new Size(344, 39);
            rectangleBlue2.TabIndex = 112;
            // 
            // EditBarangayModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(427, 318);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditBarangayModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Data";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Panel panel2;
        private ComboBox comboBoxStatus;
        private RectangleBlue rectangleBlue2;
        private Label label1;
        private TextBox txtBarangay;
        private RectangleBlue rectangleBlue1;
        private Label lblBrgyId;
        private Label lblUsername;
        private Label lblBrgyType;
    }
}