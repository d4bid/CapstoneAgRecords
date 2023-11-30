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
            groupBox1 = new GroupBox();
            label18 = new Label();
            cmbJobTitle = new ComboBox();
            rectangleRound15 = new RectangleRound();
            label17 = new Label();
            txtTitle = new TextBox();
            rectangleRound14 = new RectangleRound();
            label16 = new Label();
            txtExtension = new TextBox();
            rectangleRound13 = new RectangleRound();
            label15 = new Label();
            txtMiddlename = new TextBox();
            label10 = new Label();
            rectangleRound12 = new RectangleRound();
            txtBoxContact = new TextBox();
            rectangleRound4 = new RectangleRound();
            comboBoxGender = new ComboBox();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            rectangleRound3 = new RectangleRound();
            label11 = new Label();
            rectangleRound2 = new RectangleRound();
            rectangleRound1 = new RectangleRound();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            label6 = new Label();
            txtBoxUserId = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtBoxUsername = new TextBox();
            txtBoxPassword = new TextBox();
            lblPasswordStrength = new Label();
            txtBoxConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            groupBox3 = new GroupBox();
            comboBoxRole = new ComboBox();
            panel1 = new Panel();
            panelPassConfirm = new Panel();
            panel3 = new Panel();
            label13 = new Label();
            rectangleRound11 = new RectangleRound();
            panelPassStrength = new Panel();
            panel2 = new Panel();
            rectangleRound9 = new RectangleRound();
            comboBoxStatus = new ComboBox();
            rectangleRound6 = new RectangleRound();
            rectangleRound5 = new RectangleRound();
            rectangleRound8 = new RectangleRound();
            label3 = new Label();
            label9 = new Label();
            rectangleRound7 = new RectangleRound();
            label12 = new Label();
            picBoxUser = new RoundedPictureBox();
            btnBrowse = new FontAwesome.Sharp.IconButton();
            btnBack = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            lblUsernameExists = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            panelPassConfirm.SuspendLayout();
            panel3.SuspendLayout();
            panelPassStrength.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(cmbJobTitle);
            groupBox1.Controls.Add(rectangleRound15);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(rectangleRound14);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtExtension);
            groupBox1.Controls.Add(rectangleRound13);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtMiddlename);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(rectangleRound12);
            groupBox1.Controls.Add(txtBoxContact);
            groupBox1.Controls.Add(rectangleRound4);
            groupBox1.Controls.Add(comboBoxGender);
            groupBox1.Controls.Add(txtBoxLastName);
            groupBox1.Controls.Add(txtBoxFirstName);
            groupBox1.Controls.Add(rectangleRound3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(rectangleRound2);
            groupBox1.Controls.Add(rectangleRound1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(385, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1192, 381);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(202, 329);
            label18.Name = "label18";
            label18.Size = new Size(89, 17);
            label18.TabIndex = 40;
            label18.Text = "Dr., Engr., etc.";
            // 
            // cmbJobTitle
            // 
            cmbJobTitle.BackColor = Color.White;
            cmbJobTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJobTitle.FlatStyle = FlatStyle.Flat;
            cmbJobTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbJobTitle.FormattingEnabled = true;
            cmbJobTitle.Items.AddRange(new object[] { "Admin Aide", "Agricultural Technologist", "Agricultturist", "Municipal Agriculturist" });
            cmbJobTitle.Location = new Point(841, 170);
            cmbJobTitle.Margin = new Padding(3, 4, 3, 4);
            cmbJobTitle.Name = "cmbJobTitle";
            cmbJobTitle.Size = new Size(264, 31);
            cmbJobTitle.TabIndex = 38;
            // 
            // rectangleRound15
            // 
            rectangleRound15.BackColor = Color.White;
            rectangleRound15.Location = new Point(832, 167);
            rectangleRound15.Name = "rectangleRound15";
            rectangleRound15.Size = new Size(278, 38);
            rectangleRound15.TabIndex = 39;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(710, 176);
            label17.Name = "label17";
            label17.Size = new Size(61, 20);
            label17.TabIndex = 37;
            label17.Text = "Position";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.Location = new Point(211, 294);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(366, 26);
            txtTitle.TabIndex = 36;
            // 
            // rectangleRound14
            // 
            rectangleRound14.BackColor = Color.White;
            rectangleRound14.Location = new Point(202, 288);
            rectangleRound14.Name = "rectangleRound14";
            rectangleRound14.Size = new Size(385, 38);
            rectangleRound14.TabIndex = 34;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(47, 299);
            label16.Name = "label16";
            label16.Size = new Size(38, 20);
            label16.TabIndex = 33;
            label16.Text = "Title";
            // 
            // txtExtension
            // 
            txtExtension.BackColor = Color.White;
            txtExtension.BorderStyle = BorderStyle.None;
            txtExtension.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtExtension.Location = new Point(211, 221);
            txtExtension.Margin = new Padding(3, 4, 3, 4);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(366, 26);
            txtExtension.TabIndex = 32;
            // 
            // rectangleRound13
            // 
            rectangleRound13.BackColor = Color.White;
            rectangleRound13.Location = new Point(202, 216);
            rectangleRound13.Name = "rectangleRound13";
            rectangleRound13.Size = new Size(385, 38);
            rectangleRound13.TabIndex = 31;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(47, 227);
            label15.Name = "label15";
            label15.Size = new Size(116, 20);
            label15.TabIndex = 30;
            label15.Text = "Extension Name";
            // 
            // txtMiddlename
            // 
            txtMiddlename.BackColor = Color.White;
            txtMiddlename.BorderStyle = BorderStyle.None;
            txtMiddlename.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtMiddlename.Location = new Point(211, 123);
            txtMiddlename.Margin = new Padding(3, 4, 3, 4);
            txtMiddlename.Name = "txtMiddlename";
            txtMiddlename.Size = new Size(366, 26);
            txtMiddlename.TabIndex = 29;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(47, 176);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 28;
            label10.Text = "Last Name";
            // 
            // rectangleRound12
            // 
            rectangleRound12.BackColor = Color.White;
            rectangleRound12.Location = new Point(202, 117);
            rectangleRound12.Name = "rectangleRound12";
            rectangleRound12.Size = new Size(385, 38);
            rectangleRound12.TabIndex = 27;
            // 
            // txtBoxContact
            // 
            txtBoxContact.BackColor = Color.White;
            txtBoxContact.BorderStyle = BorderStyle.None;
            txtBoxContact.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxContact.Location = new Point(841, 123);
            txtBoxContact.Margin = new Padding(3, 4, 3, 4);
            txtBoxContact.Name = "txtBoxContact";
            txtBoxContact.Size = new Size(259, 26);
            txtBoxContact.TabIndex = 19;
            // 
            // rectangleRound4
            // 
            rectangleRound4.BackColor = Color.White;
            rectangleRound4.Location = new Point(832, 117);
            rectangleRound4.Name = "rectangleRound4";
            rectangleRound4.Size = new Size(278, 38);
            rectangleRound4.TabIndex = 24;
            // 
            // comboBoxGender
            // 
            comboBoxGender.BackColor = Color.White;
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FlatStyle = FlatStyle.Flat;
            comboBoxGender.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(841, 70);
            comboBoxGender.Margin = new Padding(3, 4, 3, 4);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(264, 31);
            comboBoxGender.TabIndex = 12;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.White;
            txtBoxLastName.BorderStyle = BorderStyle.None;
            txtBoxLastName.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxLastName.Location = new Point(211, 172);
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
            txtBoxFirstName.Location = new Point(211, 75);
            txtBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(366, 26);
            txtBoxFirstName.TabIndex = 15;
            // 
            // rectangleRound3
            // 
            rectangleRound3.BackColor = Color.White;
            rectangleRound3.Location = new Point(832, 67);
            rectangleRound3.Name = "rectangleRound3";
            rectangleRound3.Size = new Size(278, 38);
            rectangleRound3.TabIndex = 23;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(19, 28);
            label11.Name = "label11";
            label11.Size = new Size(187, 25);
            label11.TabIndex = 22;
            label11.Text = "Personal Information";
            // 
            // rectangleRound2
            // 
            rectangleRound2.BackColor = Color.White;
            rectangleRound2.Location = new Point(202, 166);
            rectangleRound2.Name = "rectangleRound2";
            rectangleRound2.Size = new Size(385, 38);
            rectangleRound2.TabIndex = 21;
            // 
            // rectangleRound1
            // 
            rectangleRound1.BackColor = Color.White;
            rectangleRound1.Location = new Point(202, 69);
            rectangleRound1.Name = "rectangleRound1";
            rectangleRound1.Size = new Size(385, 38);
            rectangleRound1.TabIndex = 20;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(710, 76);
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
            label4.Location = new Point(710, 126);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Contact";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 127);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Middle Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 78);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1311, 867);
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
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(52, 78);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 21;
            label6.Text = "UserID";
            // 
            // txtBoxUserId
            // 
            txtBoxUserId.BackColor = Color.White;
            txtBoxUserId.BorderStyle = BorderStyle.None;
            txtBoxUserId.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxUserId.Location = new Point(211, 75);
            txtBoxUserId.Margin = new Padding(3, 4, 3, 4);
            txtBoxUserId.Name = "txtBoxUserId";
            txtBoxUserId.ReadOnly = true;
            txtBoxUserId.Size = new Size(366, 26);
            txtBoxUserId.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 19);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 23;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(52, 127);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 24;
            label8.Text = "Username";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.BackColor = Color.White;
            txtBoxUsername.BorderStyle = BorderStyle.None;
            txtBoxUsername.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxUsername.Location = new Point(211, 123);
            txtBoxUsername.Margin = new Padding(3, 4, 3, 4);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(366, 26);
            txtBoxUsername.TabIndex = 25;
            txtBoxUsername.TextChanged += txtBoxUsername_TextChanged;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = Color.White;
            txtBoxPassword.BorderStyle = BorderStyle.None;
            txtBoxPassword.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(185, 15);
            txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(366, 26);
            txtBoxPassword.TabIndex = 26;
            txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordStrength
            // 
            lblPasswordStrength.AutoSize = true;
            lblPasswordStrength.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordStrength.ForeColor = Color.FromArgb(207, 92, 96);
            lblPasswordStrength.Location = new Point(176, 3);
            lblPasswordStrength.Name = "lblPasswordStrength";
            lblPasswordStrength.Size = new Size(389, 34);
            lblPasswordStrength.TabIndex = 27;
            lblPasswordStrength.Text = "Password must be 8-16 characters with at least one uppercase \nletter, lowercase letter, number, and special character.";
            // 
            // txtBoxConfirmPassword
            // 
            txtBoxConfirmPassword.BackColor = Color.White;
            txtBoxConfirmPassword.BorderStyle = BorderStyle.None;
            txtBoxConfirmPassword.Font = new Font("Segoe UI Semibold", 11.7F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxConfirmPassword.Location = new Point(185, 12);
            txtBoxConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            txtBoxConfirmPassword.Size = new Size(366, 26);
            txtBoxConfirmPassword.TabIndex = 29;
            txtBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmPassword.ForeColor = Color.FromArgb(207, 92, 96);
            lblConfirmPassword.Location = new Point(176, 3);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(162, 17);
            lblConfirmPassword.TabIndex = 30;
            lblConfirmPassword.Text = "Passwords do not match.";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lblUsernameExists);
            groupBox3.Controls.Add(comboBoxRole);
            groupBox3.Controls.Add(panel1);
            groupBox3.Controls.Add(comboBoxStatus);
            groupBox3.Controls.Add(rectangleRound6);
            groupBox3.Controls.Add(txtBoxUsername);
            groupBox3.Controls.Add(rectangleRound5);
            groupBox3.Controls.Add(rectangleRound8);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtBoxUserId);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(rectangleRound7);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(385, 402);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1192, 457);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = Color.White;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FlatStyle = FlatStyle.Flat;
            comboBoxRole.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(841, 116);
            comboBoxRole.Margin = new Padding(3, 4, 3, 4);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(264, 31);
            comboBoxRole.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelPassConfirm);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelPassStrength);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(20, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 234);
            panel1.TabIndex = 34;
            // 
            // panelPassConfirm
            // 
            panelPassConfirm.Controls.Add(lblConfirmPassword);
            panelPassConfirm.Dock = DockStyle.Top;
            panelPassConfirm.Location = new Point(0, 154);
            panelPassConfirm.Name = "panelPassConfirm";
            panelPassConfirm.Size = new Size(580, 50);
            panelPassConfirm.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtBoxConfirmPassword);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(rectangleRound11);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 50);
            panel3.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(29, 15);
            label13.Name = "label13";
            label13.Size = new Size(62, 20);
            label13.TabIndex = 23;
            label13.Text = "Confirm";
            // 
            // rectangleRound11
            // 
            rectangleRound11.BackColor = Color.White;
            rectangleRound11.Location = new Point(176, 6);
            rectangleRound11.Name = "rectangleRound11";
            rectangleRound11.Size = new Size(385, 38);
            rectangleRound11.TabIndex = 34;
            // 
            // panelPassStrength
            // 
            panelPassStrength.Controls.Add(lblPasswordStrength);
            panelPassStrength.Dock = DockStyle.Top;
            panelPassStrength.Location = new Point(0, 54);
            panelPassStrength.Name = "panelPassStrength";
            panelPassStrength.Size = new Size(580, 50);
            panelPassStrength.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtBoxPassword);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(rectangleRound9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 54);
            panel2.TabIndex = 0;
            // 
            // rectangleRound9
            // 
            rectangleRound9.BackColor = Color.White;
            rectangleRound9.Location = new Point(176, 10);
            rectangleRound9.Name = "rectangleRound9";
            rectangleRound9.Size = new Size(385, 38);
            rectangleRound9.TabIndex = 34;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.White;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FlatStyle = FlatStyle.Flat;
            comboBoxStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBoxStatus.Location = new Point(841, 71);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(264, 31);
            comboBoxStatus.TabIndex = 37;
            // 
            // rectangleRound6
            // 
            rectangleRound6.BackColor = Color.White;
            rectangleRound6.Location = new Point(832, 114);
            rectangleRound6.Name = "rectangleRound6";
            rectangleRound6.Size = new Size(278, 38);
            rectangleRound6.TabIndex = 40;
            // 
            // rectangleRound5
            // 
            rectangleRound5.BackColor = Color.White;
            rectangleRound5.Location = new Point(832, 69);
            rectangleRound5.Name = "rectangleRound5";
            rectangleRound5.Size = new Size(278, 38);
            rectangleRound5.TabIndex = 39;
            // 
            // rectangleRound8
            // 
            rectangleRound8.BackColor = Color.White;
            rectangleRound8.Location = new Point(202, 117);
            rectangleRound8.Name = "rectangleRound8";
            rectangleRound8.Size = new Size(385, 38);
            rectangleRound8.TabIndex = 33;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(710, 78);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 35;
            label3.Text = "Status";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(710, 127);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 36;
            label9.Text = "Role";
            // 
            // rectangleRound7
            // 
            rectangleRound7.BackColor = Color.White;
            rectangleRound7.Location = new Point(202, 69);
            rectangleRound7.Name = "rectangleRound7";
            rectangleRound7.Size = new Size(385, 38);
            rectangleRound7.TabIndex = 32;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(20, 28);
            label12.Name = "label12";
            label12.Size = new Size(184, 25);
            label12.TabIndex = 31;
            label12.Text = "Account Information";
            // 
            // picBoxUser
            // 
            picBoxUser.BackgroundImageLayout = ImageLayout.Zoom;
            picBoxUser.BorderStyle = BorderStyle.FixedSingle;
            picBoxUser.Image = Properties.Resources.profile;
            picBoxUser.Location = new Point(38, 39);
            picBoxUser.Name = "picBoxUser";
            picBoxUser.Size = new Size(300, 300);
            picBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxUser.TabIndex = 10;
            picBoxUser.TabStop = false;
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
            btnBrowse.Location = new Point(114, 375);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 40);
            btnBrowse.TabIndex = 56;
            btnBrowse.Text = "Browse";
            btnBrowse.TextAlign = ContentAlignment.MiddleRight;
            btnBrowse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click_1;
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
            btnBack.Location = new Point(1447, 866);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 57;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(picBoxUser);
            panel4.Controls.Add(btnBrowse);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 10);
            panel4.Size = new Size(379, 926);
            panel4.TabIndex = 58;
            // 
            // lblUsernameExists
            // 
            lblUsernameExists.AutoSize = true;
            lblUsernameExists.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsernameExists.ForeColor = Color.FromArgb(207, 92, 96);
            lblUsernameExists.Location = new Point(202, 158);
            lblUsernameExists.Name = "lblUsernameExists";
            lblUsernameExists.Size = new Size(152, 17);
            lblUsernameExists.TabIndex = 41;
            lblUsernameExists.Text = "Username already exist.";
            lblUsernameExists.Visible = false;
            // 
            // UserAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
            Controls.Add(btnBack);
            Controls.Add(groupBox3);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(panel4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserAddView";
            Text = "UserAddView";
            Load += UserAddView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panelPassConfirm.ResumeLayout(false);
            panelPassConfirm.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelPassStrength.ResumeLayout(false);
            panelPassStrength.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private TextBox txtBoxContact;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private ComboBox comboBoxGender;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
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
        private RectangleRound rectangleRound1;
        private Label label11;
        private RectangleRound rectangleRound2;
        private RectangleRound rectangleRound3;
        private RectangleRound rectangleRound4;
        private RectangleRound rectangleRound9;
        private RectangleRound rectangleRound8;
        private RectangleRound rectangleRound7;
        private Label label12;
        private RoundedPictureBox picBoxUser;
        private FontAwesome.Sharp.IconButton btnBrowse;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label13;
        private RectangleRound rectangleRound11;
        private Panel panelPassStrength;
        private Panel panelPassConfirm;
        private FontAwesome.Sharp.IconButton btnBack;
        private RectangleRound rectangleRound12;
        private TextBox txtMiddlename;
        private TextBox txtExtension;
        private RectangleRound rectangleRound13;
        private Label label15;
        private TextBox txtTitle;
        private RectangleRound rectangleRound14;
        private Label label16;
        private ComboBox cmbJobTitle;
        private RectangleRound rectangleRound15;
        private Label label17;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxStatus;
        private RectangleRound rectangleRound6;
        private RectangleRound rectangleRound5;
        private Label label3;
        private Label label9;
        private Label label18;
        private Panel panel4;
        private Label lblUsernameExists;
    }
}