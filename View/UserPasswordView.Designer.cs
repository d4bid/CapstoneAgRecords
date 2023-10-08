namespace AgRecords.View
{
    partial class UserPasswordView
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
            label8 = new Label();
            label7 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtBoxPassword = new TextBox();
            rectangleRound9 = new RectangleRound();
            txtBoxConfirmPassword = new TextBox();
            rectangleRound10 = new RectangleRound();
            lblConfirmPassword = new Label();
            lblPasswordStrength = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(29, 35);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 23;
            label8.Text = "New Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 147);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 22;
            label7.Text = "Confirm Password";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(43, 121, 223);
            btnCancel.Location = new Point(303, 286);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(167, 286);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = Color.White;
            txtBoxPassword.BorderStyle = BorderStyle.None;
            txtBoxPassword.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(38, 63);
            txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(395, 26);
            txtBoxPassword.TabIndex = 36;
            txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // rectangleRound9
            // 
            rectangleRound9.BackColor = Color.White;
            rectangleRound9.Location = new Point(29, 58);
            rectangleRound9.Name = "rectangleRound9";
            rectangleRound9.Size = new Size(414, 38);
            rectangleRound9.TabIndex = 37;
            // 
            // txtBoxConfirmPassword
            // 
            txtBoxConfirmPassword.BackColor = Color.White;
            txtBoxConfirmPassword.BorderStyle = BorderStyle.None;
            txtBoxConfirmPassword.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxConfirmPassword.Location = new Point(38, 176);
            txtBoxConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            txtBoxConfirmPassword.Size = new Size(395, 26);
            txtBoxConfirmPassword.TabIndex = 38;
            txtBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // rectangleRound10
            // 
            rectangleRound10.BackColor = Color.White;
            rectangleRound10.Location = new Point(29, 170);
            rectangleRound10.Name = "rectangleRound10";
            rectangleRound10.Size = new Size(414, 38);
            rectangleRound10.TabIndex = 39;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmPassword.ForeColor = Color.FromArgb(207, 92, 96);
            lblConfirmPassword.Location = new Point(29, 211);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(162, 17);
            lblConfirmPassword.TabIndex = 41;
            lblConfirmPassword.Text = "Passwords do not match.";
            // 
            // lblPasswordStrength
            // 
            lblPasswordStrength.AutoSize = true;
            lblPasswordStrength.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordStrength.ForeColor = Color.FromArgb(207, 92, 96);
            lblPasswordStrength.Location = new Point(29, 99);
            lblPasswordStrength.Name = "lblPasswordStrength";
            lblPasswordStrength.Size = new Size(389, 34);
            lblPasswordStrength.TabIndex = 40;
            lblPasswordStrength.Text = "Password must be 8-16 characters with at least one uppercase \nletter, lowercase letter, number, and special character.";
            // 
            // UserPasswordView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(463, 350);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPasswordStrength);
            Controls.Add(txtBoxConfirmPassword);
            Controls.Add(rectangleRound10);
            Controls.Add(txtBoxPassword);
            Controls.Add(rectangleRound9);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(label7);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserPasswordView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password";
            Load += UserPasswordView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Label label7;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtBoxPassword;
        private RectangleRound rectangleRound9;
        private TextBox txtBoxConfirmPassword;
        private RectangleRound rectangleRound10;
        private Label lblConfirmPassword;
        private Label lblPasswordStrength;
    }
}