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
    public partial class CropsRiceView : Form
    {
        private Panel parentPanel;
        private CropsRiceController cropsRiceController;

        public CropsRiceView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            cropsRiceController = new CropsRiceController(this);
        }

        // Methods

        private void FormRefresh()
        {

        }

        private void CropsRiceAddView_FormClosed(object sender, EventArgs e)
        {
            CropsRiceView cropsRiceView = new CropsRiceView(parentPanel);
            cropsRiceView.TopLevel = false;
            cropsRiceView.FormBorderStyle = FormBorderStyle.None;
            cropsRiceView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(cropsRiceView);
            cropsRiceView.Show();
        }

        private void CropsRiceEditView_FormClosed(object sender, EventArgs e)
        {
            CropsRiceView cropsRiceView = new CropsRiceView(parentPanel);
            cropsRiceView.TopLevel = false;
            cropsRiceView.FormBorderStyle = FormBorderStyle.None;
            cropsRiceView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(cropsRiceView);
            cropsRiceView.Show();
        }

        public void DisplayDataTableFilter()
        {
            string column = cmbColumn.Text;
            string keyword = txtBoxSearch.Text;

            if (cmbReportType.Text == "Planting")
            {
                DataTable cornPlantingTable = cropsRiceController.LoadRicePlantingReportView(column, keyword);
                dgvRice.DataSource = cornPlantingTable;
            }
            else if (cmbReportType.Text == "Standing")
            {
                DataTable cornPlantingTable = cropsRiceController.LoadRiceStandingReportView(column, keyword);
                dgvRice.DataSource = cornPlantingTable;
            }
            else if (cmbReportType.Text == "Harvesting")
            {
                DataTable cornPlantingTable = cropsRiceController.LoadRiceHarvestingReportView(column, keyword);
                dgvRice.DataSource = cornPlantingTable;
            }
        }

        // Trigger Events

        private void CropsRiceView_Load(object sender, EventArgs e)
        {
            FormRefresh();

            HomeView.Instance.title.Text = "Crops \u23F5 Rice";

            cmbColumn.Text = "All";
            cmbReportType.Text = "Standing";

            DisplayDataTableFilter();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RiceAddView riceAddView = new RiceAddView();
            riceAddView.SaveButtonClicked += (s, args) =>
            {
                // Get the RiceAddView's labelRiceSrId value
                string riceSrId = riceAddView.RiceSrIdValue;

                // Handle the event when the Save button is clicked in RiceAddView
                this.Close(); // Close the current form (CropsRiceView)

                CropsRiceAddView cropsRiceAddView = new CropsRiceAddView();
                cropsRiceAddView.FormClosed += CropsRiceAddView_FormClosed;
                cropsRiceAddView.TopLevel = false;
                cropsRiceAddView.FormBorderStyle = FormBorderStyle.None;
                cropsRiceAddView.Dock = DockStyle.Fill;

                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(cropsRiceAddView);


                // Set the labelRiceSrId in CropsRiceAddView
                cropsRiceAddView.RiceSrIdValue = riceSrId;

                // Call the MoveNextStandingLogs method from cropsRiceController
                bool success = cropsRiceController.MoveNextStandingLogs(riceSrId);

                cropsRiceAddView.Show();
            };
            riceAddView.Show();
        }

        private void dgvRice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvRice.Rows[e.RowIndex];

                // Get the user ID from the first cell of the row
                string riceSrId = row.Cells[0].Value.ToString();

                if (riceSrId != null)
                {
                    RicePlantingRep rpr = null;
                    RiceStandingRep rsr = null;
                    RiceHarvestingRep rhr = null;

                    // Check if the cbPlanting checkbox is checked
                    if (cmbReportType.Text == "Planting")
                    {
                        rpr = cropsRiceController.GetRicePlantReportById(riceSrId);
                    }
                    else if (cmbReportType.Text == "Standing")
                    {
                        rsr = cropsRiceController.GetRiceStandReportById(riceSrId);
                    }
                    else if (cmbReportType.Text == "Harvesting")
                    {
                        rhr = cropsRiceController.GetRiceHarvestReportById(riceSrId);
                    }

                    CropsRiceEditView cropsRiceEditView = new CropsRiceEditView(rpr, rsr, rhr);
                    cropsRiceEditView.FormClosed += CropsRiceEditView_FormClosed;

                    cropsRiceEditView.TopLevel = false;
                    cropsRiceEditView.FormBorderStyle = FormBorderStyle.None;
                    cropsRiceEditView.Dock = DockStyle.Fill;

                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(cropsRiceEditView);
                    cropsRiceEditView.Show();
                }
            }
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
    }
}
