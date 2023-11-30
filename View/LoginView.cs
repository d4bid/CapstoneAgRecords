using AgRecords.Controller;
using AgRecords.Model;
using AgRecords.Properties;
using AgRecords.View;

namespace AgRecords
{
    public partial class LoginView : Form
    {
        // Form style
        private int borderSize = 2;
        private int attempt = 0;

        // Controller
        private LoginController controller;

        public LoginView()
        {
            InitializeComponent();

            controller = new LoginController(this);

            this.Padding = new Padding(borderSize); //Border size
            this.BackColor = Color.FromArgb(5, 93, 96); //Border color

            //this.AcceptButton = btnLogin;
            timer1.Start();

            //if database connection is not working, display system config
            //DatabaseConnection dbCheck = new DatabaseConnection();
            //if (!dbCheck.ValidateConnection())
            //{
            //    using (SystemConfig configForm = new SystemConfig())
            //    {
            //        DialogResult result = configForm.ShowDialog();

            //        if (result == DialogResult.OK)
            //        {
            //        }
            //    }
            //}
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            controller.ResetLoginTable();
            txtUsername.Select();

            DatabaseConnection dbCheck = new DatabaseConnection();
            if (dbCheck.ValidateConnection())
            {
                using (SystemConfig configForm = new SystemConfig())
                {
                    DialogResult result = configForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            controller.ValidateUser(username, password);
        }

        // Hide/Show password

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            txtPassword.Select();
            btnShowPass.Hide();
            btnHidePass.Show();
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            txtPassword.Select();
            btnShowPass.Show();
            btnHidePass.Hide();
        }

        // Methods
        public void ShowError()
        {
            lblError.Visible = true;
            attempt += 1;

            if (attempt > 2)
            {
                MessageBox.Show("Too many attempts! Try again later.");
                Application.Exit();
            }
        }

        public void ShowInactiveError()
        {
            MessageBox.Show("Your account is not active! Contact the admin.");
        }

        public void NavigateToDashboard(UserAccount user)
        {
            if (user.userRole == "Admin")
            {
                HomeView adminDashboardView = new HomeView();
                adminDashboardView.SetUserInfo(user);
                adminDashboardView.Show();
            }
            else if (user.userRole == "User" || user.userRole == "User")
            {
                HomeView userDashboard = new HomeView();
                userDashboard.SetUserInfo(user);
                userDashboard.Show();
            }

            this.Hide();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            using (SystemConfig configForm = new SystemConfig())
            {
                DialogResult result = configForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DatabaseConnection dbCheck = new DatabaseConnection();
            if (!dbCheck.ValidateConnection())
            {
                // Stop the timer to prevent further checks
                timer1.Stop();

                // Show the configuration form
                using (SystemConfig configForm = new SystemConfig())
                {
                    DialogResult result = configForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // Resume the timer if needed
                        timer1.Start();
                    }
                    else
                    {
                        // Handle the case where the user closes the configuration form without saving
                        // You may want to exit the application or take appropriate action
                        timer1.Start();

                    }
                }
            }
        }
    }
}