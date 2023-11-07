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
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            panelSettingsSubMenu = new Panel();
            btnBackupRestore = new FontAwesome.Sharp.IconButton();
            btnSettingsAudit = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnUsers = new FontAwesome.Sharp.IconButton();
            btnActivities = new FontAwesome.Sharp.IconButton();
            panelReportsSubMenu = new Panel();
            btnReportsHVC = new FontAwesome.Sharp.IconButton();
            btnReportsRice = new FontAwesome.Sharp.IconButton();
            btnReportsCorn = new FontAwesome.Sharp.IconButton();
            btnReportsRsbsa = new FontAwesome.Sharp.IconButton();
            btnReports = new FontAwesome.Sharp.IconButton();
            btnCertifications = new FontAwesome.Sharp.IconButton();
            btnLetters = new FontAwesome.Sharp.IconButton();
            panelCropsSubMenu = new Panel();
            btnVegetable = new FontAwesome.Sharp.IconButton();
            btnCorn = new FontAwesome.Sharp.IconButton();
            btnRice = new FontAwesome.Sharp.IconButton();
            btnCrops = new FontAwesome.Sharp.IconButton();
            btnRSBSA = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnDashoard = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnHome = new PictureBox();
            btnMenu = new FontAwesome.Sharp.IconButton();
            panelTitleBar = new Panel();
            lblUsername = new Label();
            picUserPhoto = new RoundedPictureBox();
            btnMin = new FontAwesome.Sharp.IconButton();
            btnMax = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            lblUserRole = new Label();
            lblFullname = new Label();
            lblTitle = new Label();
            panelDesktop = new Panel();
            toolTip1 = new ToolTip(components);
            panelMenu.SuspendLayout();
            panelSettingsSubMenu.SuspendLayout();
            panelReportsSubMenu.SuspendLayout();
            panelCropsSubMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserPhoto).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(43, 121, 223);
            panelMenu.Controls.Add(panelSettingsSubMenu);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnActivities);
            panelMenu.Controls.Add(panelReportsSubMenu);
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnCertifications);
            panelMenu.Controls.Add(btnLetters);
            panelMenu.Controls.Add(panelCropsSubMenu);
            panelMenu.Controls.Add(btnCrops);
            panelMenu.Controls.Add(btnRSBSA);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnDashoard);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(320, 753);
            panelMenu.TabIndex = 0;
            // 
            // panelSettingsSubMenu
            // 
            panelSettingsSubMenu.BackColor = Color.FromArgb(38, 109, 200);
            panelSettingsSubMenu.Controls.Add(btnBackupRestore);
            panelSettingsSubMenu.Controls.Add(btnSettingsAudit);
            panelSettingsSubMenu.Dock = DockStyle.Top;
            panelSettingsSubMenu.Location = new Point(0, 1042);
            panelSettingsSubMenu.Name = "panelSettingsSubMenu";
            panelSettingsSubMenu.Size = new Size(299, 102);
            panelSettingsSubMenu.TabIndex = 24;
            // 
            // btnBackupRestore
            // 
            btnBackupRestore.Dock = DockStyle.Top;
            btnBackupRestore.FlatAppearance.BorderSize = 0;
            btnBackupRestore.FlatStyle = FlatStyle.Flat;
            btnBackupRestore.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackupRestore.ForeColor = Color.White;
            btnBackupRestore.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBackupRestore.IconColor = Color.White;
            btnBackupRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBackupRestore.IconSize = 32;
            btnBackupRestore.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackupRestore.Location = new Point(0, 51);
            btnBackupRestore.Margin = new Padding(3, 4, 3, 4);
            btnBackupRestore.Name = "btnBackupRestore";
            btnBackupRestore.Padding = new Padding(40, 0, 0, 0);
            btnBackupRestore.Size = new Size(299, 51);
            btnBackupRestore.TabIndex = 17;
            btnBackupRestore.Tag = "Backup & Restore";
            btnBackupRestore.Text = "Backup and Restore";
            btnBackupRestore.TextAlign = ContentAlignment.MiddleLeft;
            btnBackupRestore.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBackupRestore.UseVisualStyleBackColor = true;
            btnBackupRestore.Click += btnBackupRestore_Click;
            // 
            // btnSettingsAudit
            // 
            btnSettingsAudit.Dock = DockStyle.Top;
            btnSettingsAudit.FlatAppearance.BorderSize = 0;
            btnSettingsAudit.FlatStyle = FlatStyle.Flat;
            btnSettingsAudit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettingsAudit.ForeColor = Color.White;
            btnSettingsAudit.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSettingsAudit.IconColor = Color.White;
            btnSettingsAudit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettingsAudit.IconSize = 32;
            btnSettingsAudit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettingsAudit.Location = new Point(0, 0);
            btnSettingsAudit.Margin = new Padding(3, 4, 3, 4);
            btnSettingsAudit.Name = "btnSettingsAudit";
            btnSettingsAudit.Padding = new Padding(40, 0, 0, 0);
            btnSettingsAudit.Size = new Size(299, 51);
            btnSettingsAudit.TabIndex = 16;
            btnSettingsAudit.Tag = "Audit Logs";
            btnSettingsAudit.Text = "Audit Logs";
            btnSettingsAudit.TextAlign = ContentAlignment.MiddleLeft;
            btnSettingsAudit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettingsAudit.UseVisualStyleBackColor = true;
            btnSettingsAudit.Click += btnSettingsAudit_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 109, 200);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            btnSettings.IconColor = Color.White;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 32;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 982);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(13, 0, 0, 0);
            btnSettings.Size = new Size(299, 60);
            btnSettings.TabIndex = 23;
            btnSettings.Tag = "Settings";
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 109, 200);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsers.ForeColor = Color.White;
            btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsers.IconColor = Color.White;
            btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsers.IconSize = 32;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 922);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(13, 0, 0, 0);
            btnUsers.Size = new Size(299, 60);
            btnUsers.TabIndex = 16;
            btnUsers.Tag = "Users";
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnActivities
            // 
            btnActivities.Dock = DockStyle.Top;
            btnActivities.FlatAppearance.BorderSize = 0;
            btnActivities.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 109, 200);
            btnActivities.FlatStyle = FlatStyle.Flat;
            btnActivities.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnActivities.ForeColor = Color.White;
            btnActivities.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            btnActivities.IconColor = Color.White;
            btnActivities.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActivities.IconSize = 32;
            btnActivities.ImageAlign = ContentAlignment.MiddleLeft;
            btnActivities.Location = new Point(0, 862);
            btnActivities.Margin = new Padding(3, 4, 3, 4);
            btnActivities.Name = "btnActivities";
            btnActivities.Padding = new Padding(13, 0, 0, 0);
            btnActivities.Size = new Size(299, 60);
            btnActivities.TabIndex = 21;
            btnActivities.Tag = "Weekly Activities";
            btnActivities.Text = "Weekly Activities";
            btnActivities.TextAlign = ContentAlignment.MiddleLeft;
            btnActivities.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActivities.UseVisualStyleBackColor = true;
            btnActivities.Click += btnActivities_Click;
            // 
            // panelReportsSubMenu
            // 
            panelReportsSubMenu.BackColor = Color.FromArgb(38, 109, 200);
            panelReportsSubMenu.Controls.Add(btnReportsHVC);
            panelReportsSubMenu.Controls.Add(btnReportsRice);
            panelReportsSubMenu.Controls.Add(btnReportsCorn);
            panelReportsSubMenu.Controls.Add(btnReportsRsbsa);
            panelReportsSubMenu.Dock = DockStyle.Top;
            panelReportsSubMenu.Location = new Point(0, 658);
            panelReportsSubMenu.Name = "panelReportsSubMenu";
            panelReportsSubMenu.Size = new Size(299, 204);
            panelReportsSubMenu.TabIndex = 20;
            // 
            // btnReportsHVC
            // 
            btnReportsHVC.Dock = DockStyle.Top;
            btnReportsHVC.FlatAppearance.BorderSize = 0;
            btnReportsHVC.FlatStyle = FlatStyle.Flat;
            btnReportsHVC.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportsHVC.ForeColor = Color.White;
            btnReportsHVC.IconChar = FontAwesome.Sharp.IconChar.None;
            btnReportsHVC.IconColor = Color.White;
            btnReportsHVC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportsHVC.IconSize = 32;
            btnReportsHVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportsHVC.Location = new Point(0, 153);
            btnReportsHVC.Margin = new Padding(3, 4, 3, 4);
            btnReportsHVC.Name = "btnReportsHVC";
            btnReportsHVC.Padding = new Padding(40, 0, 0, 0);
            btnReportsHVC.Size = new Size(299, 51);
            btnReportsHVC.TabIndex = 19;
            btnReportsHVC.Tag = "HVC";
            btnReportsHVC.Text = "HVC";
            btnReportsHVC.TextAlign = ContentAlignment.MiddleLeft;
            btnReportsHVC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportsHVC.UseVisualStyleBackColor = true;
            btnReportsHVC.Click += btnReportsHVC_Click;
            // 
            // btnReportsRice
            // 
            btnReportsRice.Dock = DockStyle.Top;
            btnReportsRice.FlatAppearance.BorderSize = 0;
            btnReportsRice.FlatStyle = FlatStyle.Flat;
            btnReportsRice.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportsRice.ForeColor = Color.White;
            btnReportsRice.IconChar = FontAwesome.Sharp.IconChar.None;
            btnReportsRice.IconColor = Color.White;
            btnReportsRice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportsRice.IconSize = 32;
            btnReportsRice.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportsRice.Location = new Point(0, 102);
            btnReportsRice.Margin = new Padding(3, 4, 3, 4);
            btnReportsRice.Name = "btnReportsRice";
            btnReportsRice.Padding = new Padding(40, 0, 0, 0);
            btnReportsRice.Size = new Size(299, 51);
            btnReportsRice.TabIndex = 18;
            btnReportsRice.Tag = "Corn";
            btnReportsRice.Text = "Corn";
            btnReportsRice.TextAlign = ContentAlignment.MiddleLeft;
            btnReportsRice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportsRice.UseVisualStyleBackColor = true;
            btnReportsRice.Click += btnReportsRice_Click;
            // 
            // btnReportsCorn
            // 
            btnReportsCorn.Dock = DockStyle.Top;
            btnReportsCorn.FlatAppearance.BorderSize = 0;
            btnReportsCorn.FlatStyle = FlatStyle.Flat;
            btnReportsCorn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportsCorn.ForeColor = Color.White;
            btnReportsCorn.IconChar = FontAwesome.Sharp.IconChar.None;
            btnReportsCorn.IconColor = Color.White;
            btnReportsCorn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportsCorn.IconSize = 32;
            btnReportsCorn.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportsCorn.Location = new Point(0, 51);
            btnReportsCorn.Margin = new Padding(3, 4, 3, 4);
            btnReportsCorn.Name = "btnReportsCorn";
            btnReportsCorn.Padding = new Padding(40, 0, 0, 0);
            btnReportsCorn.Size = new Size(299, 51);
            btnReportsCorn.TabIndex = 17;
            btnReportsCorn.Tag = "Rice";
            btnReportsCorn.Text = "Rice";
            btnReportsCorn.TextAlign = ContentAlignment.MiddleLeft;
            btnReportsCorn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportsCorn.UseVisualStyleBackColor = true;
            btnReportsCorn.Click += btnReportsCorn_Click;
            // 
            // btnReportsRsbsa
            // 
            btnReportsRsbsa.Dock = DockStyle.Top;
            btnReportsRsbsa.FlatAppearance.BorderSize = 0;
            btnReportsRsbsa.FlatStyle = FlatStyle.Flat;
            btnReportsRsbsa.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportsRsbsa.ForeColor = Color.White;
            btnReportsRsbsa.IconChar = FontAwesome.Sharp.IconChar.None;
            btnReportsRsbsa.IconColor = Color.White;
            btnReportsRsbsa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportsRsbsa.IconSize = 32;
            btnReportsRsbsa.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportsRsbsa.Location = new Point(0, 0);
            btnReportsRsbsa.Margin = new Padding(3, 4, 3, 4);
            btnReportsRsbsa.Name = "btnReportsRsbsa";
            btnReportsRsbsa.Padding = new Padding(40, 0, 0, 0);
            btnReportsRsbsa.Size = new Size(299, 51);
            btnReportsRsbsa.TabIndex = 16;
            btnReportsRsbsa.Tag = "RSBSA";
            btnReportsRsbsa.Text = "RSBSA";
            btnReportsRsbsa.TextAlign = ContentAlignment.MiddleLeft;
            btnReportsRsbsa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportsRsbsa.UseVisualStyleBackColor = true;
            btnReportsRsbsa.Click += btnReportsRsbsa_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 109, 200);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = Color.White;
            btnReports.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnReports.IconColor = Color.White;
            btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReports.IconSize = 32;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 598);
            btnReports.Margin = new Padding(3, 4, 3, 4);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(13, 0, 0, 0);
            btnReports.Size = new Size(299, 60);
            btnReports.TabIndex = 19;
            btnReports.Tag = "Analytics";
            btnReports.Text = "Analytics";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnCertifications
            // 
            btnCertifications.Dock = DockStyle.Top;
            btnCertifications.FlatAppearance.BorderSize = 0;
            btnCertifications.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 109, 200);
            btnCertifications.FlatStyle = FlatStyle.Flat;
            btnCertifications.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCertifications.ForeColor = Color.White;
            btnCertifications.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            btnCertifications.IconColor = Color.White;
            btnCertifications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCertifications.IconSize = 32;
            btnCertifications.ImageAlign = ContentAlignment.MiddleLeft;
            btnCertifications.Location = new Point(0, 538);
            btnCertifications.Margin = new Padding(3, 4, 3, 4);
            btnCertifications.Name = "btnCertifications";
            btnCertifications.Padding = new Padding(13, 0, 0, 0);
            btnCertifications.Size = new Size(299, 60);
            btnCertifications.TabIndex = 22;
            btnCertifications.Tag = "Certifications";
            btnCertifications.Text = "Certifications";
            btnCertifications.TextAlign = ContentAlignment.MiddleLeft;
            btnCertifications.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCertifications.UseVisualStyleBackColor = true;
            btnCertifications.Click += btnCertifications_Click;
            // 
            // btnLetters
            // 
            btnLetters.Dock = DockStyle.Top;
            btnLetters.FlatAppearance.BorderSize = 0;
            btnLetters.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 109, 200);
            btnLetters.FlatStyle = FlatStyle.Flat;
            btnLetters.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLetters.ForeColor = Color.White;
            btnLetters.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            btnLetters.IconColor = Color.White;
            btnLetters.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLetters.IconSize = 32;
            btnLetters.ImageAlign = ContentAlignment.MiddleLeft;
            btnLetters.Location = new Point(0, 478);
            btnLetters.Margin = new Padding(3, 4, 3, 4);
            btnLetters.Name = "btnLetters";
            btnLetters.Padding = new Padding(13, 0, 0, 0);
            btnLetters.Size = new Size(299, 60);
            btnLetters.TabIndex = 17;
            btnLetters.Tag = "Letters";
            btnLetters.Text = "Letters";
            btnLetters.TextAlign = ContentAlignment.MiddleLeft;
            btnLetters.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLetters.UseVisualStyleBackColor = true;
            btnLetters.Click += btnLetters_Click;
            // 
            // panelCropsSubMenu
            // 
            panelCropsSubMenu.BackColor = Color.FromArgb(38, 109, 200);
            panelCropsSubMenu.Controls.Add(btnVegetable);
            panelCropsSubMenu.Controls.Add(btnCorn);
            panelCropsSubMenu.Controls.Add(btnRice);
            panelCropsSubMenu.Dock = DockStyle.Top;
            panelCropsSubMenu.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panelCropsSubMenu.Location = new Point(0, 329);
            panelCropsSubMenu.Name = "panelCropsSubMenu";
            panelCropsSubMenu.Size = new Size(299, 149);
            panelCropsSubMenu.TabIndex = 15;
            // 
            // btnVegetable
            // 
            btnVegetable.Dock = DockStyle.Top;
            btnVegetable.FlatAppearance.BorderSize = 0;
            btnVegetable.FlatStyle = FlatStyle.Flat;
            btnVegetable.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVegetable.ForeColor = Color.White;
            btnVegetable.IconChar = FontAwesome.Sharp.IconChar.None;
            btnVegetable.IconColor = Color.White;
            btnVegetable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVegetable.IconSize = 32;
            btnVegetable.ImageAlign = ContentAlignment.MiddleLeft;
            btnVegetable.Location = new Point(0, 102);
            btnVegetable.Margin = new Padding(3, 4, 3, 4);
            btnVegetable.Name = "btnVegetable";
            btnVegetable.Padding = new Padding(40, 0, 0, 0);
            btnVegetable.Size = new Size(299, 51);
            btnVegetable.TabIndex = 17;
            btnVegetable.Tag = "HVC";
            btnVegetable.Text = "HVC";
            btnVegetable.TextAlign = ContentAlignment.MiddleLeft;
            btnVegetable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVegetable.UseVisualStyleBackColor = true;
            btnVegetable.Click += btnVegetable_Click;
            // 
            // btnCorn
            // 
            btnCorn.Dock = DockStyle.Top;
            btnCorn.FlatAppearance.BorderSize = 0;
            btnCorn.FlatStyle = FlatStyle.Flat;
            btnCorn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCorn.ForeColor = Color.White;
            btnCorn.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCorn.IconColor = Color.White;
            btnCorn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCorn.IconSize = 32;
            btnCorn.ImageAlign = ContentAlignment.MiddleLeft;
            btnCorn.Location = new Point(0, 51);
            btnCorn.Margin = new Padding(3, 4, 3, 4);
            btnCorn.Name = "btnCorn";
            btnCorn.Padding = new Padding(40, 0, 0, 0);
            btnCorn.Size = new Size(299, 51);
            btnCorn.TabIndex = 16;
            btnCorn.Tag = "Corn";
            btnCorn.Text = "Corn";
            btnCorn.TextAlign = ContentAlignment.MiddleLeft;
            btnCorn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCorn.UseVisualStyleBackColor = true;
            btnCorn.Click += btnCorn_Click;
            // 
            // btnRice
            // 
            btnRice.Dock = DockStyle.Top;
            btnRice.FlatAppearance.BorderSize = 0;
            btnRice.FlatStyle = FlatStyle.Flat;
            btnRice.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRice.ForeColor = Color.White;
            btnRice.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRice.IconColor = Color.White;
            btnRice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRice.IconSize = 32;
            btnRice.ImageAlign = ContentAlignment.MiddleLeft;
            btnRice.Location = new Point(0, 0);
            btnRice.Margin = new Padding(3, 4, 3, 4);
            btnRice.Name = "btnRice";
            btnRice.Padding = new Padding(40, 0, 0, 0);
            btnRice.Size = new Size(299, 51);
            btnRice.TabIndex = 15;
            btnRice.Tag = "Rice";
            btnRice.Text = "Rice";
            btnRice.TextAlign = ContentAlignment.MiddleLeft;
            btnRice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRice.UseVisualStyleBackColor = true;
            btnRice.Click += btnRice_Click;
            // 
            // btnCrops
            // 
            btnCrops.Dock = DockStyle.Top;
            btnCrops.FlatAppearance.BorderSize = 0;
            btnCrops.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 109, 200);
            btnCrops.FlatStyle = FlatStyle.Flat;
            btnCrops.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrops.ForeColor = Color.White;
            btnCrops.IconChar = FontAwesome.Sharp.IconChar.WheatAwn;
            btnCrops.IconColor = Color.White;
            btnCrops.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrops.IconSize = 32;
            btnCrops.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrops.Location = new Point(0, 269);
            btnCrops.Margin = new Padding(3, 4, 3, 4);
            btnCrops.Name = "btnCrops";
            btnCrops.Padding = new Padding(13, 0, 0, 0);
            btnCrops.Size = new Size(299, 60);
            btnCrops.TabIndex = 14;
            btnCrops.Tag = "Crops";
            btnCrops.Text = "Crops";
            btnCrops.TextAlign = ContentAlignment.MiddleLeft;
            btnCrops.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrops.UseVisualStyleBackColor = true;
            btnCrops.Click += btnCrops_Click;
            // 
            // btnRSBSA
            // 
            btnRSBSA.Dock = DockStyle.Top;
            btnRSBSA.FlatAppearance.BorderSize = 0;
            btnRSBSA.FlatStyle = FlatStyle.Flat;
            btnRSBSA.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRSBSA.ForeColor = Color.White;
            btnRSBSA.IconChar = FontAwesome.Sharp.IconChar.File;
            btnRSBSA.IconColor = Color.White;
            btnRSBSA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRSBSA.IconSize = 32;
            btnRSBSA.ImageAlign = ContentAlignment.MiddleLeft;
            btnRSBSA.Location = new Point(0, 209);
            btnRSBSA.Margin = new Padding(3, 4, 3, 4);
            btnRSBSA.Name = "btnRSBSA";
            btnRSBSA.Padding = new Padding(13, 0, 0, 0);
            btnRSBSA.Size = new Size(299, 60);
            btnRSBSA.TabIndex = 13;
            btnRSBSA.Tag = "RSBSA";
            btnRSBSA.Text = "RSBSA";
            btnRSBSA.TextAlign = ContentAlignment.MiddleLeft;
            btnRSBSA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRSBSA.UseVisualStyleBackColor = true;
            btnRSBSA.Click += btnRSBSA_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogout.IconColor = Color.White;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 32;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 1144);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(13, 0, 0, 0);
            btnLogout.Size = new Size(299, 75);
            btnLogout.TabIndex = 11;
            btnLogout.Tag = "Logout";
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDashoard
            // 
            btnDashoard.Dock = DockStyle.Top;
            btnDashoard.FlatAppearance.BorderSize = 0;
            btnDashoard.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 109, 200);
            btnDashoard.FlatStyle = FlatStyle.Flat;
            btnDashoard.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashoard.ForeColor = Color.White;
            btnDashoard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnDashoard.IconColor = Color.White;
            btnDashoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashoard.IconSize = 32;
            btnDashoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashoard.Location = new Point(0, 149);
            btnDashoard.Margin = new Padding(3, 4, 3, 4);
            btnDashoard.Name = "btnDashoard";
            btnDashoard.Padding = new Padding(13, 0, 0, 0);
            btnDashoard.Size = new Size(299, 60);
            btnDashoard.TabIndex = 8;
            btnDashoard.Tag = "Dashboard";
            btnDashoard.Text = "Dashboard";
            btnDashoard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashoard.UseVisualStyleBackColor = true;
            btnDashoard.Click += btnDashoard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(btnMenu);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 149);
            panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackgroundImage = Properties.Resources.tempLogo6;
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Location = new Point(60, 13);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(181, 119);
            btnHome.TabIndex = 2;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 109, 200);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            btnMenu.IconColor = Color.FromArgb(224, 236, 222);
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 30;
            btnMenu.Location = new Point(266, 4);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(53, 60);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.White;
            panelTitleBar.Controls.Add(lblUsername);
            panelTitleBar.Controls.Add(picUserPhoto);
            panelTitleBar.Controls.Add(btnMin);
            panelTitleBar.Controls.Add(btnMax);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblUserRole);
            panelTitleBar.Controls.Add(lblFullname);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(320, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1162, 87);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(43, 121, 223);
            lblUsername.Location = new Point(777, 13);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(62, 17);
            lblUsername.TabIndex = 27;
            lblUsername.Text = "username";
            lblUsername.Visible = false;
            // 
            // picUserPhoto
            // 
            picUserPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picUserPhoto.BackgroundImage = Properties.Resources.profile;
            picUserPhoto.BackgroundImageLayout = ImageLayout.Zoom;
            picUserPhoto.BorderStyle = BorderStyle.FixedSingle;
            picUserPhoto.Location = new Point(905, 23);
            picUserPhoto.Name = "picUserPhoto";
            picUserPhoto.Size = new Size(55, 55);
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
            btnMin.IconColor = Color.FromArgb(43, 121, 223);
            btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMin.IconSize = 15;
            btnMin.Location = new Point(1066, 7);
            btnMin.Margin = new Padding(3, 4, 3, 4);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(46, 19);
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
            btnMax.IconColor = Color.FromArgb(43, 121, 223);
            btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMax.IconSize = 15;
            btnMax.Location = new Point(845, 11);
            btnMax.Margin = new Padding(3, 4, 3, 4);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(46, 19);
            btnMax.TabIndex = 24;
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Visible = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.FromArgb(43, 121, 223);
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 15;
            btnExit.Location = new Point(1114, 7);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(46, 19);
            btnExit.TabIndex = 23;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblUserRole
            // 
            lblUserRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblUserRole.ForeColor = Color.FromArgb(43, 121, 223);
            lblUserRole.Location = new Point(975, 57);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(41, 17);
            lblUserRole.TabIndex = 22;
            lblUserRole.Text = "label1";
            // 
            // lblFullname
            // 
            lblFullname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullname.ForeColor = Color.FromArgb(43, 121, 223);
            lblFullname.Location = new Point(975, 35);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(51, 20);
            lblFullname.TabIndex = 21;
            lblFullname.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 35, 76);
            lblTitle.Location = new Point(18, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 31);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Home";
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(239, 239, 239);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(320, 87);
            panelDesktop.Margin = new Padding(3, 4, 3, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Padding = new Padding(10, 11, 15, 15);
            panelDesktop.Size = new Size(1162, 666);
            panelDesktop.TabIndex = 3;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 753);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1026, 651);
            Name = "HomeView";
            Text = "HomeView";
            WindowState = FormWindowState.Maximized;
            Load += HomeView_Load;
            Resize += HomeView_Resize;
            panelMenu.ResumeLayout(false);
            panelSettingsSubMenu.ResumeLayout(false);
            panelReportsSubMenu.ResumeLayout(false);
            panelCropsSubMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitleBar;
        public FontAwesome.Sharp.IconButton btnDashoard;
        private Panel panel2;
        public FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnExit;
        private Label lblUserRole;
        private Label lblFullname;
        private Label lblTitle;
        private RoundedPictureBox picUserPhoto;
        private FontAwesome.Sharp.IconButton btnMenu;
        private PictureBox btnHome;
        private Panel panelDesktop;
        public FontAwesome.Sharp.IconButton btnRSBSA;
        public FontAwesome.Sharp.IconButton btnCrops;
        private Panel panelCropsSubMenu;
        public FontAwesome.Sharp.IconButton btnRice;
        public FontAwesome.Sharp.IconButton btnVegetable;
        public FontAwesome.Sharp.IconButton btnCorn;
        public FontAwesome.Sharp.IconButton btnUsers;
        public FontAwesome.Sharp.IconButton btnLetters;
        public FontAwesome.Sharp.IconButton btnReports;
        private Panel panelReportsSubMenu;
        public FontAwesome.Sharp.IconButton btnReportsRsbsa;
        public FontAwesome.Sharp.IconButton btnReportsCorn;
        public FontAwesome.Sharp.IconButton btnActivities;
        public FontAwesome.Sharp.IconButton btnCertifications;
        private ToolTip toolTip1;
        private Label lblUsername;
        public FontAwesome.Sharp.IconButton btnSettings;
        public FontAwesome.Sharp.IconButton btnReportsRice;
        public FontAwesome.Sharp.IconButton btnReportsHVC;
        private Panel panelSettingsSubMenu;
        public FontAwesome.Sharp.IconButton btnBackupRestore;
        public FontAwesome.Sharp.IconButton btnSettingsAudit;
    }
}