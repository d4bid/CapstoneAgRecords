using AgRecords.Model;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AgRecords.View
{
    public partial class HomeView : Form
    {
        UserModel userModel = new UserModel();
        private int borderSize = 2;
        private Size formSize;
        private IconButton currentBtn;
        private Form currentChildForm;

        //for accessing the username of the current user
        public static HomeView Instance;
        public Label fullName;
        public Label username;
        public Label role;

        public HomeView()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //Border size
            this.BackColor = Color.FromArgb(43, 121, 223); //Border color

            SubmenuDesign();

            //for accessing the username of the current user
            Instance = this;
            fullName = lblFullname;
            username = lblUsername;
            role = lblUserRole;
        }

        //FORM STYLE

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        //Submenu
        private void SubmenuDesign()
        {
            panelCropsSubMenu.Visible = false;
            panelReportsSubMenu.Visible = false;
            panelSettingsSubMenu.Visible = false;
        }

        //Hide Submenu

        private void HideSubMenu()
        {
            if (panelCropsSubMenu.Visible == true)
                panelCropsSubMenu.Visible = false;
            if (panelReportsSubMenu.Visible == true)
                panelReportsSubMenu.Visible = false;
            if (panelSettingsSubMenu.Visible == true)
                panelSettingsSubMenu.Visible = false;
        }

        //Show Submenu

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void CollapseMenu()
        {
            //collapse menu
            if (this.panelMenu.Width > 200)
            {

                panelMenu.Width = 100;
                btnHome.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }

                HideSubMenu();
            }
            //expand menu
            else
            {
                panelMenu.Width = 300;
                btnHome.Visible = true;
                btnMenu.Dock = DockStyle.None;
                btnMenu.Location = new Point(254, 1);
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        //change color of active button
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 221, 100);
                currentBtn.ForeColor = Color.FromArgb(0, 35, 76);
                currentBtn.IconColor = Color.FromArgb(0, 35, 76);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(43, 121, 223);
                currentBtn.ForeColor = Color.FromArgb(255, 255, 255);
                currentBtn.IconColor = Color.FromArgb(255, 255, 255);
            }
        }

        //open forms on button click
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void SetUserInfo(UserAccount user)
        {
            if (user.userPhoto != null)
            {
                using (MemoryStream ms = new MemoryStream(user.userPhoto))
                {
                    picUserPhoto.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picUserPhoto.Image = null;
            }

            lblFullname.Text = user.userFirstname + " " + user.userLastname;
            lblUserRole.Text = user.userRole;
            lblUsername.Text = user.username;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            AdjustForm();

            if (lblUserRole.Text == "Crop Reporter" || lblUserRole.Text == "Admin")
            {
                btnCrops.Visible = true;
                btnRice.Visible = true;
                btnCorn.Visible = true;
                btnVegetable.Visible = true;
                panelCropsSubMenu.Visible = true;

                HideSubMenu();
            }
            else
            {
                btnCrops.Visible = false;
                btnRice.Visible = false;
                btnCorn.Visible = false;
                btnVegetable.Visible = false;
                panelCropsSubMenu.Visible = false;

                HideSubMenu();
            }

            if (lblUserRole.Text == "Admin")
            {
                btnSettings.Visible = true;
                btnSettingsAudit.Visible = true;
                btnBackupRestore.Visible = true;

                btnUsers.Visible = true;

                HideSubMenu();
            }
            else
            {
                btnSettings.Visible = false;
                btnSettingsAudit.Visible = false;
                btnBackupRestore.Visible = false;

                btnUsers.Visible = false;

                HideSubMenu();
            }

            MainView mainView = new MainView(panelDesktop);
            mainView.TopLevel = false;
            mainView.FormBorderStyle = FormBorderStyle.None;
            mainView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(mainView);
            mainView.Show();

            DisableButton();
            OpenChildForm(new MainView(panelDesktop));
            lblTitle.Text = "Home";

            foreach (IconButton menuButton in panelMenu.Controls.OfType<IconButton>())
            {
                menuButton.MouseEnter += IconButton_MouseEnter;
            }
        }

        private void HomeView_Resize(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void IconButton_MouseEnter(object sender, EventArgs e)
        {
            IconButton iconButton = (IconButton)sender;

            // Check if the panelMenu is in a collapsed state
            if (panelMenu.Width <= 100) // Adjust this condition as needed
            {
                // Display the tooltip with the IconButton's Tag property as text
                toolTip1.Active = true;
                toolTip1.SetToolTip(iconButton, iconButton.Tag.ToString());
            }
            else
            {
                toolTip1.Active = false;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainView mainView = new MainView(panelDesktop);
            mainView.TopLevel = false;
            mainView.FormBorderStyle = FormBorderStyle.None;
            mainView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(mainView);
            mainView.Show();

            DisableButton();
            OpenChildForm(new MainView(panelDesktop));
            lblTitle.Text = "Home";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                userModel.InserActionLog(lblUsername.Text, "Logout", "Account", $"Logout success ({lblUsername.Text})");
                //string username = lblUserName.Text;
                this.Close();
                LoginView loginView = new LoginView();
                loginView.Show();
            }
        }

        private void btnDashoard_Click(object sender, EventArgs e)
        {
            DashboardView dashboardView = new DashboardView(panelDesktop);
            //userView.formRefresh();
            dashboardView.TopLevel = false;
            dashboardView.FormBorderStyle = FormBorderStyle.None;
            dashboardView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(dashboardView);
            dashboardView.Show();

            ActivateButton(sender, Color.FromArgb(43, 121, 223));
            OpenChildForm(new DashboardView(panelDesktop));
            lblTitle.Text = "Dashboard";

            HideSubMenu();
        }

        private void btnRSBSA_Click(object sender, EventArgs e)
        {
            RsbsaView rsbsaView = new RsbsaView(panelDesktop);
            //userView.formRefresh();
            rsbsaView.TopLevel = false;
            rsbsaView.FormBorderStyle = FormBorderStyle.None;
            rsbsaView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(rsbsaView);
            rsbsaView.Show();

            ActivateButton(sender, Color.FromArgb(43, 121, 223));
            OpenChildForm(new RsbsaView(panelDesktop));
            lblTitle.Text = "RSBSA";

            HideSubMenu();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserView userView = new UserView(panelDesktop);
            //userView.formRefresh();
            userView.TopLevel = false;
            userView.FormBorderStyle = FormBorderStyle.None;
            userView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(userView);
            userView.Show();

            ActivateButton(sender, Color.FromArgb(43, 121, 223));
            OpenChildForm(new UserView(panelDesktop));
            lblTitle.Text = "User Accounts";

            HideSubMenu();
        }

        private void btnCrops_Click(object sender, EventArgs e)
        {
            // Check if the menu is collapsed
            if (panelMenu.Width < 200)
            {
                // Expand the menu
                panelMenu.Width = 300;
                btnHome.Visible = true;
                btnMenu.Dock = DockStyle.None;
                btnMenu.Location = new Point(254, 1);
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }

            ShowSubMenu(panelCropsSubMenu);
        }

        private void btnLetters_Click(object sender, EventArgs e)
        {
            LettersView lettersView = new LettersView(panelDesktop);
            //userView.formRefresh();
            lettersView.TopLevel = false;
            lettersView.FormBorderStyle = FormBorderStyle.None;
            lettersView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(lettersView);
            lettersView.Show();

            ActivateButton(sender, Color.FromArgb(43, 121, 223));
            OpenChildForm(new LettersView(panelDesktop));
            lblTitle.Text = "Letters";

            HideSubMenu();

        }

        private void btnRice_Click(object sender, EventArgs e)
        {
            CropsRiceView cropsRiceView = new CropsRiceView(panelDesktop);
            //userView.formRefresh();
            cropsRiceView.TopLevel = false;
            cropsRiceView.FormBorderStyle = FormBorderStyle.None;
            cropsRiceView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(cropsRiceView);
            cropsRiceView.Show();

            ActivateButton(btnCrops, Color.FromArgb(43, 121, 223));
            OpenChildForm(new CropsRiceView(panelDesktop));
            lblTitle.Text = "Crops \u23F5 Rice";

            HideSubMenu();
        }

        private void btnCorn_Click(object sender, EventArgs e)
        {
            CropsCornView cropsCornView = new CropsCornView(panelDesktop);
            //userView.formRefresh();
            cropsCornView.TopLevel = false;
            cropsCornView.FormBorderStyle = FormBorderStyle.None;
            cropsCornView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(cropsCornView);
            cropsCornView.Show();

            ActivateButton(btnCrops, Color.FromArgb(43, 121, 223));
            OpenChildForm(new CropsCornView(panelDesktop));
            lblTitle.Text = "Crops \u23F5 Corn";

            HideSubMenu();
        }

        private void btnVegetable_Click(object sender, EventArgs e)
        {
            CropsHvcView cropsHvcView = new CropsHvcView(panelDesktop);
            //userView.formRefresh();
            cropsHvcView.TopLevel = false;
            cropsHvcView.FormBorderStyle = FormBorderStyle.None;
            cropsHvcView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(cropsHvcView);
            cropsHvcView.Show();

            ActivateButton(btnCrops, Color.FromArgb(43, 121, 223));
            OpenChildForm(new CropsHvcView(panelDesktop));
            lblTitle.Text = "Crops \u23F5 HVC";

            HideSubMenu();
        }

        private void btnDamages_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // Check if the menu is collapsed
            if (panelMenu.Width < 200)
            {
                // Expand the menu
                panelMenu.Width = 300;
                btnHome.Visible = true;
                btnMenu.Dock = DockStyle.None;
                btnMenu.Location = new Point(254, 1);
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }

            ShowSubMenu(panelReportsSubMenu);
        }

        private void btnReportsRsbsa_Click(object sender, EventArgs e)
        {
            AnalyticsRsbsaView analyticsRsbsaView = new AnalyticsRsbsaView(panelDesktop);
            //userView.formRefresh();
            analyticsRsbsaView.TopLevel = false;
            analyticsRsbsaView.FormBorderStyle = FormBorderStyle.None;
            analyticsRsbsaView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(analyticsRsbsaView);
            analyticsRsbsaView.Show();

            ActivateButton(btnReports, Color.FromArgb(43, 121, 223));
            OpenChildForm(new AnalyticsRsbsaView(panelDesktop));
            lblTitle.Text = "Analytics \u23F5 RSBSA";

            HideSubMenu();
        }

        private void btnCertifications_Click(object sender, EventArgs e)
        {
            CertificationsView certificationsView = new CertificationsView(panelDesktop);
            //userView.formRefresh();
            certificationsView.TopLevel = false;
            certificationsView.FormBorderStyle = FormBorderStyle.None;
            certificationsView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(certificationsView);
            certificationsView.Show();

            ActivateButton(sender, Color.FromArgb(43, 121, 223));
            OpenChildForm(new CertificationsView(panelDesktop));
            lblTitle.Text = "Certifications";

            HideSubMenu();
        }

        private void btnReportsCorn_Click(object sender, EventArgs e)
        {
            AnalyticsCropsView analyticsCropsView = new AnalyticsCropsView(panelDesktop);
            //userView.formRefresh();
            analyticsCropsView.TopLevel = false;
            analyticsCropsView.FormBorderStyle = FormBorderStyle.None;
            analyticsCropsView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(analyticsCropsView);
            analyticsCropsView.Show();

            ActivateButton(btnReports, Color.FromArgb(43, 121, 223));
            OpenChildForm(new AnalyticsCropsView(panelDesktop));
            lblTitle.Text = "Analytics \u23F5 Rice";

            HideSubMenu();
        }

        private void btnReportsRice_Click(object sender, EventArgs e)
        {
            AnalyticsCropsCornView analyticsCropsCornView = new AnalyticsCropsCornView(panelDesktop);
            //userView.formRefresh();
            analyticsCropsCornView.TopLevel = false;
            analyticsCropsCornView.FormBorderStyle = FormBorderStyle.None;
            analyticsCropsCornView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(analyticsCropsCornView);
            analyticsCropsCornView.Show();

            ActivateButton(btnReports, Color.FromArgb(43, 121, 223));
            OpenChildForm(new AnalyticsCropsCornView(panelDesktop));
            lblTitle.Text = "Analytics \u23F5 Corn";

            HideSubMenu();
        }

        private void btnReportsHVC_Click(object sender, EventArgs e)
        {
            AnalyticsCropsHvcView analyticsCropsHvcView = new AnalyticsCropsHvcView(panelDesktop);
            //userView.formRefresh();
            analyticsCropsHvcView.TopLevel = false;
            analyticsCropsHvcView.FormBorderStyle = FormBorderStyle.None;
            analyticsCropsHvcView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(analyticsCropsHvcView);
            analyticsCropsHvcView.Show();

            ActivateButton(btnReports, Color.FromArgb(43, 121, 223));
            OpenChildForm(new AnalyticsCropsHvcView(panelDesktop));
            lblTitle.Text = "Analytics \u23F5 HVC";

            HideSubMenu();
        }

        //private void btnReportsLetters_Click(object sender, EventArgs e)
        //{
        //    AnalyticsCropsView analyticsCropsView = new AnalyticsCropsView(panelDesktop);
        //    //userView.formRefresh();
        //    analyticsCropsView.TopLevel = false;
        //    analyticsCropsView.FormBorderStyle = FormBorderStyle.None;
        //    analyticsCropsView.Dock = DockStyle.Fill;

        //    panelDesktop.Controls.Clear();
        //    panelDesktop.Controls.Add(analyticsCropsView);
        //    analyticsCropsView.Show();

        //    ActivateButton(btnReports, Color.FromArgb(43, 121, 223));
        //    OpenChildForm(new AnalyticsCropsView(panelDesktop));
        //    lblTitle.Text = "Analytics \u23F5 Letters";

        //    HideSubMenu();
        //}

        private void btnActivities_Click(object sender, EventArgs e)
        {
            WeeklyActivitiesView weeklyActivitiesView = new WeeklyActivitiesView(panelDesktop);
            //userView.formRefresh();
            weeklyActivitiesView.TopLevel = false;
            weeklyActivitiesView.FormBorderStyle = FormBorderStyle.None;
            weeklyActivitiesView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(weeklyActivitiesView);
            weeklyActivitiesView.Show();

            ActivateButton(sender, Color.FromArgb(43, 121, 223));
            OpenChildForm(new WeeklyActivitiesView(panelDesktop));
            lblTitle.Text = "Weekly Activities";

            HideSubMenu();
        }

        private void btnSettingsAudit_Click(object sender, EventArgs e)
        {
            AuditLogsView auditLogsView = new AuditLogsView(panelDesktop);
            //userView.formRefresh();
            auditLogsView.TopLevel = false;
            auditLogsView.FormBorderStyle = FormBorderStyle.None;
            auditLogsView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(auditLogsView);
            auditLogsView.Show();

            ActivateButton(btnSettings, Color.FromArgb(43, 121, 223));
            OpenChildForm(new AuditLogsView(panelDesktop));
            lblTitle.Text = "Settings \u23F5 Audit Logs";

            HideSubMenu();
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            BackupAndRestoreView backupAndRestoreView = new BackupAndRestoreView(panelDesktop);
            //userView.formRefresh();
            backupAndRestoreView.TopLevel = false;
            backupAndRestoreView.FormBorderStyle = FormBorderStyle.None;
            backupAndRestoreView.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(backupAndRestoreView);
            backupAndRestoreView.Show();

            ActivateButton(btnSettings, Color.FromArgb(43, 121, 223));
            OpenChildForm(new BackupAndRestoreView(panelDesktop));
            lblTitle.Text = "Settingss \u23F5 Backup and Restore";

            HideSubMenu();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Check if the menu is collapsed
            if (panelMenu.Width < 200)
            {
                // Expand the menu
                panelMenu.Width = 300;
                btnHome.Visible = true;
                btnMenu.Dock = DockStyle.None;
                btnMenu.Location = new Point(254, 1);
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }

            ShowSubMenu(panelSettingsSubMenu);
        }
    }
}
