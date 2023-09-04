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

namespace AgRecords.View
{
    public partial class HomeView : Form
    {
        private int borderSize = 2;
        private Size formSize;
        private IconButton currentBtn;
        private Form currentChildForm;

        public HomeView()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //Border size
            this.BackColor = Color.FromArgb(5, 93, 96); //Border color

            SubmenuDesign();
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
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
        }

        //Hide Submenu

        private void HideSubMenu()
        {
            if (panelCropsSubMenu.Visible == true)
                panelCropsSubMenu.Visible = false;
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

            lblUserName.Text = user.userFirstname + " " + user.userLastname;
            lblUserRole.Text = user.userRole;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            AdjustForm();
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
                //string username = lblUserName.Text;
                this.Close();
                LoginView loginView = new LoginView();
                loginView.Show();
            }
        }

        private void btnDashoard_Click(object sender, EventArgs e)
        {

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

        private void btnCorn_Click(object sender, EventArgs e)
        {

        }

        private void btnVegetable_Click(object sender, EventArgs e)
        {

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
            lblTitle.Text = "Crops \u23F5y Rice";

            HideSubMenu();
        }
    }
}
