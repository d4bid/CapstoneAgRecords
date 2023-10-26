using AgRecords.Controller;
using AgRecords.Model;
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
            btnUpdate.Visible = false;
            ClearTextControls();

            btnPrint.Enabled = true;
            btnEdit.Enabled = true;

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
            int colorId = MapCornItemToValue(cmbCornTypeFilter);
            int growthId = MapGrowthItemToValue(cmbGrowthStageFilter);
            int seedId = MapGrowthItemToValue(cmbSeedTypeFilter);
            int landId = MapGrowthItemToValue(cmbLandTypeFilter);

            if (labelArea.Text == "PLANTING ACCOMPLISHMENTS")
            {
                DataTable cornPlantingTable = cropsCornController.LoadCornPlantingView(cornPrId, seedId, colorId);
                dgvCornPlanting.DataSource = cornPlantingTable;
            }
            else if (labelArea.Text == "PLANTING BY ECOLOGICAL ZONE ACCOMPLISHMENTS")
            {
                DataTable cornPlantingTable = cropsCornController.LoadCornPlantingEcoView(cornPrId, colorId, growthId);
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
                btnNew.Visible = false;
                btnUpdate.Visible = false;
                btnEdit.Visible = false;

                labelAveYield.Visible = false;
                txtAveYield.Visible = false;
                boxAveYield.Visible = false;

                labelGrowthFilter.Visible = false;
                boxGrowthFilter.Visible = false;
                cmbGrowthStageFilter.Visible = false;

                txtSize.ReadOnly = true;
                txtSize.ForeColor = SystemColors.WindowText;
                txtSize.BackColor = Color.White;

                labelGrowthStage.Text = "Newly Planted/Vegetative Stage";
                labelSize.Text = "Size (ha)";

                // cmbGrowthStageFilter Location

                labelSeedTypeFilter.Location = new Point(384, 13);
                boxSeedTypeFilter.Location = new Point(489, 6);
                cmbSeedTypeFilter.Location = new Point(495, 8);

                // cmbSeedTypeFilter Location

                labelLandFilter.Location = new Point(796, 13);
                boxLandFilter.Location = new Point(885, 6);
                cmbLandTypeFilter.Location = new Point(891, 8);


            }
            else if (labelArea.Text == "HARVESTING ACCOMPLISHMENTS")
            {
                btnNew.Visible = true;
                btnUpdate.Visible = true;
                btnEdit.Visible = true;

                labelAveYield.Visible = true;
                txtAveYield.Visible = true;
                boxAveYield.Visible = true;

                labelSeedTypeFilter.Visible = true;
                boxSeedTypeFilter.Visible = true;
                cmbSeedTypeFilter.Visible = true;

                labelGrowthFilter.Visible = false;
                boxGrowthFilter.Visible = false;
                cmbGrowthStageFilter.Visible = false;

                labelLandFilter.Visible = false;
                boxLandFilter.Visible = false;
                cmbLandTypeFilter.Visible = false;

                txtSize.ReadOnly = true;
                txtSize.ForeColor = SystemColors.WindowText;
                txtSize.BackColor = Color.White;

                labelGrowthStage.Text = "Harvested";

                labelSize.Text = "Area Harvested (ha)";

                labelSeedTypeFilter.Location = new Point(384, 13);
                boxSeedTypeFilter.Location = new Point(489, 6);
                cmbSeedTypeFilter.Location = new Point(495, 8);
            }
            else if (labelArea.Text == "PLANTING BY ECOLOGICAL ZONE ACCOMPLISHMENTS")
            {
                btnNew.Visible = true;
                btnUpdate.Visible = true;
                btnEdit.Visible = true;

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

                labelLandFilter.Visible = false;
                boxLandFilter.Visible = false;
                cmbLandTypeFilter.Visible = false;

                labelSeedTypeFilter.Visible = false;
                boxSeedTypeFilter.Visible = false;
                cmbSeedTypeFilter.Visible = false;

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextControls();
        }

        private void dgvCornPlanting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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

            cmbSeedTypeFilter.SelectedIndex = 0;
            cmbCornTypeFilter.SelectedIndex = 0;
            cmbLandTypeFilter.SelectedIndex = 0;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
