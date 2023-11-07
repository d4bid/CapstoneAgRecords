using AgRecords.Model;
using AgRecords.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AgRecords.Controller
{
    internal class UserController
    {
        private UserView userView;
        private UserAddView userAddView;
        private UserEditView userEditView;
        private UserPasswordView userPasswordView;

        private UserModel userModel;
        private Boolean isDone = false; //for processing CRUD operations
        private string fullName = HomeView.Instance.fullName.Text;
        private string username = HomeView.Instance.username.Text;

        public UserController(UserView userView)
        {
            this.userView = userView;
            userModel = new UserModel();
        }

        public UserController(UserAddView userAddView)
        {
            this.userAddView = userAddView;
            userModel = new UserModel();
        }

        public UserController(UserEditView userEditView)
        {
            this.userEditView = userEditView;
            userModel = new UserModel();
        }

        public UserController(UserPasswordView userPasswordView)
        {
            this.userPasswordView = userPasswordView;
            userModel = new UserModel();
        }

        public DataTable LoadUserView()
        {
            try
            {
                DataTable usersTable = userModel.LoadUserDataGrid();
                return usersTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "User Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
            
        }

        public DataTable GetAllRoles()
        {
            try
            {
                return userModel.GetAllRoles();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Roles Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public string GenerateNewUserID()
        {
            try
            {
                return userModel.GenerateNextId();

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "ID Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public bool AddUser(string userId, string userFirstName, string userLastName, string userMiddlename, string userExtension, 
            string userTitle, string userJobTitle, string userGender, string userContact, string userActive, string userRole, 
            byte[] userPhoto, string username, string userPassword, string confirmPassword)
        {
            try
            {
                UserAccount user = new UserAccount()
                {
                    userId = userId,
                    userPhoto = userPhoto,
                    userFirstname = userFirstName,
                    userLastname = userLastName,
                    userMiddlename = userMiddlename,
                    userExtension = userExtension,
                    userTitle = userTitle,
                    userJobTitle = userJobTitle,
                    userGender = userGender,
                    userContact = userContact,
                    userRole = userRole,
                    userActive = userActive,
                    username = username,
                    userPassword = userPassword
                };

                if (user.userPhoto == null)
                {
                    MessageBox.Show("Please insert an image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userFirstname == "")
                {
                    MessageBox.Show("First name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userLastname == "")
                {
                    MessageBox.Show("Last name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userRole != "Admin" && user.userJobTitle == "")
                {
                    MessageBox.Show("Position is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userRole == "")
                {
                    MessageBox.Show("User Role is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.username == "")
                {
                    MessageBox.Show("Username is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userPassword == "")
                {
                    MessageBox.Show("Password is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userPhoto != null && user.userFirstname != "" && user.userLastname != "" && user.userContact != "" && user.username != "" && user.userPassword != "")
                {
                    if (Regex.IsMatch(user.userPassword, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,16}$"))
                    {
                        if (user.userPassword == confirmPassword) 
                        {
                            DialogResult result = MessageBox.Show("Are you sure you want to register this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes) //proceed to adding the new user
                            {
                                if (userModel.AddUserAccount(user))
                                {
                                    MessageBox.Show("Account created succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    isDone = true;
                                    userModel.InserActionLog(username, "Insert", "User", $"{userId} added successfully.");
                                }
                            }
                            else //cancel adding
                            {

                            }
                        }
                        else
                        {
                            userAddView.PasswordNotMatch();
                        }
                    }
                    else
                    {
                        userAddView.PasswordStrengthInvalid();
                    }   
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add User Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Insert", "User", $"{userId} adding failed.");

                return false;
            }
        }


        public Boolean UpdateUser(string userId, string userFirstName, string userLastName, string userMiddlename, string userExtension,
            string userTitle, string userJobTitle, string userGender, string userContact,  string userActive, string userRole, byte[] userPhoto)
        {
            try
            {
                UserAccount user = new UserAccount()
                {
                    userId = userId,
                    userPhoto = userPhoto,
                    userFirstname = userFirstName,
                    userLastname = userLastName,
                    userMiddlename = userMiddlename,
                    userExtension = userExtension,
                    userTitle = userTitle,
                    userJobTitle = userJobTitle,
                    userGender = userGender,
                    userContact = userContact,
                    userRole = userRole,
                    userActive = userActive
                };
                MessageBox.Show(userJobTitle, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                if (user.userPhoto == null)
                {
                    MessageBox.Show("Please insert an image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userFirstname == "")
                {
                    MessageBox.Show("First name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userLastname == "")
                {
                    MessageBox.Show("Last name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userRole != "Admin" && user.userJobTitle == "")
                {
                    MessageBox.Show("Position is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userRole == "")
                {
                    MessageBox.Show("User Role is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userPhoto != null && user.userFirstname != "" && user.userLastname != "" && user.userContact != "")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to update this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) //proceed to updating the user
                    {
                        if (userModel.UpdateUserAccount(user))
                        {
                            MessageBox.Show("Account updated succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isDone = true;
                            userModel.InserActionLog(username, "Update", "User", $"{userId} updated successfully.");
                        }
                    }
                    else //cancel updating
                    {
                        
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Update User Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Update", "User", $"{userId} update failed.");
                return false;
            }

        }

        public Boolean UpdateUserPassword(string userId, string userPassword, string confirmUserPassword)
        {
            try
            {
                UserAccount user = new UserAccount()
                {
                    userId = userId,
                    userPassword = userPassword
                };

                if (user.userPassword == "")
                {
                    MessageBox.Show("Password is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (confirmUserPassword == "")
                {
                    MessageBox.Show("Please confirm the password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (user.userPassword != "" && confirmUserPassword != "")
                {
                    if (Regex.IsMatch(user.userPassword, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,16}$"))
                    {
                        if (user.userPassword == confirmUserPassword)
                        {
                            DialogResult result = MessageBox.Show("Are you sure you want to update your password?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes) //proceed to updating the user
                            {
                                if (userModel.UpdateUserPassword(user))
                                {
                                    MessageBox.Show("Account password updated succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    userModel.InserActionLog(username, "Update", "User", $"{userId} password updated successfully.");
                                    isDone = true;
                                }
                            }
                            else //cancel updating
                            {

                            }
                        }
                        else
                        {
                            userPasswordView.PasswordNotMatch();
                        }
                    }
                    else
                    {
                        userPasswordView.PasswordStrengthInvalid();
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Update Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Update", "User", $"{userId} password update failed.");
                return false;
            }
        }

        public UserAccount GetUserAccountById(string userId)
        {
            try
            {
                return userModel.GetUserAccountById(userId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding Account Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

    }
}
