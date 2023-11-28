using AgRecords.Controller;
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
    public partial class AuditLogsView : Form
    {
        private Panel parentPanel;
        private UserController userController;

        public AuditLogsView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            userController = new UserController(this);
        }

        private void AuditLogsView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        public void FormRefresh()
        {
            DataTable logsTable = userController.LoadUserLogsView();
            dgvLogs.DataSource = logsTable;
            cmbFilter.SelectedIndex = 0;
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string filterText = txtBoxSearch.Text.Trim();
            string selectedFilter = cmbFilter.SelectedItem.ToString();

            DataView dv = ((DataTable)dgvLogs.DataSource).DefaultView;

            if (!string.IsNullOrEmpty(filterText))
            {
                string filterExpression = string.Empty;

                switch (selectedFilter)
                {
                    case "Username":
                        filterExpression = $"Username LIKE '%{filterText}%'";
                        break;
                    case "Section":
                        filterExpression = $"Section LIKE '%{filterText}%'";
                        break;
                    case "Timestamp":
                        // Convert DateTime to string for comparison
                        filterExpression = $"CONVERT(Timestamp, 'System.String') LIKE '%{filterText}%'";
                        break;
                    default:
                        // "All" or any other case
                        filterExpression = $"CONVERT(ID, 'System.String') LIKE '%{filterText}%' OR Username LIKE '%{filterText}%' OR Section LIKE '%{filterText}%' OR Description LIKE '%{filterText}%' OR Device LIKE '%{filterText}%' OR CONVERT(Timestamp, 'System.String') LIKE '%{filterText}%'";
                        break;
                }

                dv.RowFilter = filterExpression;
            }
            else
            {
                // If the filter text is empty, remove the filter
                dv.RowFilter = string.Empty;
            }
        }

    }
}
