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
    public partial class UserAddView : Form
    {
        private byte[] userPhoto; // store the selected image as a byte array
        private UserController userController;

        public UserAddView()
        {
            InitializeComponent();
            userController = new UserController(this);

        }

        private void UserAddView_Load(object sender, EventArgs e)
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
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            getUserPhoto();
        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {
            getUserPhoto();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            UserView userView = new UserView();
            userView.Show();
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

            if (userController.AddUser(txtBoxUserId.Text, txtBoxFirstName.Text, txtBoxLastName.Text, comboBoxGender.Text, txtBoxContact.Text, comboBoxStatus.Text, comboBoxRole.SelectedValue.ToString(), userPhoto, txtBoxUsername.Text, txtBoxPassword.Text))
            {
                //if success, return to user view
                this.Close();
                UserView userView = new UserView();
                userView.Show();
            }


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
    }
}
