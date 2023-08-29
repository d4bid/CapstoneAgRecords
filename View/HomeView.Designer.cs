namespace AgRecords.View
{
    partial class HomeView
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
            panelMenu = new Panel();
            btnUsers = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnRSBSA = new FontAwesome.Sharp.IconButton();
            btnDashoard = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnHome = new PictureBox();
            btnMenu = new FontAwesome.Sharp.IconButton();
            panelTitleBar = new Panel();
            picUserPhoto = new RoundedPictureBox();
            btnMin = new FontAwesome.Sharp.IconButton();
            btnMax = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            lblUserRole = new Label();
            lblUserName = new Label();
            lblTitle = new Label();
            panel1 = new Panel();
            panelDesktop = new Panel();
            pbLogo = new PictureBox();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserPhoto).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(16, 133, 117);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(btnRSBSA);
            panelMenu.Controls.Add(btnDashoard);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(284, 640);
            panelMenu.TabIndex = 0;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.ForeColor = Color.White;
            btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsers.IconColor = Color.White;
            btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsers.IconSize = 32;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 308);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(11, 0, 0, 0);
            btnUsers.Size = new Size(284, 56);
            btnUsers.TabIndex = 12;
            btnUsers.Tag = "Users";
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogout.IconColor = Color.White;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 32;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 584);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(11, 0, 0, 0);
            btnLogout.Size = new Size(284, 56);
            btnLogout.TabIndex = 11;
            btnLogout.Tag = "Logout";
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.WheatAwn;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 252);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(11, 0, 0, 0);
            iconButton2.Size = new Size(284, 56);
            iconButton2.TabIndex = 10;
            iconButton2.Tag = "Crops";
            iconButton2.Text = "Crops";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // btnRSBSA
            // 
            btnRSBSA.Dock = DockStyle.Top;
            btnRSBSA.FlatAppearance.BorderSize = 0;
            btnRSBSA.FlatStyle = FlatStyle.Flat;
            btnRSBSA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRSBSA.ForeColor = Color.White;
            btnRSBSA.IconChar = FontAwesome.Sharp.IconChar.File;
            btnRSBSA.IconColor = Color.White;
            btnRSBSA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRSBSA.IconSize = 32;
            btnRSBSA.ImageAlign = ContentAlignment.MiddleLeft;
            btnRSBSA.Location = new Point(0, 196);
            btnRSBSA.Name = "btnRSBSA";
            btnRSBSA.Padding = new Padding(11, 0, 0, 0);
            btnRSBSA.Size = new Size(284, 56);
            btnRSBSA.TabIndex = 9;
            btnRSBSA.Tag = "RSBSA";
            btnRSBSA.Text = "RSBSA";
            btnRSBSA.TextAlign = ContentAlignment.MiddleLeft;
            btnRSBSA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRSBSA.UseVisualStyleBackColor = true;
            // 
            // btnDashoard
            // 
            btnDashoard.Dock = DockStyle.Top;
            btnDashoard.FlatAppearance.BorderSize = 0;
            btnDashoard.FlatStyle = FlatStyle.Flat;
            btnDashoard.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashoard.ForeColor = Color.White;
            btnDashoard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnDashoard.IconColor = Color.White;
            btnDashoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashoard.IconSize = 32;
            btnDashoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashoard.Location = new Point(0, 140);
            btnDashoard.Name = "btnDashoard";
            btnDashoard.Padding = new Padding(11, 0, 0, 0);
            btnDashoard.Size = new Size(284, 56);
            btnDashoard.TabIndex = 8;
            btnDashoard.Tag = "Dashboard";
            btnDashoard.Text = "Dashboard";
            btnDashoard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashoard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(btnMenu);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 140);
            panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackgroundImage = Properties.Resources.logo2;
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Location = new Point(35, 17);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(188, 107);
            btnHome.TabIndex = 2;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            btnMenu.IconColor = Color.FromArgb(224, 236, 222);
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 30;
            btnMenu.Location = new Point(234, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(46, 45);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.White;
            panelTitleBar.Controls.Add(picUserPhoto);
            panelTitleBar.Controls.Add(btnMin);
            panelTitleBar.Controls.Add(btnMax);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblUserRole);
            panelTitleBar.Controls.Add(lblUserName);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(284, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1100, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // picUserPhoto
            // 
            picUserPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picUserPhoto.BackgroundImage = Properties.Resources.profile;
            picUserPhoto.BackgroundImageLayout = ImageLayout.Zoom;
            picUserPhoto.BorderStyle = BorderStyle.FixedSingle;
            picUserPhoto.Location = new Point(874, 23);
            picUserPhoto.Margin = new Padding(3, 2, 3, 2);
            picUserPhoto.Name = "picUserPhoto";
            picUserPhoto.Size = new Size(48, 42);
            picUserPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picUserPhoto.TabIndex = 26;
            picUserPhoto.TabStop = false;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.White;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMin.IconColor = Color.FromArgb(16, 133, 117);
            btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMin.IconSize = 15;
            btnMin.Location = new Point(978, 3);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(40, 14);
            btnMin.TabIndex = 25;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.White;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMax.IconColor = Color.FromArgb(16, 133, 117);
            btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMax.IconSize = 15;
            btnMax.Location = new Point(1016, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(40, 14);
            btnMax.TabIndex = 24;
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.FromArgb(16, 133, 117);
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 15;
            btnExit.Location = new Point(1058, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 14);
            btnExit.TabIndex = 23;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblUserRole
            // 
            lblUserRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Century Gothic", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblUserRole.ForeColor = Color.FromArgb(5, 93, 96);
            lblUserRole.Location = new Point(934, 46);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(40, 15);
            lblUserRole.TabIndex = 22;
            lblUserRole.Text = "label1";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.FromArgb(5, 93, 96);
            lblUserName.Location = new Point(934, 30);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(44, 16);
            lblUserName.TabIndex = 21;
            lblUserName.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(148, 145, 145);
            lblTitle.Location = new Point(16, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(56, 19);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Home";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(284, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 5);
            panel1.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(240, 241, 242);
            panelDesktop.Controls.Add(pbLogo);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(284, 85);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1100, 555);
            panelDesktop.TabIndex = 3;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.BackgroundImage = Properties.Resources.logo2;
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.Location = new Point(374, 127);
            pbLogo.Margin = new Padding(3, 2, 3, 2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(350, 300);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 640);
            Controls.Add(panelDesktop);
            Controls.Add(panel1);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "HomeView";
            Text = "HomeView";
            Load += HomeView_Load;
            Resize += HomeView_Resize;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserPhoto).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitleBar;
        public FontAwesome.Sharp.IconButton btnDashoard;
        private Panel panel2;
        private Panel panel1;
        public FontAwesome.Sharp.IconButton btnLogout;
        public FontAwesome.Sharp.IconButton iconButton2;
        public FontAwesome.Sharp.IconButton btnRSBSA;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnExit;
        private Label lblUserRole;
        private Label lblUserName;
        private Label lblTitle;
        private RoundedPictureBox picUserPhoto;
        private FontAwesome.Sharp.IconButton btnMenu;
        private PictureBox btnHome;
        private Panel panelDesktop;
        private PictureBox pbLogo;
        public FontAwesome.Sharp.IconButton btnUsers;
    }
}