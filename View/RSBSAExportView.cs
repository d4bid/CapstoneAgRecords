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

                // Get the column headers from the DataGridView and add them to the worksheet
                for (int i = 0; i < dgvRSBSAExport.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvRSBSAExport.Columns[i].HeaderText;
                }

                // Get the data from the DataGridView and add it to the worksheet
                for (int i = 0; i < dgvRSBSAExport.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvRSBSAExport.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvRSBSAExport.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Save the Excel package to the selected file location
                package.SaveAs(new FileInfo(saveFileDialog.FileName));

                // Inform the user that the data has been exported successfully
                MessageBox.Show("Data exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
