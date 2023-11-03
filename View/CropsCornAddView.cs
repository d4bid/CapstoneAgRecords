﻿using AgRecords.Controller;
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
    public partial class CropsCornAddView : Form
    {
        private CropsCornController cropsCornController;
        public event EventHandler FormClosed;

        public CropsCornAddView()
        {
            InitializeComponent();
            cropsCornController = new CropsCornController(this);
        }

        // Methods

        public string CornPrIdValue
        {
            get { return labelCornPrId.Text; }
            set { labelCornPrId.Text = value; }
        }

        public void FormRefresh()
        {
            btnUpdate.Visible = false;
            ClearTextControls();
            DisplayDataTableFilter();
        }

        public void ClearTextControls()
        {
            cmbBrgy.SelectedIndex = -1;
            cmbLandType.SelectedIndex = -1;
            //cmbGrowthStage.SelectedIndex = -1;
            cmbSeedType.SelectedIndex = -1;
            cmbCornType.SelectedIndex = -1;
            txtSize.Text = "";
            dtpLogDate.Value = DateTime.Now;
            labelCornPlantingId.Text = "";
            labelGrowthStage.Text = "Newly Planted/Seedling Stage";
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

        public void DisplayDataTableFilter()
        {
            string cornPrId = labelCornPrId.Text;
            int colorId = MapCornItemToValue(cmbCornTypeFilter);
            int growthId = MapGrowthItemToValue(cmbGrowthStageFilter);

            DataTable cornPlantingTable = cropsCornController.LoadCornPlantingEcoView(cornPrId, colorId, growthId);
            dgvCornPlanting.DataSource = cornPlantingTable;
        }

        // Events

        private void CropsCornAddView_Load(object sender, EventArgs e)
        {
            string cornPrId = labelCornPrId.Text;

            CornReport cp = cropsCornController.GetCornPlantingEcoReportById(cornPrId);
            if (cp != null)
            {
                labelWeek.Text = cp.week;
                labelMonth.Text = cp.month;
                labelYear.Text = cp.year;
                labelSeason.Text = cp.season;
                labelSeasonYear.Text = cp.seasonYear;
            }

            FormRefresh();

            cmbCornTypeFilter.SelectedIndex = 0;
            cmbGrowthStageFilter.SelectedIndex = 0;
        }

        private void dgvCornPlanting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Visible = true;

            if (labelGrowthStage.Text == "Newly Planted/Seedling Stage")
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
                DataGridViewRow row = dgvCornPlanting.Rows[e.RowIndex];

                int cornPlantingId = Convert.ToInt32(row.Cells[0].Value);

                labelCornPlantingId.Text = cornPlantingId.ToString();

                CornPlantingEco cpe = cropsCornController.GetCornPlantingEcoById(cornPlantingId);
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
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;

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
            float size = float.Parse(txtSize.Text);

            if (cropsCornController.AddCornPlantingEco(labelCornPrId.Text, brgyId, landTypeId, growthStageId, seedTypeId, colorTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            labelCornPlantingId.Visible = false;

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
            int cornPlantingEcoId = int.Parse(labelCornPlantingId.Text);

            if (cropsCornController.UpdateCornPlantingEco(cornPlantingEcoId, brgyId, landTypeId, growthStageId, seedTypeId, colorTypeId, size, dtpLogDate.Value.Date))
            {
                FormRefresh();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            ClearTextControls();
        }

        private void cmbCornTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void cmbGrowthStageFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}