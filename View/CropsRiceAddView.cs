using AgRecords.Controller;
using AgRecords.Model;
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
        public CropsRiceAddView()
        {
            InitializeComponent();
            cropsRiceController = new CropsRiceController(this);
        }

        //Methods

        public void FormRefresh()
        {
            string riceSrId = labelRiceSrId.Text;

            RiceStandingRep rsr = cropsRiceController.GetRiceStandReportById(riceSrId);
            if (rsr != null)
            {
                labelWeek.Text = rsr.week;
                labelMonth.Text = rsr.month;
                labelYear.Text = rsr.year;
            }

            cbIrrigated.Checked = true;
            ShowChecked();

            btnUpdate.Visible = false;
            ClearStandingLogsTextControls();
        }

        public void ClearStandingLogsTextControls()
        {
            cmbBrgy.SelectedIndex = -1;
            cmbFarmType.SelectedIndex = -1;
            cmbGrowthStage.SelectedIndex = -1;
            cmbSeedType.SelectedIndex = -1;
            txtSize.Text = "";
            dtpLogDate.Value = DateTime.Now;
        }

        public string RiceSrIdValue
        {
            get { return labelRiceSrId.Text; }
            set { labelRiceSrId.Text = value; }
        }

        public void ShowChecked()
        {
            string riceSrId = labelRiceSrId.Text;

            if (cbIrrigated.Checked)
            {
                DataTable riceStandLogsTable = cropsRiceController.LoadIrrigatedRiceStandLogsView(riceSrId);
                dgvRiceStandLogs.DataSource = riceStandLogsTable;
            }
            else if (cbLowland.Checked)
            {
                DataTable riceStandLogsTable = cropsRiceController.LoadLowlandRiceStandLogsView(riceSrId);
                dgvRiceStandLogs.DataSource = riceStandLogsTable;
            }
            else if (cbUpland.Checked)
            {
                DataTable riceStandLogsTable = cropsRiceController.LoadUplandRiceStandLogsView(riceSrId);
                dgvRiceStandLogs.DataSource = riceStandLogsTable;
            }
            else if (cbIrrigated.Checked && cbLowland.Checked)
            {

            }
            else if (cbIrrigated.Checked && cbLowland.Checked && cbUpland.Checked)
            {

            }
        }

        // Events
        private void CropsRiceAddView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        private void dgvRiceStandLogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Visible = true;

            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvRiceStandLogs.Rows[e.RowIndex];

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

                    int growthIndex = rs.growthStageId - 1; // Convert from 1-based ID to 0-based index
                    if (growthIndex >= 0 && growthIndex < cmbGrowthStage.Items.Count)
                    {
                        cmbGrowthStage.SelectedIndex = growthIndex;
                    }

                    txtSize.Text = rs.size.ToString();
                    dtpLogDate.Text = rs.logDate.ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;

            int brgyIndex = cmbBrgy.SelectedIndex;
            int farmTypeIndex = cmbFarmType.SelectedIndex;
            int growthStageIndex = cmbGrowthStage.SelectedIndex;
            int seedTypeIndex = cmbSeedType.SelectedIndex;

            // Retrieve the corresponding integer values based on the indices
            int brgyId = brgyIndex + 1; // Add 1 to convert from 0-based index to 1-based ID
            int farmTypeId = farmTypeIndex + 1;
            int growthStageId = growthStageIndex + 1;
            int seedTypeId = seedTypeIndex + 1;

            float size = float.Parse(txtSize.Text);
            int riceStandingLogsId = int.Parse(labelRiceStandingLogsId.Text);

            if (cropsRiceController.UpdateRiceStandingLog(riceStandingLogsId, labelRiceSrId.Text, brgyId, farmTypeId, growthStageId, seedTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int brgyIndex = cmbBrgy.SelectedIndex;
            int farmTypeIndex = cmbFarmType.SelectedIndex;
            int growthStageIndex = cmbGrowthStage.SelectedIndex;
            int seedTypeIndex = cmbSeedType.SelectedIndex;

            // Retrieve the corresponding integer values based on the indices
            int brgyId = brgyIndex + 1; // Add 1 to convert from 0-based index to 1-based ID
            int farmTypeId = farmTypeIndex + 1;
            int growthStageId = growthStageIndex + 1;
            int seedTypeId = seedTypeIndex + 1;

            float size = float.Parse(txtSize.Text);

            if (cropsRiceController.AddRiceStandingLogs(labelRiceSrId.Text, brgyId, farmTypeId, growthStageId, seedTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            ClearStandingLogsTextControls();
        }

        private void cbIrrigated_CheckedChanged(object sender, EventArgs e)
        {
            ShowChecked();
        }

        private void cbLowland_CheckedChanged(object sender, EventArgs e)
        {
            ShowChecked();
        }

        private void cbUpland_CheckedChanged(object sender, EventArgs e)
        {
            ShowChecked();
        }
    }
}
