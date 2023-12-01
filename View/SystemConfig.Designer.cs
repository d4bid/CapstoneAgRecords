namespace AgRecords.View
{
    partial class SystemConfig
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
            btnCancel = new Button();
            btnSave = new Button();
            txtServerAddress = new TextBox();
            rectangleBlue1 = new RectangleBlue();
            lblUsername = new Label();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnRestore = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnConfig = new FontAwesome.Sharp.IconButton();
            txtUsername = new TextBox();
            label2 = new Label();
            rectangleBlue2 = new RectangleBlue();
            txtDatabase = new TextBox();
            Username = new Label();
            label3 = new Label();
            rectangleBlue4 = new RectangleBlue();
            rectangleBlue3 = new RectangleBlue();
            label4 = new Label();
            txtPassword = new TextBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(221, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(43, 430);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtServerAddress
            // 
            txtServerAddress.BorderStyle = BorderStyle.None;
            txtServerAddress.Font = new Font("Segoe UI", 11.7F, FontStyle.Regular, GraphicsUnit.Point);
            txtServerAddress.Location = new Point(49, 149);
            txtServerAddress.Margin = new Padding(5, 3, 3, 3);
            txtServerAddress.Name = "txtServerAddress";
            txtServerAddress.Size = new Size(333, 26);
            txtServerAddress.TabIndex = 44;
            // 
            // rectangleBlue1
            // 
            rectangleBlue1.Location = new Point(42, 144);
            rectangleBlue1.Name = "rectangleBlue1";
            rectangleBlue1.Size = new Size(344, 38);
            rectangleBlue1.TabIndex = 46;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(43, 121, 223);
            lblUsername.Location = new Point(41, 121);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 45;
            lblUsername.Text = "Hostname";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(43, 121, 223);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.White;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 20;
            btnExit.Location = new Point(328, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 20);
            btnExit.TabIndex = 47;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.FromArgb(43, 121, 223);
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatAppearance.MouseDownBackColor = Color.FromArgb(43, 121, 223);
            btnRestore.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 121, 223);
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnRestore.IconColor = Color.White;
            btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRestore.IconSize = 100;
            btnRestore.Location = new Point(140, 196);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(100, 100);
            btnRestore.TabIndex = 48;
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(119, 298);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 49;
            label1.Text = "Restore Database";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 500);
            panel1.TabIndex = 50;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(btnConfig);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(rectangleBlue2);
            panel2.Controls.Add(txtDatabase);
            panel2.Controls.Add(Username);
            panel2.Controls.Add(txtServerAddress);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(rectangleBlue4);
            panel2.Controls.Add(rectangleBlue1);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(rectangleBlue3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 500);
            panel2.TabIndex = 51;
            // 
            // btnConfig
            // 
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatAppearance.MouseDownBackColor = Color.White;
            btnConfig.FlatAppearance.MouseOverBackColor = Color.White;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            btnConfig.IconColor = Color.FromArgb(43, 121, 223);
            btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfig.IconSize = 30;
            btnConfig.Location = new Point(216, 32);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(25, 20);
            btnConfig.TabIndex = 61;
            btnConfig.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11.7F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(50, 224);
            txtUsername.Margin = new Padding(5, 3, 3, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(333, 26);
            txtUsername.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(43, 121, 223);
            label2.Location = new Point(131, 60);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 60;
            label2.Text = "System Configuration";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rectangleBlue2
            // 
            rectangleBlue2.Location = new Point(43, 219);
            rectangleBlue2.Name = "rectangleBlue2";
            rectangleBlue2.Size = new Size(344, 38);
            rectangleBlue2.TabIndex = 53;
            // 
            // txtDatabase
            // 
            txtDatabase.BorderStyle = BorderStyle.None;
            txtDatabase.Font = new Font("Segoe UI", 11.7F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatabase.Location = new Point(50, 376);
            txtDatabase.Margin = new Padding(5, 3, 3, 3);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(333, 26);
            txtDatabase.TabIndex = 57;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.FromArgb(43, 121, 223);
            Username.Location = new Point(42, 196);
            Username.Name = "Username";
            Username.Size = new Size(78, 20);
            Username.TabIndex = 52;
            Username.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(43, 121, 223);
            label3.Location = new Point(41, 270);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 55;
            label3.Text = "Password";
            // 
            // rectangleBlue4
            // 
            rectangleBlue4.Location = new Point(43, 371);
            rectangleBlue4.Name = "rectangleBlue4";
            rectangleBlue4.Size = new Size(344, 38);
            rectangleBlue4.TabIndex = 59;
            // 
            // rectangleBlue3
            // 
            rectangleBlue3.Location = new Point(42, 293);
            rectangleBlue3.Name = "rectangleBlue3";
            rectangleBlue3.Size = new Size(344, 38);
            rectangleBlue3.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(43, 121, 223);
            label4.Location = new Point(42, 348);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 58;
            label4.Text = "Database";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11.7F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(49, 298);
            txtPassword.Margin = new Padding(5, 3, 3, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(333, 26);
            txtPassword.TabIndex = 54;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 121, 223);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnRestore);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(437, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 500);
            panel3.TabIndex = 51;
            // 
            // SystemConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SystemConfig";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SystemConfig";
            Load += SystemConfig_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtServerAddress;
        private RectangleBlue rectangleBlue1;
        private Label lblUsername;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnRestore;
        private Label label1;
        private Panel panel1;
        private TextBox txtUsername;
        private RectangleBlue rectangleBlue2;
        private Label Username;
        private TextBox txtPassword;
        private RectangleBlue rectangleBlue3;
        private Label label3;
        private TextBox txtDatabase;
        private RectangleBlue rectangleBlue4;
        private Label label4;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnConfig;
        private Panel panel2;
        private Panel panel3;
    }
}