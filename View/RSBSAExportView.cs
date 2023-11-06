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
            comboBoxSearchCategory.SelectedIndex = 0;
            comboBoxFilterBrgy.SelectedIndex = 0;
            comboBoxFilterCommodity.SelectedIndex = 0;

            DataTable rsbasaTable = rsbsaController.LoadRSBSAExportView();
            dgvRSBSAExport.DataSource = rsbasaTable;
        }

        private void btnExport_Click(object sender, EventArgs e)
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
    }
}
