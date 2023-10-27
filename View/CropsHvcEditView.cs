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
            float size = float.Parse(txtSize.Text);

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
    }
}
