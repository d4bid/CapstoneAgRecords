using AgRecords.Controller;
using AgRecords.Model;
using AgRecords.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AgRecords.View
{
    public partial class CropsCornEditView : Form
    {
        private CropsCornController cropsCornController;
        public event EventHandler FormClosed;
        private string reportType;

        public CropsCornEditView(CornReport cr, string reportType)
        {
            InitializeComponent();

            cropsCornController = new CropsCornController(this);

            if (reportType == "Planting")
            {
                labelArea.Text = "PLANTING ACCOMPLISHMENTS";
                labelCornPrId.Text = cr.cornPrId.ToString();
                labelSeason.Text = cr.season.ToString();
                labelSeasonYear.Text = cr.seasonYear.ToString();
                labelMonth.Text = cr.month.ToString();
                labelWeek.Text = cr.week.ToString();
                labelYear.Text = cr.year.ToString();
            }
            else if (reportType == "Planting By Ecological Zone")
            {
                labelArea.Text = "PLANTING BY ECOLOGICAL ZONE ACCOMPLISHMENTS";
                labelCornPrId.Text = cr.cornPrId.ToString();
                labelSeason.Text = cr.season.ToString();
                labelSeasonYear.Text = cr.seasonYear.ToString();
                labelMonth.Text = cr.month.ToString();
                labelWeek.Text = cr.week.ToString();
                labelYear.Text = cr.year.ToString();
            }
            else if (reportType == "Harvesting")
            {
                labelArea.Text = "HARVESTING ACCOMPLISHMENTS";
                labelCornPrId.Text = cr.cornPrId.ToString();
                labelSeason.Text = cr.season.ToString();
                labelSeasonYear.Text = cr.seasonYear.ToString();
                labelMonth.Text = cr.month.ToString();
                labelWeek.Text = cr.week.ToString();
                labelYear.Text = cr.year.ToString();
            }
        }

        // Methods

        public void FormRefresh()
        {
            btnUpdate.Enabled = false;
            ClearTextControls();

            btnPrint.Enabled = true;

            if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS" || labelArea.Text == "PLANTING ACCOMPLISHMENTS")
            {
                btnNew.Enabled = false;
                btnNew.Enabled = false;
            }
            else
            {
                btnNew.Enabled = true;
                btnNew.Enabled = true;
            }

            DisplayDataTableFilter();
        }

        public void ClearTextControls()
        {
            cmbBrgy.SelectedIndex = -1;
            cmbLandType.SelectedIndex = -1;
            cmbSeedType.SelectedIndex = -1;
            cmbCornType.SelectedIndex = -1;
            txtSize.Text = "";
            dtpLogDate.Value = DateTime.Now;
            labelCornPlantingId.Text = "";
        }

        private int MapCornItemToValue(ComboBox comboBox)
        {
            string selectedCornItem = comboBox.SelectedItem?.ToString(); // Use ?. to handle potential null value
            int cornId = 1; // Default value or value for unhandled cases

            if (selectedCornItem != null)
            {
                switch (selectedCornItem)
                {
                    case "Yellow":
                        cornId = 1;
                        break;
                    case "White":
                        cornId = 2;
                        break;
                        // Handle other cases here if needed
                }
            }

            return cornId;
        }

        private int MapGrowthItemToValue(ComboBox comboBox)
        {
            string selectedGrowthItem = comboBox.SelectedItem?.ToString(); // Use ?. to handle potential null value
            int growthId = 1; // Default value or value for unhandled cases

            if (selectedGrowthItem != null)
            {
                switch (selectedGrowthItem)
                {
                    case "Newly Planted/Seedling Stage":
                        growthId = 1;
                        break;
                    case "Vegetative Stage":
                        growthId = 2;
                        break;
                    case "Reproductive Stage":
                        growthId = 3;
                        break;
                    case "Maturing Stage":
                        growthId = 4;
                        break;
                    case "Harvested":
                        growthId = 5;
                        break;
                }
            }

            return growthId;
        }

        private int MapSeedItemToValue(ComboBox comboBox)
        {
            string selectedSeedItem = comboBox.SelectedItem?.ToString(); // Use ?. to handle potential null value
            int seedId = 1; // Default value or value for unhandled cases

            if (selectedSeedItem != null)
            {
                switch (selectedSeedItem)
                {
                    case "GMO":
                        seedId = 1;
                        break;
                    case "HYBRID":
                        seedId = 2;
                        break;
                    case "OPV":
                        seedId = 3;
                        break;
                    case "GREEN CORN/SWEET CORN":
                        seedId = 4;
                        break;
                    case "TRADITIONAL":
                        seedId = 5;
                        break;
                }
            }

            return seedId;
        }

        private int MapLandItemToValue(ComboBox comboBox)
        {
            string selectedLandItem = comboBox.SelectedItem?.ToString(); // Use ?. to handle potential null value
            int landId = 1; // Default value or value for unhandled cases

            if (selectedLandItem != null)
            {
                switch (selectedLandItem)
                {
                    case "L.Vega":
                        landId = 1;
                        break;
                    case "U.Vega":
                        landId = 2;
                        break;
                    case "Broad Plains":
                        landId = 3;
                        break;
                    case "Hilly":
                        landId = 4;
                        break;
                    case "Traditional":
                        landId = 5;
                        break;
                }
            }

            return landId;
        }

        public void DisplayDataTableFilter()
        {
            string cornPrId = labelCornPrId.Text;
            int colorId = MapCornItemToValue(cmbCornType);
            int growthId = MapGrowthItemToValue(cmbGrowthStageFilter);
            int seedId = MapGrowthItemToValue(cmbSeedType);
            int landId = MapGrowthItemToValue(cmbLandType);

            if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
            {
                DataTable cornPlantingTable = cropsCornController.LoadCornPlantingView(cornPrId, seedId, colorId);
                dgvCornPlanting.DataSource = cornPlantingTable;
            }
            else if (labelArea.Text == "PLANTING BY ECOLOGICAL ZONE ACCOMPLISHMENTS")
            {
                DataTable cornPlantingTable = cropsCornController.LoadCornPlantingEcoView(cornPrId, colorId, growthId, seedId);
                dgvCornPlanting.DataSource = cornPlantingTable;
            }
            else if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
            {
                DataTable cornPlantingTable = cropsCornController.LoadCornHarvestingView(cornPrId, seedId, colorId, landId);
                dgvCornPlanting.DataSource = cornPlantingTable;
            }
        }

        public void HideControls()
        {
            if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
            {
                btnNew.Enabled = false;
                btnUpdate.Enabled = false;

                labelAveYield.Visible = false;
                txtAveYield.Visible = false;
                boxAveYield.Visible = false;

                panelGrowth.Visible = false;

                txtSize.ReadOnly = true;
                txtSize.ForeColor = SystemColors.WindowText;
                txtSize.BackColor = Color.White;

                labelGrowthStage.Text = "Newly Planted/Vegetative Stage";
                labelSize.Text = "Size (ha)";
            }
            else if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
            {
                btnNew.Enabled = true;
                btnUpdate.Enabled = true;

                labelAveYield.Enabled = true;
                txtAveYield.Visible = true;
                boxAveYield.Visible = true;

                panelSeed.Visible = true;

                panelGrowth.Visible = false;

                txtSize.ReadOnly = true;
                txtSize.ForeColor = SystemColors.WindowText;
                txtSize.BackColor = Color.White;

                labelGrowthStage.Text = "Harvested";

                labelSize.Text = "Area Harvested (ha)";
            }
            else if (labelArea.Text == "PLANTING BY ECOLOGICAL ZONE ACCOMPLISHMENTS")
            {
                btnNew.Visible = true;
                btnUpdate.Visible = true;

                labelAveYield.Visible = false;
                txtAveYield.Visible = false;
                boxAveYield.Visible = false;

                panelSeed.Visible = true;

                labelSize.Text = "Size (ha)";
            }

        }

        // Events

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
            {
                btnUpdate.Visible = true;
                btnNew.Visible = false;
            }
            else if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
            {
                btnUpdate.Visible = false;
                btnNew.Visible = false;
            }
            else if (labelArea.Text == "PLANTING BY ECOLOGICAL ZONE ACCOMPLISHMENTS")
            {
                btnUpdate.Visible = false;
                btnNew.Visible = true;
            }

            int brgyIndex = cmbBrgy.SelectedIndex;
            int landTypeIndex = cmbLandType.SelectedIndex;
            int colorTypeIndex = cmbCornType.SelectedIndex;
            int seedTypeIndex = cmbSeedType.SelectedIndex;

            // Retrieve the corresponding integer values based on the indices
            int brgyId = brgyIndex + 1; // Add 1 to convert from 0-based index to 1-based ID
            int landTypeId = landTypeIndex + 1;
            int colorTypeId = colorTypeIndex + 1;
            int seedTypeId = seedTypeIndex + 1;

            string growthStageText = labelGrowthStage.Text;
            int growthStageId = 0;

            switch (growthStageText)
            {
                case "Newly Planted/Seedling Stage":
                    growthStageId = 1;
                    break;
                case "Vegetative Stage":
                    growthStageId = 2;
                    break;
                case "Reproductive Stage":
                    growthStageId = 3;
                    break;
                case "Maturing Stage":
                    growthStageId = 4;
                    break;
                case "Harvested":
                    growthStageId = 5;
                    break;
                default:
                    break;
            }

             float size = float.Parse(txtSize.Text);
            //float size = 0.00f;
            //if (!string.IsNullOrEmpty(txtSize.Text))
            //{
            //    size = float.Parse(txtSize.Text);
            //}
            MessageBox.Show($"{txtAveYield}");
            float yield = float.Parse(txtAveYield.Text);
            int cornPlantingEcoId = int.Parse(labelCornPlantingId.Text);
            int cornHarvestingId = int.Parse(labelCornPlantingId.Text);

            if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
            {
                if (cropsCornController.UpdateCornHarvesting(cornHarvestingId, yield))
                {
                    FormRefresh();
                }
            }
            else if (labelArea.Text == "PLANTING BY ECOLOGICAL ZONE ACCOMPLISHMENTS")
            {
                if (cropsCornController.UpdateCornPlantingEco(cornPlantingEcoId, brgyId, landTypeId, growthStageId, seedTypeId, colorTypeId, size, dtpLogDate.Value.Date))
                {
                    FormRefresh();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;

            int brgyIndex = cmbBrgy.SelectedIndex;
            int landTypeIndex = cmbLandType.SelectedIndex;
            int colorTypeIndex = cmbCornType.SelectedIndex;
            int seedTypeIndex = cmbSeedType.SelectedIndex;

            // Retrieve the corresponding integer values based on the indices
            int brgyId = brgyIndex + 1; // Add 1 to convert from 0-based index to 1-based ID
            int landTypeId = landTypeIndex + 1;
            int colorTypeId = colorTypeIndex + 1;
            int seedTypeId = seedTypeIndex + 1;

            int growthStageId = 1;
               float size = 0.00f;
            if (!string.IsNullOrEmpty(txtSize.Text))
            {
                size = float.Parse(txtSize.Text);
            }


            if (cropsCornController.AddCornPlantingEco(labelCornPrId.Text, brgyId, landTypeId, growthStageId, seedTypeId, colorTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void dgvCornPlanting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnNew.Enabled = false;

            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvCornPlanting.Rows[e.RowIndex];

                if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
                {
                    btnNew.Visible = false;
                    btnUpdate.Visible = false;

                    int cornPlantingId = Convert.ToInt32(row.Cells[0].Value);

                    labelCornPlantingId.Text = cornPlantingId.ToString();

                    CornPlanting cp = cropsCornController.GetCornPlantingById(cornPlantingId);
                    if (cp != null)
                    {

                        int brgyIndex = cp.brgyId - 1; // Convert from 1-based ID to 0-based index
                        if (brgyIndex >= 0 && brgyIndex < cmbBrgy.Items.Count)
                        {
                            cmbBrgy.SelectedIndex = brgyIndex;
                        }

                        int landIndex = cp.landTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (landIndex >= 0 && landIndex < cmbLandType.Items.Count)
                        {
                            cmbLandType.SelectedIndex = landIndex;
                        }

                        int seedIndex = cp.seedTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (seedIndex >= 0 && seedIndex < cmbSeedType.Items.Count)
                        {
                            cmbSeedType.SelectedIndex = seedIndex;
                        }

                        int colorIndex = cp.colorTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (colorIndex >= 0 && colorIndex < cmbCornType.Items.Count)
                        {
                            cmbCornType.SelectedIndex = colorIndex;
                        }

                        txtSize.Text = cp.size.ToString();
                    }
                }
                else if (labelArea.Text == "PLANTING BY ECOLOGICAL ZONE ACCOMPLISHMENTS")
                {
                    if (labelGrowthStage.Text == "Newly Planted/Seedling Stage")
                    {
                        btnUpdate.Enabled = true;
                    }
                    else
                    {
                        btnUpdate.Enabled = false;
                    }

                    int cornPlantingEcoId = Convert.ToInt32(row.Cells[0].Value);

                    labelCornPlantingId.Text = cornPlantingEcoId.ToString();

                    CornPlantingEco cpe = cropsCornController.GetCornPlantingEcoById(cornPlantingEcoId);
                    if (cpe != null)
                    {

                        int brgyIndex = cpe.brgyId - 1; // Convert from 1-based ID to 0-based index
                        if (brgyIndex >= 0 && brgyIndex < cmbBrgy.Items.Count)
                        {
                            cmbBrgy.SelectedIndex = brgyIndex;
                        }

                        int landIndex = cpe.landTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (landIndex >= 0 && landIndex < cmbLandType.Items.Count)
                        {
                            cmbLandType.SelectedIndex = landIndex;
                        }

                        int seedIndex = cpe.seedTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (seedIndex >= 0 && seedIndex < cmbSeedType.Items.Count)
                        {
                            cmbSeedType.SelectedIndex = seedIndex;
                        }

                        int colorIndex = cpe.colorTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (colorIndex >= 0 && colorIndex < cmbCornType.Items.Count)
                        {
                            cmbCornType.SelectedIndex = colorIndex;
                        }

                        int growthStageId = cpe.growthStageId;

                        switch (growthStageId)
                        {
                            case 1:
                                labelGrowthStage.Text = "Newly Planted/Seedling Stage";
                                break;
                            case 2:
                                labelGrowthStage.Text = "Vegetative Stage";
                                break;
                            case 3:
                                labelGrowthStage.Text = "Reproductive Stage";
                                break;
                            case 4:
                                labelGrowthStage.Text = "Maturing Stage";
                                break;
                            case 5:
                                labelGrowthStage.Text = "Harvested";
                                break;
                            default:
                                labelGrowthStage.Text = "Unknown Stage";
                                break;
                        }

                        txtSize.Text = cpe.size.ToString();
                        dtpLogDate.Text = cpe.logDate.ToString();
                    }
                }
                else if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
                {
                    btnNew.Visible = false;
                    btnNew.Enabled = false;
                    btnUpdate.Visible = true;
                    btnUpdate.Enabled = true;

                    int cornHarvestingId = Convert.ToInt32(row.Cells[0].Value);

                    labelCornPlantingId.Text = cornHarvestingId.ToString();

                    CornHarvesting ch = cropsCornController.GetCornHarvestingById(cornHarvestingId);
                    if (ch != null)
                    {

                        int brgyIndex = ch.brgyId - 1; // Convert from 1-based ID to 0-based index
                        if (brgyIndex >= 0 && brgyIndex < cmbBrgy.Items.Count)
                        {
                            cmbBrgy.SelectedIndex = brgyIndex;
                        }

                        int landIndex = ch.landTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (landIndex >= 0 && landIndex < cmbLandType.Items.Count)
                        {
                            cmbLandType.SelectedIndex = landIndex;
                        }

                        int seedIndex = ch.seedTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (seedIndex >= 0 && seedIndex < cmbSeedType.Items.Count)
                        {
                            cmbSeedType.SelectedIndex = seedIndex;
                        }

                        int colorIndex = ch.colorTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (colorIndex >= 0 && colorIndex < cmbCornType.Items.Count)
                        {
                            cmbCornType.SelectedIndex = colorIndex;
                        }

                        txtSize.Text = ch.size.ToString();
                        txtAveYield.Text = ch.yield.ToString();
                    }
                }
            }
        }

        private void CropsCornEditView_Load(object sender, EventArgs e)
        {
            FormRefresh();

            cmbSeedType.SelectedIndex = 0;
            cmbCornType.SelectedIndex = 0;
            cmbLandType.SelectedIndex = 0;
            cmbGrowthStageFilter.SelectedIndex = 0;

            btnUpdate.Enabled = false;

            HideControls();

            DisplayDataTableFilter();
        }

        private void cmbCornTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void cmbGrowthStageFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void cmbSeedTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void cmbLandTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
            {
                // Retrieve data from the controller
                string cornPrId = labelCornPrId.Text;
                DataTable data = cropsCornController.LoadCornPlantingGmoHybridView(cornPrId);

                // Get the directory where the application executable is located
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the path to the Excel file relative to the executable path
                string relativePath = Path.Combine("Templates", "CornPlantingReport.xlsx");

                // Combine the executable path with the relative path to get the full file path
                string filePath = Path.Combine(executablePath, relativePath);

                // Create an instance of Excel Application
                Excel.Application excelApp = new Excel.Application();

                // Open the Excel template
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

                // Get the worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1]; // Assuming the first worksheet

                worksheet.Cells[3, 2].Value = worksheet.Cells[3, 2].Text + labelMonth.Text.ToUpper() + " " + labelWeek.Text + ", " + labelYear.Text +
                    "(" + labelSeason.Text.ToUpper() + " SEASON CY " + labelSeasonYear.Text + ")";

                int startRow = 12;
                int startColumn = 2;

                foreach (DataRow row in data.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow, startColumn] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn++;
                    }

                    startRow++; // Move to the next row in Excel
                    startColumn = 2; // Reset the column index for the next row
                }

                DataTable data1 = cropsCornController.LoadCornPlantingOpvGreenSweetView(cornPrId);
                int startRow1 = 12;
                int startColumn1 = 26;

                foreach (DataRow row in data1.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow1, startColumn1] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn1++;
                    }

                    startRow1++; // Move to the next row in Excel
                    startColumn1 = 26; // Reset the column index for the next row
                }

                DataTable data2 = cropsCornController.LoadCornPlantingTraditionalGrandTotalView(cornPrId);
                int startRow2 = 12;
                int startColumn2 = 50;

                foreach (DataRow row in data2.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow2, startColumn2] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn2++;
                    }

                    startRow2++; // Move to the next row in Excel
                    startColumn2 = 50; // Reset the column index for the next row
                }

                // Display the filled Excel file using Excel application
                excelApp.Visible = true;

                // Release Excel objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            }
            else if (labelArea.Text == "PLANTING BY ECOLOGICAL ZONE ACCOMPLISHMENTS")
            {
                // Retrieve data from the controller
                string cornPrId = labelCornPrId.Text;
                DataTable data = cropsCornController.LoadCornPlantingEcoYellowView(cornPrId);

                // Get the directory where the application executable is located
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the path to the Excel file relative to the executable path
                string relativePath = Path.Combine("Templates", "CornPlantingByEcologicalZoneReport.xlsx");

                // Combine the executable path with the relative path to get the full file path
                string filePath = Path.Combine(executablePath, relativePath);

                // Create an instance of Excel Application
                Excel.Application excelApp = new Excel.Application();

                // Open the Excel template
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

                // Get the worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1]; // Assuming the first worksheet

                worksheet.Cells[2, 2].Value = worksheet.Cells[2, 2].Text + labelSeason.Text.ToUpper() + " SEASON " + labelSeasonYear.Text;
                worksheet.Cells[5, 2].Value = worksheet.Cells[5, 2].Text + labelMonth.Text.ToUpper() + " " + labelWeek.Text + ", " + labelYear.Text;

                int startRow = 13;
                int startColumn = 2;

                foreach (DataRow row in data.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow, startColumn] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn++;
                    }

                    startRow++; // Move to the next row in Excel
                    startColumn = 2; // Reset the column index for the next row
                }

                DataTable data1 = cropsCornController.LoadCornPlantingEcoWhiteView(cornPrId);
                int startRow1 = 13;
                int startColumn1 = 26;

                foreach (DataRow row in data1.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow1, startColumn1] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn1++;
                    }

                    startRow1++; // Move to the next row in Excel
                    startColumn1 = 26; // Reset the column index for the next row
                }

                DataTable data2 = cropsCornController.LoadCornPlantingEcoTotalView(cornPrId);
                int startRow2 = 13;
                int startColumn2 = 50;

                foreach (DataRow row in data2.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow2, startColumn2] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn2++;
                    }

                    startRow2++; // Move to the next row in Excel
                    startColumn2 = 50; // Reset the column index for the next row
                }

                // Display the filled Excel file using Excel application
                excelApp.Visible = true;

                // Release Excel objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            }
            else if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
            {
                // Retrieve data from the controller
                string cornPrId = labelCornPrId.Text;
                DataTable data = cropsCornController.LoadCornHarvestingGmoView(cornPrId);

                // Get the directory where the application executable is located
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the path to the Excel file relative to the executable path
                string relativePath = Path.Combine("Templates", "CornHarvestingReport.xlsx");

                // Combine the executable path with the relative path to get the full file path
                string filePath = Path.Combine(executablePath, relativePath);

                // Create an instance of Excel Application
                Excel.Application excelApp = new Excel.Application();

                // Open the Excel template
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

                // Get the worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1]; // Assuming the first worksheet

                worksheet.Cells[3, 2].Value = worksheet.Cells[3, 2].Text + labelMonth.Text.ToUpper() + " " + labelWeek.Text + ", " + labelYear.Text +
                   "(" + labelSeason.Text.ToUpper() + " SEASON CY " + labelSeasonYear.Text + ")";

                int startRow = 12;
                int startColumn = 2;

                foreach (DataRow row in data.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow, startColumn] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn++;
                    }

                    startRow++; // Move to the next row in Excel
                    startColumn = 2; // Reset the column index for the next row
                }

                DataTable data1 = cropsCornController.LoadCornHarvestingHybridView(cornPrId);
                int startRow1 = 12;
                int startColumn1 = 26;

                foreach (DataRow row in data1.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow1, startColumn1] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn1++;
                    }

                    startRow1++; // Move to the next row in Excel
                    startColumn1 = 26; // Reset the column index for the next row
                }

                DataTable data2 = cropsCornController.LoadCornHarvestingOpvView(cornPrId);
                int startRow2 = 12;
                int startColumn2 = 50;

                foreach (DataRow row in data2.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow2, startColumn2] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn2++;
                    }

                    startRow2++; // Move to the next row in Excel
                    startColumn2 = 50; // Reset the column index for the next row
                }

                DataTable data3 = cropsCornController.LoadCornHarvestingGreenSweetView(cornPrId);
                int startRow3 = 12;
                int startColumn3 = 74;

                foreach (DataRow row in data3.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow3, startColumn3] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn3++;
                    }

                    startRow3++; // Move to the next row in Excel
                    startColumn3 = 74; // Reset the column index for the next row
                }

                DataTable data4 = cropsCornController.LoadCornHarvestingTraditionalView(cornPrId);
                int startRow4 = 12;
                int startColumn4 = 98;

                foreach (DataRow row in data4.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow4, startColumn4] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn4++;
                    }

                    startRow4++; // Move to the next row in Excel
                    startColumn4 = 98; // Reset the column index for the next row
                }

                DataTable data5 = cropsCornController.LoadCornHarvestingTotalView(cornPrId);
                int startRow5 = 12;
                int startColumn5 = 122;

                foreach (DataRow row in data4.Rows)
                {
                    for (int i = 2; i <= 25; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow5, startColumn5] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn5++;
                    }

                    startRow5++; // Move to the next row in Excel
                    startColumn5 = 122; // Reset the column index for the next row
                }

                // Display the filled Excel file using Excel application
                excelApp.Visible = true;

                // Release Excel objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            }
        }
        private void NumOrDecimalsOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_NumericWithDecimal(sender, e);
        }

        private void SelectedPanel(object sender, EventArgs e)
        {
            Control focusedControl = sender as Control;

            if (focusedControl.Parent == panelPlantingByEcoZone)
            {
                PanelSelected.Panel_Enter(panelPlantingByEcoZone, panelPlantingByEcoZoneHeader);
            }
        }

        private void UnselectedPanel(object sender, EventArgs e)
        {
            Control focusedControl = sender as Control;

            if (focusedControl.Parent == panelPlantingByEcoZone)
            {
                PanelSelected.Panel_Leave(panelPlantingByEcoZone, panelPlantingByEcoZoneHeader);
            }

        }
    }
}