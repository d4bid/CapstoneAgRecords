namespace AgRecords.View
{
    partial class RestoreBackupPasswordView
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
            txtPassword = new TextBox();
            rectangleBlue1 = new RectangleBlue();
            lblUsername = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(41, 62);
            txtPassword.Margin = new Padding(5, 3, 3, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter admin password";
            txtPassword.Size = new Size(333, 25);
            txtPassword.TabIndex = 47;
            // 
            // rectangleBlue1
            // 
            rectangleBlue1.Location = new Point(34, 56);
            rectangleBlue1.Name = "rectangleBlue1";
            rectangleBlue1.Size = new Size(344, 38);
            rectangleBlue1.TabIndex = 49;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(43, 121, 223);
            lblUsername.Location = new Point(34, 28);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(82, 23);
            lblUsername.TabIndex = 48;
            lblUsername.Text = "Password";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(34, 116);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 34);
            btnSave.TabIndex = 51;
            btnSave.Text = "Restore";
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
            btnCancel.Location = new Point(212, 116);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 34);
            btnCancel.TabIndex = 50;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(rectangleBlue1);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 176);
            panel2.TabIndex = 52;
            // 
            // RestoreBackupPasswordView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(419, 176);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RestoreBackupPasswordView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Restore Database";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPassword;
        private RectangleBlue rectangleBlue1;
        private Label lblUsername;
        private Button btnSave;
        private Button btnCancel;
        private Panel panel2;
    }
}