using AgRecords.Controller;
using AgRecords.Model;
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
    public partial class CertificationsView : Form
    {
        private Panel parentPanel;
        private CertificationsController certController;

        public CertificationsView(Control parentControl)
        {
            InitializeComponent();
            certController = new CertificationsController(this);
            this.parentPanel = parentControl as Panel;

            comboBoxFilterBrgy.SelectedIndex = 0;

        }

        // Methods

        private void CertificationsAddView_FormClosed(object sender, EventArgs e)
        {
            CertificationsView certificationsView = new CertificationsView(parentPanel);
            certificationsView.TopLevel = false;
            certificationsView.FormBorderStyle = FormBorderStyle.None;
            certificationsView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(certificationsView);
            certificationsView.Show();
        }

        // Events

        private void CertificationsView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        public void FormRefresh()
        {
            //DataTable certTable = certController.LoadFarmerView();
            //dgvCert.DataSource = certTable;

            comboBoxSearchCategory.SelectedIndex = 0;

        }

        private void dgvCert_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvCert.Rows[e.RowIndex];

                // Get the user ID from the first cell of the row
                string rsbsaId = row.Cells[0].Value.ToString();

                if (rsbsaId != null)
                {
                    Certifications cert = certController.GetFarmerInfoById(rsbsaId);
                    List<Certifications> certList = certController.GetCertCommodities(rsbsaId);

                    CertificationsAddView certificationsAddView = new CertificationsAddView(cert, certList);
                    certificationsAddView.FormClosed += CertificationsAddView_FormClosed;
                    certificationsAddView.TopLevel = false;
                    certificationsAddView.FormBorderStyle = FormBorderStyle.None;
                    certificationsAddView.Dock = DockStyle.Fill;

                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(certificationsAddView);
                    certificationsAddView.Show();
                }
            }

        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void comboBoxSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void comboBoxFilterBrgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string searchValue = txtBoxSearch.Text;
            string selectedCategory = comboBoxSearchCategory.SelectedItem != null
                                     ? comboBoxSearchCategory.SelectedItem.ToString()
                                     : string.Empty;
            string selectedBrgy = comboBoxFilterBrgy.SelectedItem != null
                                  ? comboBoxFilterBrgy.SelectedItem.ToString()
                                  : string.Empty;

            // Get the original DataTable (assuming it's directly loaded in FormRefresh)
            DataTable certTable = certController.LoadFarmerView();

            // Filter the DataTable based on search criteria
            DataView dv = certTable.DefaultView;
            dv.RowFilter = GetSearchFilterExpression(searchValue, selectedCategory, selectedBrgy);

            // Set a limit for the number of rows to fetch/display
            int limit = 20; // You can adjust this value based on your preference

            // Check if there are any rows in the result
            if (dv.Count > 0)
            {
                // Check if the number of rows is less than the limit
                if (dv.Count < limit)
                {
                    // If fewer rows than the limit, take all rows
                    limit = dv.Count;
                }

                // Create a new DataTable with the filtered rows
                DataTable dt = dv.ToTable().AsEnumerable().Take(limit).CopyToDataTable();

                // Set the filtered DataTable as the DataSource for dgvCert
                dgvCert.DataSource = dt;
            }
            else
            {
                // Handle the case when there are no rows in the result for dgvCert
                // For example, display a message or clear the DataGridView
                dgvCert.DataSource = null;
            }
        }
        private string GetSearchFilterExpression(string searchValue, string selectedCategory, string selectedBrgy)
        {
            List<string> filters = new List<string>();

            // Create filter expression based on selected category and search value
            if (!string.IsNullOrEmpty(searchValue))
            {
                switch (selectedCategory)
                {
                    case "RSBSA ID":
                        filters.Add($"CONVERT([RSBSA ID], System.String) LIKE '%{searchValue}%'");
                        break;
                    case "FIRST NAME":
                        filters.Add($"[First Name] LIKE '%{searchValue}%'");
                        break;
                    case "LAST NAME":
                        filters.Add($"[Last Name] LIKE '%{searchValue}%'");
                        break;
                    case "NO. OF FARM PARCEL":
                        // Convert integer column to string before performing 'LIKE' comparison
                        filters.Add($"CONVERT([No. of Farm Parcel], System.String) LIKE '%{searchValue}%'");
                        break;
                    case "BIRTHDATE":
                        // Format the search value as a string and perform partial matching with 'LIKE' operator
                        string formattedSearchDate = searchValue;
                        filters.Add($"CONVERT([Birthdate], System.String) LIKE '%{formattedSearchDate}%'");
                        break;
                    default:
                        filters.Add($"([RSBSA ID] LIKE '%{searchValue}%' OR [First Name] LIKE '%{searchValue}%' OR " +
                                    $"[Last Name] LIKE '%{searchValue}%' OR " +
                                    $"CONVERT([No. of Farm Parcel], System.String) LIKE '%{searchValue}%' OR " +
                                    $"CONVERT([Birthdate], System.String) LIKE '%{searchValue}%')");
                        break;
                }
            }

            // Add additional filtering based on selected barangay if applicable
            if (!string.IsNullOrEmpty(selectedBrgy) && selectedBrgy != "ALL")
            {
                filters.Add($"[Barangay] = '{selectedBrgy}'");
            }

            // Combine filters with AND condition
            string filterExpression = string.Join(" AND ", filters);

            return filterExpression;
        }
    }
}
