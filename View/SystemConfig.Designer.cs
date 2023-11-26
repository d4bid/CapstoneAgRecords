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
            txtUsername = new TextBox();
            rectangleBlue2 = new RectangleBlue();
            Username = new Label();
            txtPassword = new TextBox();
            rectangleBlue3 = new RectangleBlue();
            label3 = new Label();
            txtDatabase = new TextBox();
            rectangleBlue4 = new RectangleBlue();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(580, 329);
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
            btnSave.Location = new Point(402, 329);
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
            txtServerAddress.Location = new Point(408, 52);
            txtServerAddress.Margin = new Padding(5, 3, 3, 3);
            txtServerAddress.Name = "txtServerAddress";
            txtServerAddress.Size = new Size(333, 26);
            txtServerAddress.TabIndex = 44;
            // 
            // rectangleBlue1
            // 
            rectangleBlue1.Location = new Point(401, 47);
            rectangleBlue1.Name = "rectangleBlue1";
            rectangleBlue1.Size = new Size(344, 38);
            rectangleBlue1.TabIndex = 46;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(43, 121, 223);
            lblUsername.Location = new Point(400, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 23);
            lblUsername.TabIndex = 45;
            lblUsername.Text = "Hostname";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = SystemColors.Window;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.FromArgb(43, 121, 223);
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 20;
            btnExit.Location = new Point(767, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 20);
            btnExit.TabIndex = 47;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRestore
            // 
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatAppearance.MouseDownBackColor = Color.White;
            btnRestore.FlatAppearance.MouseOverBackColor = Color.White;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnRestore.IconColor = Color.FromArgb(43, 121, 223);
            btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRestore.IconSize = 100;
            btnRestore.Location = new Point(570, 401);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(100, 100);
            btnRestore.TabIndex = 48;
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 121, 223);
            label1.Location = new Point(420, 439);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 49;
            label1.Text = "Restore Database";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 500);
            panel1.TabIndex = 50;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11.7F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(409, 121);
            txtUsername.Margin = new Padding(5, 3, 3, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(333, 26);
            txtUsername.TabIndex = 51;
            // 
            // rectangleBlue2
            // 
            rectangleBlue2.Location = new Point(402, 116);
            rectangleBlue2.Name = "rectangleBlue2";
            rectangleBlue2.Size = new Size(344, 38);
            rectangleBlue2.TabIndex = 53;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.FromArgb(43, 121, 223);
            Username.Location = new Point(401, 88);
            Username.Name = "Username";
            Username.Size = new Size(87, 23);
            Username.TabIndex = 52;
            Username.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11.7F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(408, 197);
            txtPassword.Margin = new Padding(5, 3, 3, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(333, 26);
            txtPassword.TabIndex = 54;
            // 
            // rectangleBlue3
            // 
            rectangleBlue3.Location = new Point(401, 192);
            rectangleBlue3.Name = "rectangleBlue3";
            rectangleBlue3.Size = new Size(344, 38);
            rectangleBlue3.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(43, 121, 223);
            label3.Location = new Point(400, 164);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 55;
            label3.Text = "Password";
            // 
            // txtDatabase
            // 
            txtDatabase.BorderStyle = BorderStyle.None;
            txtDatabase.Font = new Font("Segoe UI", 11.7F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatabase.Location = new Point(409, 275);
            txtDatabase.Margin = new Padding(5, 3, 3, 3);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(333, 26);
            txtDatabase.TabIndex = 57;
            // 
            // rectangleBlue4
            // 
            rectangleBlue4.Location = new Point(402, 270);
            rectangleBlue4.Name = "rectangleBlue4";
            rectangleBlue4.Size = new Size(344, 38);
            rectangleBlue4.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(43, 121, 223);
            label4.Location = new Point(401, 242);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 58;
            label4.Text = "Database";
            // 
            // SystemConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(txtDatabase);
            Controls.Add(rectangleBlue4);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(rectangleBlue3);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(rectangleBlue2);
            Controls.Add(Username);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnRestore);
            Controls.Add(btnExit);
            Controls.Add(txtServerAddress);
            Controls.Add(rectangleBlue1);
            Controls.Add(lblUsername);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SystemConfig";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SystemConfig";
            Load += SystemConfig_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}