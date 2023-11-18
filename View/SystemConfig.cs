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
        public SystemConfig()
        {
            InitializeComponent();
            txtServerAddress.Text = Settings.Default.ServerIPAddress.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.ServerIPAddress = txtServerAddress.Text;
            Settings.Default.Save();

            // Close the form
            DialogResult = DialogResult.OK;
            Application.Restart();
        }

        private void SystemConfig_Load(object sender, EventArgs e)
        {
            txtServerAddress.Text = Settings.Default.ServerIPAddress.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
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
                    MessageBox.Show("SQL file restored succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Restoration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
