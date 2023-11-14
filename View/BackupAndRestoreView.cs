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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AgRecords.View
{
    public partial class BackupAndRestoreView : Form
    {
        private Panel parentPanel;
        private UserController userController;
        UserModel userModel = new UserModel();

        private string fullName = HomeView.Instance.fullName.Text;
        private string username = HomeView.Instance.username.Text;

        public BackupAndRestoreView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            userController = new UserController(this);
        }

        private void BackupAndRestoreView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        public void FormRefresh()
        {
            DataTable logsTable = userController.LoadBackupLogsView();
            dgvLogs.DataSource = logsTable;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Set up the SaveFileDialog
                SaveFileDialog backup = new SaveFileDialog();
                backup.InitialDirectory = "C:\\";
                backup.Title = "Database Backup";
                backup.CheckFileExists = false;
                backup.CheckPathExists = false;
                backup.DefaultExt = "sql";
                backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.* ";
                backup.RestoreDirectory = true;

                // Set preset filename based on the current date
                string presetFileName = "agrecords " + DateTime.Now.ToString("MM-dd-yy") + ".sql";
                backup.FileName = presetFileName;

                if (backup.ShowDialog() == DialogResult.OK)
                {
                    if (userModel.BackupDatabase(backup.FileName))
                    {
                        MessageBox.Show("Backup success.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userModel.InserActionLog(username, "Backup", "Settings", $"{backup.FileName} - Backup created successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Backup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Backup", "Settings", "Backup creation failed.");
            }
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
                    if (userModel.RestoreDatabase(restore.FileName))
                    {
                        MessageBox.Show("SQL file restored succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userModel.InserActionLog(username, "Backup", "Settings", $"{restore.FileName} - Backup restored successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Restoration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Backup", "Settings", "Backup restoration failed.");
            }
        }

    }
}
