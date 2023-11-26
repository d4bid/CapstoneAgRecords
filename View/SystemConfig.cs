using AgRecords.Model;
using AgRecords.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AgRecords.View
{
    public partial class SystemConfig : Form
    {

        UserModel userModel = new UserModel();


        public SystemConfig()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate the connection
            DatabaseConnection testConnection = new DatabaseConnection(txtServerAddress.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);

            if (testConnection.ValidateConnection())
            {
                // Connection is valid, save the settings
                if (Settings.Default.ServerIPAddress != txtServerAddress.Text || Settings.Default.database != txtDatabase.Text || Settings.Default.username != txtUsername.Text || Settings.Default.password != txtPassword.Text)
                {
                    // Save the new IP address
                    Settings.Default.ServerIPAddress = txtServerAddress.Text;
                    Settings.Default.database = txtDatabase.Text;
                    Settings.Default.username = txtUsername.Text;
                    Settings.Default.password = txtPassword.Text;
                    Settings.Default.Save();

                    // IP address has changed, inform the user
                    MessageBox.Show("The system will restart to apply the changes.", "System Restart", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Restart the application
                    Application.Restart();
                }
                else
                {
                    // IP address has not changed, save the settings without restart
                    Settings.Default.Save();
                    MessageBox.Show("No changes were made.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Unable to connect to the database using the provided server address.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SystemConfig_Load(object sender, EventArgs e)
        {
            txtServerAddress.Text = Settings.Default.ServerIPAddress.ToString();
            txtDatabase.Text = Settings.Default.database.ToString();
            txtUsername.Text = Settings.Default.username.ToString();
            txtPassword.Text = Settings.Default.password.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            using (RestoreBackupPasswordView restorePw = new RestoreBackupPasswordView())
            {
                DialogResult result = restorePw.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        string connectionString = $"server={txtServerAddress.Text};uid={txtUsername.Text};pwd={txtPassword.Text};";

                        // Set up the OpenFileDialog
                        OpenFileDialog restore = new OpenFileDialog();
                        restore.InitialDirectory = "C:\\";
                        restore.Title = "Database Restore";
                        restore.CheckFileExists = true;
                        restore.CheckPathExists = true;
                        restore.DefaultExt = "sql";
                        restore.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.* ";
                        restore.RestoreDirectory = true;

                        if (restore.ShowDialog() == DialogResult.OK)
                        {
                            if (userModel.RestoreDroppedDatabase(restore.FileName, connectionString))
                            {
                                MessageBox.Show("SQL file restored succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Restoration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            
        }
    }
}
