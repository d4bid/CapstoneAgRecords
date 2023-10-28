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
            openFileDialog1 = new OpenFileDialog();
            btnChangePassword = new Button();
            btnSave = new Button();
            picBoxUser = new RoundedPictureBox();
            groupBox1 = new GroupBox();
            comboBoxRole = new ComboBox();
            comboBoxStatus = new ComboBox();
            rectangleRound6 = new RectangleRound();
            rectangleRound5 = new RectangleRound();
            txtBoxContact = new TextBox();
            rectangleRound4 = new RectangleRound();
            comboBoxGender = new ComboBox();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            rectangleRound3 = new RectangleRound();
            label11 = new Label();
            rectangleRound2 = new RectangleRound();
            rectangleRound1 = new RectangleRound();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtBoxUsername = new TextBox();
            rectangleRound8 = new RectangleRound();
            txtBoxUserId = new TextBox();
            rectangleRound7 = new RectangleRound();
            label12 = new Label();
            label8 = new Label();
            label6 = new Label();
            btnBack = new FontAwesome.Sharp.IconButton();
            btnBrowse = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangePassword.BackColor = Color.FromArgb(43, 121, 223);
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(384, 182);
            btnChangePassword.Margin = new Padding(3, 4, 3, 4);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(185, 40);
            btnChangePassword.TabIndex = 36;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1311, 442);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // picBoxUser
            // 
            picBoxUser.BackgroundImageLayout = ImageLayout.Zoom;
            picBoxUser.BorderStyle = BorderStyle.FixedSingle;
            picBoxUser.Image = Properties.Resources.profile;
            picBoxUser.Location = new Point(28, 41);
            picBoxUser.Name = "picBoxUser";
            picBoxUser.Size = new Size(300, 300);
            picBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxUser.TabIndex = 37;
            picBoxUser.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.Controls.Add(rectangleRound6);
            groupBox1.Controls.Add(rectangleRound5);
            groupBox1.Controls.Add(txtBoxContact);
            groupBox1.Controls.Add(rectangleRound4);
            groupBox1.Controls.Add(comboBoxGender);
            groupBox1.Controls.Add(txtBoxLastName);
            groupBox1.Controls.Add(txtBoxFirstName);
            groupBox1.Controls.Add(rectangleRound3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(rectangleRound2);
            groupBox1.Controls.Add(rectangleRound1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(385, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(575, 420);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = Color.White;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FlatStyle = FlatStyle.Flat;
            comboBoxRole.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(173, 361);
            comboBoxRole.Margin = new Padding(3, 4, 3, 4);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(371, 33);
            comboBoxRole.TabIndex = 14;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.White;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FlatStyle = FlatStyle.Flat;
            comboBoxStatus.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBoxStatus.Location = new Point(173, 316);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(371, 33);
            comboBoxStatus.TabIndex = 13;
            // 
            // rectangleRound6
            // 
            rectangleRound6.BackColor = Color.White;
            rectangleRound6.Location = new Point(164, 359);
            rectangleRound6.Name = "rectangleRound6";
            rectangleRound6.Size = new Size(385, 38);
            rectangleRound6.TabIndex = 26;
            // 
            // rectangleRound5
            // 
            rectangleRound5.BackColor = Color.White;
            rectangleRound5.Location = new Point(164, 314);
            rectangleRound5.Name = "rectangleRound5";
            rectangleRound5.Size = new Size(385, 38);
            rectangleRound5.TabIndex = 25;
            // 
            // txtBoxContact
            // 
            txtBoxContact.BackColor = Color.White;
            txtBoxContact.BorderStyle = BorderStyle.None;
            txtBoxContact.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxContact.Location = new Point(173, 248);
            txtBoxContact.Margin = new Padding(3, 4, 3, 4);
            txtBoxContact.Name = "txtBoxContact";
            txtBoxContact.Size = new Size(366, 26);
            txtBoxContact.TabIndex = 19;
            // 
            // rectangleRound4
            // 
            rectangleRound4.BackColor = Color.White;
            rectangleRound4.Location = new Point(164, 242);
            rectangleRound4.Name = "rectangleRound4";
            rectangleRound4.Size = new Size(385, 38);
            rectangleRound4.TabIndex = 24;
            // 
            // comboBoxGender
            // 
            comboBoxGender.BackColor = Color.White;
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FlatStyle = FlatStyle.Flat;
            comboBoxGender.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(173, 194);
            comboBoxGender.Margin = new Padding(3, 4, 3, 4);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(371, 33);
            comboBoxGender.TabIndex = 12;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.White;
            txtBoxLastName.BorderStyle = BorderStyle.None;
            txtBoxLastName.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxLastName.Location = new Point(173, 123);
            txtBoxLastName.Margin = new Padding(3, 4, 3, 4);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(366, 26);
            txtBoxLastName.TabIndex = 16;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.White;
            txtBoxFirstName.BorderStyle = BorderStyle.None;
            txtBoxFirstName.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxFirstName.Location = new Point(173, 75);
            txtBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(366, 26);
            txtBoxFirstName.TabIndex = 15;
            // 
            // rectangleRound3
            // 
            rectangleRound3.BackColor = Color.White;
            rectangleRound3.Location = new Point(164, 192);
            rectangleRound3.Name = "rectangleRound3";
            rectangleRound3.Size = new Size(385, 38);
            rectangleRound3.TabIndex = 23;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(19, 29);
            label11.Name = "label11";
            label11.Size = new Size(187, 25);
            label11.TabIndex = 22;
            label11.Text = "Personal Information";
            // 
            // rectangleRound2
            // 
            rectangleRound2.BackColor = Color.White;
            rectangleRound2.Location = new Point(164, 117);
            rectangleRound2.Name = "rectangleRound2";
            rectangleRound2.Size = new Size(385, 38);
            rectangleRound2.TabIndex = 21;
            // 
            // rectangleRound1
            // 
            rectangleRound1.BackColor = Color.White;
            rectangleRound1.Location = new Point(164, 69);
            rectangleRound1.Name = "rectangleRound1";
            rectangleRound1.Size = new Size(385, 38);
            rectangleRound1.TabIndex = 20;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(47, 369);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 11;
            label9.Text = "Role";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 202);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 6;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 252);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Contact";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 323);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 128);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 79);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txtBoxUsername);
            groupBox3.Controls.Add(rectangleRound8);
            groupBox3.Controls.Add(txtBoxUserId);
            groupBox3.Controls.Add(btnChangePassword);
            groupBox3.Controls.Add(rectangleRound7);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(981, 13);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(596, 420);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.BackColor = Color.White;
            txtBoxUsername.BorderStyle = BorderStyle.None;
            txtBoxUsername.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxUsername.Location = new Point(177, 123);
            txtBoxUsername.Margin = new Padding(3, 4, 3, 4);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(382, 26);
            txtBoxUsername.TabIndex = 25;
            // 
            // rectangleRound8
            // 
            rectangleRound8.BackColor = Color.White;
            rectangleRound8.Location = new Point(168, 117);
            rectangleRound8.Name = "rectangleRound8";
            rectangleRound8.Size = new Size(401, 38);
            rectangleRound8.TabIndex = 33;
            // 
            // txtBoxUserId
            // 
            txtBoxUserId.BackColor = Color.White;
            txtBoxUserId.BorderStyle = BorderStyle.None;
            txtBoxUserId.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxUserId.Location = new Point(177, 75);
            txtBoxUserId.Margin = new Padding(3, 4, 3, 4);
            txtBoxUserId.Name = "txtBoxUserId";
            txtBoxUserId.ReadOnly = true;
            txtBoxUserId.Size = new Size(382, 26);
            txtBoxUserId.TabIndex = 22;
            // 
            // rectangleRound7
            // 
            rectangleRound7.BackColor = Color.White;
            rectangleRound7.Location = new Point(168, 69);
            rectangleRound7.Name = "rectangleRound7";
            rectangleRound7.Size = new Size(401, 38);
            rectangleRound7.TabIndex = 32;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(20, 29);
            label12.Name = "label12";
            label12.Size = new Size(184, 25);
            label12.TabIndex = 31;
            label12.Text = "Account Information";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(52, 128);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 24;
            label8.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(52, 79);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 21;
            label6.Text = "UserID";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatAppearance.MouseDownBackColor = Color.White;
            btnBack.FlatAppearance.MouseOverBackColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(43, 121, 223);
            btnBack.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            btnBack.IconColor = Color.FromArgb(43, 121, 223);
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 30;
            btnBack.Location = new Point(1447, 441);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 54;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.FlatAppearance.BorderSize = 2;
            btnBrowse.FlatAppearance.MouseDownBackColor = Color.White;
            btnBrowse.FlatAppearance.MouseOverBackColor = Color.White;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.FromArgb(43, 121, 223);
            btnBrowse.IconChar = FontAwesome.Sharp.IconChar.Image;
            btnBrowse.IconColor = Color.FromArgb(43, 121, 223);
            btnBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBrowse.IconSize = 30;
            btnBrowse.Location = new Point(102, 362);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 40);
            btnBrowse.TabIndex = 55;
            btnBrowse.Text = "Browse";
            btnBrowse.TextAlign = ContentAlignment.MiddleRight;
            btnBrowse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // UserEditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(btnBrowse);
            Controls.Add(btnBack);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(picBoxUser);
            Controls.Add(btnSave);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserEditView";
            Text = "UserEditView";
            Load += UserEditView_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxUser).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Button btnChangePassword;
        private Button btnSave;
        private RoundedPictureBox picBoxUser;
        private GroupBox groupBox1;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxStatus;
        private RectangleRound rectangleRound6;
        private RectangleRound rectangleRound5;
        private TextBox txtBoxContact;
        private RectangleRound rectangleRound4;
        private ComboBox comboBoxGender;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private RectangleRound rectangleRound3;
        private Label label11;
        private RectangleRound rectangleRound2;
        private RectangleRound rectangleRound1;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox txtBoxUsername;
        private RectangleRound rectangleRound8;
        private TextBox txtBoxUserId;
        private RectangleRound rectangleRound7;
        private Label label12;
        private Label label8;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnBrowse;
    }
}