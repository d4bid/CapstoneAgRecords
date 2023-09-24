using AgRecords.Controller;
using AgRecords.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgRecords.View
{
    public partial class UserPasswordView : Form
    {
        private UserController userController;
        private string ID = "";

        public UserPasswordView(UserAccount user)
        {
            userController = new UserController(this);
            ID = user.userId;
            InitializeComponent();
        }

        private void UserPasswordView_Load(object sender, EventArgs e)
        {

        }

        public void PasswordStrengthInvalid()
        {
            lblPasswordStrength.Visible = true;
        }

        public void PasswordNotMatch()
        {
            lblPasswordStrength.Visible = false;
            lblConfirmPassword.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (userController.UpdateUserPassword(ID, txtBoxPassword.Text, txtBoxConfirmPassword.Text))
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
