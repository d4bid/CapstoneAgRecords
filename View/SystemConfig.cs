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
            Properties.Settings.Default.ServerIPAddress = txtServerAddress.Text;
            Properties.Settings.Default.Save();

            // Close the form
            DialogResult = DialogResult.OK;
            Close();
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
    }
}
