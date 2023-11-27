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
            txtBarangay = new TextBox();
            rectangleBlue1 = new RectangleBlue();
            lblUsername = new Label();
            lblBrgyId = new Label();
            comboBoxStatus = new ComboBox();
            searchBox4 = new SearchBox();
            label1 = new Label();
            lblBrgyType = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(39, 224);
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
            btnCancel.Location = new Point(217, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 34);
            btnCancel.TabIndex = 55;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtBarangay
            // 
            txtBarangay.BorderStyle = BorderStyle.None;
            txtBarangay.Font = new Font("Segoe UI", 11.7F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarangay.Location = new Point(50, 84);
            txtBarangay.Margin = new Padding(5, 3, 3, 3);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.Size = new Size(333, 26);
            txtBarangay.TabIndex = 52;
            // 
            // rectangleBlue1
            // 
            rectangleBlue1.Location = new Point(43, 79);
            rectangleBlue1.Name = "rectangleBlue1";
            rectangleBlue1.Size = new Size(344, 38);
            rectangleBlue1.TabIndex = 54;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(43, 121, 223);
            lblUsername.Location = new Point(42, 51);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 23);
            lblUsername.TabIndex = 53;
            lblUsername.Text = "Barangay #";
            // 
            // lblBrgyId
            // 
            lblBrgyId.AutoSize = true;
            lblBrgyId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrgyId.ForeColor = Color.FromArgb(43, 121, 223);
            lblBrgyId.Location = new Point(132, 51);
            lblBrgyId.Name = "lblBrgyId";
            lblBrgyId.Size = new Size(19, 23);
            lblBrgyId.TabIndex = 57;
            lblBrgyId.Text = "0";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FlatStyle = FlatStyle.Flat;
            comboBoxStatus.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Enabled", "Disabled" });
            comboBoxStatus.Location = new Point(49, 157);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(323, 33);
            comboBoxStatus.TabIndex = 99;
            // 
            // searchBox4
            // 
            searchBox4.Location = new Point(43, 154);
            searchBox4.Name = "searchBox4";
            searchBox4.Size = new Size(340, 39);
            searchBox4.TabIndex = 101;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 121, 223);
            label1.Location = new Point(43, 131);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 102;
            label1.Text = "Status";
            // 
            // lblBrgyType
            // 
            lblBrgyType.AutoSize = true;
            lblBrgyType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrgyType.ForeColor = Color.FromArgb(43, 121, 223);
            lblBrgyType.Location = new Point(217, 27);
            lblBrgyType.Name = "lblBrgyType";
            lblBrgyType.Size = new Size(81, 23);
            lblBrgyType.TabIndex = 103;
            lblBrgyType.Text = "brgyType";
            lblBrgyType.Visible = false;
            // 
            // EditBarangayModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 318);
            Controls.Add(lblBrgyType);
            Controls.Add(label1);
            Controls.Add(comboBoxStatus);
            Controls.Add(searchBox4);
            Controls.Add(lblBrgyId);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtBarangay);
            Controls.Add(rectangleBlue1);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditBarangayModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditBarangayModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtBarangay;
        private RectangleBlue rectangleBlue1;
        private Label lblUsername;
        private Label lblBrgyId;
        private ComboBox comboBoxStatus;
        private SearchBox searchBox4;
        private Label label1;
        private Label lblBrgyType;
    }
}