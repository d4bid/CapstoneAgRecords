using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AgRecords.Model
{
    public class DatabaseConnection : IDisposable
    {
        // Connect to MySql
        private MySqlConnection connection;

        public DatabaseConnection(string server = "localhost", string database = "agrecords_db", string username = "root", string password = "")
        {
            string connectionString = $"server={server};database={database};uid={username};pwd={password};";
            connection = new MySqlConnection(connectionString);
        }

        public void Open()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Close()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
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
