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
            txtBoxConfirmPassword = new TextBox();
            txtBoxPassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            lblPasswordStrength = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // txtBoxConfirmPassword
            // 
            txtBoxConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxConfirmPassword.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxConfirmPassword.Location = new Point(33, 197);
            txtBoxConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            txtBoxConfirmPassword.Size = new Size(378, 29);
            txtBoxConfirmPassword.TabIndex = 25;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPassword.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(33, 58);
            txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(378, 29);
            txtBoxPassword.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(29, 32);
            label8.Name = "label8";
            label8.Size = new Size(130, 22);
            label8.TabIndex = 23;
            label8.Text = "New Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 171);
            label7.Name = "label7";
            label7.Size = new Size(157, 22);
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
            btnCancel.Location = new Point(281, 305);
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
            btnSave.Location = new Point(145, 305);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblPasswordStrength
            // 
            lblPasswordStrength.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPasswordStrength.AutoSize = true;
            lblPasswordStrength.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordStrength.ForeColor = Color.FromArgb(207, 92, 96);
            lblPasswordStrength.Location = new Point(33, 96);
            lblPasswordStrength.Name = "lblPasswordStrength";
            lblPasswordStrength.Size = new Size(378, 40);
            lblPasswordStrength.TabIndex = 29;
            lblPasswordStrength.Text = "Password must be 8-16 characters with at least one uppercase \nletter, lowercase letter, number, and special character.";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(207, 92, 96);
            label11.Location = new Point(33, 241);
            label11.Name = "label11";
            label11.Size = new Size(157, 20);
            label11.TabIndex = 31;
            label11.Text = "Passwords do not match.";
            // 
            // UserPasswordView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(441, 371);
            Controls.Add(label11);
            Controls.Add(lblPasswordStrength);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBoxConfirmPassword);
            Controls.Add(txtBoxPassword);
            Controls.Add(label8);
            Controls.Add(label7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserPasswordView";
            Text = "UserPasswordView";
            Load += UserPasswordView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxConfirmPassword;
        private TextBox txtBoxPassword;
        private Label label8;
        private Label label7;
        private Button btnCancel;
        private Button btnSave;
        private Label lblPasswordStrength;
        private Label label11;
    }
}