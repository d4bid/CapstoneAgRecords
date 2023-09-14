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
            groupBox5 = new GroupBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            groupBox4 = new GroupBox();
            checkBox11 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            groupBox6 = new GroupBox();
            checkBox10 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            btnSave = new Button();
            label6 = new Label();
            txtBoxUserId = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtBoxUsername = new TextBox();
            txtBoxPassword = new TextBox();
            lblPasswordStrength = new Label();
            label10 = new Label();
            txtBoxConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // picBoxUser
            // 
            picBoxUser.BorderStyle = BorderStyle.FixedSingle;
            picBoxUser.Location = new Point(16, 42);
            picBoxUser.Margin = new Padding(3, 4, 3, 4);
            picBoxUser.Name = "picBoxUser";
            picBoxUser.Size = new Size(150, 150);
            picBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxUser.TabIndex = 0;
            picBoxUser.TabStop = false;
            picBoxUser.Click += picBoxUser_Click;
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
            groupBox1.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(637, 342);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // txtBoxContact
            // 
            txtBoxContact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxContact.BackColor = Color.White;
            txtBoxContact.BorderStyle = BorderStyle.FixedSingle;
            txtBoxContact.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxContact.Location = new Point(297, 189);
            txtBoxContact.Margin = new Padding(3, 4, 3, 4);
            txtBoxContact.Name = "txtBoxContact";
            txtBoxContact.Size = new Size(305, 29);
            txtBoxContact.TabIndex = 19;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxLastName.BackColor = Color.White;
            txtBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLastName.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.Location = new Point(297, 86);
            txtBoxLastName.Margin = new Padding(3, 4, 3, 4);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(305, 29);
            txtBoxLastName.TabIndex = 16;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxFirstName.BackColor = Color.White;
            txtBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFirstName.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.Location = new Point(297, 46);
            txtBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(305, 29);
            txtBoxFirstName.TabIndex = 15;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxRole.BackColor = Color.FromArgb(239, 239, 239);
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(297, 283);
            comboBoxRole.Margin = new Padding(3, 4, 3, 4);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(305, 30);
            comboBoxRole.TabIndex = 14;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxStatus.BackColor = Color.FromArgb(239, 239, 239);
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBoxStatus.Location = new Point(297, 243);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(305, 30);
            comboBoxStatus.TabIndex = 13;
            // 
            // comboBoxGender
            // 
            comboBoxGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxGender.BackColor = Color.FromArgb(239, 239, 239);
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(297, 144);
            comboBoxGender.Margin = new Padding(3, 4, 3, 4);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(305, 30);
            comboBoxGender.TabIndex = 12;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(188, 286);
            label9.Name = "label9";
            label9.Size = new Size(45, 22);
            label9.TabIndex = 11;
            label9.Text = "Role";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(188, 148);
            label5.Name = "label5";
            label5.Size = new Size(68, 22);
            label5.TabIndex = 6;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(188, 191);
            label4.Name = "label4";
            label4.Size = new Size(73, 22);
            label4.TabIndex = 5;
            label4.Text = "Contact";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(188, 246);
            label3.Name = "label3";
            label3.Size = new Size(62, 22);
            label3.TabIndex = 4;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(188, 88);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 49);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(43, 121, 223);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(16, 200);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 39);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(43, 121, 223);
            btnCancel.Location = new Point(1079, 592);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(15, 363);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1194, 223);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Permissions";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(checkBox7);
            groupBox5.Controls.Add(checkBox8);
            groupBox5.Controls.Add(checkBox9);
            groupBox5.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(255, 33);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(103, 171);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Users";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox7.Location = new Point(17, 30);
            checkBox7.Margin = new Padding(3, 4, 3, 4);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(71, 26);
            checkBox7.TabIndex = 0;
            checkBox7.Tag = "5";
            checkBox7.Text = "View";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox8.Location = new Point(17, 97);
            checkBox8.Margin = new Padding(3, 4, 3, 4);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(62, 26);
            checkBox8.TabIndex = 2;
            checkBox8.Tag = "7";
            checkBox8.Text = "Edit";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox9.Location = new Point(17, 64);
            checkBox9.Margin = new Padding(3, 4, 3, 4);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(64, 26);
            checkBox9.TabIndex = 1;
            checkBox9.Tag = "6";
            checkBox9.Text = "Add";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox11);
            groupBox4.Controls.Add(checkBox4);
            groupBox4.Controls.Add(checkBox5);
            groupBox4.Controls.Add(checkBox6);
            groupBox4.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(135, 33);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(103, 171);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Letters";
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox11.Location = new Point(17, 130);
            checkBox11.Margin = new Padding(3, 4, 3, 4);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(69, 26);
            checkBox11.TabIndex = 4;
            checkBox11.Tag = "11";
            checkBox11.Text = "Print";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(17, 30);
            checkBox4.Margin = new Padding(3, 4, 3, 4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(71, 26);
            checkBox4.TabIndex = 0;
            checkBox4.Tag = "8";
            checkBox4.Text = "View";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(17, 97);
            checkBox5.Margin = new Padding(3, 4, 3, 4);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(62, 26);
            checkBox5.TabIndex = 2;
            checkBox5.Tag = "10";
            checkBox5.Text = "Edit";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(17, 64);
            checkBox6.Margin = new Padding(3, 4, 3, 4);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(64, 26);
            checkBox6.TabIndex = 1;
            checkBox6.Tag = "9";
            checkBox6.Text = "Add";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(checkBox10);
            groupBox6.Controls.Add(checkBox1);
            groupBox6.Controls.Add(checkBox3);
            groupBox6.Controls.Add(checkBox2);
            groupBox6.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(16, 33);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(103, 171);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "RSBSA";
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox10.Location = new Point(17, 130);
            checkBox10.Margin = new Padding(3, 4, 3, 4);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(69, 26);
            checkBox10.TabIndex = 3;
            checkBox10.Tag = "4";
            checkBox10.Text = "Print";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(17, 30);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 26);
            checkBox1.TabIndex = 0;
            checkBox1.Tag = "1";
            checkBox1.Text = "View";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(17, 97);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(62, 26);
            checkBox3.TabIndex = 2;
            checkBox3.Tag = "3";
            checkBox3.Text = "Edit";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(17, 64);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 26);
            checkBox2.TabIndex = 1;
            checkBox2.Tag = "2";
            checkBox2.Text = "Add";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(943, 592);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 45);
            label6.Name = "label6";
            label6.Size = new Size(64, 22);
            label6.TabIndex = 21;
            label6.Text = "UserID";
            // 
            // txtBoxUserId
            // 
            txtBoxUserId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxUserId.BackColor = Color.White;
            txtBoxUserId.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUserId.Location = new Point(133, 45);
            txtBoxUserId.Margin = new Padding(3, 4, 3, 4);
            txtBoxUserId.Name = "txtBoxUserId";
            txtBoxUserId.ReadOnly = true;
            txtBoxUserId.Size = new Size(375, 31);
            txtBoxUserId.TabIndex = 22;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 148);
            label7.Name = "label7";
            label7.Size = new Size(89, 22);
            label7.TabIndex = 23;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 105);
            label8.Name = "label8";
            label8.Size = new Size(93, 22);
            label8.TabIndex = 24;
            label8.Text = "Username";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxUsername.BackColor = Color.White;
            txtBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUsername.Location = new Point(133, 101);
            txtBoxUsername.Margin = new Padding(3, 4, 3, 4);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(375, 31);
            txtBoxUsername.TabIndex = 25;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxPassword.BackColor = Color.White;
            txtBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPassword.Location = new Point(133, 143);
            txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(375, 31);
            txtBoxPassword.TabIndex = 26;
            // 
            // lblPasswordStrength
            // 
            lblPasswordStrength.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPasswordStrength.AutoSize = true;
            lblPasswordStrength.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordStrength.ForeColor = Color.FromArgb(207, 92, 96);
            lblPasswordStrength.Location = new Point(133, 181);
            lblPasswordStrength.Name = "lblPasswordStrength";
            lblPasswordStrength.Size = new Size(378, 40);
            lblPasswordStrength.TabIndex = 27;
            lblPasswordStrength.Text = "Password must be 8-16 characters with at least one uppercase \nletter, lowercase letter, number, and special character.";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(14, 246);
            label10.Name = "label10";
            label10.Size = new Size(74, 22);
            label10.TabIndex = 28;
            label10.Text = "Confirm";
            // 
            // txtBoxConfirmPassword
            // 
            txtBoxConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxConfirmPassword.BackColor = Color.White;
            txtBoxConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxConfirmPassword.Location = new Point(133, 242);
            txtBoxConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            txtBoxConfirmPassword.Size = new Size(375, 31);
            txtBoxConfirmPassword.TabIndex = 29;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPassword.ForeColor = Color.FromArgb(207, 92, 96);
            lblConfirmPassword.Location = new Point(133, 283);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(157, 20);
            lblConfirmPassword.TabIndex = 30;
            lblConfirmPassword.Text = "Passwords do not match.";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lblConfirmPassword);
            groupBox3.Controls.Add(txtBoxConfirmPassword);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(lblPasswordStrength);
            groupBox3.Controls.Add(txtBoxPassword);
            groupBox3.Controls.Add(txtBoxUsername);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtBoxUserId);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(669, 13);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(540, 342);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account Information";
            // 
            // UserAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1221, 645);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private PictureBox picBoxUser;
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
        private Label label6;
        private TextBox txtBoxUserId;
        private Label label7;
        private Label label8;
        private TextBox txtBoxUsername;
        private TextBox txtBoxPassword;
        private Label lblPasswordStrength;
        private Label label10;
        private TextBox txtBoxConfirmPassword;
        private Label lblConfirmPassword;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private GroupBox groupBox4;
        private CheckBox checkBox11;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private GroupBox groupBox6;
        private CheckBox checkBox10;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
    }
}