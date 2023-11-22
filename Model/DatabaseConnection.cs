using AgRecords.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class DatabaseConnection : IDisposable
    {
        // Connect to MySql
        private MySqlConnection connection;

        // Use null as the default value for server, and set it inside the constructor
        public DatabaseConnection() : this(Settings.Default.ServerIPAddress)
        {
        }

        public DatabaseConnection(string server, string database = "agrecords_db", string username = "root", string password = "")  
        {
            string connectionString = $"server={server};database={database};uid={username};pwd={password};";
            connection = new MySqlConnection(connectionString);
        }

        public void Open()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DATABASE ERROR: " + ex.Message, ex);
            }
        }

        public void Close()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public bool ValidateConnection()
        {
            try
            {
                using (var testConnection = new MySqlConnection(connection.ConnectionString))
                {
                    testConnection.Open();
                    return true;
                }
            }
            catch (MySqlException)
            {
                // Connection failed
                return false;
            }
        }

        public async Task OpenAsync()
        {
            if (connection.State != ConnectionState.Open)
            {
                await connection.OpenAsync();
            }
        }

        public MySqlDataReader ExecuteQuery(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            return command.ExecuteReader();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        // Implement IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (connection != null)
                {
                    connection.Dispose();
                    connection = null;
                }
            }
        }
    }
}