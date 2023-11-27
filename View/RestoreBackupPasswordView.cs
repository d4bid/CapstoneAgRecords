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
        // Form style
        private int borderSize = 2;
        private int attempt = 0;

        public RestoreBackupPasswordView()
        {
            InitializeComponent();

            this.Padding = new Padding(borderSize); //Border size
            this.BackColor = Color.FromArgb(5, 93, 96); //Border color
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
