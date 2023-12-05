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

namespace AgRecords.View
{
    public partial class CropsHvcAddView : Form
    {
        private CropsHvcController cropsHvcController;
        public event EventHandler FormClosed;

        public CropsHvcAddView()
        {
            InitializeComponent();
            cropsHvcController = new CropsHvcController(this);
        }

        // Methods

        public string HvcSrIdValue
        {
            get { return labelHvcSrId.Text; }
            set { labelHvcSrId.Text = value; }
        }

        public void FormRefresh()
        {
            dtpLogDate.MaxDate = DateTime.Today;

            btnUpdate.Enabled = false;
            ClearTextControls();
            DisplayDataTableFilter();
        }

        public void ClearTextControls()
        {
            cmbCropType.SelectedIndex = -1;
            txtSize.Text = "";
            dtpLogDate.Value = DateTime.Today;
            labelHvcStandingId.Text = "";
            labelCropStage.Text = "Newly Transplanted";
        }

        public void DisplayDataTableFilter()
        {
            string hvcSrId = labelHvcSrId.Text;

            if (cbTotal.Checked)
            {
                DataTable hvcStandingTable = cropsHvcController.LoadHvcStandingTotalView(hvcSrId);
                dgvHvcStanding.DataSource = hvcStandingTable;
            }
            else if (cbTotal.Checked == false)
            {
                DataTable hvcStandingTable = cropsHvcController.LoadHvcStandingView(hvcSrId);
                dgvHvcStanding.DataSource = hvcStandingTable;
            }
        }

        private void CropsHvcAddView_Load(object sender, EventArgs e)
        {
            HomeView.Instance.title.Text = "Crops \u23F5 HVC \u23F5 Add Standing HVC";

            string hvcSrId = labelHvcSrId.Text;

            HvcReport hp = cropsHvcController.GetHvcStandingReportById(hvcSrId);
            if (hp != null)
            {
                labelWeek.Text = hp.week;
                labelMonth.Text = hp.month;
                labelYear.Text = hp.year;
            }

            FormRefresh();

            cbTotal.Checked = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnNew.Enabled = true;

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


            float size = 0.00f;
            if (!string.IsNullOrEmpty(txtSize.Text))
            {
                size = float.Parse(txtSize.Text);
            }
            int hvcStandingId = int.Parse(labelHvcStandingId.Text);

            if (cropsHvcController.UpdateHvcStanding(hvcStandingId, cropStageId, cropTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;

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
            btnUpdate.Enabled = false;
            btnNew.Enabled = true;
            ClearTextControls();
        }

        private void dgvHvcStanding_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnNew.Enabled = false;

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

        private void cbTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTotal.Checked)
            {
                DisplayDataTableFilter();

                dgvHvcStanding.CellDoubleClick -= dgvHvcStanding_CellDoubleClick;
                dgvHvcStanding.Columns[0].Visible = false;
            }
            else if (cbTotal.Checked == false)
            {
                DisplayDataTableFilter();

                dgvHvcStanding.CellDoubleClick += dgvHvcStanding_CellDoubleClick;
                dgvHvcStanding.Columns[0].Visible = false;
            }
        }
    }
}
