namespace AgRecords.View
{
    partial class UserEditView
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
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            txtBoxUserId = new TextBox();
            txtBoxContact = new TextBox();
            txtBoxPassword = new TextBox();
            txtBoxUsername = new TextBox();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            comboBoxRole = new ComboBox();
            comboBoxStatus = new ComboBox();
            comboBoxGender = new ComboBox();
            label9 = new Label();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBrowse = new Button();
            picBoxUser = new PictureBox();
            btnCancel = new Button();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnChangePassword = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 181);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Permissions";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChangePassword);
            groupBox1.Controls.Add(txtBoxUserId);
            groupBox1.Controls.Add(txtBoxContact);
            groupBox1.Controls.Add(txtBoxPassword);
            groupBox1.Controls.Add(txtBoxUsername);
            groupBox1.Controls.Add(txtBoxLastName);
            groupBox1.Controls.Add(txtBoxFirstName);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.Controls.Add(comboBoxGender);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(picBoxUser);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 181);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // txtBoxUserId
            // 
            txtBoxUserId.Location = new Point(567, 14);
            txtBoxUserId.Name = "txtBoxUserId";
            txtBoxUserId.ReadOnly = true;
            txtBoxUserId.Size = new Size(121, 23);
            txtBoxUserId.TabIndex = 20;
            // 
            // txtBoxContact
            // 
            txtBoxContact.Location = new Point(461, 75);
            txtBoxContact.Name = "txtBoxContact";
            txtBoxContact.Size = new Size(121, 23);
            txtBoxContact.TabIndex = 19;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(204, 127);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(100, 23);
            txtBoxPassword.TabIndex = 18;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(204, 91);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.ReadOnly = true;
            txtBoxUsername.Size = new Size(100, 23);
            txtBoxUsername.TabIndex = 17;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(204, 49);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(100, 23);
            txtBoxLastName.TabIndex = 16;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(204, 19);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(100, 23);
            txtBoxFirstName.TabIndex = 15;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(461, 133);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(121, 23);
            comboBoxRole.TabIndex = 14;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBoxStatus.Location = new Point(461, 104);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 13;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(461, 45);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(121, 23);
            comboBoxGender.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(410, 135);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 11;
            label9.Text = "Role";
            // 
            // button1
            // 
            button1.Location = new Point(505, 55);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(134, 99);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 9;
            label8.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(134, 131);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 8;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(410, 19);
            label6.Name = "label6";
            label6.Size = new Size(151, 15);
            label6.TabIndex = 7;
            label6.Text = "UserID (decide, hide or not)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 48);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 80);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 5;
            label4.Text = "Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 107);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 51);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(6, 131);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 29);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // picBoxUser
            // 
            picBoxUser.BorderStyle = BorderStyle.FixedSingle;
            picBoxUser.Location = new Point(6, 22);
            picBoxUser.Name = "picBoxUser";
            picBoxUser.Size = new Size(112, 103);
            picBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxUser.TabIndex = 0;
            picBoxUser.TabStop = false;
            picBoxUser.Click += picBoxUser_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(667, 391);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 47);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(540, 391);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 47);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(632, 67);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(121, 47);
            btnChangePassword.TabIndex = 21;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // UserEditView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "UserEditView";
            Text = "UserEditView";
            Load += UserEditView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtBoxUserId;
        private TextBox txtBoxContact;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUsername;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxGender;
        private Label label9;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBrowse;
        private PictureBox picBoxUser;
        private Button btnCancel;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
        private Button btnChangePassword;
    }
}