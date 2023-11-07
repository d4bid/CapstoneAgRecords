using AgRecords.Controller;
using AgRecords.Model;
using OfficeOpenXml;
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
    public partial class RSBSAExportView : Form
    {
        RSBSAModel rsbsaModel = new RSBSAModel();
        UserModel userModel = new UserModel();
        private RSBSAController rsbsaController;
        private string fullName = HomeView.Instance.fullName.Text;
        private string username = HomeView.Instance.username.Text;

        public RSBSAExportView()
        {
            InitializeComponent();
            rsbsaController = new RSBSAController(this);

        }

        private void RSBSAExportView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        public void FormRefresh()
        {

            DataTable rsbasaTable = rsbsaController.LoadRSBSAExportView();
            dgvRSBSAExport.DataSource = rsbasaTable;

            comboBoxFilterBrgy.SelectedIndex = 0;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cbIsMultipleSheet.Checked == false)
            {
                // Create a SaveFileDialog instance
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.Title = "Export to Excel";
                saveFileDialog.FileName = "ExportedData.xlsx"; // Default file name

                // Show the SaveFileDialog and wait for the user to select a file
                DialogResult result = saveFileDialog.ShowDialog();

                // If the user clicked OK, export the data
                if (result == DialogResult.OK)
                {
                    // Create a new Excel package and a worksheet
                    ExcelPackage package = new ExcelPackage();
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // Get the visible column headers from the DataGridView and add them to the worksheet
                    int columnIndex = 1;
                    for (int i = 0; i < dgvRSBSAExport.Columns.Count; i++)
                    {
                        if (dgvRSBSAExport.Columns[i].Visible)
                        {
                            worksheet.Cells[1, columnIndex].Value = dgvRSBSAExport.Columns[i].HeaderText;
                            columnIndex++;
                        }
                    }

                    // Get the visible data from the DataGridView and add it to the worksheet
                    for (int i = 0; i < dgvRSBSAExport.Rows.Count; i++)
                    {
                        columnIndex = 1;
                        for (int j = 0; j < dgvRSBSAExport.Columns.Count; j++)
                        {
                            if (dgvRSBSAExport.Columns[j].Visible)
                            {
                                worksheet.Cells[i + 2, columnIndex].Value = dgvRSBSAExport.Rows[i].Cells[j].Value.ToString();
                                columnIndex++;
                            }
                        }
                    }

                    // Save the Excel package to the selected file location
                    package.SaveAs(new FileInfo(saveFileDialog.FileName));

                    // Inform the user that the data has been exported successfully
                    MessageBox.Show("Data exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Create a SaveFileDialog instance
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.Title = "Export to Excel";
                saveFileDialog.FileName = "ExportedData.xlsx"; // Default file name

                // Show the SaveFileDialog and wait for the user to select a file
                DialogResult result = saveFileDialog.ShowDialog();

                // If the user clicked OK, export the data to multiple sheets
                if (result == DialogResult.OK)
                {
                    // Create a new Excel package
                    ExcelPackage package = new ExcelPackage();

                    // Group data by Barangay and create separate sheets
                    var groupedData = dgvRSBSAExport.Rows.Cast<DataGridViewRow>()
                        .GroupBy(row => row.Cells["PERMANENT ADDRESS 2- BRGY/VILL"].Value.ToString());

                    foreach (var group in groupedData)
                    {
                        string barangayName = group.Key;

                        // Create a worksheet for the current barangay
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(barangayName);

                        // Add column headers to the worksheet
                        for (int i = 0; i < dgvRSBSAExport.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dgvRSBSAExport.Columns[i].HeaderText;
                        }

                        // Add data rows to the worksheet
                        int rowIndex = 2;
                        foreach (var row in group)
                        {
                            for (int i = 0; i < dgvRSBSAExport.Columns.Count; i++)
                            {
                                worksheet.Cells[rowIndex, i + 1].Value = row.Cells[i].Value?.ToString();
                            }
                            rowIndex++;
                        }
                    }

                    // Save the Excel package to the selected file location
                    package.SaveAs(new FileInfo(saveFileDialog.FileName));

                    // Inform the user that the data has been exported successfully
                    MessageBox.Show("Data exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }


        private void cbMunicipality_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["PERMANENT CITY"].Visible = cbMunicipality.Checked;
        }

        private void cbProvince_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["PERMANENT PROVINCE"].Visible = cbProvince.Checked;

        }

        private void cbStreet_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["PERMANENT ADDRESS 1- NO., STREET"].Visible = cbStreet.Checked;
        }

        private void cbIdNumber_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["RSBSA REFERENCE NUMBER"].Visible = cbIdNumber.Checked;

        }

        private void cbBirthDate_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["BIRTHDATE"].Visible = cbBirthDate.Checked;

        }

        private void cbPlaceOfBirth_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["PLACE OF BIRTH"].Visible = cbPlaceOfBirth.Checked;

        }

        private void cbMobileNo_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["MOBILE NO."].Visible = cbMobileNo.Checked;

        }

        private void cbFarmParcelNo_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["# OF FARM PARCEL"].Visible = cbFarmParcelNo.Checked;

        }

        private void cbTotalFarmArea_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["TOTAL FARM AREA (Ha)"].Visible = cbTotalFarmArea.Checked;

        }

        private void cbRice_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["RICE"].Visible = cbRice.Checked;

        }

        private void cbCorn_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["CORN"].Visible = cbCorn.Checked;

        }

        private void cbHVC_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["HVC"].Visible = cbHVC.Checked;

        }

        private void cbAgriFishery_CheckedChanged(object sender, EventArgs e)
        {
            dgvRSBSAExport.Columns["AGRI-FISHERY"].Visible = cbAgriFishery.Checked;

        }

        private void PerformSearch()
        {
            string selectedBrgy = comboBoxFilterBrgy.SelectedItem?.ToString() ?? "ALL";

            // Filter the DataGridView based on selected barangay
            if (selectedBrgy == "ALL")
            {
                (dgvRSBSAExport.DataSource as DataTable).DefaultView.RowFilter = "";
            }
            else
            {
                (dgvRSBSAExport.DataSource as DataTable).DefaultView.RowFilter = $"[PERMANENT ADDRESS 2- BRGY/VILL] = '{selectedBrgy}'";
            }
        }


        private void comboBoxFilterBrgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }
    }
}
