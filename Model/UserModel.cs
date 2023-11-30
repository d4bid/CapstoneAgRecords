using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    internal class UserModel
    {
        private DatabaseConnection db;

        public UserModel()
        {
            db = new DatabaseConnection();
        }

        public DataTable LoadUserDataGrid()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_users;", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading users: " + ex.Message, ex);
            }
        }

        public DataTable LoadUserLogsDataGrid()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_audit_trails;", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading user logs: " + ex.Message, ex);
            }
        }

        public DataTable LoadBackupLogsDataGrid()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_backup_logs;", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading backup logs: " + ex.Message, ex);
            }
        }


        public DataTable GetAllRoles()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable rolesTable = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_roles;", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(rolesTable);
                    return rolesTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting roles: " + ex.Message, ex);
            }
        }

        public bool IsUsernameExists(string username)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "SELECT COUNT(*) FROM tbl_users WHERE username = @username";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // If count is greater than 0, the username already exists
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception as needed (logging, throwing a custom exception, etc.)
                throw new ApplicationException("Error checking username existence: " + ex.Message, ex);
            }
        }



        //add user account
        public Boolean AddUserAccount(UserAccount user)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewUser(@userPhoto, @userId, @userFirstname, @userLastname, @userMiddlename, @userExtension, @userTitle, @userJobTitle, @userGender, @userContact, @userRole, @username, @userPassword, @userActive)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@userPhoto", user.userPhoto);
                    command.Parameters.AddWithValue("@userId", user.userId);
                    command.Parameters.AddWithValue("@userFirstname", user.userFirstname);
                    command.Parameters.AddWithValue("@userLastname", user.userLastname);
                    command.Parameters.AddWithValue("@userMiddlename", user.userMiddlename);
                    command.Parameters.AddWithValue("@userExtension", user.userExtension);
                    command.Parameters.AddWithValue("@userTitle", user.userTitle);
                    command.Parameters.AddWithValue("@userJobTitle", user.userJobTitle);
                    command.Parameters.AddWithValue("@userGender", user.userGender);
                    command.Parameters.AddWithValue("@userContact", user.userContact);
                    command.Parameters.AddWithValue("@userRole", user.userRole);
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@userPassword", user.userPassword);
                    command.Parameters.AddWithValue("@userActive", user.userActive);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new user: " + ex.Message, ex);
            }
        }


        //generate new user ID
        public string GenerateNextId()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_selectMaxUserId", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        return "USER0001";
                    }
                    else
                    {
                        string lastId = result.ToString();
                        int lastNumber = int.Parse(lastId.Substring(4));
                        int nextNumber = lastNumber + 1;
                        string nextId = "USER" + nextNumber.ToString("00");
                        return nextId;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error generating next ID: " + ex.Message, ex);
            }
        }

        // Find userID by full name
        public string FindUserIDByFullName(string fullName)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_findUserIdByFullName(@fullname)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@fullname", fullName);

                    // Execute the query and retrieve the result as a string
                    string userId = command.ExecuteScalar() as string;

                    return userId;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error finding user ID by full name: " + ex.Message, ex);
            }
        }

        //update user account
        public Boolean UpdateUserAccount(UserAccount user)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_updateUser(@userId, @userPhoto, @userFirstname, @userLastname, @userMiddlename, @userExtension, @userTitle, @userJobTitle, @userGender, @userContact, @userRole, @userActive)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@userId", user.userId);
                    command.Parameters.AddWithValue("@userPhoto", user.userPhoto);
                    command.Parameters.AddWithValue("@userFirstname", user.userFirstname);
                    command.Parameters.AddWithValue("@userLastname", user.userLastname);
                    command.Parameters.AddWithValue("@userMiddlename", user.userMiddlename);
                    command.Parameters.AddWithValue("@userExtension", user.userExtension);
                    command.Parameters.AddWithValue("@userTitle", user.userTitle);
                    command.Parameters.AddWithValue("@userJobTitle", user.userJobTitle);
                    command.Parameters.AddWithValue("@userGender", user.userGender);
                    command.Parameters.AddWithValue("@userContact", user.userContact);
                    command.Parameters.AddWithValue("@userRole", user.userRole);
                    command.Parameters.AddWithValue("@userActive", user.userActive);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error updating user account: " + ex.Message, ex);
            }
        }


        //get user account details
        public UserAccount GetUserAccountById(string userId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getUserById(@userId)", db.GetConnection());
                    command.Parameters.AddWithValue("@userId", userId);

                    MySqlDataReader reader = command.ExecuteReader();

                    UserAccount user = null;

                    if (reader.Read())
                    {
                        user = new UserAccount();
                        user.userId = reader["userId"].ToString();
                        user.userFirstname = reader["userFirstname"].ToString();
                        user.userLastname = reader["userLastname"].ToString();
                        user.userMiddlename = reader["userMiddlename"].ToString();
                        user.userExtension = reader["userExtension"].ToString();
                        user.userTitle = reader["userTitle"].ToString();
                        user.userJobTitle = reader["userJobTitle"].ToString();
                        user.userGender = reader["userGender"].ToString();
                        user.userRole = reader["roleId"].ToString();
                        user.userContact = reader["userContact"].ToString();
                        user.username = reader["username"].ToString();
                        user.userPassword = reader["userPassword"].ToString();
                        user.userActive = reader["userActive"].ToString();

                        // Check if userPhoto column is null before attempting to retrieve it
                        if (reader["userPhoto"] != DBNull.Value)
                        {
                            user.userPhoto = (byte[])reader["userPhoto"];
                        }
                    }

                    reader.Close();
                    return user;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting user account by ID: " + ex.Message, ex);
            }
        }

        //update user password
        public Boolean UpdateUserPassword(UserAccount user)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_change_password(@userId, @userPassword)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@userId", user.userId);
                    command.Parameters.AddWithValue("@userPassword", user.userPassword);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error updating user password: " + ex.Message, ex);
            }
        }

        public void InserActionLog(string username, string activity, string section, string description)
        {
            using (DatabaseConnection db = new DatabaseConnection())
            {
                db.Open();

                string query = "CALL sp_RegisterUserAction(@username, @activity, @section, @description, @device)";
                MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@activity", activity);
                command.Parameters.AddWithValue("@section", section);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@device", Environment.MachineName);

                command.ExecuteNonQuery();
            }
        }

        public Boolean BackupDatabase(string filepath)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    //List<string> list = new List<string>();
                    //list.Add("tbl_user_logs");

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = db.GetConnection();
                    MySqlBackup mb = new MySqlBackup(cmd);
                    //mb.ExportInfo.ExcludeTables = list;
                    mb.ExportToFile(filepath);

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Backup Error: " + ex.Message, ex);
            }
        }

        public Boolean RestoreDatabase(string filepath)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = db.GetConnection();
                    MySqlBackup mb = new MySqlBackup(cmd);
                    mb.ImportFromFile(filepath);

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Restore Error: " + ex.Message, ex);
            }
        }


        public Boolean RestoreDroppedDatabase(string filepath, string connectionString)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the 'agrecords_db' database if it doesn't exist
                    using (MySqlCommand createDbCommand = new MySqlCommand("CREATE DATABASE IF NOT EXISTS agrecords_db", connection))
                    {
                        createDbCommand.ExecuteNonQuery();
                    }

                    // Set the database to 'agrecords_db' in the connection string
                    connection.ChangeDatabase("agrecords_db");

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    MySqlBackup mb = new MySqlBackup(cmd);
                    mb.ImportFromFile(filepath);

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Restore Error: " + ex.Message, ex);
            }
        }
    }
}
