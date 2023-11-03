﻿using AgRecords.Controller;
using AgRecords.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Drawing.Printing;
using System.IO;
using System.IO.Packaging;
using System.Reflection.Metadata;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace AgRecords.View
{
    public partial class CropsRiceEditView : Form
    {
        private CropsRiceController cropsRiceController;
        public event EventHandler FormClosed;


        public CropsRiceEditView(RicePlantingRep rpr, RiceStandingRep rsr, RiceHarvestingRep rhr)
        {
            InitializeComponent();
            cropsRiceController = new CropsRiceController(this);

            // RicePlantingRep
            if (rpr != null)
            {
                labelArea.Text = "PLANTING ACCOMPLISHMENTS";
                labelRiceSrId.Text = rpr.riceSrId.ToString();
                labelSeason.Text = rpr.season.ToString();
                labelSeasonYear.Text = rpr.seasonYear.ToString();
                labelMonth.Text = rpr.month.ToString();
                labelWeek.Text = rpr.week.ToString();
                labelYear.Text = rpr.year.ToString();
            }

            // RiceStandingRep
            if (rsr != null)
            {
                labelArea.Text = "STANDING ACCOMPLISHMENTS";
                labelRiceSrId.Text = rsr.riceSrId.ToString();
                labelMonth.Text = rsr.month.ToString();
                labelWeek.Text = rsr.week.ToString();
                labelYear.Text = rsr.year.ToString();
            }

            // RiceHarvestingRep
            if (rhr != null)
            {
                labelArea.Text = "HARVESTING ACCOMPLISHMENTS";
                labelRiceSrId.Text = rhr.riceSrId.ToString();
                labelSeason.Text = rhr.season.ToString();
                labelSeasonYear.Text = rhr.seasonYear.ToString();
                labelMonth.Text = rhr.month.ToString();
                labelWeek.Text = rhr.week.ToString();
                labelYear.Text = rhr.year.ToString();
            }
        }

        //Methods

        public void FormRefresh()
        {
            btnUpdate.Visible = false;
            labelRiceStandingLogsId.Visible = false;
            ClearStandingLogsTextControls();

            btnPrint.Enabled = true;

            if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS" || labelArea.Text == "PLANTING ACCOMPLISHMENTS")
            {
                btnNew.Enabled = false;
                btnNew.Visible = false;
            }
            else
            {
                btnNew.Enabled = true;
                btnNew.Visible = true;
            }
        }

        public void ClearStandingLogsTextControls()
        {
            cmbBrgy.SelectedIndex = -1;
            cmbFarmType.SelectedIndex = -1;
            //cmbGrowthStage.SelectedIndex = -1;
            cmbSeedType.SelectedIndex = -1;
            txtSize.Text = "";
            dtpLogDate.Value = DateTime.Now;
            labelRiceStandingLogsId.Text = "";
            txtAveYield.Text = "";
        }

        public void HideControls()
        {
            if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
            {
                btnNew.Visible = false;
                btnUpdate.Visible = false;

                labelAveYield.Visible = false;
                txtAveYield.Visible = false;
                boxAveYield.Visible = false;

                labelSeedTypeFilter.Visible = false;
                boxSeedTypeFilter.Visible = false;
                cmbSeedTypeFilter.Visible = false;

                txtSize.ReadOnly = true;
                txtSize.ForeColor = SystemColors.WindowText;
                txtSize.BackColor = Color.White;

                labelGrowthStage.Text = "Vegetative Stage";
                labelSize.Text = "Size (ha)";
            }
            else if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
            {
                btnNew.Visible = true;
                btnUpdate.Visible = true;

                labelAveYield.Visible = true;
                txtAveYield.Visible = true;
                boxAveYield.Visible = true;

                labelSeedTypeFilter.Visible = true;
                boxSeedTypeFilter.Visible = true;
                cmbSeedTypeFilter.Visible = true;

                txtSize.ReadOnly = true;
                txtSize.ForeColor = SystemColors.WindowText;
                txtSize.BackColor = Color.White;

                labelGrowthStage.Text = "Harvested";

                labelSize.Text = "Area Harvested (ha)";
            }
            else if (labelArea.Text == "STANDING ACCOMPLISHMENTS")
            {
                btnNew.Visible = true;
                btnUpdate.Visible = true;

                labelAveYield.Visible = false;
                txtAveYield.Visible = false;
                boxAveYield.Visible = false;

                labelSeedTypeFilter.Visible = false;
                boxSeedTypeFilter.Visible = false;
                cmbSeedTypeFilter.Visible = false;

                labelSeason.Visible = false;
                labelSeasonl.Visible = false;
                boxSeason.Visible = false;

                labelSeasonYearl.Visible = false;
                labelSeasonYear.Visible = false;
                boxSeasonYear.Visible = false;

                labelSize.Text = "Size (ha)";
            }

        }

        private int MapSeedItemToValue(ComboBox comboBox)
        {
            string selectedSeedItem = comboBox.SelectedItem?.ToString(); // Use ?. to handle potential null value
            int seedId = 1; // Default value or value for unhandled cases

            if (selectedSeedItem != null)
            {
                switch (selectedSeedItem)
                {
                    case "Hybrid Seeds":
                        seedId = 1;
                        break;
                    case "Tagged Seeds":
                        seedId = 2;
                        break;
                    case "Good Quality Seeds":
                        seedId = 3;
                        break;
                    case "Farmers Saved Seeds":
                        seedId = 4;
                        break;
                        // Handle other cases here if needed
                }
            }

            return seedId;
        }

        private void HandleCheckboxConditions()
        {
            string riceSrId = labelRiceSrId.Text;
            int seedId = MapSeedItemToValue(cmbSeedTypeFilter);

            if (cbIrrigated.Checked)
            {
                cbLowland.Checked = false;
                cbUpland.Checked = false;

                // Handle your logic for the selected area
                if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
                {
                    DataTable riceStandLogsTable = cropsRiceController.LoadIrrigatedRicePlantingView(riceSrId);
                    dgvRiceStandLogs.DataSource = riceStandLogsTable;
                }
                else if (labelArea.Text == "STANDING ACCOMPLISHMENTS")
                {
                    DataTable riceStandLogsTable = cropsRiceController.LoadIrrigatedRiceStandLogsView(riceSrId);
                    dgvRiceStandLogs.DataSource = riceStandLogsTable;
                }
                else if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
                {
                    DataTable riceStandLogsTable = cropsRiceController.LoadIrrigatedRiceHarvestingView(riceSrId, seedId);
                    dgvRiceStandLogs.DataSource = riceStandLogsTable;
                }
            }

            if (cbLowland.Checked)
            {
                cbIrrigated.Checked = false;
                cbUpland.Checked = false;

                // Handle your logic for the selected area
                if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
                {
                    DataTable riceStandLogsTable = cropsRiceController.LoadLowlandRicePlantingView(riceSrId);
                    dgvRiceStandLogs.DataSource = riceStandLogsTable;
                }
                else if (labelArea.Text == "STANDING ACCOMPLISHMENTS")
                {
                    DataTable riceStandLogsTable = cropsRiceController.LoadLowlandRiceStandLogsView(riceSrId);
                    dgvRiceStandLogs.DataSource = riceStandLogsTable;
                }
                else if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
                {
                    DataTable riceStandLogsTable = cropsRiceController.LoadLowlandRiceHarvestingView(riceSrId, seedId);
                    dgvRiceStandLogs.DataSource = riceStandLogsTable;
                }
            }

            if (cbUpland.Checked)
            {
                cbIrrigated.Checked = false;
                cbLowland.Checked = false;

                // Handle your logic for the selected area
                if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
                {
                    DataTable riceStandLogsTable = cropsRiceController.LoadUplandRicePlantingView(riceSrId);
                    dgvRiceStandLogs.DataSource = riceStandLogsTable;
                }
                else if (labelArea.Text == "STANDING ACCOMPLISHMENTS")
                {
                    DataTable riceStandLogsTable = cropsRiceController.LoadUplandRiceStandLogsView(riceSrId);
                    dgvRiceStandLogs.DataSource = riceStandLogsTable;
                }
                else if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
                {
                    DataTable riceStandLogsTable = cropsRiceController.LoadUplandRiceHarvestingView(riceSrId, seedId);
                    dgvRiceStandLogs.DataSource = riceStandLogsTable;
                }
            }
        }

        // Events

        private void CropsRiceEditView_Load(object sender, EventArgs e)
        {
            FormRefresh();
            cbIrrigated.Checked = true;

            cmbSeedTypeFilter.SelectedIndex = 0;

            btnUpdate.Enabled = false;

            HideControls();
        }

        private void dgvRiceStandLogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Visible = true;
            labelRiceStandingLogsId.Visible = true;

            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvRiceStandLogs.Rows[e.RowIndex];

                if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
                {
                    btnNew.Visible = false;
                    btnUpdate.Visible = false;
                    int ricePlantingId = Convert.ToInt32(row.Cells[0].Value);

                    labelRiceStandingLogsId.Text = ricePlantingId.ToString();

                    RicePlanting rp = cropsRiceController.GetRicePlantingById(ricePlantingId);
                    if (rp != null)
                    {

                        int brgyIndex = rp.brgyId - 1; // Convert from 1-based ID to 0-based index
                        if (brgyIndex >= 0 && brgyIndex < cmbBrgy.Items.Count)
                        {
                            cmbBrgy.SelectedIndex = brgyIndex;
                        }

                        int farmIndex = rp.farmTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (farmIndex >= 0 && farmIndex < cmbFarmType.Items.Count)
                        {
                            cmbFarmType.SelectedIndex = farmIndex;
                        }

                        int seedIndex = rp.seedTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (seedIndex >= 0 && seedIndex < cmbSeedType.Items.Count)
                        {
                            cmbSeedType.SelectedIndex = seedIndex;
                        }

                        txtSize.Text = rp.size.ToString();
                    }
                }

                if (labelArea.Text == "STANDING ACCOMPLISHMENTS")
                {
                    if (labelGrowthStage.Text == "Newly Planted/Seedling Stage")
                    {
                        btnUpdate.Enabled = true;
                    }
                    else
                    {
                        btnUpdate.Enabled = false;
                    }

                    int riceStandingLogsId = Convert.ToInt32(row.Cells[0].Value);

                    labelRiceStandingLogsId.Text = riceStandingLogsId.ToString();

                    RiceStanding rs = cropsRiceController.GetRiceStandingLogsById(riceStandingLogsId);
                    if (rs != null)
                    {

                        int brgyIndex = rs.brgyId - 1; // Convert from 1-based ID to 0-based index
                        if (brgyIndex >= 0 && brgyIndex < cmbBrgy.Items.Count)
                        {
                            cmbBrgy.SelectedIndex = brgyIndex;
                        }

                        int farmIndex = rs.farmTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (farmIndex >= 0 && farmIndex < cmbFarmType.Items.Count)
                        {
                            cmbFarmType.SelectedIndex = farmIndex;
                        }

                        int seedIndex = rs.seedTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (seedIndex >= 0 && seedIndex < cmbSeedType.Items.Count)
                        {
                            cmbSeedType.SelectedIndex = seedIndex;
                        }

                        //int growthIndex = rs.growthStageId - 1; // Convert from 1-based ID to 0-based index
                        //if (growthIndex >= 0 && growthIndex < cmbGrowthStage.Items.Count)
                        //{
                        //    cmbGrowthStage.SelectedIndex = growthIndex;
                        //}

                        int growthStageId = rs.growthStageId;

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

                        txtSize.Text = rs.size.ToString();
                        dtpLogDate.Text = rs.logDate.ToString();
                    }
                }

                if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
                {
                    btnNew.Visible = false;
                    btnNew.Enabled = false;
                    btnUpdate.Visible = true;
                    btnUpdate.Enabled = true;

                    int riceHarvestingId = Convert.ToInt32(row.Cells[0].Value);

                    labelRiceStandingLogsId.Text = riceHarvestingId.ToString();

                    RiceHarvesting rh = cropsRiceController.GetRiceHarvestingById(riceHarvestingId);
                    if (rh != null)
                    {

                        int brgyIndex = rh.brgyId - 1; // Convert from 1-based ID to 0-based index
                        if (brgyIndex >= 0 && brgyIndex < cmbBrgy.Items.Count)
                        {
                            cmbBrgy.SelectedIndex = brgyIndex;
                        }

                        int farmIndex = rh.farmTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (farmIndex >= 0 && farmIndex < cmbFarmType.Items.Count)
                        {
                            cmbFarmType.SelectedIndex = farmIndex;
                        }

                        int seedIndex = rh.seedTypeId - 1; // Convert from 1-based ID to 0-based index
                        if (seedIndex >= 0 && seedIndex < cmbSeedType.Items.Count)
                        {
                            cmbSeedType.SelectedIndex = seedIndex;
                        }

                        txtSize.Text = rh.size.ToString();
                        txtAveYield.Text = rh.yield.ToString();
                    }
                }
            }
        }

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
            else if (labelArea.Text == "STANDING ACCOMPLISHMENTS")
            {
                btnUpdate.Visible = false;
                btnNew.Visible = true;
            }

            int brgyIndex = cmbBrgy.SelectedIndex;
            int farmTypeIndex = cmbFarmType.SelectedIndex;
            //int growthStageIndex = cmbGrowthStage.SelectedIndex;
            int seedTypeIndex = cmbSeedType.SelectedIndex;

            // Retrieve the corresponding integer values based on the indices
            int brgyId = brgyIndex + 1; // Add 1 to convert from 0-based index to 1-based ID
            int farmTypeId = farmTypeIndex + 1;
            //int growthStageId = growthStageIndex + 1;
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
            float yield = float.Parse(txtAveYield.Text);
            int riceStandingLogsId = int.Parse(labelRiceStandingLogsId.Text);
            int riceHarvestingId = int.Parse(labelRiceStandingLogsId.Text);


            if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
            {
                if (cropsRiceController.UpdateRiceHarvesting(riceHarvestingId, yield))
                {
                    FormRefresh();
                }
            }
            else if (labelArea.Text == "PLANTING BY ECOLOGICAL ZONE ACCOMPLISHMENTS")
            {
                if (cropsRiceController.UpdateRiceStandingLog(riceStandingLogsId, brgyId, farmTypeId, growthStageId, seedTypeId, size, dtpLogDate.Value.Date))
                {
                    FormRefresh();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int brgyIndex = cmbBrgy.SelectedIndex;
            int farmTypeIndex = cmbFarmType.SelectedIndex;
            //int growthStageIndex = cmbGrowthStage.SelectedIndex;
            int seedTypeIndex = cmbSeedType.SelectedIndex;

            // Retrieve the corresponding integer values based on the indices
            int brgyId = brgyIndex + 1; // Add 1 to convert from 0-based index to 1-based ID
            int farmTypeId = farmTypeIndex + 1;
            //int growthStageId = growthStageIndex + 1;
            int seedTypeId = seedTypeIndex + 1;

            int growthStageId = 1;
            float size = float.Parse(txtSize.Text);

            if (cropsRiceController.AddRiceStandingLogs(labelRiceSrId.Text, brgyId, farmTypeId, growthStageId, seedTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnNew.Visible = true;
            labelRiceStandingLogsId.Visible = false;
            ClearStandingLogsTextControls();
        }

        private void cbIrrigated_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIrrigated.Checked)
            {
                HandleCheckboxConditions();
            }
        }

        private void cbLowland_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLowland.Checked)
            {
                HandleCheckboxConditions();
            }
        }

        private void cbUpland_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUpland.Checked)
            {
                HandleCheckboxConditions();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
        }

        private void cmbSeedTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleCheckboxConditions();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
            {
                // Retrieve data from the controller
                string riceSrId = labelRiceSrId.Text;
                DataTable data = cropsRiceController.LoadRicePlantingView(riceSrId);

                // Get the directory where the application executable is located
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the path to the Excel file relative to the executable path
                string relativePath = Path.Combine("Templates", "RicePlantingReport.xlsx");

                // Combine the executable path with the relative path to get the full file path
                string filePath = Path.Combine(executablePath, relativePath);

                // Create an instance of Excel Application
                Excel.Application excelApp = new Excel.Application();

                // Open the Excel template
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

                // Get the worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1]; // Assuming the first worksheet

                worksheet.Cells[3, 1].Value = worksheet.Cells[3, 1].Text + labelSeason.Text.ToUpper() + " SEASON " + labelSeasonYear.Text;
                worksheet.Cells[4, 1].Value = worksheet.Cells[4, 1].Text + labelMonth.Text + " " + labelWeek.Text + ", " + labelYear.Text;

                int startRow = 12;
                int startColumn = 2;

                foreach (DataRow row in data.Rows)
                {
                    for (int i = 2; i <= 21; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow, startColumn] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn++;
                    }

                    startRow++; // Move to the next row in Excel
                    startColumn = 2; // Reset the column index for the next row
                }

                // Display the filled Excel file using Excel application
                excelApp.Visible = true;

                // Release Excel objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            }
            else if (labelArea.Text == "STANDING ACCOMPLISHMENTS")
            {
                // Retrieve data from the controller
                string riceSrId = labelRiceSrId.Text;
                DataTable data = cropsRiceController.LoadRiceStandingView(riceSrId);

                // Get the directory where the application executable is located
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the path to the Excel file relative to the executable path
                string relativePath = Path.Combine("Templates", "RiceStandingReport.xlsx");

                // Combine the executable path with the relative path to get the full file path
                string filePath = Path.Combine(executablePath, relativePath);

                // Create an instance of Excel Application
                Excel.Application excelApp = new Excel.Application();

                // Open the Excel template
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

                // Get the worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1]; // Assuming the first worksheet

                worksheet.Cells[5, 1].Value = worksheet.Cells[5, 1].Text + labelMonth.Text + " " + labelWeek.Text + ", " + labelYear.Text;

                int startRow = 11;
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

                // Display the filled Excel file using Excel application
                excelApp.Visible = true;

                // Release Excel objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                // Optionally, you can quit the Excel application here if needed
                //excelApp.Quit();
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            else if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
            {
                // Retrieve data from the controller
                string riceSrId = labelRiceSrId.Text;
                DataTable data = cropsRiceController.LoadRiceIrrigatedHarvestingView(riceSrId);
                DataTable data1 = cropsRiceController.LoadRiceLowlandHarvestingView(riceSrId);
                DataTable data2 = cropsRiceController.LoadRiceUplandHarvestingView(riceSrId);

                // Get the directory where the application executable is located
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the path to the Excel file relative to the executable path
                string relativePath = Path.Combine("Templates", "RiceHarvestingReport.xlsx");

                // Combine the executable path with the relative path to get the full file path
                string filePath = Path.Combine(executablePath, relativePath);

                // Create an instance of Excel Application
                Excel.Application excelApp = new Excel.Application();

                // Open the Excel template
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

                // Get the worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1]; // Assuming the first worksheet

                worksheet.Cells[3, 1].Value = worksheet.Cells[3, 1].Text + labelSeason.Text.ToUpper() + " SEASON " + labelSeasonYear.Text;
                worksheet.Cells[4, 1].Value = worksheet.Cells[4, 1].Text + labelMonth.Text.ToUpper() + " " + labelWeek.Text + ", " + labelYear.Text;

                int startRow = 9;
                int startColumn = 2;

                foreach (DataRow row in data.Rows)
                {
                    for (int i = 1; i <= 15; i++) // Loop through all columns, including the first column
                    {
                        worksheet.Cells[startRow, startColumn] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn++;
                    }

                    startRow++; // Move to the next row in Excel
                    startColumn = 2; // Reset the column index for the next row
                }

                // Get the worksheet
                Excel.Worksheet worksheet1 = (Excel.Worksheet)workbook.Worksheets[2];

                worksheet1.Cells[3, 1].Value = worksheet1.Cells[3, 1].Text + labelSeason.Text.ToUpper() + " SEASON " + labelSeasonYear.Text;
                worksheet1.Cells[4, 1].Value = worksheet1.Cells[4, 1].Text + labelMonth.Text.ToUpper() + " " + labelWeek.Text + ", " + labelYear.Text;

                int startRow1 = 9;
                int startColumn1 = 2;

                foreach (DataRow row in data1.Rows)
                {
                    for (int i = 1; i <= 15; i++) // Loop through all columns, including the first column
                    {
                        worksheet1.Cells[startRow1, startColumn1] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn1++;
                    }

                    startRow1++; // Move to the next row in Excel
                    startColumn1 = 2; // Reset the column index for the next row
                }

                // Get the worksheet
                Excel.Worksheet worksheet2 = (Excel.Worksheet)workbook.Worksheets[3];

                worksheet2.Cells[3, 1].Value = worksheet2.Cells[3, 1].Text + labelSeason.Text.ToUpper() + " SEASON " + labelSeasonYear.Text;
                worksheet2.Cells[4, 1].Value = worksheet2.Cells[4, 1].Text + labelMonth.Text.ToUpper() + " " + labelWeek.Text + ", " + labelYear.Text;

                int startRow2 = 9;
                int startColumn2 = 2;

                foreach (DataRow row in data2.Rows)
                {
                    for (int i = 1; i <= 15; i++) // Loop through all columns, including the first column
                    {
                        worksheet2.Cells[startRow2, startColumn2] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                        startColumn2++;
                    }

                    startRow2++; // Move to the next row in Excel
                    startColumn2 = 2; // Reset the column index for the next row
                }

                // Display the filled Excel file using Excel application
                excelApp.Visible = true;

                // Release Excel objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}