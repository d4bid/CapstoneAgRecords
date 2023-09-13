using AgRecords.Controller;
using AgRecords.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserEditView : Form
    {
        private byte[] userPhoto; // store the selected image as a byte array
        private UserController userController;
        public event EventHandler FormClosed;

        public UserEditView(UserAccount user)
        {
            userController = new UserController(this);
            InitializeComponent();

            //populate combobox for roles 
            DataTable rolesTable = userController.GetAllRoles();
            comboBoxRole.DataSource = rolesTable;
            comboBoxRole.DisplayMember = "roleName";
            comboBoxRole.ValueMember = "roleId";

            // Set the values of the fields using the user data
            txtBoxUserId.Text = user.userId.ToString();
            txtBoxFirstName.Text = user.userFirstname;
            txtBoxLastName.Text = user.userLastname;
            comboBoxGender.Text = user.userGender;
            txtBoxContact.Text = user.userContact;
            txtBoxUsername.Text = user.username;
            comboBoxStatus.Text = user.userActive;

            // Find the role name based on the role ID and set the DisplayMember
            DataRow[] roleRows = rolesTable.Select("roleId = " + user.userRole);
            if (roleRows.Length > 0)
            {
                comboBoxRole.Text = roleRows[0]["roleName"].ToString();
            }

            // Convert the user photo byte array to an Image and display it in the picture box
            if (user.userPhoto != null && user.userPhoto.Length > 0)
            {
                ImageConverter converter = new ImageConverter();
                Image img = (Image)converter.ConvertFrom(user.userPhoto);
                picBoxUser.Image = img;
            }
        }

        private void UserEditView_Load(object sender, EventArgs e)
        {

        }

        // METHODS

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

        //image to byte converter
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // You can change the format as needed
                return ms.ToArray();
            }
        }

        // TRIGGERS

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            getUserPhoto();
        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {
            getUserPhoto();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Get the user account data from the database using the user ID
            UserAccount user = userController.GetUserAccountById(txtBoxUserId.Text);

            UserPasswordView userPasswordView = new UserPasswordView(user);
            userPasswordView.ShowDialog();
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


            if (userController.UpdateUser(txtBoxUserId.Text, txtBoxFirstName.Text, txtBoxLastName.Text, comboBoxGender.Text, txtBoxContact.Text, comboBoxStatus.Text, comboBoxRole.SelectedValue.ToString(), userPhoto))
            {
                //MessageBox.Show("User added successfully.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FormClosed?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
