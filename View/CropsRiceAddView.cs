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

            DataTable riceStandLogsTable = cropsRiceController.LoadRiceStandLogsView(riceSrId);
            dgvRiceStandLogs.DataSource = riceStandLogsTable;

            btnUpdate.Visible = false;
            ClearStandingLogsTextControls();

        }

        public void ClearStandingLogsTextControls()
        {
            cmbBrgy.Text = string.Empty;
        }

        public string RiceSrIdValue
        {
            get { return labelRiceSrId.Text; }
            set { labelRiceSrId.Text = value; }
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

                RiceStanding rs = cropsRiceController.GetRiceStandingLogsById(riceStandingLogsId);
                if (rs != null)
                {
                    labelRiceStandingLogsId.Text = rs.riceStandingLogsId.ToString();

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
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
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
    }
}
