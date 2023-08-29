using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    internal class LoginModel
    {
        private DatabaseConnection db;

        public LoginModel()
        {
            db = new DatabaseConnection();
        }

        public UserAccount GetUserAccount(string username, string password)
        {
            UserAccount user = null;
            db.Open();

            MySqlCommand command = new MySqlCommand("CALL sp_login(@username, @password)", db.GetConnection());
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                user = new UserAccount();

                byte[] photoData = reader["userPhoto"] == DBNull.Value ? null : (byte[])reader["userPhoto"];
                user.userPhoto = photoData;

                user.userRole = reader.GetString("userRole");
                user.username = reader.GetString("username");
                user.userPassword = reader.GetString("userPassword");
                user.userFirstname = reader.GetString("userFirstname");
                user.userLastname = reader.GetString("userLastname");
            }
            reader.Close();
            db.Close();

            return user;
        }

        public bool CheckUserActive(string username)
        {
            bool isActive = false;
            db.Open();
            MySqlCommand command = new MySqlCommand("CALL sp_checkUserActive(@username)", db.GetConnection());
            command.Parameters.AddWithValue("@username", username);

            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                isActive = true;
            }
            db.Close();
            return isActive;
        }

        public void UpdateLoginStatus(string username)
        {
            db.Open();
            MySqlCommand command = new MySqlCommand("CALL sp_updateLogin(@username)", db.GetConnection());
            command.Parameters.AddWithValue("@username", username);
            command.ExecuteNonQuery();
            db.Close();
        }

        public void ResetLoginTable()
        {
            db.Open();
            MySqlCommand command = new MySqlCommand("CALL sp_updateLogout", db.GetConnection());
            command.ExecuteNonQuery();
            db.Close();
        }
    }
}
