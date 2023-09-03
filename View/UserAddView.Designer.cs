namespace AgRecords.View
{
    partial class UserAddView
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
            openFileDialog1 = new OpenFileDialog();
            picBoxUser = new PictureBox();
            groupBox3 = new GroupBox();
            lblPasswordStrength = new Label();
            txtBoxPassword = new TextBox();
            txtBoxUsername = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtBoxUserId = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtBoxContact = new TextBox();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            comboBoxRole = new ComboBox();
            comboBoxStatus = new ComboBox();
            comboBoxGender = new ComboBox();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBrowse = new Button();
            btnCancel = new Button();
            groupBox2 = new GroupBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // picBoxUser
            // 
            picBoxUser.BorderStyle = BorderStyle.FixedSingle;
            picBoxUser.Location = new Point(7, 31);
            picBoxUser.Margin = new Padding(3, 4, 3, 4);
            picBoxUser.Name = "picBoxUser";
            picBoxUser.Size = new Size(150, 150);
            picBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxUser.TabIndex = 0;
            picBoxUser.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lblPasswordStrength);
            groupBox3.Controls.Add(txtBoxPassword);
            groupBox3.Controls.Add(txtBoxUsername);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtBoxUserId);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 286);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(515, 273);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account Information";
            // 
            // lblPasswordStrength
            // 
            lblPasswordStrength.AutoSize = true;
            lblPasswordStrength.Font = new Font("Roboto Condensed Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordStrength.Location = new Point(109, 184);
            lblPasswordStrength.Name = "lblPasswordStrength";
            lblPasswordStrength.Size = new Size(263, 18);
            lblPasswordStrength.TabIndex = 27;
            lblPasswordStrength.Text = "Password must be 8-16 characters with at least one";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = Color.FromArgb(239, 239, 239);
            txtBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPassword.Location = new Point(109, 149);
            txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(305, 30);
            txtBoxPassword.TabIndex = 26;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.BackColor = Color.FromArgb(239, 239, 239);
            txtBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUsername.Location = new Point(109, 101);
            txtBoxUsername.Margin = new Padding(3, 4, 3, 4);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(305, 30);
            txtBoxUsername.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 109);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 24;
            label8.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 152);
            label7.Name = "label7";
            label7.Size = new Size(73, 23);
            label7.TabIndex = 23;
            label7.Text = "Password";
            // 
            // txtBoxUserId
            // 
            txtBoxUserId.BackColor = Color.FromArgb(239, 239, 239);
            txtBoxUserId.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUserId.Location = new Point(109, 40);
            txtBoxUserId.Margin = new Padding(3, 4, 3, 4);
            txtBoxUserId.Name = "txtBoxUserId";
            txtBoxUserId.ReadOnly = true;
            txtBoxUserId.Size = new Size(305, 30);
            txtBoxUserId.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 43);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 21;
            label6.Text = "UserID";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtBoxContact);
            groupBox1.Controls.Add(txtBoxLastName);
            groupBox1.Controls.Add(txtBoxFirstName);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.Controls.Add(comboBoxGender);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(picBoxUser);
            groupBox1.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1115, 253);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // txtBoxContact
            // 
            txtBoxContact.BackColor = Color.FromArgb(239, 239, 239);
            txtBoxContact.BorderStyle = BorderStyle.FixedSingle;
            txtBoxContact.Location = new Point(272, 193);
            txtBoxContact.Margin = new Padding(3, 4, 3, 4);
            txtBoxContact.Name = "txtBoxContact";
            txtBoxContact.Size = new Size(305, 30);
            txtBoxContact.TabIndex = 19;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.FromArgb(239, 239, 239);
            txtBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLastName.Location = new Point(272, 75);
            txtBoxLastName.Margin = new Padding(3, 4, 3, 4);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(305, 30);
            txtBoxLastName.TabIndex = 16;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.White;
            txtBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFirstName.Location = new Point(272, 35);
            txtBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(305, 30);
            txtBoxFirstName.TabIndex = 15;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = Color.FromArgb(239, 239, 239);
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(753, 73);
            comboBoxRole.Margin = new Padding(3, 4, 3, 4);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(305, 31);
            comboBoxRole.TabIndex = 14;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.FromArgb(239, 239, 239);
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBoxStatus.Location = new Point(753, 34);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(305, 31);
            comboBoxStatus.TabIndex = 13;
            // 
            // comboBoxGender
            // 
            comboBoxGender.BackColor = Color.FromArgb(239, 239, 239);
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(272, 140);
            comboBoxGender.Margin = new Padding(3, 4, 3, 4);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(305, 31);
            comboBoxGender.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(690, 77);
            label9.Name = "label9";
            label9.Size = new Size(40, 23);
            label9.TabIndex = 11;
            label9.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 143);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 6;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 196);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 5;
            label4.Text = "Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(690, 40);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 4;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 77);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 38);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(43, 121, 223);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(7, 189);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 39);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(43, 121, 223);
            btnCancel.Location = new Point(997, 567);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(547, 286);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(580, 273);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Permissions";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(861, 567);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // UserAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 619);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(groupBox2);
            Controls.Add(btnSave);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserAddView";
            Text = "UserAddView";
            Load += UserAddView_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxUser).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private PictureBox picBoxUser;
        private GroupBox groupBox3;
        private Label lblPasswordStrength;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUsername;
        private Label label8;
        private Label label7;
        private TextBox txtBoxUserId;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox txtBoxContact;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxGender;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBrowse;
        private Button btnCancel;
        private GroupBox groupBox2;
        private Button btnSave;
    }
}