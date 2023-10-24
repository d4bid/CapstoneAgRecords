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
    public partial class DashboardView : Form
    {
        private Panel parentPanel;

        public DashboardView(Control parentControl)
        {
            InitializeComponent();
            this.parentPanel = parentControl as Panel;
        }

        // Methods
        private void DashboardView_FormClosed(object sender, EventArgs e)
        {
            DashboardView dashboardView = new DashboardView(parentPanel);
            dashboardView.TopLevel = false;
            dashboardView.FormBorderStyle = FormBorderStyle.None;
            dashboardView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(dashboardView);
            dashboardView.Show();
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {

        }
    }
}
