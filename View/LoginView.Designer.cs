namespace AgRecords
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLeft = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            panelRight = new Panel();
            btnShowPass = new FontAwesome.Sharp.IconButton();
            btnHidePass = new FontAwesome.Sharp.IconButton();
            systemLogo = new FontAwesome.Sharp.IconPictureBox();
            lblError = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            panelPassword = new Panel();
            panelUsername = new Panel();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnMin = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)systemLogo).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Controls.Add(label3);
            panelLeft.Controls.Add(iconPictureBox1);
            panelLeft.Controls.Add(label4);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(386, 500);
            panelLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logoSolano;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(54, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(43, 121, 223);
            label3.Location = new Point(40, 10);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 43;
            label3.Text = "AgRecords";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 108, 103);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WheatAwn;
            iconPictureBox1.IconColor = Color.FromArgb(0, 108, 103);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 28;
            iconPictureBox1.Location = new Point(7, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(28, 28);
            iconPictureBox1.TabIndex = 43;
            iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(148, 145, 145);
            label4.Location = new Point(7, 477);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 13;
            label4.Text = "Version 1.0";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(btnShowPass);
            panelRight.Controls.Add(btnHidePass);
            panelRight.Controls.Add(systemLogo);
            panelRight.Controls.Add(lblError);
            panelRight.Controls.Add(label2);
            panelRight.Controls.Add(label1);
            panelRight.Controls.Add(btnLogin);
            panelRight.Controls.Add(panelPassword);
            panelRight.Controls.Add(panelUsername);
            panelRight.Controls.Add(lblPassword);
            panelRight.Controls.Add(lblUsername);
            panelRight.Controls.Add(txtPassword);
            panelRight.Controls.Add(txtUsername);
            panelRight.Controls.Add(btnMin);
            panelRight.Controls.Add(btnExit);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(387, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(413, 500);
            panelRight.TabIndex = 1;
            // 
            // btnShowPass
            // 
            btnShowPass.FlatAppearance.BorderSize = 0;
            btnShowPass.FlatAppearance.MouseDownBackColor = Color.White;
            btnShowPass.FlatAppearance.MouseOverBackColor = Color.White;
            btnShowPass.FlatStyle = FlatStyle.Flat;
            btnShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnShowPass.IconColor = Color.FromArgb(43, 121, 223);
            btnShowPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShowPass.IconSize = 30;
            btnShowPass.Location = new Point(339, 308);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(25, 20);
            btnShowPass.TabIndex = 42;
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // btnHidePass
            // 
            btnHidePass.FlatAppearance.BorderSize = 0;
            btnHidePass.FlatAppearance.MouseDownBackColor = Color.White;
            btnHidePass.FlatAppearance.MouseOverBackColor = Color.White;
            btnHidePass.FlatStyle = FlatStyle.Flat;
            btnHidePass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnHidePass.IconColor = Color.FromArgb(43, 121, 223);
            btnHidePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHidePass.IconSize = 30;
            btnHidePass.Location = new Point(339, 308);
            btnHidePass.Name = "btnHidePass";
            btnHidePass.Size = new Size(25, 20);
            btnHidePass.TabIndex = 41;
            btnHidePass.UseVisualStyleBackColor = true;
            btnHidePass.Click += btnHidePass_Click;
            // 
            // systemLogo
            // 
            systemLogo.BackColor = Color.White;
            systemLogo.ForeColor = Color.FromArgb(0, 108, 103);
            systemLogo.IconChar = FontAwesome.Sharp.IconChar.WheatAwn;
            systemLogo.IconColor = Color.FromArgb(0, 108, 103);
            systemLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            systemLogo.Location = new Point(202, 78);
            systemLogo.Name = "systemLogo";
            systemLogo.Size = new Size(32, 32);
            systemLogo.TabIndex = 40;
            systemLogo.TabStop = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.FromArgb(207, 92, 96);
            lblError.ImageAlign = ContentAlignment.MiddleLeft;
            lblError.Location = new Point(46, 343);
            lblError.Name = "lblError";
            lblError.Size = new Size(225, 23);
            lblError.TabIndex = 39;
            lblError.Text = "Incorrect username or password.";
            lblError.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(43, 121, 223);
            label2.Location = new Point(143, 147);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 38;
            label2.Text = "Login to your account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 121, 223);
            label1.Location = new Point(169, 115);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 37;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(43, 121, 223);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(46, 385);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(323, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panelPassword
            // 
            panelPassword.Location = new Point(48, 336);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(296, 4);
            panelPassword.TabIndex = 35;
            // 
            // panelUsername
            // 
            panelUsername.Location = new Point(48, 255);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(296, 4);
            panelUsername.TabIndex = 34;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.FromArgb(43, 121, 223);
            lblPassword.Location = new Point(45, 274);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 24);
            lblPassword.TabIndex = 33;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(43, 121, 223);
            lblUsername.Location = new Point(45, 193);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 24);
            lblUsername.TabIndex = 32;
            lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(48, 303);
            txtPassword.Margin = new Padding(5, 3, 3, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(321, 28);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(48, 222);
            txtUsername.Margin = new Padding(5, 3, 3, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(321, 28);
            txtUsername.TabIndex = 1;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = SystemColors.Window;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMin.IconColor = Color.FromArgb(43, 121, 223);
            btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMin.IconSize = 15;
            btnMin.Location = new Point(345, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(30, 20);
            btnMin.TabIndex = 16;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
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
            btnExit.IconSize = 15;
            btnExit.Location = new Point(378, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 20);
            btnExit.TabIndex = 15;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LoginView
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)systemLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnExit;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnShowPass;
        private FontAwesome.Sharp.IconButton btnHidePass;
        private FontAwesome.Sharp.IconPictureBox systemLogo;
        private Label lblError;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private Panel panelPassword;
        private Panel panelUsername;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private PictureBox pictureBox1;
    }
}