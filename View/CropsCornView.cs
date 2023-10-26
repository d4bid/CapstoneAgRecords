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
    public partial class CropsCornView : Form
    {
        private Panel parentPanel;
        private CropsCornController cropsCornController;

        public CropsCornView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            cropsCornController = new CropsCornController(this);
        }

        // Methods

        private void CropsCornEditView_FormClosed(object sender, EventArgs e)
        {
            CropsCornView cropsCornView = new CropsCornView(parentPanel);
            cropsCornView.TopLevel = false;
            cropsCornView.FormBorderStyle = FormBorderStyle.None;
            cropsCornView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(cropsCornView);
            cropsCornView.Show();
        }

        public void DisplayDataTableFilter()
        {
            string column = cmbColumn.Text;
            string keyword = txtBoxSearch.Text;

            if (cmbReportType.Text == "Planting")
            {
                DataTable cornPlantingTable = cropsCornController.LoadCornPlantingReportView(column, keyword);
                dgvCorn.DataSource = cornPlantingTable;
            }
            else if (cmbReportType.Text == "Planting By Ecological Zone")
            {
                DataTable cornPlantingTable = cropsCornController.LoadCornPlantingEcoReportView(column, keyword);
                dgvCorn.DataSource = cornPlantingTable;
            }
            else if (cmbReportType.Text == "Harvesting")
            {
                DataTable cornPlantingTable = cropsCornController.LoadCornHarvestingReportView(column, keyword);
                dgvCorn.DataSource = cornPlantingTable;
            }
        }

        // Events
        private void CropsCornView_Load(object sender, EventArgs e)
        {
            cmbColumn.Text = "All";
            cmbReportType.Text = "Planting By Ecological Zone";

            DisplayDataTableFilter();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CornAddView cornAddView = new CornAddView();
            cornAddView.SaveButtonClicked += (s, args) =>
            {
                // Get the RiceAddView's labelRiceSrId value
                string cornPrId = cornAddView.CornPrIdValue;

                // Handle the event when the Save button is clicked in RiceAddView
                this.Close(); // Close the current form (CropsRiceView)

                CropsCornAddView cropsCornAddView = new CropsCornAddView();
                cropsCornAddView.TopLevel = false;
                cropsCornAddView.FormBorderStyle = FormBorderStyle.None;
                cropsCornAddView.Dock = DockStyle.Fill;

                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(cropsCornAddView);


                // Set the labelRiceSrId in CropsRiceAddView
                cropsCornAddView.CornPrIdValue = cornPrId;

                // Call the MoveNextStandingLogs method from cropsRiceController
                bool success = cropsCornController.MoveNextCornPlantingEco(cornPrId);

                cropsCornAddView.Show();
            };
            cornAddView.Show();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void cmbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDataTableFilter();
        }

        private void dgvCorn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvCorn.Rows[e.RowIndex];

                // Get the user ID from the first cell of the row
                string cornPrId = row.Cells[0].Value.ToString();

                if (cornPrId != null)
                {
                    CornReport cr= null;

                    // Check if the cbPlanting checkbox is checked
                    if (cmbReportType.Text == "Planting")
                    {
                        cr = cropsCornController.GetCornPlantingReportById(cornPrId);
                    }
                    else if (cmbReportType.Text == "Planting By Ecological Zone")
                    {
                        cr = cropsCornController.GetCornPlantingEcoReportById(cornPrId);
                    }
                    else if (cmbReportType.Text == "Harvesting")
                    {
                        cr = cropsCornController.GetCornHarvestingReportById(cornPrId);
                    }

                    CropsCornEditView cropsCornEditView = new CropsCornEditView(cr, cmbReportType.Text);
                    cropsCornEditView.FormClosed += CropsCornEditView_FormClosed;

                    cropsCornEditView.TopLevel = false;
                    cropsCornEditView.FormBorderStyle = FormBorderStyle.None;
                    cropsCornEditView.Dock = DockStyle.Fill;

                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(cropsCornEditView);
                    cropsCornEditView.Show();
                }
            }

        }
    }
}
