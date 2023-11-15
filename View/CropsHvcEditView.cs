using AgRecords.Controller;
using AgRecords.Model;
using AgRecords.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AgRecords.View
{
    public partial class CropsHvcEditView : Form
    {
        private CropsHvcController cropsHvcController;
        public event EventHandler FormClosed;

        public CropsHvcEditView(HvcReport hr)
        {
            InitializeComponent();
            cropsHvcController = new CropsHvcController(this);

            labelHvcSrId.Text = hr.hvcSrId.ToString();
            labelMonth.Text = hr.month.ToString();
            labelWeek.Text = hr.week.ToString();
            labelYear.Text = hr.year.ToString();
        }

        // Method

        public void FormRefresh()
        {
            dtpLogDate.MaxDate = DateTime.Today;

            btnUpdate.Visible = false;
            ClearTextControls();

            btnNew.Enabled = true;
            btnNew.Visible = true;

            DisplayDataTableFilter();
        }

        public void ClearTextControls()
        {
            cmbCropType.SelectedIndex = -1;
            txtSize.Text = "";
            dtpLogDate.Value = DateTime.Now;
            labelHvcStandingId.Text = "";
            labelCropStage.Text = "Newly Transplanted";
        }

        public void DisplayDataTableFilter()
        {
            string hvcSrId = labelHvcSrId.Text;

            DataTable hvcStandingTable = cropsHvcController.LoadHvcStandingView(hvcSrId);
            dgvHvcStanding.DataSource = hvcStandingTable;
        }

        private void CropsHvcEditView_Load(object sender, EventArgs e)
        {
            FormRefresh();

            btnUpdate.Enabled = false;

            DisplayDataTableFilter();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            labelHvcStandingId.Visible = false;

            int cropTypeIndex = cmbCropType.SelectedIndex;

            int cropTypeId = cropTypeIndex + 1;

            string cropStageText = labelCropStage.Text;
            int cropStageId = 0;

            switch (cropStageText)
            {
                case "Newly Transplanted":
                    cropStageId = 1;
                    break;
                case "Vegetative":
                    cropStageId = 2;
                    break;
                case "Reproductive":
                    cropStageId = 3;
                    break;
                case "Maturity/Harvestable":
                    cropStageId = 4;
                    break;
                default:
                    break;
            }

            float size = float.Parse(txtSize.Text);
            int hvcStandingId = int.Parse(labelHvcStandingId.Text);

            if (cropsHvcController.UpdateHvcStanding(hvcStandingId, cropStageId, cropTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;

            int cropTypeIndex = cmbCropType.SelectedIndex;

            int cropTypeId = cropTypeIndex + 1;

            int cropStageId = 1;
            float size = 0.00f;
            if (!string.IsNullOrEmpty(txtSize.Text))
            {
                size = float.Parse(txtSize.Text);
            }


            if (cropsHvcController.AddHvcStanding(labelHvcSrId.Text, cropStageId, cropTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnNew.Visible = true;
            ClearTextControls();
        }

        private void dgvHvcStanding_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Visible = true;

            if (labelCropStage.Text == "Newly Transplanted")
            {
                btnUpdate.Enabled = true;
                btnNew.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnNew.Enabled = false;
            }

            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvHvcStanding.Rows[e.RowIndex];

                int hvcStandingId = Convert.ToInt32(row.Cells[0].Value);

                labelHvcStandingId.Text = hvcStandingId.ToString();

                HvcStanding hs = cropsHvcController.GetHvcStandingById(hvcStandingId);
                if (hs != null)
                {
                    int cropTypeIndex = hs.cropTypeId - 1; // Convert from 1-based ID to 0-based index
                    if (cropTypeIndex >= 0 && cropTypeIndex < cmbCropType.Items.Count)
                    {
                        cmbCropType.SelectedIndex = cropTypeIndex;
                    }

                    int cropStageId = hs.cropStageId;

                    switch (cropStageId)
                    {
                        case 1:
                            labelCropStage.Text = "Newly Transplanted";
                            break;
                        case 2:
                            labelCropStage.Text = "Vegetative";
                            break;
                        case 3:
                            labelCropStage.Text = "Reproductive";
                            break;
                        case 4:
                            labelCropStage.Text = "Maturity/Harvestable";
                            break;
                        default:
                            labelCropStage.Text = "Unknown Stage";
                            break;
                    }

                    txtSize.Text = hs.size.ToString();
                    dtpLogDate.Text = hs.logDate.ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Retrieve data from the controller
            string hvcSrId = labelHvcSrId.Text;
            DataTable data = cropsHvcController.LoadStandingHvcPinakbetView(hvcSrId);
            DataTable data1 = cropsHvcController.LoadStandingHvcRootcropsView(hvcSrId);
            DataTable data2 = cropsHvcController.LoadStandingHvcPlantationView(hvcSrId);

            // Get the directory where the application executable is located
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Specify the path to the Excel file relative to the executable path
            string relativePath = Path.Combine("Templates", "HVCStandingReport.xlsx");

            // Combine the executable path with the relative path to get the full file path
            string filePath = Path.Combine(executablePath, relativePath);

            // Create an instance of Excel Application
            Excel.Application excelApp = new Excel.Application();

            // Open the Excel template
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

            // Get the worksheet
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1]; // Assuming the first worksheet

            worksheet.Cells[6, 1].Value = worksheet.Cells[6, 1].Text + labelMonth.Text + " " + labelWeek.Text + ", " + labelYear.Text;

            int startRow = 10;
            int startColumn = 4;

            foreach (DataRow row in data.Rows)
            {
                for (int i = 2; i <= 6; i++) // Loop through all columns, including the first column
                {
                    worksheet.Cells[startRow, startColumn] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                    startColumn++;
                }

                startRow++; // Move to the next row in Excel
                startColumn = 4; // Reset the column index for the next row
            }

            int startRow1 = 21;
            int startColumn1 = 4;

            foreach (DataRow row in data1.Rows)
            {
                for (int i = 2; i <= 6; i++) // Loop through all columns, including the first column
                {
                    worksheet.Cells[startRow1, startColumn1] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                    startColumn1++;
                }

                startRow1++; // Move to the next row in Excel
                startColumn1 = 4; // Reset the column index for the next row
            }

            int startRow2 = 25;
            int startColumn2 = 4;

            foreach (DataRow row in data2.Rows)
            {
                for (int i = 2; i <= 6; i++) // Loop through all columns, including the first column
                {
                    worksheet.Cells[startRow2, startColumn2] = row[i] != DBNull.Value ? row[i].ToString() : string.Empty;
                    startColumn2++;
                }

                startRow2++; // Move to the next row in Excel
                startColumn2 = 4; // Reset the column index for the next row
            }

            // Display the filled Excel file using Excel application
            excelApp.Visible = true;

            // Release Excel objects
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
        }

        private void NumOrDecimalsOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_NumericWithDecimal(sender, e);
        }

        private void SelectedPanel(object sender, EventArgs e)
        {
            Control focusedControl = sender as Control;

            if (focusedControl.Parent == panelStandingAccomplishments)
            {
                PanelSelected.Panel_Enter(panelStandingAccomplishments, panelStandingAccomplishmentsHeader);
            }
        }

        private void UnselectedPanel(object sender, EventArgs e)
        {
            Control focusedControl = sender as Control;

            if (focusedControl.Parent == panelStandingAccomplishments)
            {
                PanelSelected.Panel_Leave(panelStandingAccomplishments, panelStandingAccomplishmentsHeader);
            }

        }
    }
}
