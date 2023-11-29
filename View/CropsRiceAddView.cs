using AgRecords.Controller;
using AgRecords.Model;
using AgRecords.Utilities;
using Google.Protobuf.WellKnownTypes;
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
    public partial class CropsRiceAddView : Form
    {
        private CropsRiceController cropsRiceController;
        public event EventHandler FormClosed;

        public CropsRiceAddView()
        {
            InitializeComponent();
            cropsRiceController = new CropsRiceController(this);
        }

        //Methods

        public void FormRefresh()
        {
            dtpLogDate.MaxDate = DateTime.Today;

            btnUpdate.Enabled = false;
            string riceSrId = labelRiceSrId.Text;

            //DataTable riceStandLogsTable = cropsRiceController.LoadRiceStandLogsView(riceSrId);
            //dgvRiceStandLogs.DataSource = riceStandLogsTable;

            RiceStandingRep rsr = cropsRiceController.GetRiceStandReportById(riceSrId);
            if (rsr != null)
            {
                labelWeek.Text = rsr.week;
                labelMonth.Text = rsr.month;
                labelYear.Text = rsr.year;
            }

            ClearStandingLogsTextControls();

            DisplayDataTableFilter();
        }

        public void ClearStandingLogsTextControls()
        {
            cmbBrgy.SelectedIndex = 0;
            //cmbGrowthStage.SelectedIndex = -1;
            txtSize.Text = "";
            dtpLogDate.Value = DateTime.Today;
            labelRiceStandingLogsId.Text = "";
            labelGrowthStage.Text = "Newly Planted/Seedling Stage";
        }

        public string RiceSrIdValue
        {
            get { return labelRiceSrId.Text; }
            set { labelRiceSrId.Text = value; }
        }

        private int MapRiceLandItemToValue(ComboBox comboBox)
        {
            string selectedLandItem = comboBox.SelectedItem?.ToString(); // Use ?. to handle potential null value
            int landId = 1; // Default value or value for unhandled cases

            if (selectedLandItem != null)
            {
                switch (selectedLandItem)
                {
                    case "Irrigated":
                        landId = 1;
                        break;
                    case "Rainfed Lowland":
                        landId = 2;
                        break;
                    case "Rainfed Upland":
                        landId = 3;
                        break;
                        // Handle other cases here if needed
                }
            }

            return landId;
        }

        private int MapRiceSeedItemToValue(ComboBox comboBox)
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

        public void DisplayDataTableFilter()
        {
            string riceSrId = labelRiceSrId.Text;
            int farmId = MapRiceLandItemToValue(cmbFarmType);
            int seedId = MapRiceSeedItemToValue(cmbSeedType);

            if (cbTotal.Checked)
            {
                cbGrandTotal.Checked = false;
                DataTable riceStandingTable = cropsRiceController.LoadRiceStandingTotalView(riceSrId, farmId, seedId);
                dgvRiceStandLogs.DataSource = riceStandingTable;
            }
            else if (cbGrandTotal.Checked)
            {
                cbTotal.Checked = false;
                DataTable riceStandingTable = cropsRiceController.LoadRiceStandingGrandTotalView(riceSrId);
                dgvRiceStandLogs.DataSource = riceStandingTable;
            }
            else if (cbTotal.Checked == false && cbGrandTotal.Checked == false)
            {
                DataTable riceStandingTable = cropsRiceController.LoadRiceStandingView(riceSrId, farmId, seedId);
                dgvRiceStandLogs.DataSource = riceStandingTable;
            }
        }


        // Events
        private void CropsRiceAddView_Load(object sender, EventArgs e)
        {
            FormRefresh();

            HomeView.Instance.title.Text = "Crops \u23F5 Rice \u23F5 Add Standing Rice";

            cbTotal.Checked = true;

            cmbFarmType.SelectedIndex = 0;
            cmbSeedType.SelectedIndex = 0;
        }

        private void dgvRiceStandLogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvRiceStandLogs.Rows[e.RowIndex];


                if (row.Cells[0].Value != null)
                {
                    if (int.TryParse(row.Cells[0].Value.ToString(), out int riceStandingLogsId))
                    {
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
                    else
                    {
                        // Handle the case where parsing the ID fails (e.g., show an error message).
                        MessageBox.Show("Invalid Rice Standing ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Handle the case where the cell value is null or empty.
                    MessageBox.Show("Rice Standing ID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnNew.Enabled = true;

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

            float size = 0.00f;
            if (!string.IsNullOrEmpty(txtSize.Text))
            {
                size = float.Parse(txtSize.Text);
            }

            int riceStandingLogsId = int.Parse(labelRiceStandingLogsId.Text);

            if (cropsRiceController.UpdateRiceStandingLog(riceStandingLogsId, brgyId, farmTypeId, growthStageId, seedTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
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
            float size = 0.00f;
            if (!string.IsNullOrEmpty(txtSize.Text))
            {
                size = float.Parse(txtSize.Text);
            }


            if (cropsRiceController.AddRiceStandingLogs(labelRiceSrId.Text, brgyId, farmTypeId, growthStageId, seedTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            labelRiceStandingLogsId.Visible = true;
            ClearStandingLogsTextControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void cmbFarmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void cmbSeedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void cbGrandTotal_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbGrandTotal.Checked)
            {
                cbTotal.Checked = false;
                DisplayDataTableFilter();

                dgvRiceStandLogs.CellDoubleClick -= dgvRiceStandLogs_CellDoubleClick;
                dgvRiceStandLogs.Columns[0].Visible = false;
            }
            else
            {
                DisplayDataTableFilter();

                dgvRiceStandLogs.CellDoubleClick -= dgvRiceStandLogs_CellDoubleClick;
                dgvRiceStandLogs.Columns[0].Visible = false;
            }
        }

        private void cbTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTotal.Checked)
            {
                cbGrandTotal.Checked = false;
                DisplayDataTableFilter();

                dgvRiceStandLogs.CellDoubleClick -= dgvRiceStandLogs_CellDoubleClick;
                dgvRiceStandLogs.Columns[0].Visible = false;
            }
            else
            {
                DisplayDataTableFilter();

                dgvRiceStandLogs.CellDoubleClick -= dgvRiceStandLogs_CellDoubleClick;
                dgvRiceStandLogs.Columns[0].Visible = false;
            }
        }

        private void NumOrDecimalsOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_NumericWithDecimal(sender, e);
        }

        private void SelectedPanel(object sender, EventArgs e)
        {
            Control focusedControl = sender as Control;

            if (focusedControl.Parent == panelStandingAccomplishments || focusedControl == dtpLogDate)
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
