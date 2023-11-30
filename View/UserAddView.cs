using AgRecords.Controller;
using AgRecords.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgRecords.View
{
    public partial class UserAddView : Form
    {
        private byte[] userPhoto; // store the selected image as a byte array
        private UserController userController;
        public event EventHandler FormClosed;

        public UserAddView()
        {
            InitializeComponent();
            userController = new UserController(this);

        }

        private void UserAddView_Load(object sender, EventArgs e)
        {
            FormRefresh();

            HomeView.Instance.title.Text = "User Accounts \u23F5 Add User";
        }

        public void FormRefresh()
        {
            //populate combobox for roles 
            DataTable rolesTable = userController.GetAllRoles();
            comboBoxRole.DataSource = rolesTable;
            comboBoxRole.DisplayMember = "roleName";
            comboBoxRole.ValueMember = "roleId";

            //set an initial value of a combobox
            comboBoxRole.SelectedIndex = 0;
            comboBoxGender.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;

            //generate new userID
            txtBoxUserId.Text = userController.GenerateNewUserID();

            // Hide error label
            lblPasswordStrength.Visible = false;
            panelPassStrength.Visible = false;
            lblConfirmPassword.Visible = false;
            panelPassConfirm.Visible = false;

            // Disabled control
            txtBoxUserId.Enabled = false;
        }

        public void PasswordStrengthInvalid()
        {
            lblPasswordStrength.Visible = true;
            panelPassStrength.Visible = true;
        }

        public void PasswordNotMatch()
        {
            lblPasswordStrength.Visible = false;
            panelPassStrength.Visible = false;
            lblConfirmPassword.Visible = true;
            panelPassConfirm.Visible = true;
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // You can change the format as needed
                return ms.ToArray();
            }
        }

        public void getUserPhoto() //method - get user photo
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // load the selected image into a Bitmap object
                    Bitmap bmp = new Bitmap(openFileDialog.FileName);

                    // convert the Bitmap to a byte array and store it
                    ImageConverter converter = new ImageConverter();
                    userPhoto = (byte[])converter.ConvertTo(bmp, typeof(byte[]));

                    // display the image in the picture box
                    picBoxUser.Image = bmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {
            if (picBoxUser.Image != null)
            {
                Image selectedImage = picBoxUser.Image;

                // Create and show the ImageDisplayForm.
                using (var userPhotoView = new UserPhotoView(selectedImage))
                {
                    userPhotoView.ShowDialog();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image userImg = null;

            //get the image in the picturebox
            if (picBoxUser.Image != null)
            {
                userImg = picBoxUser.Image;

                // Convert the Image to bytes
                userPhoto = ImageToByteArray(userImg);
            }

            if (userController.AddUser(txtBoxUserId.Text, txtBoxFirstName.Text, txtBoxLastName.Text, txtMiddlename.Text, txtExtension.Text,
                    txtTitle.Text, cmbJobTitle.Text, comboBoxGender.Text,
                    txtBoxContact.Text, comboBoxStatus.Text, comboBoxRole.SelectedValue.ToString(), userPhoto, txtBoxUsername.Text,
                    txtBoxPassword.Text, txtBoxConfirmPassword.Text, lblUsernameExists.Visible.ToString()))
            {
                //if success, return to user view
                this.Close();
                FormClosed?.Invoke(this, EventArgs.Empty);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            getUserPhoto();
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;

            // Check if the username already exists
            if (IsUsernameExists(username))
            {
                lblUsernameExists.Visible = true;
            }
            else
            {
                lblUsernameExists.Visible = false;
            }
        }

        private bool IsUsernameExists(string username)
        {
            // Call a method to check if the username already exists in the database
            // You can implement this method using your data access logic
            // For example, you can add a method in your model to check the username existence
            UserModel userModel = new UserModel();
            return userModel.IsUsernameExists(username);
        }
    }
}
