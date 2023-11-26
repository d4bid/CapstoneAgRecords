using System;
using AgRecords.Properties;
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
    public partial class RestoreBackupPasswordView : Form
    {
        public RestoreBackupPasswordView()
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
            if (txtPassword.Text == Settings.Default.adminPassword.ToString() || txtPassword.Text == Settings.Default.devPassword.ToString())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect password.", "Restore Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
