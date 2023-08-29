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
            lblPasswordStrength = new Label();
            txtBoxConfirmPassword = new TextBox();
            txtBoxPassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblPasswordStrength
            // 
            lblPasswordStrength.AutoSize = true;
            lblPasswordStrength.Location = new Point(55, 73);
            lblPasswordStrength.Name = "lblPasswordStrength";
            lblPasswordStrength.Size = new Size(139, 15);
            lblPasswordStrength.TabIndex = 26;
            lblPasswordStrength.Text = "Password must contain...";
            // 
            // txtBoxConfirmPassword
            // 
            txtBoxConfirmPassword.Location = new Point(55, 127);
            txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            txtBoxConfirmPassword.Size = new Size(100, 23);
            txtBoxConfirmPassword.TabIndex = 25;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(55, 47);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(100, 23);
            txtBoxPassword.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 29);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 23;
            label8.Text = "New Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 109);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 22;
            label7.Text = "Confirm Password";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(182, 167);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 47);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(55, 167);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 47);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // UserPasswordView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 368);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPasswordStrength);
            Controls.Add(txtBoxConfirmPassword);
            Controls.Add(txtBoxPassword);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "UserPasswordView";
            Text = "UserPasswordView";
            Load += UserPasswordView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPasswordStrength;
        private TextBox txtBoxConfirmPassword;
        private TextBox txtBoxPassword;
        private Label label8;
        private Label label7;
        private Button btnCancel;
        private Button btnSave;
    }
}